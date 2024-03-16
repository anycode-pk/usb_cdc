using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;
using CommonModel;
using ApplicationLogic.Global;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class StationListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IStationListView>
    {
        StationRepository stationRepo = new StationRepository();
        public StationListPresenter(IStationListView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            if (UserRightChecker.CheckRightCurrenUser(CommonModel.Enums.RightsMapper.AllowAccessToOtherStation))
            { this.View.Stations = stationRepo.GetAll(); }
            else
            {
                this.View.Stations = stationRepo.GetAll(CommonContext.Instance.CurrentUser);
            }
        }

        public void ShowEditor(IStationEditView view, MeasureStation currentStation)
        {
            view.CurrentStation = currentStation;
            view.CurrentUsers = currentStation.UserStationM2M.Select(p => p.User).ToList();
            view.CurrentDevices = currentStation.StationDeviceM2M.Select(p => p.Device).ToList();
            view.ShowView();
        }

        public void DeleteStation()
        {
            if (this.View.ShowQuestion(TextContentRepository.StationDeleteQuestion, TextContentRepository.Attention) == true)
            {
                if (stationRepo.Remove(this.View.CurrentStation) == false)
                {
                    this.View.ShowError(TextContentRepository.StationDeleteError, TextContentRepository.Attention);
                }
            } 
        }
    }
}
