namespace WinClient.Dictionaries
{
    partial class UnitEditForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.bsUnit = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbxShortcut = new System.Windows.Forms.TextBox();
            this.epValidateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(107, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Anuluj";
            this.tlInfoTip.SetToolTip(this.btnCancel, "Anuluj zmiany.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.tlInfoTip.SetToolTip(this.btnSave, "Zapisz zmiany.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nazwa:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUnit, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(61, 12);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 1;
            this.tlInfoTip.SetToolTip(this.tbxName, "Pełna nazwa w postaci tekstowej.");
            // 
            // bsUnit
            // 
            this.bsUnit.DataSource = typeof(CommonModel.Entities.Unit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Skrót:";
            // 
            // tbxShortcut
            // 
            this.tbxShortcut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUnit, "ShortCut", true));
            this.tbxShortcut.Location = new System.Drawing.Point(61, 38);
            this.tbxShortcut.MaxLength = 10;
            this.tbxShortcut.Name = "tbxShortcut";
            this.tbxShortcut.Size = new System.Drawing.Size(121, 20);
            this.tbxShortcut.TabIndex = 2;
            this.tlInfoTip.SetToolTip(this.tbxShortcut, "Skrót nazwy (przyrostek) w postaci tekstowej.");
            // 
            // epValidateError
            // 
            this.epValidateError.ContainerControl = this;
            this.epValidateError.DataSource = this.bsUnit;
            // 
            // UnitEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(199, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxShortcut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitEditForm";
            this.Text = "Edycja jednostki";
            ((System.ComponentModel.ISupportInitialize)(this.bsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxShortcut;
        private System.Windows.Forms.BindingSource bsUnit;
        private System.Windows.Forms.ErrorProvider epValidateError;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}