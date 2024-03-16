using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IUserEditView : IBaseView
    {
        User CurrentUser { set; get; }
        IList<Right> CurrentRight { set; get; }
        IList<Right> SelectedRights { get; }
    }
}
