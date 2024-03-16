using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic.Interfaces.Base
{
    /// <summary>
    /// Bazowy interfejs opisujący funkcje wyświetlające informacje.
    /// </summary>
    public interface IInformer
    {
        void ShowInfo(string content, string caption);
        bool ShowQuestion(string content, string caption);
        void ShowWarning(string content, string caption);
        void ShowError(string content, string caption);
        void ShowException(Exception ex, string caption);
    }
}
