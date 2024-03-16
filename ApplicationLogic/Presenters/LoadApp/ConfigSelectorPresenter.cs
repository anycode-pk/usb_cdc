using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.ReadyState;
using DataManager.Repositories;
using CommonModel;
using BusinessLogic;
using ApplicationLogic.Helpers;

namespace ApplicationLogic.Presenters.LoadApp
{
    public class ConfigSelectorPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IConfigSelectorVew>
    {
        private ConfigurationRepository cfgRepo = new ConfigurationRepository();
        private IMainFormView mainView;

        public ConfigSelectorPresenter(IConfigSelectorVew view)
            : base(view)
        {
        }
        
        public IMainFormView MainView
        {
            set { mainView = value; }
        }

        public override void Initialize()
        {
            this.View.Devices = new DeviceRepository().GetActive(CommonContext.Instance.CurrentStation);
        }

        public void ReloadConfiguration()
        {
            this.View.Configurations = cfgRepo.GetActive(this.View.SelectedDevice);
        }
        public void LoadConfigurationDescription()
        {
            if (this.View.SelectedConfigurtion != null)
                this.View.ConfigurationDescription = this.View.SelectedConfigurtion.Decsription;
        }

        public void RunApp()
        {
            CommonContext.Instance.CurrentSession.ConfDevice = this.View.SelectedConfigurtion;
            CommonContext.Instance.CurrentSession.Description = this.View.SessionDescription;
            DeviceManager devManager = new DeviceManager();
            if (devManager.Connect(CommonContext.Instance.CurrentSession.ConfDevice.Device))
            {
                this.View.CloseView();
                mainView.ShowMeasurementStationControl();
            }
            else
            {
                this.View.ShowError(TextContentRepository.DeviceConnError, TextContentRepository.Attention);
            }            
        }
    }
}
