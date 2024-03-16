namespace WinClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSystemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miSystemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictionaries = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictStations = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.miDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.miDevCmdArchetype = new System.Windows.Forms.ToolStripMenuItem();
            this.miDevConfigurations = new System.Windows.Forms.ToolStripMenuItem();
            this.miDevCmdList = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(13, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(607, 451);
            this.pnlMain.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem,
            this.miDictionaries,
            this.miDevices});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(632, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystemAbout,
            this.miSystemExit});
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(57, 20);
            this.miSystem.Text = "System";
            // 
            // miSystemAbout
            // 
            this.miSystemAbout.Name = "miSystemAbout";
            this.miSystemAbout.Size = new System.Drawing.Size(152, 22);
            this.miSystemAbout.Text = "O programie";
            this.miSystemAbout.Click += new System.EventHandler(this.miSystemAbout_Click);
            // 
            // miSystemExit
            // 
            this.miSystemExit.Name = "miSystemExit";
            this.miSystemExit.Size = new System.Drawing.Size(152, 22);
            this.miSystemExit.Text = "Wyjście";
            this.miSystemExit.Click += new System.EventHandler(this.miSystemExit_Click);
            // 
            // miDictionaries
            // 
            this.miDictionaries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDictUsers,
            this.miDictStations,
            this.miDictUnits,
            this.miDictDevices});
            this.miDictionaries.Name = "miDictionaries";
            this.miDictionaries.Size = new System.Drawing.Size(63, 20);
            this.miDictionaries.Text = "Słowniki";
            // 
            // miDictUsers
            // 
            this.miDictUsers.Name = "miDictUsers";
            this.miDictUsers.Size = new System.Drawing.Size(150, 22);
            this.miDictUsers.Text = "Użytkownicy";
            this.miDictUsers.Click += new System.EventHandler(this.miDictUsers_Click);
            // 
            // miDictStations
            // 
            this.miDictStations.Name = "miDictStations";
            this.miDictStations.Size = new System.Drawing.Size(150, 22);
            this.miDictStations.Text = "Stacje";
            this.miDictStations.Click += new System.EventHandler(this.miDictStations_Click);
            // 
            // miDictUnits
            // 
            this.miDictUnits.Name = "miDictUnits";
            this.miDictUnits.Size = new System.Drawing.Size(150, 22);
            this.miDictUnits.Text = "Jednostki miar";
            this.miDictUnits.Click += new System.EventHandler(this.miDictUnits_Click);
            // 
            // miDictDevices
            // 
            this.miDictDevices.Name = "miDictDevices";
            this.miDictDevices.Size = new System.Drawing.Size(150, 22);
            this.miDictDevices.Text = "Urządzenia";
            this.miDictDevices.Click += new System.EventHandler(this.miDictDevices_Click);
            // 
            // miDevices
            // 
            this.miDevices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDevCmdArchetype,
            this.miDevConfigurations,
            this.miDevCmdList});
            this.miDevices.Name = "miDevices";
            this.miDevices.Size = new System.Drawing.Size(76, 20);
            this.miDevices.Text = "Urządzenia";
            // 
            // miDevCmdArchetype
            // 
            this.miDevCmdArchetype.Name = "miDevCmdArchetype";
            this.miDevCmdArchetype.Size = new System.Drawing.Size(193, 22);
            this.miDevCmdArchetype.Text = "Pierwowzory rozkazów";
            this.miDevCmdArchetype.Click += new System.EventHandler(this.miDevCmdArchetype_Click);
            // 
            // miDevConfigurations
            // 
            this.miDevConfigurations.Name = "miDevConfigurations";
            this.miDevConfigurations.Size = new System.Drawing.Size(193, 22);
            this.miDevConfigurations.Text = "Konfiguracje";
            this.miDevConfigurations.Click += new System.EventHandler(this.miDevConfigurations_Click);
            // 
            // miDevCmdList
            // 
            this.miDevCmdList.Name = "miDevCmdList";
            this.miDevCmdList.Size = new System.Drawing.Size(193, 22);
            this.miDevCmdList.Text = "Listy rozkazów";
            this.miDevCmdList.Click += new System.EventHandler(this.miDevCmdList_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "USB-CDC";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 513);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(640, 540);
            this.Name = "MainForm";
            this.Text = "USB-CDC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miSystemAbout;
        private System.Windows.Forms.ToolStripMenuItem miSystemExit;
        private System.Windows.Forms.ToolStripMenuItem miDictionaries;
        private System.Windows.Forms.ToolStripMenuItem miDictUsers;
        private System.Windows.Forms.ToolStripMenuItem miDictStations;
        private System.Windows.Forms.ToolStripMenuItem miDictUnits;
        private System.Windows.Forms.ToolStripMenuItem miDictDevices;
        private System.Windows.Forms.ToolStripMenuItem miDevices;
        private System.Windows.Forms.ToolStripMenuItem miDevCmdArchetype;
        private System.Windows.Forms.ToolStripMenuItem miDevConfigurations;
        private System.Windows.Forms.ToolStripMenuItem miDevCmdList;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
    }
}