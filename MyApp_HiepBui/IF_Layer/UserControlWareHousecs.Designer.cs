namespace MyApp_HiepBui.IF_Layer
{
    partial class UserControlWareHousecs
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
            this.btnCheckInven = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifyItem = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnDetails = new System.Windows.Forms.Panel();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtEXP = new System.Windows.Forms.TextBox();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.txtMFG = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProDate = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbTypeItem = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIDItem = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.pnDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckInven
            // 
            this.btnCheckInven.AutoSize = true;
            this.btnCheckInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnCheckInven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInven.ForeColor = System.Drawing.Color.White;
            this.btnCheckInven.Location = new System.Drawing.Point(28, 63);
            this.btnCheckInven.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckInven.Name = "btnCheckInven";
            this.btnCheckInven.Size = new System.Drawing.Size(143, 48);
            this.btnCheckInven.TabIndex = 0;
            this.btnCheckInven.Text = "Check inventory";
            this.btnCheckInven.UseVisualStyleBackColor = false;
            this.btnCheckInven.Click += new System.EventHandler(this.btnCheckInven_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvInfo.Location = new System.Drawing.Point(28, 139);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.RowTemplate.Height = 24;
            this.dgvInfo.Size = new System.Drawing.Size(707, 479);
            this.dgvInfo.TabIndex = 1;
            this.dgvInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdItem";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NameItem";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Type";
            this.Column4.HeaderText = "Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NumberOfItem";
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NameOfSupplier";
            this.Column6.HeaderText = "Supplier";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProductionDate";
            this.Column7.HeaderText = "Production Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ExpirationDate";
            this.Column8.HeaderText = "Expiration Date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnModifyItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyItem.ForeColor = System.Drawing.Color.White;
            this.btnModifyItem.Location = new System.Drawing.Point(336, 63);
            this.btnModifyItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.Size = new System.Drawing.Size(113, 48);
            this.btnModifyItem.TabIndex = 3;
            this.btnModifyItem.Text = "Modify item";
            this.btnModifyItem.UseVisualStyleBackColor = false;
            this.btnModifyItem.Click += new System.EventHandler(this.btnModifyItem_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(472, 63);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 48);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import goods";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(194, 62);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(119, 48);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pnDetails
            // 
            this.pnDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnDetails.Controls.Add(this.cbSupplier);
            this.pnDetails.Controls.Add(this.cbType);
            this.pnDetails.Controls.Add(this.txtEXP);
            this.pnDetails.Controls.Add(this.lbSupplier);
            this.pnDetails.Controls.Add(this.txtMFG);
            this.pnDetails.Controls.Add(this.txtQuantity);
            this.pnDetails.Controls.Add(this.txtPrice);
            this.pnDetails.Controls.Add(this.txtName);
            this.pnDetails.Controls.Add(this.txtID);
            this.pnDetails.Controls.Add(this.label2);
            this.pnDetails.Controls.Add(this.lbProDate);
            this.pnDetails.Controls.Add(this.lbQuantity);
            this.pnDetails.Controls.Add(this.lbTypeItem);
            this.pnDetails.Controls.Add(this.lbPrice);
            this.pnDetails.Controls.Add(this.lbName);
            this.pnDetails.Controls.Add(this.lbIDItem);
            this.pnDetails.Location = new System.Drawing.Point(770, 56);
            this.pnDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(411, 506);
            this.pnDetails.TabIndex = 6;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(122, 264);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(266, 28);
            this.cbSupplier.TabIndex = 16;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(89, 210);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(301, 28);
            this.cbType.TabIndex = 14;
            // 
            // txtEXP
            // 
            this.txtEXP.Location = new System.Drawing.Point(123, 443);
            this.txtEXP.Multiline = true;
            this.txtEXP.Name = "txtEXP";
            this.txtEXP.Size = new System.Drawing.Size(267, 36);
            this.txtEXP.TabIndex = 13;
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Location = new System.Drawing.Point(16, 267);
            this.lbSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(80, 20);
            this.lbSupplier.TabIndex = 15;
            this.lbSupplier.Text = "Supplier :";
            // 
            // txtMFG
            // 
            this.txtMFG.Location = new System.Drawing.Point(122, 385);
            this.txtMFG.Multiline = true;
            this.txtMFG.Name = "txtMFG";
            this.txtMFG.Size = new System.Drawing.Size(267, 36);
            this.txtMFG.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(122, 323);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(267, 36);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(89, 145);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(301, 36);
            this.txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 80);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 36);
            this.txtName.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 18);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(301, 36);
            this.txtID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "EXP Date :";
            // 
            // lbProDate
            // 
            this.lbProDate.AutoSize = true;
            this.lbProDate.Location = new System.Drawing.Point(12, 388);
            this.lbProDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProDate.Name = "lbProDate";
            this.lbProDate.Size = new System.Drawing.Size(97, 20);
            this.lbProDate.TabIndex = 5;
            this.lbProDate.Text = "MFG Date :";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(12, 326);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(81, 20);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Quantity :";
            // 
            // lbTypeItem
            // 
            this.lbTypeItem.AutoSize = true;
            this.lbTypeItem.Location = new System.Drawing.Point(13, 213);
            this.lbTypeItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTypeItem.Name = "lbTypeItem";
            this.lbTypeItem.Size = new System.Drawing.Size(55, 20);
            this.lbTypeItem.TabIndex = 3;
            this.lbTypeItem.Text = "Type :";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(13, 148);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 20);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 83);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name :";
            // 
            // lbIDItem
            // 
            this.lbIDItem.AutoSize = true;
            this.lbIDItem.Location = new System.Drawing.Point(13, 21);
            this.lbIDItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDItem.Name = "lbIDItem";
            this.lbIDItem.Size = new System.Drawing.Size(36, 20);
            this.lbIDItem.TabIndex = 0;
            this.lbIDItem.Text = "ID :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(786, 570);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1021, 570);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(615, 63);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(120, 48);
            this.btnStatistic.TabIndex = 9;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // UserControlWareHousecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.pnDetails);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnModifyItem);
            this.Controls.Add(this.btnCheckInven);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlWareHousecs";
            this.Size = new System.Drawing.Size(1209, 666);
            this.Load += new System.EventHandler(this.UserControlWareHousecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckInven;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnModifyItem;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbTypeItem;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIDItem;
        private System.Windows.Forms.TextBox txtEXP;
        private System.Windows.Forms.TextBox txtMFG;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnStatistic;
    }
}
