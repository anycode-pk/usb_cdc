namespace WinClient.DevicesCfg
{
    partial class CmdListListForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCmdList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDelayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberInOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCmdList = new System.Windows.Forms.BindingSource(this.components);
            this.cmbConfigurations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(505, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zamknij";
            this.tlInfoTip.SetToolTip(this.btnClose, "Zamknij okno.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(175, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Usuń";
            this.tlInfoTip.SetToolTip(this.btnDelete, "Usuń zaznaczony element.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(94, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edytuj";
            this.tlInfoTip.SetToolTip(this.btnEdit, "Edytuj zaznaczony element.");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.tlInfoTip.SetToolTip(this.btnAdd, "Dodaj nowy element.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCmdList
            // 
            this.dgvCmdList.AllowUserToAddRows = false;
            this.dgvCmdList.AllowUserToDeleteRows = false;
            this.dgvCmdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCmdList.AutoGenerateColumns = false;
            this.dgvCmdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.postDelayDataGridViewTextBoxColumn,
            this.ConfDevice,
            this.numberInOrderDataGridViewTextBoxColumn});
            this.dgvCmdList.DataSource = this.bsCmdList;
            this.dgvCmdList.Location = new System.Drawing.Point(13, 12);
            this.dgvCmdList.Name = "dgvCmdList";
            this.dgvCmdList.ReadOnly = true;
            this.dgvCmdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdList.Size = new System.Drawing.Size(567, 319);
            this.dgvCmdList.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDelayDataGridViewTextBoxColumn
            // 
            this.postDelayDataGridViewTextBoxColumn.DataPropertyName = "PostDelay";
            this.postDelayDataGridViewTextBoxColumn.HeaderText = "Opóźnienie po wykonaniu";
            this.postDelayDataGridViewTextBoxColumn.Name = "postDelayDataGridViewTextBoxColumn";
            this.postDelayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConfDevice
            // 
            this.ConfDevice.DataPropertyName = "ConfDevice";
            this.ConfDevice.HeaderText = "Konfiguracja";
            this.ConfDevice.Name = "ConfDevice";
            this.ConfDevice.ReadOnly = true;
            // 
            // numberInOrderDataGridViewTextBoxColumn
            // 
            this.numberInOrderDataGridViewTextBoxColumn.DataPropertyName = "NumberInOrder";
            this.numberInOrderDataGridViewTextBoxColumn.HeaderText = "Kolejność";
            this.numberInOrderDataGridViewTextBoxColumn.Name = "numberInOrderDataGridViewTextBoxColumn";
            this.numberInOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsCmdList
            // 
            this.bsCmdList.DataSource = typeof(CommonModel.Entities.CmdList);
            // 
            // cmbConfigurations
            // 
            this.cmbConfigurations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbConfigurations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigurations.FormattingEnabled = true;
            this.cmbConfigurations.Location = new System.Drawing.Point(331, 338);
            this.cmbConfigurations.Name = "cmbConfigurations";
            this.cmbConfigurations.Size = new System.Drawing.Size(121, 21);
            this.cmbConfigurations.TabIndex = 10;
            this.cmbConfigurations.SelectedIndexChanged += new System.EventHandler(this.cmbConfigurations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Konfiguracja:";
            // 
            // CmdListListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbConfigurations);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCmdList);
            this.Name = "CmdListListForm";
            this.Text = "Lista list rozkazów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCmdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDelayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberInOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsCmdList;
        private System.Windows.Forms.ComboBox cmbConfigurations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}