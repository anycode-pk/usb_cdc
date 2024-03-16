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
    public partial class CmdListListForm : WinClient.Base.BaseViewForm, ICmdListListView
    {
        private CmdListListPresenter presenter;

        public CmdListListForm()
        {
            InitializeComponent();
            presenter = new CmdListListPresenter(this);
            presenter.Initialize();
        }

        public IList<CmdList> CommandsList
        {
            set 
            {
                bsCmdList.DataSource = value;
                bsCmdList.ResetBindings(false);
            }
        }

        public CmdList CurrentCmdList
        {
            get { return bsCmdList.Current as CmdList; }
        }

        public IList<ConfDevice> Configurations
        {
            set 
            {
                cmbConfigurations.DataSource = value;
            }
        }

        public ConfDevice CurrentConfiguration
        {
            get 
            {
                return cmbConfigurations.SelectedItem as ConfDevice;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new CmdListEditForm(), new CmdList() { ConfDevice = CurrentConfiguration });
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new CmdListEditForm(), CurrentCmdList);
            presenter.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteCmdList();
            presenter.Initialize();
        }

        private void cmbConfigurations_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ReloadCmdList();
        }

        public void DisableEditing()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
