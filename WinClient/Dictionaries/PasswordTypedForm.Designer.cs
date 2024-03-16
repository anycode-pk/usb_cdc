namespace WinClient.Dictionaries
{
    partial class PasswordTypedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordTypedForm));
            this.label1 = new System.Windows.Forms.Label();
            this.mtbxPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtbxRetypedPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasło:";
            // 
            // mtbxPassword
            // 
            this.mtbxPassword.Location = new System.Drawing.Point(91, 13);
            this.mtbxPassword.Name = "mtbxPassword";
            this.mtbxPassword.Size = new System.Drawing.Size(183, 20);
            this.mtbxPassword.TabIndex = 1;
            this.tlInfoTip.SetToolTip(this.mtbxPassword, "Zamaskowany tekst hasła.");
            this.mtbxPassword.UseSystemPasswordChar = true;
            // 
            // mtbxRetypedPassword
            // 
            this.mtbxRetypedPassword.Location = new System.Drawing.Point(91, 39);
            this.mtbxRetypedPassword.Name = "mtbxRetypedPassword";
            this.mtbxRetypedPassword.Size = new System.Drawing.Size(183, 20);
            this.mtbxRetypedPassword.TabIndex = 3;
            this.tlInfoTip.SetToolTip(this.mtbxRetypedPassword, "Powtórzone hasło.");
            this.mtbxRetypedPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Powtórz hasło:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(117, 90);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.tlInfoTip.SetToolTip(this.btnOK, "Zapisz zmiany.");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.tlInfoTip.SetToolTip(this.btnCancel, "Anuluj zmiany.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PasswordTypedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 121);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.mtbxRetypedPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbxPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordTypedForm";
            this.Text = "Zmień hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbxPassword;
        private System.Windows.Forms.MaskedTextBox mtbxRetypedPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}