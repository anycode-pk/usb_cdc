namespace WinClient.ReadyState
{
    partial class MeasureStationControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDevice = new System.Windows.Forms.Label();
            this.lbConfiguration = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbDeviceStatus = new System.Windows.Forms.Label();
            this.lbxCmdsList = new System.Windows.Forms.ListBox();
            this.bsCmdsList = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartCycle = new System.Windows.Forms.Button();
            this.btnStopCycle = new System.Windows.Forms.Button();
            this.btnForceMeasurement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCycleDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMeasurementDescription = new System.Windows.Forms.RichTextBox();
            this.cbxRepeat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCurrCmd = new System.Windows.Forms.Label();
            this.lbCurrValueUnit = new System.Windows.Forms.Label();
            this.lbCurrValueDev = new System.Windows.Forms.Label();
            this.lbCurrError = new System.Windows.Forms.Label();
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urządzenie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konfiguracja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Użytkownik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status urządzenia:";
            // 
            // lbDevice
            // 
            this.lbDevice.AutoSize = true;
            this.lbDevice.Location = new System.Drawing.Point(117, 20);
            this.lbDevice.Name = "lbDevice";
            this.lbDevice.Size = new System.Drawing.Size(35, 13);
            this.lbDevice.TabIndex = 4;
            this.lbDevice.Text = "label5";
            // 
            // lbConfiguration
            // 
            this.lbConfiguration.AutoSize = true;
            this.lbConfiguration.Location = new System.Drawing.Point(117, 36);
            this.lbConfiguration.Name = "lbConfiguration";
            this.lbConfiguration.Size = new System.Drawing.Size(35, 13);
            this.lbConfiguration.TabIndex = 5;
            this.lbConfiguration.Text = "label5";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(117, 52);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(35, 13);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "label6";
            // 
            // lbDeviceStatus
            // 
            this.lbDeviceStatus.AutoSize = true;
            this.lbDeviceStatus.Location = new System.Drawing.Point(117, 66);
            this.lbDeviceStatus.Name = "lbDeviceStatus";
            this.lbDeviceStatus.Size = new System.Drawing.Size(35, 13);
            this.lbDeviceStatus.TabIndex = 7;
            this.lbDeviceStatus.Text = "label7";
            // 
            // lbxCmdsList
            // 
            this.lbxCmdsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCmdsList.DataSource = this.bsCmdsList;
            this.lbxCmdsList.FormattingEnabled = true;
            this.lbxCmdsList.Location = new System.Drawing.Point(10, 137);
            this.lbxCmdsList.Name = "lbxCmdsList";
            this.lbxCmdsList.Size = new System.Drawing.Size(287, 290);
            this.lbxCmdsList.TabIndex = 8;
            this.tlInfoTip.SetToolTip(this.lbxCmdsList, "Lista rozkazów w aktualnej konfiguracji. Zaznaczona jest aktualnie wykonywana lis" +
        "ta.");
            // 
            // bsCmdsList
            // 
            this.bsCmdsList.DataSource = typeof(CommonModel.Entities.CmdList);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista rozkazów:";
            // 
            // btnStartCycle
            // 
            this.btnStartCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCycle.Location = new System.Drawing.Point(303, 137);
            this.btnStartCycle.Name = "btnStartCycle";
            this.btnStartCycle.Size = new System.Drawing.Size(141, 23);
            this.btnStartCycle.TabIndex = 10;
            this.btnStartCycle.Text = "Uruchom cykl";
            this.tlInfoTip.SetToolTip(this.btnStartCycle, "Uruchom cykl pomiarowy, który wykona wszystkie listy rozkazów.");
            this.btnStartCycle.UseVisualStyleBackColor = true;
            this.btnStartCycle.Click += new System.EventHandler(this.btnStartCycle_Click);
            // 
            // btnStopCycle
            // 
            this.btnStopCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopCycle.Location = new System.Drawing.Point(303, 189);
            this.btnStopCycle.Name = "btnStopCycle";
            this.btnStopCycle.Size = new System.Drawing.Size(140, 23);
            this.btnStopCycle.TabIndex = 11;
            this.btnStopCycle.Text = "Zatrzymaj cykl";
            this.tlInfoTip.SetToolTip(this.btnStopCycle, "Zatrzymaj aktualnie trwający cykl.");
            this.btnStopCycle.UseVisualStyleBackColor = true;
            this.btnStopCycle.Click += new System.EventHandler(this.btnStopCycle_Click);
            // 
            // btnForceMeasurement
            // 
            this.btnForceMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForceMeasurement.Location = new System.Drawing.Point(450, 137);
            this.btnForceMeasurement.Name = "btnForceMeasurement";
            this.btnForceMeasurement.Size = new System.Drawing.Size(140, 75);
            this.btnForceMeasurement.TabIndex = 12;
            this.btnForceMeasurement.Text = "Wymuś pomiar";
            this.tlInfoTip.SetToolTip(this.btnForceMeasurement, "Wykonaj pojedynczy pomiar z zaznaczonej listy rozkazów.");
            this.btnForceMeasurement.UseVisualStyleBackColor = true;
            this.btnForceMeasurement.Click += new System.EventHandler(this.btnForceMeasurement_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Opis cyklu:";
            // 
            // tbxCycleDescription
            // 
            this.tbxCycleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCycleDescription.Location = new System.Drawing.Point(303, 248);
            this.tbxCycleDescription.Name = "tbxCycleDescription";
            this.tbxCycleDescription.Size = new System.Drawing.Size(290, 80);
            this.tbxCycleDescription.TabIndex = 14;
            this.tbxCycleDescription.Text = "";
            this.tlInfoTip.SetToolTip(this.tbxCycleDescription, "Tekstowy opis cyklu. Dla pomiaru wymuszonego pozostaje jeden opis.");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Opis pomiaru:";
            // 
            // tbxMeasurementDescription
            // 
            this.tbxMeasurementDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMeasurementDescription.Location = new System.Drawing.Point(303, 347);
            this.tbxMeasurementDescription.Name = "tbxMeasurementDescription";
            this.tbxMeasurementDescription.Size = new System.Drawing.Size(287, 80);
            this.tbxMeasurementDescription.TabIndex = 16;
            this.tbxMeasurementDescription.Text = "";
            this.tlInfoTip.SetToolTip(this.tbxMeasurementDescription, "Tekstowy opis pomiaru. Odczytywany co zmianę listy rozkazu.");
            // 
            // cbxRepeat
            // 
            this.cbxRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRepeat.AutoSize = true;
            this.cbxRepeat.Location = new System.Drawing.Point(303, 166);
            this.cbxRepeat.Name = "cbxRepeat";
            this.cbxRepeat.Size = new System.Drawing.Size(74, 17);
            this.cbxRepeat.TabIndex = 17;
            this.cbxRepeat.Text = "Zapętlone";
            this.tlInfoTip.SetToolTip(this.cbxRepeat, "Zaznaczone powoduje, że cykl rozkazów wykonywany jest bez przerwy. Po wykonaniu o" +
        "statniej listy rozkazów znów następuje pierwsza lista rozkazów.");
            this.cbxRepeat.UseVisualStyleBackColor = true;
            this.cbxRepeat.CheckedChanged += new System.EventHandler(this.cbxRepeat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbDevice);
            this.groupBox1.Controls.Add(this.lbConfiguration);
            this.groupBox1.Controls.Add(this.lbUser);
            this.groupBox1.Controls.Add(this.lbDeviceStatus);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 96);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbCurrCmd);
            this.groupBox2.Controls.Add(this.lbCurrValueUnit);
            this.groupBox2.Controls.Add(this.lbCurrValueDev);
            this.groupBox2.Controls.Add(this.lbCurrError);
            this.groupBox2.Location = new System.Drawing.Point(303, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 96);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik ostatniego rozkazu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wartość:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rozkaz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Wartośc w jedn.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Błąd:";
            // 
            // lbCurrCmd
            // 
            this.lbCurrCmd.AutoSize = true;
            this.lbCurrCmd.Location = new System.Drawing.Point(117, 20);
            this.lbCurrCmd.Name = "lbCurrCmd";
            this.lbCurrCmd.Size = new System.Drawing.Size(34, 13);
            this.lbCurrCmd.TabIndex = 4;
            this.lbCurrCmd.Text = "(brak)";
            // 
            // lbCurrValueUnit
            // 
            this.lbCurrValueUnit.AutoSize = true;
            this.lbCurrValueUnit.Location = new System.Drawing.Point(117, 36);
            this.lbCurrValueUnit.Name = "lbCurrValueUnit";
            this.lbCurrValueUnit.Size = new System.Drawing.Size(34, 13);
            this.lbCurrValueUnit.TabIndex = 5;
            this.lbCurrValueUnit.Text = "(brak)";
            // 
            // lbCurrValueDev
            // 
            this.lbCurrValueDev.AutoSize = true;
            this.lbCurrValueDev.Location = new System.Drawing.Point(117, 52);
            this.lbCurrValueDev.Name = "lbCurrValueDev";
            this.lbCurrValueDev.Size = new System.Drawing.Size(34, 13);
            this.lbCurrValueDev.TabIndex = 6;
            this.lbCurrValueDev.Text = "(brak)";
            // 
            // lbCurrError
            // 
            this.lbCurrError.AutoSize = true;
            this.lbCurrError.Location = new System.Drawing.Point(117, 66);
            this.lbCurrError.Name = "lbCurrError";
            this.lbCurrError.Size = new System.Drawing.Size(34, 13);
            this.lbCurrError.TabIndex = 7;
            this.lbCurrError.Text = "(brak)";
            // 
            // MeasureStationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxRepeat);
            this.Controls.Add(this.tbxMeasurementDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxCycleDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnForceMeasurement);
            this.Controls.Add(this.btnStopCycle);
            this.Controls.Add(this.btnStartCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxCmdsList);
            this.Name = "MeasureStationControl";
            this.Size = new System.Drawing.Size(600, 435);
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDevice;
        private System.Windows.Forms.Label lbConfiguration;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDeviceStatus;
        private System.Windows.Forms.ListBox lbxCmdsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartCycle;
        private System.Windows.Forms.Button btnStopCycle;
        private System.Windows.Forms.Button btnForceMeasurement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbxCycleDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbxMeasurementDescription;
        private System.Windows.Forms.BindingSource bsCmdsList;
        private System.Windows.Forms.CheckBox cbxRepeat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCurrCmd;
        private System.Windows.Forms.Label lbCurrValueUnit;
        private System.Windows.Forms.Label lbCurrValueDev;
        private System.Windows.Forms.Label lbCurrError;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}
