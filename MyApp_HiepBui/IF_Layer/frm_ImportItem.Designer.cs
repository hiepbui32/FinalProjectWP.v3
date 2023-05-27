namespace MyApp_HiepBui.IF_Layer
{
    partial class frm_ImportItem
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearDataInDGV = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.dtpMFGDate = new System.Windows.Forms.DateTimePicker();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnGoToDGV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImportNew = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(927, 14);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 39);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import file";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1074, 14);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 39);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export file";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.DarkGray;
            this.txtContent.Location = new System.Drawing.Point(13, 13);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(418, 39);
            this.txtContent.TabIndex = 5;
            this.txtContent.Text = "Input something";
            this.txtContent.Click += new System.EventHandler(this.txtContent_Click);
            this.txtContent.Enter += new System.EventHandler(this.txtContent_Enter);
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.cbCategories);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 64);
            this.panel1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(780, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 39);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(633, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.ForeColor = System.Drawing.Color.DarkGray;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "ID Item",
            "Name",
            "Type",
            "Supplier"});
            this.cbCategories.Location = new System.Drawing.Point(437, 16);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(169, 33);
            this.cbCategories.TabIndex = 7;
            this.cbCategories.Text = "Categories";
            this.cbCategories.Click += new System.EventHandler(this.cbCategories_Click);
            this.cbCategories.Leave += new System.EventHandler(this.cbCategories_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 642);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvDetails);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 642);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnClearDataInDGV);
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.lbQuantity);
            this.panel4.Controls.Add(this.dtpMFGDate);
            this.panel4.Controls.Add(this.cbSupplier);
            this.panel4.Controls.Add(this.cbType);
            this.panel4.Controls.Add(this.btnGoToDGV);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.lbPrice);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnImportNew);
            this.panel4.Location = new System.Drawing.Point(774, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 613);
            this.panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(273, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 38);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearDataInDGV
            // 
            this.btnClearDataInDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnClearDataInDGV.ForeColor = System.Drawing.Color.White;
            this.btnClearDataInDGV.Location = new System.Drawing.Point(165, 483);
            this.btnClearDataInDGV.Name = "btnClearDataInDGV";
            this.btnClearDataInDGV.Size = new System.Drawing.Size(131, 48);
            this.btnClearDataInDGV.TabIndex = 18;
            this.btnClearDataInDGV.Text = "Clear all data";
            this.btnClearDataInDGV.UseVisualStyleBackColor = false;
            this.btnClearDataInDGV.Click += new System.EventHandler(this.btnClearDataInDGV_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(124, 363);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(280, 27);
            this.txtQuantity.TabIndex = 17;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.ForeColor = System.Drawing.Color.Black;
            this.lbQuantity.Location = new System.Drawing.Point(25, 366);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(81, 20);
            this.lbQuantity.TabIndex = 16;
            this.lbQuantity.Text = "Quantity :";
            // 
            // dtpMFGDate
            // 
            this.dtpMFGDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMFGDate.Location = new System.Drawing.Point(124, 191);
            this.dtpMFGDate.Name = "dtpMFGDate";
            this.dtpMFGDate.Size = new System.Drawing.Size(280, 27);
            this.dtpMFGDate.TabIndex = 15;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(124, 308);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(280, 28);
            this.cbSupplier.TabIndex = 14;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(124, 248);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(280, 28);
            this.cbType.TabIndex = 13;
            // 
            // btnGoToDGV
            // 
            this.btnGoToDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnGoToDGV.ForeColor = System.Drawing.Color.White;
            this.btnGoToDGV.Location = new System.Drawing.Point(90, 416);
            this.btnGoToDGV.Name = "btnGoToDGV";
            this.btnGoToDGV.Size = new System.Drawing.Size(96, 38);
            this.btnGoToDGV.TabIndex = 12;
            this.btnGoToDGV.Text = "<==";
            this.btnGoToDGV.UseVisualStyleBackColor = false;
            this.btnGoToDGV.Click += new System.EventHandler(this.btnGoToDGV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Supplier :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MFG date :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(124, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(280, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(25, 135);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 27);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(25, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(239, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImportNew
            // 
            this.btnImportNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnImportNew.ForeColor = System.Drawing.Color.White;
            this.btnImportNew.Location = new System.Drawing.Point(56, 15);
            this.btnImportNew.Name = "btnImportNew";
            this.btnImportNew.Size = new System.Drawing.Size(130, 37);
            this.btnImportNew.TabIndex = 0;
            this.btnImportNew.Text = "Import new";
            this.btnImportNew.UseVisualStyleBackColor = false;
            this.btnImportNew.Click += new System.EventHandler(this.btnImportNew_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(13, 17);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(739, 613);
            this.dgvDetails.TabIndex = 0;
            // 
            // frm_ImportItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ImportItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ImportItem";
            this.Load += new System.EventHandler(this.frm_ImportItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetails;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImportNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGoToDGV;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtpMFGDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button btnClearDataInDGV;
        private System.Windows.Forms.Button btnClear;
    }
}