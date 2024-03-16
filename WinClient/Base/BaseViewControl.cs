using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.Base;

namespace WinClient.Base
{
    /// <summary>
    /// Bazowa kontrolka, każda wyświtlana kontrolka musi z niej dziedziczyć.
    /// </summary>
    public partial class BaseViewControl : UserControl, IBaseView
    {
        public BaseViewControl()
        {
            InitializeComponent();
        }

        public void ShowView()
        {
            MainForm.Instance.ShowControl(this);
        }

        public virtual void CloseView()
        {
            MainForm.Instance.CloseCurrentControl();
        }

        public void ShowInfo(string content, string caption)
        {
            Informer.ShowInfo(content, caption);
        }

        public bool ShowQuestion(string content, string caption)
        {
            return Informer.ShowQuestion(content, caption);
        }

        public void ShowWarning(string content, string caption)
        {
            Informer.ShowWarning(content, caption);
        }

        public void ShowError(string content, string caption)
        {
            Informer.ShowError(content, caption);
        }

        public void ShowException(Exception ex, string caption)
        {
            Informer.ShowException(ex, caption);
        }
    }
}
