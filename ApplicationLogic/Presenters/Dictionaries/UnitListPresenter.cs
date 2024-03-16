using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using ApplicationLogic.Helpers;
using DataManager.Repositories;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class UnitListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IUnitListView>
    {
        UnitRepository unitRepo = new UnitRepository();
        public UnitListPresenter(IUnitListView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.Units = unitRepo.GetAll();
        }

        public void ShowEditor(IUnitEditView view, Unit current)
        {
            view.CurrentUnit = current;
            view.ShowView();
        }

        public void DeleteUnit()
        {
            if (this.View.ShowQuestion(TextContentRepository.UnitDeleteQuestion, TextContentRepository.Attention) == true)
                {
                    if (unitRepo.Remove(this.View.CurrentUnit) == false)
                    {
                        this.View.ShowError(TextContentRepository.UnitDeleteError, TextContentRepository.Attention);
                    }
                }   
        }
    }
}
