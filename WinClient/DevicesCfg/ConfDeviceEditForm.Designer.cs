namespace WinClient.DevicesCfg
{
    partial class ConfDeviceEditForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.bsConfiguration = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epValidateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Opis:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguration, "Decsription", true));
            this.tbxDescription.Location = new System.Drawing.Point(81, 65);
            this.tbxDescription.MaxLength = 50;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(121, 20);
            this.tbxDescription.TabIndex = 26;
            this.tlInfoTip.SetToolTip(this.tbxDescription, "Opcjonalny opis tekstowy.");
            // 
            // bsConfiguration
            // 
            this.bsConfiguration.DataSource = typeof(CommonModel.Entities.ConfDevice);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Urządzenie:";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsConfiguration, "Device", true));
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(81, 38);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(121, 21);
            this.cmbDevice.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nazwa:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguration, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(81, 12);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 22;
            this.tlInfoTip.SetToolTip(this.tbxName, "Nazwa wyświetlana w postaci tekstowej.");
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsConfiguration, "IsActive", true));
            this.cbxActive.Location = new System.Drawing.Point(81, 92);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(67, 17);
            this.cbxActive.TabIndex = 28;
            this.cbxActive.Text = "Aktywna";
            this.tlInfoTip.SetToolTip(this.cbxActive, "Zaznaczone oznacza, że element jest widoczny w normalnym działaniu systemu. Odzna" +
        "czenie powoduje, że element jest widoczny jedynie w konfiguracji.");
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(127, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Anuluj";
            this.tlInfoTip.SetToolTip(this.btnCancel, "Anuluj zmiany.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(46, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Zapisz";
            this.tlInfoTip.SetToolTip(this.btnSave, "Zapisz zmiany.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epValidateError
            // 
            this.epValidateError.ContainerControl = this;
            this.epValidateError.DataSource = this.bsConfiguration;
            // 
            // ConfDeviceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 146);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfDeviceEditForm";
            this.Text = "Edycja konfiguracji";
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.BindingSource bsConfiguration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epValidateError;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}