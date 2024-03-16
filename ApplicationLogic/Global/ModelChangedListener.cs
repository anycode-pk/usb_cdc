using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.ModelChandegEvents;
using DataManager.Repositories;

namespace ApplicationLogic.Global
{
    /// <summary>
    /// Klasa nasłuchująca zdarzeń generowanych w singletonie CommonContext na wystąpienie zmian w aktualnej sesji.
    /// </summary>
    public class ModelChangedListener
    {

        public ModelChangedListener()
        {
            this.InitializeListeners();
        }

        private void InitializeListeners()
        {
            CommonModel.CommonContext.Instance.OnCurrentSessionChanged += new CommonModel.CommonContext.CurrentSessionChangedEventHandler(UpdateSession_OnCurrentSessionChanged);
        }

        private void UpdateSession_OnCurrentSessionChanged(SessionChangedEventArgs eventArgs)
        {
            new SessionRepository().InsertOrUpdate(eventArgs.Session);
        }
    }
}
