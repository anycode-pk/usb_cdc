using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinClient.Dictionaries
{
    public partial class PasswordTypedForm : Form
    {
        public string NewPassword
        {
            get { return mtbxPassword.Text; }
        }

        public PasswordTypedForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mtbxPassword.Text == mtbxRetypedPassword.Text)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                WinClient.Base.Informer.ShowError(ApplicationLogic.Helpers.TextContentRepository.PasswordNoMatch,
                    ApplicationLogic.Helpers.TextContentRepository.Attention);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
