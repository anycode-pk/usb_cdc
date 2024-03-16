using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Helpers;
using DataManager;
using CommonModel;

namespace ApplicationLogic.Presenters.ReadyState
{
    public class ConfigSQLPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IConfigSQLView>
    {

        private IMainFormView mainFormView;
        public IMainFormView MainFormView
        { set { mainFormView = value; } }

        public ConfigSQLPresenter(IConfigSQLView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.StationName = System.Environment.MachineName;
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(this.View.StationName))
            {
                this.View.ShowError(TextContentRepository.EmtyString, TextContentRepository.Attention);
                return;
            }
            CommonContext.Instance.ThisStationName = this.View.StationName;
            string connStr = this.View.ConnectionString;

            if (new ConnectionTester().Test(connStr) == false)
            {
                if (this.View.ShowQuestion(TextContentRepository.BadConnectionString, TextContentRepository.Attention) == false)
                {
                    return;
                }
            }

            CommonContext.Instance.ConnectionString = connStr;
            string encrypted;

            try
            {
                FileConfig fileConfig = new FileConfig(CommonContext.Instance.ThisStationName, CommonContext.Instance.ConnectionString);
                 encrypted = CryptographyFunctions.Encypt(fileConfig.GetBytes());
            }
            catch (Exception ex)
            {
                CommonContext.Instance.LogException(ex);
                this.View.ShowError(TextContentRepository.ErrorCryptography, TextContentRepository.Attention);
                return;
            }
            FileIOFunctions file = new FileIOFunctions(ConstRepository.SQLConfigFile);
            if (file.WriteFile(encrypted) == false)
            {
                this.View.ShowError(TextContentRepository.FileWriteError, TextContentRepository.Attention);
                return;
            }

            mainFormView.ShowLoginControl();
        }
    }
}
