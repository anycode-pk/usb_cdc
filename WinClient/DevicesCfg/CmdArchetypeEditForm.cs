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
    public partial class CmdArchetypeEditForm : WinClient.Base.BaseViewForm, ICmdArchetypeEditView
    {
        private CmdArchetypeEditPresenter presenter;
        public CmdArchetypeEditForm()
        {
            InitializeComponent();
            presenter = new CmdArchetypeEditPresenter(this);
            presenter.Initialize();
        }

        public CmdArchetype CurrentCmdArchetype
        {
            get
            {
                return bsCmdArchetype.Current as CmdArchetype;
            }
            set
            {
                bsCmdArchetype.DataSource = value;
                bsCmdArchetype.ResetBindings(false);
            }
        }

        public IList<Device> AvaibleDevices
        {
            set 
            {
                cmbDevice.DataSource = value;  
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
