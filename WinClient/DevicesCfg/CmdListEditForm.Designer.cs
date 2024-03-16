namespace WinClient.DevicesCfg
{
    partial class CmdListEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.bsCmdList = new System.Windows.Forms.BindingSource(this.components);
            this.cmbConfiguration = new System.Windows.Forms.ComboBox();
            this.tbxDelayTime = new System.Windows.Forms.TextBox();
            this.nudNoInOrder = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDelayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noInOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCommands = new System.Windows.Forms.BindingSource(this.components);
            this.epValidateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlInfoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoInOrder)).BeginInit();
            this.gbCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nazwa:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdList, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(105, 12);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 15;
            this.tlInfoTip.SetToolTip(this.tbxName, "Nazwa wyświetlana w postaci tekstowej.");
            // 
            // bsCmdList
            // 
            this.bsCmdList.DataSource = typeof(CommonModel.Entities.CmdList);
            // 
            // cmbConfiguration
            // 
            this.cmbConfiguration.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsCmdList, "ConfDevice", true));
            this.cmbConfiguration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfiguration.FormattingEnabled = true;
            this.cmbConfiguration.Location = new System.Drawing.Point(105, 38);
            this.cmbConfiguration.Name = "cmbConfiguration";
            this.cmbConfiguration.Size = new System.Drawing.Size(121, 21);
            this.cmbConfiguration.TabIndex = 17;
            // 
            // tbxDelayTime
            // 
            this.tbxDelayTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCmdList, "PostDelay", true));
            this.tbxDelayTime.Location = new System.Drawing.Point(105, 65);
            this.tbxDelayTime.MaxLength = 50;
            this.tbxDelayTime.Name = "tbxDelayTime";
            this.tbxDelayTime.Size = new System.Drawing.Size(121, 20);
            this.tbxDelayTime.TabIndex = 18;
            this.tbxDelayTime.Text = "0";
            this.tlInfoTip.SetToolTip(this.tbxDelayTime, "Wartość liczbowa określająca czas zatrzymania całego procesu po wykonaniu tej lis" +
        "ty rozkazów.");
            // 
            // nudNoInOrder
            // 
            this.nudNoInOrder.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCmdList, "NumberInOrder", true));
            this.nudNoInOrder.Location = new System.Drawing.Point(105, 91);
            this.nudNoInOrder.Name = "nudNoInOrder";
            this.nudNoInOrder.Size = new System.Drawing.Size(120, 20);
            this.nudNoInOrder.TabIndex = 19;
            this.tlInfoTip.SetToolTip(this.nudNoInOrder, "Kolejność tej listy rozkazów względem innych, sortowane rosnąco.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Konfiguracja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Czas opóźnienia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kolejność:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "[ms]";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(661, 238);
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(580, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Zapisz";
            this.tlInfoTip.SetToolTip(this.btnSave, "Zapisz zmiany.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCommands
            // 
            this.gbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCommands.Controls.Add(this.btnEdit);
            this.gbCommands.Controls.Add(this.btnDelete);
            this.gbCommands.Controls.Add(this.btnAdd);
            this.gbCommands.Controls.Add(this.dataGridView1);
            this.gbCommands.Location = new System.Drawing.Point(265, 12);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(471, 220);
            this.gbCommands.TabIndex = 45;
            this.gbCommands.TabStop = false;
            this.gbCommands.Text = "Rozkazy w tej liście rozkazów";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(88, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edytuj";
            this.tlInfoTip.SetToolTip(this.btnEdit, "Edytuj zaznaczony element.");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(169, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Usuń";
            this.tlInfoTip.SetToolTip(this.btnDelete, "Usuń zaznaczony element.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(7, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Dodaj";
            this.tlInfoTip.SetToolTip(this.btnAdd, "Dodaj nowy element.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.commandValueDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.postDelayDataGridViewTextBoxColumn,
            this.noInOrderDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsCommands;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(458, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandValueDataGridViewTextBoxColumn
            // 
            this.commandValueDataGridViewTextBoxColumn.DataPropertyName = "CommandValue";
            this.commandValueDataGridViewTextBoxColumn.HeaderText = "Rozkaz";
            this.commandValueDataGridViewTextBoxColumn.Name = "commandValueDataGridViewTextBoxColumn";
            this.commandValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Indeks";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDelayDataGridViewTextBoxColumn
            // 
            this.postDelayDataGridViewTextBoxColumn.DataPropertyName = "PostDelay";
            this.postDelayDataGridViewTextBoxColumn.HeaderText = "Czas opóźnienia";
            this.postDelayDataGridViewTextBoxColumn.Name = "postDelayDataGridViewTextBoxColumn";
            this.postDelayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noInOrderDataGridViewTextBoxColumn
            // 
            this.noInOrderDataGridViewTextBoxColumn.DataPropertyName = "NoInOrder";
            this.noInOrderDataGridViewTextBoxColumn.HeaderText = "Kolejność";
            this.noInOrderDataGridViewTextBoxColumn.Name = "noInOrderDataGridViewTextBoxColumn";
            this.noInOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsCommands
            // 
            this.bsCommands.DataSource = typeof(CommonModel.Entities.Command);
            // 
            // epValidateError
            // 
            this.epValidateError.ContainerControl = this;
            this.epValidateError.DataSource = this.bsCmdList;
            // 
            // CmdListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 273);
            this.Controls.Add(this.gbCommands);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNoInOrder);
            this.Controls.Add(this.tbxDelayTime);
            this.Controls.Add(this.cmbConfiguration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Name = "CmdListEditForm";
            this.Text = "Lista rozkazów";
            this.Load += new System.EventHandler(this.CmdListEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCmdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoInOrder)).EndInit();
            this.gbCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.BindingSource bsCmdList;
        private System.Windows.Forms.ComboBox cmbConfiguration;
        private System.Windows.Forms.TextBox tbxDelayTime;
        private System.Windows.Forms.NumericUpDown nudNoInOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDelayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noInOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsCommands;
        private System.Windows.Forms.ErrorProvider epValidateError;
        private System.Windows.Forms.ToolTip tlInfoTip;
    }
}