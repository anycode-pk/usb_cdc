using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Presenters.Dictionaries;
using WinClient.Base;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using ApplicationLogic.Global;

namespace WinClient.Dictionaries
{
    public partial class StationListForm : BaseViewForm, IStationListView
    {
        private StationListPresenter presenter;

        public StationListForm()
        {
            InitializeComponent();
            presenter = new StationListPresenter(this);
            presenter.Initialize();
        }

        public IList<MeasureStation> Stations
        {
            set
            {
                bsStations.DataSource = value;
                bsStations.ResetBindings(false);
            }
        }

        public MeasureStation CurrentStation
        {
            get { return bsStations.Current as MeasureStation; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new StationEditForm(), new MeasureStation());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new StationEditForm(), CurrentStation);
            presenter.Initialize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteStation();
            presenter.Initialize();
        }
    }
}
