using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using DataManager.Repositories;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class UnitEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IUnitEditView>
    {
        UnitRepository unitRepo = new UnitRepository();
        public UnitEditPresenter(IUnitEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void Save()
        {
            unitRepo.InsertOrUpdate(this.View.CurrentUnit);
            this.View.CloseView();
        }

        public void Cancel()
        {
            unitRepo.RejectChanges(this.View.CurrentUnit);
            this.View.CloseView();
        }
    }
}
