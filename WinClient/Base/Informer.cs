using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinClient.Base
{
    /// <summary>
    /// Implementacja krótkich komunikatów.
    /// </summary>
   public static class Informer
    {
        internal static void ShowInfo(string content, string caption)
        {
            MessageBox.Show(content, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void ShowWarning(string content, string caption)
        {
            MessageBox.Show(content, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal static void ShowError(string content, string caption)
        {
            MessageBox.Show(content, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ShowException(Exception ex, string caption)
        {
            MessageBox.Show(ex.ToString(), caption);
        }

        internal static bool ShowQuestion(string content, string caption)
        {
            if (MessageBox.Show(content, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
