using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.DevicesCfg;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;

namespace ApplicationLogic.Presenters.DevicesCfg
{
    public class ConfDeviceListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IConfDeviceListView>
    {
        private ConfigurationRepository confRepo = new ConfigurationRepository();
        public ConfDeviceListPresenter(IConfDeviceListView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.Configurations = confRepo.GetAll();
        }

        public void ShowEditor(IConfDeviceEditView view, ConfDevice current)
        {
            if (current == null)
                return;

            if (current.Id == 0)
            {
                current.Device = new DeviceRepository().GetDefault();
            }
            view.CurrentCofiguration = current;
            view.AvaibleDevices = new DeviceRepository().GetAll();
            view.ShowView();
        }

        public void DeleteConfiguration()
        {
            if (this.View.ShowQuestion(TextContentRepository.ConfigurationDeleteQuestion, TextContentRepository.Attention) == true)
            {
                if (confRepo.Remove(this.View.CurrentConfiguration) == false)
                {
                    this.View.ShowError(TextContentRepository.ConfigurationDeleteError, TextContentRepository.Attention);
                }
            } 
        }
    }
}
