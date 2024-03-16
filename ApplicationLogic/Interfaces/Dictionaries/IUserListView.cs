using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;
using ApplicationLogic.Global;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IUserListView : IBaseView
    {
        IList<User> Users { set; get; }
        User CurrentUser { get; }
        IList<User> SelectedUsers { get; }
        ViewFunctionTypes ViewFuncType { set; }
        WindowResult WindowResult { get; }
    }
}
