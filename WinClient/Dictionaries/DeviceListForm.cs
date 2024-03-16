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
    public partial class DeviceListForm : WinClient.Base.BaseViewForm, IDeviceListView
    {
        private DeviceListPresenter presenter;
        private ViewFunctionTypes viewFuncType;
        private WindowResult windowResult;

        public DeviceListForm()
        {
            InitializeComponent();
            SetViewFunc();
            presenter = new DeviceListPresenter(this);
            presenter.Initialize();
            windowResult = WindowResult.NoResult;
        }

        public IList<Device> Devices
        {
            set
            {
                bsDevices.DataSource = value;
                bsDevices.ResetBindings(false);
            }
        }

        public Device CurrentDevice
        {
            get
            {
                return bsDevices.Current as Device;
            }

        }

        public IList<Device> SelectedDevices
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

        public ViewFunctionTypes ViewFuncType
        {
            set 
            {
                this.viewFuncType = value;

            }
        }

        private void SetViewFunc()
        {
            switch (this.viewFuncType)
            {
                case ViewFunctionTypes.OnlyList:
                    btnSelect.Visible = false;
                    dgvDevices.MultiSelect = false;
                    break;
                case ViewFunctionTypes.OnlySelect:
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    btnEdit.Visible = false;
                    dgvDevices.MultiSelect = true;
                    break;
                case ViewFunctionTypes.SelectAndList:
                    break;
            }
        }

        private void DevicesListForm_Load(object sender, EventArgs e)
        {
            SetViewFunc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new DeviceEditForm(), new Device());
            presenter.Initialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            presenter.ShowEditor(new DeviceEditForm(), CurrentDevice);
            presenter.Initialize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            windowResult = WindowResult.NoResult;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteDevice();
            presenter.Initialize();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            windowResult = WindowResult.SelectedResult;
            this.Close();
        }

        public WindowResult WindowResult
        {
            get { return windowResult; }
        }
    }
}
