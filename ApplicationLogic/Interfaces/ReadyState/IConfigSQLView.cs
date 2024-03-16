using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;

namespace ApplicationLogic.Interfaces.ReadyState
{
    public interface IConfigSQLView : IBaseView
    {
        string StationName { set; get; }
        string ConnectionString { get; }
    }
}
