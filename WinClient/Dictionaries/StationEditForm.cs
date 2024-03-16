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
    public partial class StationEditForm : WinClient.Base.BaseViewForm, IStationEditView
    {
        private StationsEditPresenter presenter;
        private IList<User> currentUsers;
        private IList<Device> currentDevices;

        public StationEditForm()
        {
            InitializeComponent();
            presenter = new StationsEditPresenter(this);
            presenter.Initialize();
        }

        public MeasureStation CurrentStation
        {
            get
            {
                return bsStation.Current as MeasureStation;
            }
            set
            {
                bsStation.DataSource = value;
                bsStation.ResetBindings(false);
            }
        }

        public IList<User> CurrentUsers
        {
            get
            {
                return currentUsers;
            }
            set
            {
                currentUsers = value;
                bsUsers.DataSource = currentUsers;
                bsUsers.ResetBindings(false);
            }
        }

        public IList<User> SelectedUsersToDelete
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

        public IList<Device> CurrentDevices
        {
            get
            {
                return currentDevices;
            }
            set
            {
                currentDevices = value;
                bsDevices.DataSource = currentDevices;
                bsDevices.ResetBindings(false);
            }
        }

        public IList<Device> SelectedDevicesToDelete
        {
            get
            {
                IList<Device> d = new List<Device>();
                foreach (DataGridViewRow row in dgvDevices.SelectedRows)
                {
                    d.Add(bsDevices[row.Index] as Device);
                }

                return d;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            presenter.ShowUsers(new UserListForm());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            presenter.RemoveUsers();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            presenter.ShowDevices(new DeviceListForm());
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            presenter.RemoveDevices();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            presenter.Cancel();
        }
    }
}
