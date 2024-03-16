using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;
using ApplicationLogic.Global;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IRightsView : IBaseView
    {
        IList<Right> OtherRights { set; }
        IList<Right> SelectedRights { get; }
        WindowResult WindowResult { get; }
    }
}
