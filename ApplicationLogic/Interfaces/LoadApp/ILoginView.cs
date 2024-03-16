using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;


namespace ApplicationLogic.Interfaces.ReadyState
{
    public interface ILoginView : IBaseView
    {
        string Login { get;  }
        string Password { get;  }
        IList<CommonModel.Enums.SessionType> SessionTypes {set; }
        CommonModel.Enums.SessionType SelectedSession { get; }
        void DisableSQLControls();
        void EnableSQLControls();
    }
}
