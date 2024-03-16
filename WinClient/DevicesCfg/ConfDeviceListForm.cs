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
    public partial class ConfDeviceListForm : WinClient.Base.BaseViewForm, IConfDeviceListView
    {
        private ConfDeviceListPresenter presenter;
        public ConfDeviceListForm()
        {
            InitializeComponent();
            presenter = new ConfDeviceListPresenter(this);
            presenter.Initialize();
        }

        public IList<ConfDevice> Configurations
        {
            set 
            {
                bsConfigurations.DataSource = value;
                bsConfigurations.ResetBindings(false);
            }
        }

        public ConfDevice CurrentConfiguration
        {
            get { return bsConfigurations.Current as ConfDevice; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new ConfDeviceEditForm(), new ConfDevice());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new ConfDeviceEditForm(), CurrentConfiguration);
            presenter.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteConfiguration();
            presenter.Initialize();
        }
    }
}
