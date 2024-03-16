using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using ApplicationLogic.Presenters.Dictionaries;

namespace WinClient.Dictionaries
{
    public partial class UnitEditForm : WinClient.Base.BaseViewForm, IUnitEditView
    {
        private UnitEditPresenter presenter;
        public UnitEditForm()
        {
            InitializeComponent();
            presenter = new UnitEditPresenter(this);
            presenter.Initialize();
        }

        public Unit CurrentUnit
        {
            get
            {
                return bsUnit.Current as Unit; ;
            }
            set
            {
                bsUnit.DataSource = value;
                bsUnit.ResetBindings(false);
            }
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
    }
}
