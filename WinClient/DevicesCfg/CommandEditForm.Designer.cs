namespace WinClient.DevicesCfg
{
    partial class CommandEditForm
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
            this.btnCopyArchetype = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbAchetype = new System.Windows.Forms.ComboBox();
            this.bsCommand = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDelayTime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudNoInOrder = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.epValidateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnBytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopyArchetype
            // 
            this.btnCopyArchetype.Location = new System.Drawing.Point(237, 9);
            this.btnCopyArchetype.Name = "btnCopyArchetype";
            this.btnCopyArchetype.Size = new System.Drawing.Size(75, 23);
            this.btnCopyArchetype.TabIndex = 75;
            this.btnCopyArchetype.Text = "Skopiuj";
            this.tlInfoTip.SetToolTip(this.btnCopyArchetype, "Skopiuj wartości z wybranego pierwowzoru rozkazu do aktualnego rozkazu.");
            this.btnCopyArchetype.UseVisualStyleBackColor = true;
            this.btnCopyArchetype.Click += new System.EventHandler(this.btnCopyArchetype_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Pierwowzór:";
            // 
            // cmbAchetype
            // 
            this.cmbAchetype.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsCommand, "CmdArchetype", true));
            this.cmbAchetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAchetype.FormattingEnabled = true;
            this.cmbAchetype.Location = new System.Drawing.Point(109, 12);
            this.cmbAchetype.Name = "cmbAchetype";
            this.cmbAchetype.Size = new System.Drawing.Size(121, 21);
            this.cmbAchetype.TabIndex = 73;
            // 
            // bsCommand
            // 
            this.bsCommand.DataSource = typeof(CommonModel.Entities.Command);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(268, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Anuluj";
            this.tlInfoTip.SetToolTip(this.btnCancel, "Anuluj zmiany.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Zapisz";
            this.tlInfoTip.SetToolTip(this.btnSave, "Zapisz zmiany.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(236, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "(ilość bajtów)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(236, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "( w logicznych jedn.)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(236, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "( w logicznych jedn.)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "(w jednostce)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "(w jednostce)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Zwracane dane:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Górny zakres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Dolny zakres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Górny zakres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Dolny zakres:";
            // 
            // nudReturnBytes
            // 
            this.nudReturnBytes.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCommand, "ReturnByte", true));
            this.nudReturnBytes.Location = new System.Drawing.Point(109, 302);
            this.nudReturnBytes.Name = "nudReturnBytes";
            this.nudReturnBytes.Size = new System.Drawing.Size(120, 20);
            this.nudReturnBytes.TabIndex = 59;
            this.tlInfoTip.SetToolTip(this.nudReturnBytes, "Ilość bajtów zwracanego wyniku.");
            // 
            // tbxHighRangeDev
            // 
            this.tbxHighRangeDev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "HighRangeDev", true));
            this.tbxHighRangeDev.Location = new System.Drawing.Point(109, 275);
            this.tbxHighRangeDev.MaxLength = 50;
            this.tbxHighRangeDev.Name = "tbxHighRangeDev";
            this.tbxHighRangeDev.Size = new System.Drawing.Size(121, 20);
            this.tbxHighRangeDev.TabIndex = 58;
            this.tlInfoTip.SetToolTip(this.tbxHighRangeDev, "Górny zakres liczbowy wyniku rozkazu wyrażony w jednostkach urządzenia (zazwyczaj" +
        " wartość stałoprzecinkowa).");
            // 
            // tbxLowRangeDev
            // 
            this.tbxLowRangeDev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "LowRangeDev", true));
            this.tbxLowRangeDev.Location = new System.Drawing.Point(109, 249);
            this.tbxLowRangeDev.MaxLength = 50;
            this.tbxLowRangeDev.Name = "tbxLowRangeDev";
            this.tbxLowRangeDev.Size = new System.Drawing.Size(121, 20);
            this.tbxLowRangeDev.TabIndex = 57;
            this.tlInfoTip.SetToolTip(this.tbxLowRangeDev, "Dolny zakres liczbowy wyniku rozkazu wyrażony w jednostkach urządzenia (zazwyczaj" +
        " wartość stałoprzecinkowa).");
            // 
            // tbxHighRangeUnit
            // 
            this.tbxHighRangeUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "HighRagneUnit", true));
            this.tbxHighRangeUnit.Location = new System.Drawing.Point(109, 223);
            this.tbxHighRangeUnit.MaxLength = 50;
            this.tbxHighRangeUnit.Name = "tbxHighRangeUnit";
            this.tbxHighRangeUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxHighRangeUnit.TabIndex = 56;
            this.tlInfoTip.SetToolTip(this.tbxHighRangeUnit, "Górny zakres liczbowy wyniku rozkazu wyrażony w rzeczywistej jednostce.");
            // 
            // tbxLowRangeUnit
            // 
            this.tbxLowRangeUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "LowRangeUnit", true));
            this.tbxLowRangeUnit.Location = new System.Drawing.Point(109, 197);
            this.tbxLowRangeUnit.MaxLength = 50;
            this.tbxLowRangeUnit.Name = "tbxLowRangeUnit";
            this.tbxLowRangeUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxLowRangeUnit.TabIndex = 55;
            this.tlInfoTip.SetToolTip(this.tbxLowRangeUnit, "Dolny zakres liczbowy wyniku rozkazu wyrażony w rzeczywistej jednostce.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Wartość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Indeks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Rozkaz:";
            // 
            // tbxValue
            // 
            this.tbxValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "Value", true));
            this.tbxValue.Location = new System.Drawing.Point(109, 145);
            this.tbxValue.MaxLength = 50;
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(121, 20);
            this.tbxValue.TabIndex = 49;
            this.tlInfoTip.SetToolTip(this.tbxValue, "Wartośc liczbowa parametru Value, 16 bitów dziesiętnie.");
            // 
            // tbxIndex
            // 
            this.tbxIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "Index", true));
            this.tbxIndex.Location = new System.Drawing.Point(109, 119);
            this.tbxIndex.MaxLength = 50;
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(121, 20);
            this.tbxIndex.TabIndex = 48;
            this.tlInfoTip.SetToolTip(this.tbxIndex, "Wartość liczbowa parametru Index, 16 bitów dziesiętnie.");
            // 
            // tbxCommand
            // 
            this.tbxCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "CommandValue", true));
            this.tbxCommand.Location = new System.Drawing.Point(109, 93);
            this.tbxCommand.MaxLength = 50;
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(121, 20);
            this.tbxCommand.TabIndex = 47;
            this.tlInfoTip.SetToolTip(this.tbxCommand, "Wartość liczbowa rozkazu, jeden bajt dziesiętnie.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Jednostka:";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsCommand, "Unit", true));
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(109, 65);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nazwa:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(109, 39);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 43;
            this.tlInfoTip.SetToolTip(this.tbxName, "Nazwa wyświetlana w postaci tekstowej.");
            // 
            // tbxDelayTime
            // 
            this.tbxDelayTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommand, "PostDelay", true));
            this.tbxDelayTime.Location = new System.Drawing.Point(109, 171);
            this.tbxDelayTime.MaxLength = 50;
            this.tbxDelayTime.Name = "tbxDelayTime";
            this.tbxDelayTime.Size = new System.Drawing.Size(121, 20);
            this.tbxDelayTime.TabIndex = 50;
            this.tlInfoTip.SetToolTip(this.tbxDelayTime, "Wartość liczbowa określająca czas zatrzymania całego procesu po wykonaniu tego ro" +
        "zkazu.");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Czas opóźnienia:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(236, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "[ms]";
            // 
            // nudNoInOrder
            // 
            this.nudNoInOrder.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCommand, "NoInOrder", true));
            this.nudNoInOrder.Location = new System.Drawing.Point(109, 328);
            this.nudNoInOrder.Name = "nudNoInOrder";
            this.nudNoInOrder.Size = new System.Drawing.Size(120, 20);
            this.nudNoInOrder.TabIndex = 59;
            this.tlInfoTip.SetToolTip(this.nudNoInOrder, "Kolejność tego rozkazu względem innych, sortowane rosnąco.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(47, 335);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 64;
            this.label21.Text = "Kolejność:";
            // 
            // epValidateError
            // 
            this.epValidateError.ContainerControl = this;
            this.epValidateError.DataSource = this.bsCommand;
            // 
            // CommandEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 397);
            this.Controls.Add(this.btnCopyArchetype);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbAchetype);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudNoInOrder);
            this.Controls.Add(this.nudReturnBytes);
            this.Controls.Add(this.tbxHighRangeDev);
            this.Controls.Add(this.tbxLowRangeDev);
            this.Controls.Add(this.tbxHighRangeUnit);
            this.Controls.Add(this.tbxLowRangeUnit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDelayTime);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Name = "CommandEditForm";
            this.Text = "Edycja rozkazu";
            ((System.ComponentModel.ISupportInitialize)(this.bsCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnBytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudReturnBytes;
        private System.Windows.Forms.TextBox tbxHighRangeDev;
        private System.Windows.Forms.TextBox tbxLowRangeDev;
        private System.Windows.Forms.TextBox tbxHighRangeUnit;
        private System.Windows.Forms.TextBox tbxLowRangeUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ComboBox cmbAchetype;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCopyArchetype;
        private System.Windows.Forms.BindingSource bsCommand;
        private System.Windows.Forms.TextBox tbxDelayTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudNoInOrder;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ErrorProvider epValidateError;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}