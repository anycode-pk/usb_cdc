namespace WinClient.LoadApp
{
    partial class LoginEntryControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.mtbxPassword = new System.Windows.Forms.MaskedTextBox();
            this.cmbSessionType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(47, 8);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(121, 20);
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetectEnter);
            // 
            // mtbxPassword
            // 
            this.mtbxPassword.Location = new System.Drawing.Point(47, 35);
            this.mtbxPassword.Name = "mtbxPassword";
            this.mtbxPassword.Size = new System.Drawing.Size(121, 20);
            this.mtbxPassword.TabIndex = 2;
            this.mtbxPassword.UseSystemPasswordChar = true;
            this.mtbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetectEnter);
            // 
            // cmbSessionType
            // 
            this.cmbSessionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSessionType.FormattingEnabled = true;
            this.cmbSessionType.Location = new System.Drawing.Point(47, 62);
            this.cmbSessionType.Name = "cmbSessionType";
            this.cmbSessionType.Size = new System.Drawing.Size(121, 21);
            this.cmbSessionType.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(47, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tryb:";
            // 
            // LoginEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbSessionType);
            this.Controls.Add(this.mtbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.label1);
            this.Name = "LoginEntryControl";
            this.Size = new System.Drawing.Size(288, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.MaskedTextBox mtbxPassword;
        private System.Windows.Forms.ComboBox cmbSessionType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
