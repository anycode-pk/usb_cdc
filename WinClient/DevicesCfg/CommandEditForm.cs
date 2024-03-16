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
using ApplicationLogic.Global;

namespace WinClient.DevicesCfg
{
    public partial class CommandEditForm : WinClient.Base.BaseViewForm, ICommandEditView
    {
        private CommandEditPresenter presenter;
        private WindowResult windowResult;
        private Command cloneOfCommand;

        public CommandEditForm()
        {
            InitializeComponent();
            presenter = new CommandEditPresenter(this);
            presenter.Initialize();
            windowResult = ApplicationLogic.Global.WindowResult.Cancel;
        }

        public Command CurrentCommand
        {
            get
            {
                return bsCommand.Current as Command;
            }
            set
            {
                bsCommand.DataSource = value;
                bsCommand.ResetBindings(false);
                cloneOfCommand = CurrentCommand.Clone() as Command;
            }
        }

        public IList<CmdArchetype> CmdArchetypes
        {
            set 
            { 
                cmbAchetype.DataSource = value;
            }
        }

        public IList<Unit> Units
        {
            set { cmbUnit.DataSource = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            windowResult = ApplicationLogic.Global.WindowResult.Save;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            windowResult = ApplicationLogic.Global.WindowResult.Cancel;
            this.Close();
        }

        public WindowResult WindowResult
        {
            get { return windowResult; }
        }

        public Command CloneOfCommand
        {
            get { return cloneOfCommand; }
        }

        private void btnCopyArchetype_Click(object sender, EventArgs e)
        {
            presenter.CopyArchetype();
        }
    }
}
