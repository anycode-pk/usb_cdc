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
using ApplicationLogic.Global;

namespace WinClient.Dictionaries
{
    public partial class RightList : WinClient.Base.BaseViewForm, IRightsView
    {
        private WindowResult windowsResult;

        public RightList()
        {
            InitializeComponent();
            windowsResult = ApplicationLogic.Global.WindowResult.NoResult;
        }

        public IList<Right> OtherRights
        {
            set
            {
                this.bsRights.DataSource = value;
                this.bsRights.ResetBindings(false);
            }
        }

        public IList<Right> SelectedRights
        {
            get
            {
                IList<Right> r = new List<Right>();
                foreach (DataGridViewRow row in dgvRights.SelectedRows)
                {
                    r.Add(bsRights[row.Index] as Right);
                }
                return r;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            windowsResult = ApplicationLogic.Global.WindowResult.SelectedResult;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            windowsResult = ApplicationLogic.Global.WindowResult.NoResult;
            this.Close();
        }

        public ApplicationLogic.Global.WindowResult WindowResult
        {
            get { return windowsResult; }
        }
    }
}
