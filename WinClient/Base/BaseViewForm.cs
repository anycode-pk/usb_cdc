using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationLogic.Interfaces.Base;


namespace WinClient.Base
{
    /// <summary>
    /// Bazowe okno, każde wyświetlane okno musi z niej dziedziczyć.
    /// </summary>
    public partial class BaseViewForm : Form, IBaseView
    {
        public BaseViewForm()
        {
            InitializeComponent();
        }

        public void ShowView()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowDialog();
        }

        public void CloseView()
        {
            this.Close();
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
