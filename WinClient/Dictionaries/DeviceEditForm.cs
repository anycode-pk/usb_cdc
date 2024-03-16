using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinClient.Base;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using CommonModel.Enums;
using ApplicationLogic.Presenters.Dictionaries;

namespace WinClient.Dictionaries
{
    public partial class DeviceEditForm : BaseViewForm, IDeviceEditView
    {
        private DeviceEditPresenter presenter;
        public DeviceEditForm()
        {
            InitializeComponent();
            presenter = new DeviceEditPresenter(this);
            presenter.Initialize();
        }

        public Device CurrentDevice
        {
            get
            {
                return this.bsDevice.Current as Device;
            }
            set
            {
                this.bsDevice.DataSource = value;
            }
        }

        public IList<InterfacesType> InterfaceType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                this.cmbInterface.DataSource = value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            presenter.Cancel();
        }
    }
}
