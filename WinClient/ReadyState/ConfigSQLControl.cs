using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Presenters.ReadyState;

namespace WinClient.ReadyState
{
    public partial class ConfigSQLControl : WinClient.Base.BaseViewControl, IConfigSQLView
    {
        private ConfigSQLPresenter presenter;

        public ConfigSQLControl(IMainFormView mainFormView)
        {
            InitializeComponent();
            presenter = new ConfigSQLPresenter(this);
            presenter.Initialize();
            presenter.MainFormView = mainFormView;
        }

        public string StationName
        {
            get
            {
                return tbxStationName.Text;
            }
            set
            {
                tbxStationName.Text = value;
            }
        }

        public string ConnectionString
        {
            get { return tbxConnection.Text; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
    }
}
