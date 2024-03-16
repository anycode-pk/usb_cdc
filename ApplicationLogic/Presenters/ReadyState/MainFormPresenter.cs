using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Interfaces.Dictionaries;
using ApplicationLogic.Global;
using CommonModel;
using ApplicationLogic.Helpers;
using DataManager.Repositories;
using ApplicationLogic.Interfaces.DevicesCfg;

namespace ApplicationLogic.Presenters.ReadyState
{
   public class MainFormPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IMainFormView>
    {
       public MainFormPresenter(IMainFormView view)
           : base(view)
       {

       }

       public override void Initialize()
       {
           base.Initialize();      
       }

       public void SetPermissionMenu()
       {
           this.View.SetPermissionMenu(UserRightChecker.GetAllRightsCurrentUser());
       }

       public void ShowDeviceList(IDeviceListView view)
       {
           view.ViewFuncType = ViewFunctionTypes.OnlyList;
           view.ShowView();   
       }
       public void ShowUserList(IUserListView view)
       {
           view.ViewFuncType = ViewFunctionTypes.OnlyList;
           view.ShowView();
       }
       public void ShowStationList(IStationListView view)
       {
           view.ShowView();
       }
       public void ShowUnitList(IUnitListView view)
       {
           view.ShowView();
       }
       public void ShowCmdArchetypeList(ICmdArchetypeListView view)
       {
           view.ShowView();
       }
       public void ShowConfigurationDevice(IConfDeviceListView view)
       {
           view.ShowView();
       }
       public void ShowCmdList(ICmdListListView view)
       {
           view.ShowView();
       }

       public void CloseApplication()
       {
           if (this.View.ShowQuestion(TextContentRepository.CloseApplicationQuestion, TextContentRepository.Attention) == true)
           {
               this.View.SafeCloseView();

               if (CommonContext.Instance.ConnectedDB)
               {
                   CommonContext.Instance.CurrentSession.StopDate = DateTime.Now;

                   new SessionRepository().InsertOrUpdate(CommonContext.Instance.CurrentSession);
               }

               Environment.Exit(0);
           }
           else
           {
               this.View.HideMainForm();
           }
       }
    }
}
