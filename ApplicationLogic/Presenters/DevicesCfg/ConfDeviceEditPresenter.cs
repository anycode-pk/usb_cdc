using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.DevicesCfg;
using DataManager.Repositories;

namespace ApplicationLogic.Presenters.DevicesCfg
{
    public class ConfDeviceEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IConfDeviceEditView>
    {
        ConfigurationRepository confRepo = new ConfigurationRepository();
        public ConfDeviceEditPresenter(IConfDeviceEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void Save()
        {
            confRepo.InsertOrUpdate(this.View.CurrentCofiguration);
            this.View.CloseView();
        }

        public void Cancel()
        {
            confRepo.RejectChanges(this.View.CurrentCofiguration);
            this.View.CloseView();
        }
    }
}
