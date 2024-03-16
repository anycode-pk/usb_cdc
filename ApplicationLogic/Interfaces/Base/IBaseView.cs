using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic.Interfaces.Base
{
    /// <summary>
    /// Bazowy interfejs dla wszystkich widoków.
    /// </summary>
   public interface IBaseView : IInformer
    {
        void ShowView();
        void CloseView();
    }
}
