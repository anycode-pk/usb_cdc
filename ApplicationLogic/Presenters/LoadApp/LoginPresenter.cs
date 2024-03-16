using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.ReadyState;
using CommonModel.Enums;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;
using CommonModel;
using ApplicationLogic.Global;

namespace ApplicationLogic.Presenters.LoadApp
{
    public class LoginPresenter : ApplicationLogic.Presenters.Base.BasePresenter<ILoginView>
    {

        private SessionRepository sessionRepo = new SessionRepository();
        private IMainFormView mainView;

        public IMainFormView MainView
        {
            set { mainView = value; }
        }

        public LoginPresenter(ILoginView view) : base(view) 
        {

        }

        public override void Initialize()
        {
            this.View.EnableSQLControls();

            if (this.CheckConfigFile() == false)
            {
                this.View.DisableSQLControls();
                this.View.SessionTypes = new List<SessionType>() { SessionType.SQLConfig, SessionType.TestDevice };
                return;
            }


            if (this.CheckStation() == false)
            {
                this.View.SessionTypes = new List<SessionType>() { SessionType.Administrative, SessionType.SQLConfig, SessionType.TestDevice };
                return;
            }

 
            this.View.SessionTypes = HelpersSession.GetAllTypes();

        }

        public void LogIn()
        {
            MeasureSession session;
            if ((this.View.SelectedSession == SessionType.Measure) || ( this.View.SelectedSession == SessionType.Administrative))
            {
                User usr = new UserRepository().Get(this.View.Login);
                session = new MeasureSession();

                if (usr != null)
                {
                    string passwordHash = CryptographyFunctions.StrToHash(this.View.Password);
                    if (CheckUser(usr, passwordHash) == true && CheckPermission(usr, CommonContext.Instance.CurrentStation) == true)
                    {
                        session.Type = (short)this.View.SelectedSession;
                        session.User = CommonContext.Instance.CurrentUser;
                        session.MeasureStation = CommonContext.Instance.CurrentStation;

                        CommonContext.Instance.CurrentSession = session;
                        CommonContext.Instance.ConnectedDB = true;
                        CloseLastSession(CommonContext.Instance.CurrentUser, CommonContext.Instance.CurrentStation, session);
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    View.ShowError(TextContentRepository.BadLogin, TextContentRepository.Attention);
                    return;
                }
            }
            else
            {
                session = new MeasureSession() { Type = (short)this.View.SelectedSession };

            }

            this.View.CloseView();
            this.ShowNextView(session);
        }

        private bool CheckUser(User usr, string typedPassword)
        {
            if (usr.Password != typedPassword)
            {
                View.ShowError(TextContentRepository.BadLogin, TextContentRepository.Attention);
                return false;
            }
            if (usr.IsLocked == true)
            {
                View.ShowError(TextContentRepository.UserLocked, TextContentRepository.Attention);
                return false;
            }
            CommonContext.Instance.CurrentUser = usr;
            return true;
        }

        private bool CheckPermission(User usr, MeasureStation station)
        {
            UserStationM2M uStation = new UserStationM2MRepository().Get(usr, station);
            if (uStation == null   // jeśli ma dostęp do danej stacji   i
                && ( UserRightChecker.CheckRightCurrenUser(RightsMapper.LogFromAnyStation) == false  // może logować się z dowolnej stacji
                     || UserRightChecker.CheckRightCurrenUser(RightsMapper.AllowDefineStations) == false) // lub może definiować dostępy
                )
            {
                this.View.ShowError(TextContentRepository.DenyAccessToStation, TextContentRepository.Attention);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckConfigFile()
        {
            FileIOFunctions file = new FileIOFunctions(ConstRepository.SQLConfigFile);
            if (file.FileExist() == false)
            {
                this.View.ShowError(TextContentRepository.ConfigFileNotFound, TextContentRepository.Attention);
                return false;
            }
            string encrypted = "";
            FileConfig fileCfg;
            try
            {
                encrypted = file.ReadFileContent();
            }
            catch (Exception ex)
            {
                CommonContext.Instance.LogException(ex);
                this.View.ShowError(TextContentRepository.ConfigFileNotFound, TextContentRepository.Attention);
                return false;
            }

            try
            {
                byte[] rawDecrypted = CryptographyFunctions.Decrypt(encrypted);
                fileCfg = new FileConfig(rawDecrypted);
            }
            catch (Exception ex)
            {
                CommonContext.Instance.LogException(ex);
                this.View.ShowError(TextContentRepository.BadConfigFile, TextContentRepository.Attention);
                return false;
            }

            CommonContext.Instance.ConnectionString = fileCfg.ConnectionString;
            CommonContext.Instance.ThisStationName = fileCfg.StationName;

            if (new DataManager.ConnectionTester().Test(CommonContext.Instance.ConnectionString) == false)
            {
                this.View.ShowError(TextContentRepository.DBNoFound, TextContentRepository.Attention);
                return false;

            }
             return true;
        }

        private bool CheckStation()
        {
            MeasureStation station = new StationRepository().Get(CommonContext.Instance.ThisStationName);
            if (station != null)
            {
                CommonContext.Instance.CurrentStation = station;
                return true;
            }
            else
            {
                this.View.ShowError(TextContentRepository.StationNoFound, TextContentRepository.Attention);
                return false;
            }
        }

        private void CloseLastSession(User usr, MeasureStation station, MeasureSession actualy)
        {
            IList<MeasureSession> sess = sessionRepo.GetLastOpen(usr, station);
            bool anyClosed = false;

            foreach (MeasureSession ms in sess)
            {
                if (ms.Id != actualy.Id)
                {
                    ms.StopDate = actualy.StartDate;
                    sessionRepo.InsertOrUpdate(ms);
                    anyClosed = true;
                }
            }
            if (anyClosed)
            {
                this.View.ShowInfo(TextContentRepository.OpenLastSession, TextContentRepository.Info);
            }
        }

        private void ShowNextView(MeasureSession session)
        {
            switch (session.Type)
            {
                case (int) SessionType.Measure:
                    this.mainView.ShowConfigSelectorControl();
                    break;

                case (int) SessionType.Administrative:
                    if (UserRightChecker.CheckRightCurrenUser(RightsMapper.AllowLogOnAdministrative) == true)
                    {
                        this.mainView.ShowAdminControl();
                    }
                    else
                    {
                        this.View.ShowError(TextContentRepository.DenyAccessToAdministrative, TextContentRepository.Attention);
                    }
                    break;

                case (int) SessionType.SQLConfig:
                    this.mainView.ShowSQLCofnigControl();
                    break;

                case (int) SessionType.TestDevice:
                    this.mainView.ShowTestControl();
                    break;
            }
        }
    }
}
