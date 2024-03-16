using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Presenters.LoadApp;
using CommonModel.Entities;

namespace WinClient.LoadApp
{
    public partial class ConfigSelectorControl : WinClient.Base.BaseViewControl, IConfigSelectorVew
    {
        private ConfigSelectorPresenter presenter;

        public ConfigSelectorControl(IMainFormView mainView)
        {
            InitializeComponent();
            presenter = new ConfigSelectorPresenter(this);
            presenter.Initialize();
            presenter.MainView = mainView;
        }

        public IList<CommonModel.Entities.Device> Devices
        {
            set 
            { 
                bsDevices.DataSource = value;
                bsDevices.ResetBindings(false);
            }
        }

        public CommonModel.Entities.Device SelectedDevice
        {
            get { return bsDevices.Current as Device; }
        }

        public IList<CommonModel.Entities.ConfDevice> Configurations
        {
            set 
            {
                bsConfigurations.DataSource = value;
                bsConfigurations.ResetBindings(false);
            }
        }

        public CommonModel.Entities.ConfDevice SelectedConfigurtion
        {
            get { return bsConfigurations.Current as ConfDevice; }
        }

        public string SessionDescription
        {
            get { return tbxDescription.Text; }
        }

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            presenter.RunApp();
        }

        public string ConfigurationDescription
        {
            set { tbxCfgDescription.Text = value; }
        }

        private void lbxConfigurations_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.LoadConfigurationDescription();
        }
        private void lbxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ReloadConfiguration();
        }
    }
}
