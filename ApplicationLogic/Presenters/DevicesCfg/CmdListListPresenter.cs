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
    public class CmdListListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<ICmdListListView>
    {
        private CmdListRepository cmdListRepo = new CmdListRepository();
        private ConfigurationRepository cfgRepo = new ConfigurationRepository();

        public CmdListListPresenter(ICmdListListView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
            if (this.View.CurrentConfiguration == null)
            {
                IList<ConfDevice> configurations = cfgRepo.GetAll();
                CheckConfigurations(configurations);
                this.View.Configurations = configurations;
            }
            else
            {
                this.ReloadCmdList();
            }
        }

        private void CheckConfigurations(IList<ConfDevice> configurations)
        {
            if (configurations.Any() == false)
            {
                this.View.ShowWarning(TextContentRepository.EmptyConfiguration, TextContentRepository.Attention);
                this.View.DisableEditing();
            }
        }


        public void ShowEditor(ICmdListEditView view, CmdList current)
        {
            if (current == null)
                return;

            view.CurrentCmdList = current;
            view.Configurations = cfgRepo.GetAll();
            view.ShowView();
        }

        public void DeleteCmdList()
        {
            if (this.View.ShowQuestion(TextContentRepository.CmdListDeleteQuestion, TextContentRepository.Attention) == true)
            {
                if (cmdListRepo.Remove(this.View.CurrentCmdList) == false)
                {
                    this.View.ShowError(TextContentRepository.CmdListDeleteError, TextContentRepository.Attention);
                }
            } 
        }

        public void ReloadCmdList()
        {
            this.View.CommandsList = cmdListRepo.Get(this.View.CurrentConfiguration);
        }
    }
}
