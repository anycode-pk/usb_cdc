using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using ApplicationLogic.Helpers;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class DeviceListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IDeviceListView>
    {
        private DataManager.Repositories.DeviceRepository devRepo = new DataManager.Repositories.DeviceRepository();
        public DeviceListPresenter(IDeviceListView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.Devices = devRepo.GetAll();
        }

        public void ShowEditor(IDeviceEditView view, Device dev)
        {
            view.CurrentDevice = dev;
            view.ShowView();
        }

        public void DeleteDevice()
        {
            if (this.View.ShowQuestion(TextContentRepository.DeviceDeleteQuestion, TextContentRepository.Attention) == true)
            {
                if (devRepo.Remove(this.View.CurrentDevice) == false)
                {
                    this.View.ShowError(TextContentRepository.DeviceDeleteError, TextContentRepository.Attention);
                }
            }            
        }
    }
}
