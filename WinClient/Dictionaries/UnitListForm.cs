using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.Dictionaries;
using ApplicationLogic.Global;
using CommonModel.Entities;
using ApplicationLogic.Presenters.Dictionaries;

namespace WinClient.Dictionaries
{
    public partial class UnitListForm : WinClient.Base.BaseViewForm, IUnitListView
    {
        private UnitListPresenter presenter;
        public UnitListForm()
        {
            InitializeComponent();
            presenter = new UnitListPresenter(this);
            presenter.Initialize();
        }

        public IList<Unit> Units
        {
            set 
            {
                bsUnits.DataSource = value;
                bsUnits.ResetBindings(false);
            }
        }

        public Unit CurrentUnit
        {
            get { return bsUnits.Current as Unit; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new UnitEditForm(), new Unit());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new UnitEditForm(), CurrentUnit);
            presenter.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteUnit();
            presenter.Initialize();
        }
    }
}
