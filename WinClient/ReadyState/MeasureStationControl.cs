using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Presenters.ReadyState;
using CommonModel.Entities;
using CommonModel.Enums;

namespace WinClient.ReadyState
{
    public partial class MeasureStationControl : Base.BaseViewControl, IMeasureStationView
    {
        private MeasureStationPresenter presenter;
        private IList<CmdList> cmdsList;
        private delegate void InvokerSetText(string textParameter, Control ctrlParameter);
        private delegate string InvokerGetText(Control ctrlParameter);
        private delegate void InvokerEnabled(bool boolParameter, Control ctrlParameter);
        private delegate void InvokerListBox(CmdList parameter);
        private CycleType currentCycleType;

        public MeasureStationControl(IMainFormView mainView)
        {
            InitializeComponent();
            presenter = new MeasureStationPresenter(this);
            presenter.MainView = mainView;
            presenter.Initialize();            
        }

        public string DeviceName
        {
            set { lbDevice.Text = value; }
        }

        public string ConfigurationName
        {
            set { lbConfiguration.Text = value; }
        }

        public string UserName
        {
            set { lbUser.Text = value; }
        }

        public string DeviceStatus
        {
            set 
            {
                SetTextBeginInvoke(value, lbDeviceStatus);
            }
        }

        private void SetTextBeginInvoke(string text, Control control)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new InvokerSetText(SetTextBeginInvoke), text, control );
                return;
            }
            control.Text = text;
        }

        private string GetTextBeginInvoke(Control control)
        {
            string ret = "";
            this.Invoke((MethodInvoker)delegate()
            {
                ret = control.Text;
            });
            return ret;
        }

        private void SetEnabledBeginInvoke(bool value, Control control)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new InvokerEnabled(SetEnabledBeginInvoke), value, control);
                return;
            }
            control.Enabled = value;            
        }

        public IList<CmdList> CmdsList
        {
            set 
            {
                cmdsList = value;
                bsCmdsList.DataSource = value;
                bsCmdsList.ResetBindings(false);
            }
            get
            {
                return cmdsList;
            }
        }

        public CmdList CurrentCmdList
        {
            get
            {
                return bsCmdsList.Current as CmdList;
            }
            set
            {
                SetCurrentListBoxBeginInvoke(value);
            }
        }

        private void SetCurrentListBoxBeginInvoke(CmdList value)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new InvokerListBox(SetCurrentListBoxBeginInvoke), value);
                return;
            }
            lbxCmdsList.SelectedItem = value;
        }

        public string CycleDescription
        {
            get { return GetTextBeginInvoke(tbxCycleDescription); }
        }

        public string MeasuremetDescription
        {
            get { return GetTextBeginInvoke(tbxMeasurementDescription); }
        }

        public void LockControls(CycleType cycleType)
        {
            this.SetLocksControls(cycleType, false);
        }

        public void UnlockControls(CycleType cycleType)
        {
            this.SetLocksControls(cycleType, true);
        }

        private void SetLocksControls(CycleType cycleType, bool value)
        {
            switch (cycleType)
            {
                case CycleType.CycleMeasurement:
                    SetEnabledBeginInvoke(value, btnForceMeasurement);
                    SetEnabledBeginInvoke(!value, btnStopCycle);
                    SetEnabledBeginInvoke(value, btnStartCycle);
                    break;
                case CycleType.SingleMeasurement:
                    SetEnabledBeginInvoke(value, btnStartCycle);
                    SetEnabledBeginInvoke(value, btnStopCycle);
                    SetEnabledBeginInvoke(value, cbxRepeat);
                    SetEnabledBeginInvoke(value, lbxCmdsList);
                    SetEnabledBeginInvoke(value, btnForceMeasurement);
                    break;
                case CycleType.None:
                    SetEnabledBeginInvoke(value, btnStartCycle);
                    SetEnabledBeginInvoke(!value, btnStopCycle);
                    SetEnabledBeginInvoke(value, cbxRepeat);
                    SetEnabledBeginInvoke(value, lbxCmdsList);
                    SetEnabledBeginInvoke(value, btnForceMeasurement);
                    break;
            }
        }

        private void btnStartCycle_Click(object sender, EventArgs e)
        {
            presenter.RunCycle();
        }

        private void btnStopCycle_Click(object sender, EventArgs e)
        {
            presenter.StopCycle();
        }

        private void btnForceMeasurement_Click(object sender, EventArgs e)
        {
            presenter.ForceMeasurement();
        }

        public bool Repeat
        {
            get { return cbxRepeat.Checked; }
        }

        private void cbxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            presenter.ChangeRepeat(cbxRepeat.Checked);
        }

        public override void CloseView()
        {
            presenter.WindowClosing();
            base.CloseView();
        }

        public CycleType CurrentCycleType
        {
            get
            {
                return currentCycleType;
            }
            set
            {
                currentCycleType = value;
            }
        }

        public MeasureValue CurrentMeasureValues
        {
            set 
            {
                SetTextBeginInvoke(value.Command.Name, lbCurrCmd);
                SetTextBeginInvoke(string.Format("{0} {1}", value.UnitValue, value.Command.Unit.ShortCut), lbCurrValueUnit);
                SetTextBeginInvoke(value.DevValue.ToString(), lbCurrValueDev);
                SetTextBeginInvoke(value.Error.ToString(), lbCurrError);
            }
        }
    }
}
