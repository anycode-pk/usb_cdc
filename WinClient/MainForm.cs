using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinClient.Base;
using ApplicationLogic.Interfaces.ReadyState;
using ApplicationLogic.Presenters.LoadApp;
using WinClient.LoadApp;
using WinClient.ReadyState;
using ApplicationLogic.Presenters.ReadyState;
using WinClient.Dictionaries;
using WinClient.DevicesCfg;
using CommonModel.Enums;
using CommonModel;


namespace WinClient
{
    /// <summary>
    /// Klasa głównego okna aplikacji.
    /// </summary>
    public partial class MainForm : BaseViewForm, IMainFormView
    {
        private Panel MainPanel { get { return this.pnlMain; } }
        private BaseViewControl CurrentControl { get; set; }
        private ApplicationLogic.Global.ModelChangedListener modelChangedListeneres;
        private MainFormPresenter presenter;

        private MainForm()
        {
            InitializeComponent();
            modelChangedListeneres = new ApplicationLogic.Global.ModelChangedListener();
            CommonContext.Instance.ConnectedDB = false;
            presenter = new MainFormPresenter(this);
            presenter.Initialize();
            this.LockMenu();
            LoadAplication();
        }

        private static MainForm instance;

        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm();
                }

                return instance;
            }
        }

        /// <summary>
        /// Wyświetla kontrolkę (o ile kontrolka tego typu nie jest jeszcze wyświetlana).
        /// </summary>
        public void ShowControl(BaseViewControl control)
        {
            control.Dock = DockStyle.Fill;

            this.CurrentControl = control;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(control);
        }

        /// <summary>
        /// Zamyka kontrolkę.
        /// </summary>
        public void CloseCurrentControl()
        {
            // usunięcie z listy i z panelu
            this.MainPanel.Controls.Clear();
            this.CurrentControl = null;
        }
        
        private void LoadAplication()
        {
            this.ShowLoginControl();
            
        }

        public void ShowConfigSelectorControl()
        {
            presenter.SetPermissionMenu();
            this.ShowControl(new ConfigSelectorControl(this));
        }

        public void ShowMeasurementStationControl()
        {
            this.UnlockMenu();
            this.ShowControl(new MeasureStationControl(this));
        }
        
        public void ShowAdminControl()
        {
            presenter.SetPermissionMenu();
            this.UnlockMenu();
            this.ShowControl(new TestDeviceControl());
        }

        public void ShowTestControl()
        {
            this.LockMenu();
            this.ShowControl(new TestDeviceControl());
        }

        public void ShowSQLCofnigControl()
        {
            this.LockMenu();
            this.ShowControl(new ConfigSQLControl(this));
        }

        #region Menu item events

        private void miDictDevices_Click(object sender, EventArgs e)
        {
            presenter.ShowDeviceList(new DeviceListForm());
        }
        private void miDictUsers_Click(object sender, EventArgs e)
        {
            presenter.ShowUserList(new UserListForm());
        }
        private void miDictStations_Click(object sender, EventArgs e)
        {
            presenter.ShowStationList(new StationListForm());
        }
        private void miDictUnits_Click(object sender, EventArgs e)
        {
            presenter.ShowUnitList(new UnitListForm());
        }

        private void miDevCmdArchetype_Click(object sender, EventArgs e)
        {
            presenter.ShowCmdArchetypeList(new CmdArchetypeListForm());
        }
        private void miDevConfigurations_Click(object sender, EventArgs e)
        {
            presenter.ShowConfigurationDevice(new ConfDeviceListForm());
        }
        private void miDevCmdList_Click(object sender, EventArgs e)
        {
            presenter.ShowCmdList(new CmdListListForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (presenter != null)
            {
                presenter.CloseApplication();                
            }
        }

        private void miSystemExit_Click(object sender, EventArgs e)
        {
            presenter.CloseApplication();
        }

        #endregion

        public void LockMenu()
        {
            this.SetMenuStatus(false);
        }

        public void UnlockMenu()
        {
            this.SetMenuStatus(true);
        }

        private void SetMenuStatus(bool status)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Invoker(SetMenuStatus), status);
                return;
            }
            this.miDevices.Enabled = status;
            this.miDictionaries.Enabled = status;
        }

        private delegate void Invoker(bool parameter);

        public void SetPermissionMenu(IList<RightsMapper> Rights)
        {
            miDictDevices.Enabled = false;
            miDictStations.Enabled = false;
            miDictUnits.Enabled = false;
            miDictUsers.Enabled = false;

            miDevCmdArchetype.Enabled = false;
            miDevCmdList.Enabled = false;
            miDevConfigurations.Enabled = false;            

            foreach (RightsMapper right in Rights)
            {
                switch (right)
                {
                    case RightsMapper.AllowDefineStations:
                        miDictStations.Enabled = true;
                        break;
                    case RightsMapper.AllowDefineCmdArchetype:
                        miDevCmdArchetype.Enabled = true;
                        break;
                    case RightsMapper.AllowDefineCmdList:
                        miDevCmdList.Enabled = true;
                        break;
                    case RightsMapper.AllowDefineCommands:
                        //zaimplementowane w oknie edycji listy rozkazów.
                        break;
                    case RightsMapper.AllowDefineConfigurations:
                        miDevConfigurations.Enabled = true;
                        break;
                    case RightsMapper.AllowDefineDevices:
                        miDictDevices.Enabled = true;
                        break;
                    case RightsMapper.AllowDefineUnits:
                        miDictUnits.Enabled = true;
                        break;
                    case RightsMapper.AllowDefineUsers:
                        miDictUsers.Enabled = true;
                        break;
                }
            }
        }

        public void SafeCloseView()
        {
            if (CurrentControl != null)
                CurrentControl.CloseView();
        }
        
        public void ShowLoginControl()
        {
            this.ShowControl(new LoginEntryControl(this));
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        public void HideMainForm()
        {
            this.Hide();
        }

        private void miSystemAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
