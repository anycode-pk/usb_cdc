namespace WinClient.DevicesCfg
{
    partial class CmdArchetypeEditForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudReturnBytes = new System.Windows.Forms.NumericUpDown();
            this.bsCmdArchetype = new System.Windows.Forms.BindingSource(this.components);
            this.tbxHighRangeDev = new System.Windows.Forms.TextBox();
            this.tbxLowRangeDev = new System.Windows.Forms.TextBox();
            this.tbxHighRangeUnit = new System.Windows.Forms.TextBox();
            this.tbxLowRangeUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epValidateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnBytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdArchetype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Zapisz";
            this.tlInfoTip.SetToolTip(this.btnSave, "Zapisz zmiany.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "(ilość bajtów)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "( w logicznych jedn.)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "( w logicznych jedn.)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "(w jednostce)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "(w jednostce)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Zwracane dane:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Górny zakres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Dolny zakres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Górny zakres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Dolny zakres:";
            // 
            // nudReturnBytes
            // 
            this.nudReturnBytes.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCmdArchetype, "ReturnByte", true));
            this.nudReturnBytes.Location = new System.Drawing.Point(113, 249);
            this.nudReturnBytes.Name = "nudReturnBytes";
            this.nudReturnBytes.Size = new System.Drawing.Size(120, 20);
            this.nudReturnBytes.TabIndex = 29;
            this.tlInfoTip.SetToolTip(this.nudReturnBytes, "Ilość bajtów zwracanego wyniku.");
            // 
            // bsCmdArchetype
            // 
            this.bsCmdArchetype.DataSource = typeof(CommonModel.Entities.CmdArchetype);
            // 
            // tbxHighRangeDev
            // 
            this.tbxHighRangeDev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "HighRangeDev", true));
            this.tbxHighRangeDev.Location = new System.Drawing.Point(113, 222);
            this.tbxHighRangeDev.MaxLength = 50;
            this.tbxHighRangeDev.Name = "tbxHighRangeDev";
            this.tbxHighRangeDev.Size = new System.Drawing.Size(121, 20);
            this.tbxHighRangeDev.TabIndex = 28;
            this.tlInfoTip.SetToolTip(this.tbxHighRangeDev, "Górny zakres liczbowy wyniku rozkazu wyrażony w jednostkach urządzenia (zazwyczaj" +
        " wartość stałoprzecinkowa).");
            // 
            // tbxLowRangeDev
            // 
            this.tbxLowRangeDev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "LowRangeDev", true));
            this.tbxLowRangeDev.Location = new System.Drawing.Point(113, 196);
            this.tbxLowRangeDev.MaxLength = 50;
            this.tbxLowRangeDev.Name = "tbxLowRangeDev";
            this.tbxLowRangeDev.Size = new System.Drawing.Size(121, 20);
            this.tbxLowRangeDev.TabIndex = 27;
            this.tlInfoTip.SetToolTip(this.tbxLowRangeDev, "Dolny zakres liczbowy wyniku rozkazu wyrażony w jednostkach urządzenia (zazwyczaj" +
        " wartość stałoprzecinkowa).");
            // 
            // tbxHighRangeUnit
            // 
            this.tbxHighRangeUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "HighRangeUnit", true));
            this.tbxHighRangeUnit.Location = new System.Drawing.Point(113, 170);
            this.tbxHighRangeUnit.MaxLength = 50;
            this.tbxHighRangeUnit.Name = "tbxHighRangeUnit";
            this.tbxHighRangeUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxHighRangeUnit.TabIndex = 26;
            this.tlInfoTip.SetToolTip(this.tbxHighRangeUnit, "Górny zakres liczbowy wyniku rozkazu wyrażony w rzeczywistej jednostce.");
            // 
            // tbxLowRangeUnit
            // 
            this.tbxLowRangeUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "LowRangeUnit", true));
            this.tbxLowRangeUnit.Location = new System.Drawing.Point(113, 144);
            this.tbxLowRangeUnit.MaxLength = 50;
            this.tbxLowRangeUnit.Name = "tbxLowRangeUnit";
            this.tbxLowRangeUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxLowRangeUnit.TabIndex = 25;
            this.tlInfoTip.SetToolTip(this.tbxLowRangeUnit, "Dolny zakres liczbowy wyniku rozkazu wyrażony w rzeczywistej jednostce.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Wartość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Indeks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rozkaz:";
            // 
            // tbxValue
            // 
            this.tbxValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "Value", true));
            this.tbxValue.Location = new System.Drawing.Point(113, 118);
            this.tbxValue.MaxLength = 50;
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(121, 20);
            this.tbxValue.TabIndex = 19;
            this.tlInfoTip.SetToolTip(this.tbxValue, "Wartośc liczbowa parametru Value, 16 bitów dziesiętnie.");
            // 
            // tbxIndex
            // 
            this.tbxIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "Index", true));
            this.tbxIndex.Location = new System.Drawing.Point(113, 92);
            this.tbxIndex.MaxLength = 50;
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(121, 20);
            this.tbxIndex.TabIndex = 18;
            this.tlInfoTip.SetToolTip(this.tbxIndex, "Wartość liczbowa parametru Index, 16 bitów dziesiętnie.");
            // 
            // tbxCommand
            // 
            this.tbxCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "CommandValue", true));
            this.tbxCommand.Location = new System.Drawing.Point(113, 66);
            this.tbxCommand.MaxLength = 50;
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(121, 20);
            this.tbxCommand.TabIndex = 17;
            this.tlInfoTip.SetToolTip(this.tbxCommand, "Wartość liczbowa rozkazu, jeden bajt dziesiętnie.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Urządzenie:";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsCmdArchetype, "Device", true));
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(113, 38);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(121, 21);
            this.cmbDevice.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nazwa:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdArchetype, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(113, 12);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 13;
            this.tlInfoTip.SetToolTip(this.tbxName, "Nazwa wyświetlana w postaci tekstowej.");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Anuluj";
            this.tlInfoTip.SetToolTip(this.btnCancel, "Anuluj zmiany.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epValidateError
            // 
            this.epValidateError.ContainerControl = this;
            this.epValidateError.DataSource = this.bsCmdArchetype;
            // 
            // CmdArchetypeEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(349, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudReturnBytes);
            this.Controls.Add(this.tbxHighRangeDev);
            this.Controls.Add(this.tbxLowRangeDev);
            this.Controls.Add(this.tbxHighRangeUnit);
            this.Controls.Add(this.tbxLowRangeUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CmdArchetypeEditForm";
            this.Text = "Edycja pierwowzoru rozkazu";
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnBytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdArchetype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCmdArchetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxLowRangeUnit;
        private System.Windows.Forms.TextBox tbxHighRangeUnit;
        private System.Windows.Forms.TextBox tbxLowRangeDev;
        private System.Windows.Forms.TextBox tbxHighRangeDev;
        private System.Windows.Forms.NumericUpDown nudReturnBytes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epValidateError;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}