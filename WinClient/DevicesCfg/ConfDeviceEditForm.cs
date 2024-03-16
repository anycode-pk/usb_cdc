using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.DevicesCfg;
using CommonModel.Entities;
using ApplicationLogic.Presenters.DevicesCfg;

namespace WinClient.DevicesCfg
{
    public partial class ConfDeviceEditForm : WinClient.Base.BaseViewForm, IConfDeviceEditView
    {
        private ConfDeviceEditPresenter presenter;

        public ConfDeviceEditForm()
        {
            InitializeComponent();
            presenter = new ConfDeviceEditPresenter(this);
            presenter.Initialize();
        }

        public ConfDevice CurrentCofiguration
        {
            get
            {
                return bsConfiguration.Current as ConfDevice;
            }
            set
            {
                bsConfiguration.DataSource = value;
                bsConfiguration.ResetBindings(false);
            }
        }

        public IList<Device> AvaibleDevices
        {
            set { cmbDevice.DataSource = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            presenter.Cancel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
    }
}
