using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.DevicesCfg;
using DataManager.Repositories;

namespace ApplicationLogic.Presenters.DevicesCfg
{
    public class CmdArchetypeEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<ICmdArchetypeEditView>
    {
        CmdArchetypeRepository cmdArRepo = new CmdArchetypeRepository();
        public CmdArchetypeEditPresenter(ICmdArchetypeEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void Save()
        {
            cmdArRepo.InsertOrUpdate(this.View.CurrentCmdArchetype);
            this.View.CloseView();
        }

        public void Cancel()
        {
            cmdArRepo.RejectChanges(this.View.CurrentCmdArchetype);
            this.View.CloseView();
        }

    }
}
