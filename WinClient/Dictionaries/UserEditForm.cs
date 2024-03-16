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
    public partial class UserEditForm : WinClient.Base.BaseViewForm, IUserEditView
    {
        private IList<Right> currentRight;
        private UserEditPresenter presenter;

        public UserEditForm()
        {
            InitializeComponent();
            presenter = new UserEditPresenter(this);
            presenter.Initialize();
        }

        public User CurrentUser
        {
            get
            {
                return bsUser.Current as User;
            }
            set
            {
                bsUser.DataSource = value;
                bsUser.ResetBindings(false);
            }
        }


        public IList<Right> CurrentRight
        {
            get
            {
                return currentRight;
            }
            set
            {
                currentRight = value;
                bsRight.DataSource = currentRight;
                bsRight.ResetBindings(false);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            PasswordTypedForm passForm = new PasswordTypedForm();
            if (passForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnChangePassword.Text = ApplicationLogic.Helpers.TextContentRepository.ChangedPassword;
                this.CurrentUser.Password = ApplicationLogic.Helpers.CryptographyFunctions.StrToHash(passForm.NewPassword);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowRights(new RightList());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.RemoveRights();
        }

        public IList<Right> SelectedRights
        {
            get 
            {
                IList<Right> r = new List<Right>();
                foreach (DataGridViewRow row in dgvRights.SelectedRows)
                {
                    r.Add(bsRight[row.Index] as Right);
                }
                return r;    
            }
        }
    }
}
