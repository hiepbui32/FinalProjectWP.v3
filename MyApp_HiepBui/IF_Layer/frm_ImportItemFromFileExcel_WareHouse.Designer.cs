namespace MyApp_HiepBui.IF_Layer
{
    partial class frm_ImportItemFromFileExcel_WareHouse
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
            this.lbFilename = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.dgvDataExcel = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFilename
            // 
            this.lbFilename.AutoSize = true;
            this.lbFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilename.Location = new System.Drawing.Point(13, 25);
            this.lbFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(92, 20);
            this.lbFilename.TabIndex = 0;
            this.lbFilename.Text = "File name :";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(124, 19);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(319, 33);
            this.txtSource.TabIndex = 1;
            // 
            // btnImportFile
            // 
            this.btnImportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnImportFile.ForeColor = System.Drawing.Color.White;
            this.btnImportFile.Location = new System.Drawing.Point(449, 19);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(114, 33);
            this.btnImportFile.TabIndex = 2;
            this.btnImportFile.Text = "Import file";
            this.btnImportFile.UseVisualStyleBackColor = false;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // dgvDataExcel
            // 
            this.dgvDataExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDataExcel.Location = new System.Drawing.Point(12, 70);
            this.dgvDataExcel.Name = "dgvDataExcel";
            this.dgvDataExcel.RowHeadersWidth = 51;
            this.dgvDataExcel.RowTemplate.Height = 24;
            this.dgvDataExcel.Size = new System.Drawing.Size(666, 424);
            this.dgvDataExcel.TabIndex = 3;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "No";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quantity";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Productation Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Supplier";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(569, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frm_ImportItemFromFileExcel_WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(690, 506);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDataExcel);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lbFilename);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ImportItemFromFileExcel_WareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ImportItemFromFileExcel";
            this.Load += new System.EventHandler(this.frm_ImportItemFromFileExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.DataGridView dgvDataExcel;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}