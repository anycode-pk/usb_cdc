using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Enums;

namespace ApplicationLogic.Interfaces.ReadyState
{
    public interface IMainFormView : IBaseView
    {
        void ShowConfigSelectorControl();
        void ShowMeasurementStationControl();
        void ShowAdminControl();
        void ShowTestControl();
        void ShowSQLCofnigControl();
        void ShowLoginControl();
        void LockMenu();
        void UnlockMenu();
        void SetPermissionMenu(IList<RightsMapper> Rights);
        void SafeCloseView();
        void HideMainForm();        
    }
}
