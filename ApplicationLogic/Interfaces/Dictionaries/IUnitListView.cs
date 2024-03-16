using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IUnitListView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        IList<Unit> Units { set; }
        Unit CurrentUnit { get; }
    }
}
