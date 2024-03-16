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
    public partial class TestDeviceControl : WinClient.Base.BaseViewControl, ITestDeviceView
    {
        private TestDevicePresenter presenter;
        private delegate void InvokerSetText(string textParameter, Control ctrlParameter);

        public TestDeviceControl()
        {
            InitializeComponent();
            presenter = new TestDevicePresenter(this);
            presenter.Initialize();
        }

        public string Vid
        {
            get { return tbxVid.Text; }
        }

        public string Pid
        {
            get { return tbxPid.Text; }
        }

        public byte Command
        {
            get 
            {
                byte result = 0;
                byte.TryParse(tbxCommand.Text, out result);
                return result;
            }
        }

        public short Index
        {
            get
            {
                byte result = 0;
                byte.TryParse(tbxIndex.Text, out result);
                return result;
            }
        }

        public short Value
        {
            get
            {
                byte result = 0;
                byte.TryParse(tbxValue.Text, out result);
                return result;
            }
        }

        public string ResultBin
        {
            set { tbxResultBin.Text = value; }
        }

        public string ResultDec
        {
            set { tbxResultDec.Text = value; }
        }

        public string ResultHex
        {
            set { tbxResultHex.Text = value; }
        }

        public string ResultAscii
        {
            set { tbxResultAscii.Text = value; }
        }


        public string DeviceStatus
        {
            set { SetTextBeginInvoke(value, lbStatus); }
        }

        private void SetTextBeginInvoke(string text, Control control)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new InvokerSetText(SetTextBeginInvoke), text, control);
                return;
            }
            control.Text = text;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            presenter.Connect();
        }

        public int ReturnesByres
        {
            get { return (int) nudReturnedBytes.Value; }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            presenter.Execute();
        }
    }
}
