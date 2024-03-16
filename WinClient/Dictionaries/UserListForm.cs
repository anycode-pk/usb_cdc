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
    public partial class UserListForm : BaseViewForm, IUserListView
    {
        private UserListPresenter presenter;
        private ViewFunctionTypes viewFuncType;
        private WindowResult windowsResult;
        private IList<User> users;

        public UserListForm()
        {
            InitializeComponent();
            presenter = new UserListPresenter(this);
            presenter.Initialize();
            windowsResult = ApplicationLogic.Global.WindowResult.NoResult;
        }

        public IList<User> Users
        {
            set 
            {
                bsUsers.DataSource = value;
                bsUsers.ResetBindings(false);
                users = value;
            }
            get { return users; }
        }

        public User CurrentUser
        {
            get
            {
                return bsUsers.Current as User;
            }
        }

        public IList<User> SelectedUsers
        {
            get
            {
                IList<User> u = new List<User>();
                foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                {
                    u.Add(bsUsers[row.Index] as User);
                }
                return u;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new UserEditForm(), new User());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new UserEditForm(), CurrentUser);
            presenter.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteUser();
            presenter.Initialize();
        }


        public ViewFunctionTypes ViewFuncType
        {
            set { this.viewFuncType = value; }
        }

        private void SetViewFunc()
        {
            switch (this.viewFuncType)
            {
                case ViewFunctionTypes.OnlyList:
                    btnSelect.Visible = false;
                    dgvUsers.MultiSelect = false;
                    break;
                case ViewFunctionTypes.OnlySelect:
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    btnEdit.Visible = false;
                    dgvUsers.MultiSelect = true;
                    break;
                case ViewFunctionTypes.SelectAndList:
                    break;
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            SetViewFunc();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            windowsResult = ApplicationLogic.Global.WindowResult.NoResult;
            this.Close();
        }
        
        public WindowResult WindowResult
        {
            get { return windowsResult; }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            windowsResult = ApplicationLogic.Global.WindowResult.SelectedResult;
            this.Close();
        }
    }
}
