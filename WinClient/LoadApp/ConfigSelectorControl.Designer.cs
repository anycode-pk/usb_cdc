namespace WinClient.LoadApp
{
    partial class ConfigSelectorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsDevices = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbxConfigurations = new System.Windows.Forms.ListBox();
            this.bsConfigurations = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbxDevices = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.RichTextBox();
            this.btnRunApp = new System.Windows.Forms.Button();
            this.tbxCfgDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfigurations)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDevices
            // 
            this.bsDevices.DataSource = typeof(CommonModel.Entities.Device);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konfiguracje:";
            // 
            // lbxConfigurations
            // 
            this.lbxConfigurations.DataSource = this.bsConfigurations;
            this.lbxConfigurations.DisplayMember = "Name";
            this.lbxConfigurations.FormattingEnabled = true;
            this.lbxConfigurations.Location = new System.Drawing.Point(213, 20);
            this.lbxConfigurations.Name = "lbxConfigurations";
            this.lbxConfigurations.Size = new System.Drawing.Size(200, 212);
            this.lbxConfigurations.TabIndex = 2;
            this.tlInfoTip.SetToolTip(this.lbxConfigurations, "Lista aktywnych konfiguracji dostępnych dla wybranego urządzenia.");
            this.lbxConfigurations.SelectedIndexChanged += new System.EventHandler(this.lbxConfigurations_SelectedIndexChanged);
            // 
            // bsConfigurations
            // 
            this.bsConfigurations.DataSource = typeof(CommonModel.Entities.ConfDevice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urządzenia:";
            // 
            // lbxDevices
            // 
            this.lbxDevices.DataSource = this.bsDevices;
            this.lbxDevices.DisplayMember = "Name";
            this.lbxDevices.FormattingEnabled = true;
            this.lbxDevices.Location = new System.Drawing.Point(7, 20);
            this.lbxDevices.Name = "lbxDevices";
            this.lbxDevices.Size = new System.Drawing.Size(200, 212);
            this.lbxDevices.TabIndex = 0;
            this.tlInfoTip.SetToolTip(this.lbxDevices, "Lista aktywnych urządzeń dostępnych na tym stanowisku.");
            this.lbxDevices.SelectedIndexChanged += new System.EventHandler(this.lbxDevices_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis sesji:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(7, 256);
            this.tbxDescription.MaxLength = 1000;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(583, 112);
            this.tbxDescription.TabIndex = 5;
            this.tbxDescription.Text = "";
            this.tlInfoTip.SetToolTip(this.tbxDescription, "Tekstowy opis sesji pomiarowej.");
            // 
            // btnRunApp
            // 
            this.btnRunApp.Location = new System.Drawing.Point(515, 374);
            this.btnRunApp.Name = "btnRunApp";
            this.btnRunApp.Size = new System.Drawing.Size(75, 23);
            this.btnRunApp.TabIndex = 6;
            this.btnRunApp.Text = "Uruchom";
            this.tlInfoTip.SetToolTip(this.btnRunApp, "Uruchom sesję pomiarową dla wybranego urządzenia i konfiguracji.");
            this.btnRunApp.UseVisualStyleBackColor = true;
            this.btnRunApp.Click += new System.EventHandler(this.btnRunApp_Click);
            // 
            // tbxCfgDescription
            // 
            this.tbxCfgDescription.Location = new System.Drawing.Point(420, 20);
            this.tbxCfgDescription.Name = "tbxCfgDescription";
            this.tbxCfgDescription.ReadOnly = true;
            this.tbxCfgDescription.Size = new System.Drawing.Size(170, 212);
            this.tbxCfgDescription.TabIndex = 7;
            this.tbxCfgDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis konfiguracji:";
            // 
            // ConfigSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCfgDescription);
            this.Controls.Add(this.btnRunApp);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxConfigurations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxDevices);
            this.Name = "ConfigSelectorControl";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.bsDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfigurations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxConfigurations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsDevices;
        private System.Windows.Forms.BindingSource bsConfigurations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbxDescription;
        private System.Windows.Forms.Button btnRunApp;
        private System.Windows.Forms.RichTextBox tbxCfgDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}
