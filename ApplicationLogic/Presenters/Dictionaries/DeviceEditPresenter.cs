using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using DataManager.Repositories;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class DeviceEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IDeviceEditView>
    {
        private DeviceRepository devRepo = new DeviceRepository();
        public DeviceEditPresenter(IDeviceEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.InterfaceType = CommonModel.Enums.HelpersInterface.GetAllTypes();
        }

        public void Save()
        {
            devRepo.InsertOrUpdate(this.View.CurrentDevice);
            this.View.CloseView();
        }
        public void Cancel()
        {
            devRepo.RejectChanges(this.View.CurrentDevice);
            this.View.CloseView();
        }
    }
}
