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
    public partial class CmdArchetypeListForm : WinClient.Base.BaseViewForm, ICmdArchetypeListView
    {
        private CmdArchetypeListPresenter presenter;
        public CmdArchetypeListForm()
        {
            InitializeComponent();
            presenter = new CmdArchetypeListPresenter(this);
            presenter.Initialize();
        }

        public IList<CmdArchetype> CmdArchetypes
        {
            set 
            {
                bsCmdArchetypes.DataSource = value;
                bsCmdArchetypes.ResetBindings(false);
            }
        }

        public CmdArchetype CurrentCmdArchetype
        {
            get { return bsCmdArchetypes.Current as CmdArchetype; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new CmdArchetypeEditForm(), new CmdArchetype());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new CmdArchetypeEditForm(), CurrentCmdArchetype);
            presenter.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteCmdArchetype();
            presenter.Initialize();
        }
    }
}
