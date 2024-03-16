using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using DataManager.Repositories;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class StationsEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IStationEditView>
    {
        StationRepository statRepo = new StationRepository();
        UserRepository userRepo = new UserRepository();
        DeviceRepository devRepo = new DeviceRepository();
        public StationsEditPresenter(IStationEditView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void Save()
        {
            PrepareUsers();
            PrepareDevices();
            statRepo.InsertOrUpdate(this.View.CurrentStation);
            this.View.CloseView();
        }

        [Obsolete("Metoda poprawna, jednak należy ją ponownie zaimplementować przy refaktoringu dostępu do danych, np. przy implementacji wzorca Unit of Work.")]
        private void PrepareUsers()
        {
            IList<UserStationM2M> toRemove = new List<UserStationM2M>();
            IList<UserStationM2M> dontAdd = new List<UserStationM2M>();

            foreach (UserStationM2M us in this.View.CurrentStation.UserStationM2M)
            {
                if (this.View.CurrentUsers.Where(p => p.Id == us.UserId).Any())
                {
                    dontAdd.Add(us);
                }
                else
                {
                    toRemove.Add(us);
                }
            }
            foreach (UserStationM2M us in toRemove)
            {
                this.View.CurrentStation.UserStationM2M.Remove(us);
                new UserStationM2MRepository().Remove(us);
            }

            foreach (User u in this.View.CurrentUsers)
            {
                if (dontAdd.Where(p => p.UserId == u.Id).Any() == false)
                    this.View.CurrentStation.UserStationM2M.Add(new UserStationM2M() { UserId = u.Id, StationId = this.View.CurrentStation.Id });
            }
        }

        [Obsolete("Metoda poprawna, jednak należy ją ponownie zaimplementować przy refaktoringu dostępu do danych, np. przy implementacji wzorca Unit of Work.")]
        private void PrepareDevices()
        {
            IList<StationDeviceM2M> toRemove = new List<StationDeviceM2M>();
            IList<StationDeviceM2M> dontAdd = new List<StationDeviceM2M>();

            foreach (StationDeviceM2M sd in this.View.CurrentStation.StationDeviceM2M) 
            {
                if (this.View.CurrentDevices.Where(p => p.Id == sd.DeviceId).Any()) 
                {
                    dontAdd.Add(sd);
                }
                else
                {
                    toRemove.Add(sd);
                }
            }
            foreach (StationDeviceM2M sd in toRemove)
            {
                this.View.CurrentStation.StationDeviceM2M.Remove(sd);
                new StationDeviceM2MRepository().Remove(sd);
            }


            foreach (Device d in this.View.CurrentDevices)
            {
                if (dontAdd.Where(p => p.DeviceId == d.Id).Any() == false)
                    this.View.CurrentStation.StationDeviceM2M.Add(new StationDeviceM2M() { DeviceId = d.Id, StationId = this.View.CurrentStation.Id });
            }
        }

        public void ShowUsers(IUserListView view)
        {
            view.Users = userRepo.GetOther(this.View.CurrentUsers);
            view.ViewFuncType = Global.ViewFunctionTypes.OnlySelect;
            view.ShowView();
            if (view.WindowResult == Global.WindowResult.SelectedResult)
            {
                IList<User> tmpUsers = this.View.CurrentUsers;
                foreach (User u in view.SelectedUsers)
                {
                    tmpUsers.Add(u);
                }
                this.View.CurrentUsers = tmpUsers;
                this.Initialize();
            }
        }

        public void RemoveUsers()
        {
            foreach (User u in this.View.SelectedUsersToDelete)
            {
                this.View.CurrentUsers.Remove(u);
            }
            this.View.CurrentUsers = this.View.CurrentUsers; // stuczne odświeżenie listy
        }

        public void ShowDevices(IDeviceListView view)
        {
            view.Devices = devRepo.GetOther(this.View.CurrentDevices);
            view.ViewFuncType = Global.ViewFunctionTypes.OnlySelect;
            view.ShowView();
            if (view.WindowResult == Global.WindowResult.SelectedResult)
            {
                IList<Device> tmpDev = this.View.CurrentDevices;
                foreach (Device d in view.SelectedDevices)
                {
                    tmpDev.Add(d);
                }
                this.View.CurrentDevices = tmpDev;
                this.Initialize();
            }
        }

        public void RemoveDevices()
        {
            foreach (Device d in this.View.SelectedDevicesToDelete)
            {
                this.View.CurrentDevices.Remove(d);
            }
            this.View.CurrentDevices = this.View.CurrentDevices; // stuczne odświeżenie listy
        }

        public void Cancel()
        {
            statRepo.RejectChanges(this.View.CurrentStation);
            this.View.CloseView();
        }
    }
}
