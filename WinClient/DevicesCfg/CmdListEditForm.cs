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
    public partial class CmdListEditForm : WinClient.Base.BaseViewForm, ICmdListEditView 
    {

        private CmdListEditPresenter presenter;
        public CmdListEditForm()
        {
            InitializeComponent();
            presenter = new CmdListEditPresenter(this);
        }

        public CmdList CurrentCmdList
        {
            get
            {
                return bsCmdList.Current as CmdList;
            }
            set
            {                
                bsCmdList.DataSource = value;
                bsCmdList.ResetBindings(false);
            }
        }

        public IList<Command> CurrentCommands
        {
            get
            {
                return null;
            }
            set
            {
                bsCommands.DataSource = value;
                bsCommands.ResetBindings(false);
            }
        }

        public IList<ConfDevice> Configurations
        {
            set { cmbConfiguration.DataSource = value; }
        }

        public Command SelectedCommand
        {
            get { return bsCommands.Current as Command; }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            presenter.Cancel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowCommandEditor(new CommandEditForm(), new Command());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowCommandEditor(new CommandEditForm(), SelectedCommand);
            presenter.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.RemoveSelected();
            presenter.Initialize();
        }

        private void CmdListEditForm_Load(object sender, EventArgs e)
        {
            presenter.Initialize();
        }
        
        public void LockCommands()
        {
            this.gbCommands.Enabled = false;
        }
    }
}
