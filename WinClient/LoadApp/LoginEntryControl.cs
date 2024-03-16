using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Presenters.LoadApp;
using CommonModel.Enums;

namespace WinClient.LoadApp
{
    public partial class LoginEntryControl : Base.BaseViewControl, ILoginView
    {
        private LoginPresenter presenter;

        public LoginEntryControl(IMainFormView mainView)
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
            presenter.Initialize();
            presenter.MainView = mainView;
        }

        public string Login
        {
            get
            {
                return tbxLogin.Text;
            }
            private set
            {
                throw new NotImplementedException();
            }
        }

        public string Password
        {
            get
            {
                return mtbxPassword.Text;
            }
           private set
            {
                throw new NotImplementedException();
            }
        }

        public IList<SessionType> SessionTypes
        {
            set
            {
                cmbSessionType.DataSource = value;
                cmbSessionType.SelectedItem = SessionType.Measure;
            }
        }

        public SessionType SelectedSession
        {
            get
            {
                return (SessionType) cmbSessionType.SelectedItem;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            presenter.LogIn();
        }

        public void DisableSQLControls()
        {
            tbxLogin.Enabled = false;
            mtbxPassword.Enabled = false;
        }

        public void EnableSQLControls()
        {
            tbxLogin.Enabled = true;
            mtbxPassword.Enabled = true;
        }

        private void DetectEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || e.KeyChar == '\r')
                presenter.LogIn();
        }
    }
}
