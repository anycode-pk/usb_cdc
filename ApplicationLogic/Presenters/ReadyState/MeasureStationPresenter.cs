using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.ReadyState;
using CommonModel.Enums;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;
using CommonModel;
using ApplicationLogic.Global;
using BusinessLogic;
using System.Threading;
using BusinessLogic.Other;
using BusinessLogic.StateImplementation;

namespace ApplicationLogic.Presenters.ReadyState
{
    public class MeasureStationPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IMeasureStationView>
    {
        private CycleRepository cycleRepo = new CycleRepository();
        private MeasurementManager measureManager;
        private MeasureCycle cycleForSingleMeasure;
        private MeasureCycle cycleForCycleMeasure;

        private IMainFormView mainView;
        public IMainFormView MainView
        {
            set { mainView = value; }
        }

        public MeasureStationPresenter(IMeasureStationView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.ConfigurationName = CommonContext.Instance.CurrentSession.ConfDevice.Name;
            this.View.DeviceName = CommonContext.Instance.CurrentSession.ConfDevice.Device.Name;
            this.View.UserName = CommonContext.Instance.CurrentUser.Login;
            this.View.DeviceStatus = "";
            this.View.CmdsList = new CmdListRepository().Get(CommonContext.Instance.CurrentSession.ConfDevice);//CommonContext.Instance.CurrentSession.ConfDevice.CmdList.ToList();

            foreach (CmdList cmdL in this.View.CmdsList) // posortowanie rozkazów w listach rozkazów
            {
                IList<Command> cmd = cmdL.Command.OrderByDescending(p => p.NoInOrder).ToList();
                cmdL.Command.Clear();
                foreach (Command cm in cmd)
                    cmdL.Command.Add(cm);
            }

            this.View.CurrentCycleType = CycleType.None;
            this.measureManager = new MeasurementManager();
            this.measureManager.OnDeviceStateChanged += new MeasurementManager.DeviceStateChangedEventHandler(UpdateDeviceState_OnDeviceStateChanged);
            this.measureManager.OnCmdsListChanged += new MeasurementManager.CurrentCmdsListChangedEventHandler(measureManager_OnCmdsListChanged);
            this.measureManager.OnMeasureValueChanged += new MeasurementManager.CurrentMeasureValueChangedEventHandler(measureManager_OnMeasureValueChanged);
            this.measureManager.PostInitializeState();
        }
        
        public void RunCycle()
        {
            if (cycleForCycleMeasure != null && cycleForCycleMeasure.Stop == null)
            {
                NormalEndCycle();
            }

             cycleForCycleMeasure = new MeasureCycle()
                {
                    Description = this.View.CycleDescription,
                    MeasureSession = CommonContext.Instance.CurrentSession,
                    Start = DateTime.Now,
                    Type = 0,
                    Error = 1
                };
             cycleRepo.InsertOrUpdate(cycleForCycleMeasure);
             measureManager.Repeat = this.View.Repeat;
             this.View.CurrentCycleType = CycleType.CycleMeasurement;
             this.measureManager.MeasurementDescription = this.View.MeasuremetDescription;

             if (measureManager.StartCycle(this.View.CmdsList, cycleForCycleMeasure) == false)
                 this.View.ShowWarning(TextContentRepository.DeviceBusy, TextContentRepository.Attention);             
        }

        public void ChangeRepeat(bool value)
        {
            measureManager.Repeat = value;
        }

        /* Możliwe wartości błędów:
         * 0 - wszystko ok (uruchomił i zakończył)
         * 1 - program został zamknięty inaczej niż przewidziane w kodzie
         * 2 - cykl został zakończony wymuszając Stop lub poprzez zamknięcie okna (zabicie procesu).
         */

        private void NormalEndCycle()
        {
            if (cycleForCycleMeasure != null)
            {
                cycleForCycleMeasure.Stop = cycleForCycleMeasure.Measurement.Last().MeasureValue.Last().Time;
                cycleForCycleMeasure.Error = 0;
                cycleRepo.InsertOrUpdate(cycleForCycleMeasure);
            }
        }

        private void ErrorEndCycle()
        {
            if (cycleForCycleMeasure != null)
            {
                cycleForCycleMeasure.Stop = cycleForCycleMeasure.Measurement.Last().MeasureValue.Last().Time;
                cycleForCycleMeasure.Error = 2;
                cycleRepo.InsertOrUpdate(cycleForCycleMeasure);
            }
        }

        private void NormalEndSingle()
        {
            if (cycleForSingleMeasure != null)
            {
                cycleForSingleMeasure.Stop = cycleForSingleMeasure.Measurement.Last().MeasureValue.Last().Time;
                cycleForSingleMeasure.Error = 0;
                cycleRepo.InsertOrUpdate(cycleForSingleMeasure);
            }
        }
        private void ErrorEndSingle()
        {
            if (cycleForSingleMeasure != null)
            {
                cycleForSingleMeasure.Stop = cycleForSingleMeasure.Measurement.Last().MeasureValue.Last().Time;
                cycleForSingleMeasure.Error = 2;
                cycleRepo.InsertOrUpdate(cycleForSingleMeasure);
            }
        }

        public void WindowClosing()
        {
            if (this.View.CurrentCycleType == CycleType.None)
            {
                NormalEndCycle();
                NormalEndSingle();
            }
            else
            {
                ErrorEndCycle();
                ErrorEndSingle();
            }
        }

        public void StopCycle()
        {
            if (this.View.ShowQuestion(TextContentRepository.ForceStopCycle, TextContentRepository.Attention) == true)
            {
                measureManager.StopCycle();
                ErrorEndCycle();
            }
        }

        public void ForceMeasurement()
        {
            if (cycleForSingleMeasure == null)
            {
                cycleForSingleMeasure = new MeasureCycle()
                {
                    Description = this.View.CycleDescription,
                    MeasureSession = CommonContext.Instance.CurrentSession,
                    Start = DateTime.Now,
                    Type = 1,
                    Error = 1
                };

                cycleRepo.InsertOrUpdate(cycleForSingleMeasure);
            }
            this.View.CurrentCycleType = CycleType.SingleMeasurement;

            if (measureManager.SingleMeasuremet(this.View.CurrentCmdList, cycleForSingleMeasure) == false)
                this.View.ShowWarning(TextContentRepository.DeviceBusy, TextContentRepository.Attention);
       }

        private void LockControls(CycleType cycleType)
        {
            mainView.LockMenu();
            this.View.LockControls(cycleType);
        }

        private void UnlockControls(CycleType cycleType)
        {
            mainView.UnlockMenu();
            this.View.UnlockControls(cycleType);
        }

        public void UpdateMeasurementDescription(string description)
        {
            this.measureManager.MeasurementDescription = description;
        }

        private void UpdateDeviceState_OnDeviceStateChanged(DeviceStateEventArgs eventArgs)
        {
            if (eventArgs.State is StateDisconnected)
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateDisconnect;
                this.View.CurrentCycleType = CycleType.SingleMeasurement; // ponieważ single blokuje wszystko. 
                this.LockControls(CycleType.None);
            }
            else if (eventArgs.State is StateReady)
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateReady;
                this.View.CurrentCycleType = CycleType.None;
                this.UnlockControls(CycleType.None);
            }
            else if (eventArgs.State is StateWorking)
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateWorking;
                this.LockControls(this.View.CurrentCycleType);
            }
            else
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateNone;
                this.LockControls(CycleType.None);
            }
        }

        private void measureManager_OnCmdsListChanged(CommonModel.ModelChandegEvents.CmdsListChangedEventArgs eventArgs)
        {
            this.View.CurrentCmdList = eventArgs.CommandList;
            this.measureManager.MeasurementDescription = this.View.MeasuremetDescription;
        }

        void measureManager_OnMeasureValueChanged(CommonModel.ModelChandegEvents.MeasureValuesCahngedEventArgs eventArgs)
        {
            if (UserRightChecker.CheckRightCurrenUser(RightsMapper.AlowViewLastMeasure)) 
                this.View.CurrentMeasureValues = eventArgs.Values;
        }
    }
}
