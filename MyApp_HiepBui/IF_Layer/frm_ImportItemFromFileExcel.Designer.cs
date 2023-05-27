namespace MyApp_HiepBui.IF_Layer
{
    partial class frm_ImportExcelCustomer
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
            this.dgv_ImportCustomer = new System.Windows.Forms.DataGridView();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ImportExcelCustomer = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.txt_FileAdddress = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImportCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ImportCustomer
            // 
            this.dgv_ImportCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ImportCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ImportCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ImportCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgv_ImportCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ImportCustomer.Location = new System.Drawing.Point(30, 175);
            this.dgv_ImportCustomer.Name = "dgv_ImportCustomer";
            this.dgv_ImportCustomer.RowHeadersWidth = 51;
            this.dgv_ImportCustomer.RowTemplate.Height = 24;
            this.dgv_ImportCustomer.Size = new System.Drawing.Size(1076, 376);
            this.dgv_ImportCustomer.TabIndex = 1;
            // 
            // column2
            // 
            this.column2.HeaderText = "Name of Customer";
            this.column2.MinimumWidth = 6;
            this.column2.Name = "column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Opening Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Latest Transaction";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Accumulated Point";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btn_ImportExcelCustomer
            // 
            this.btn_ImportExcelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_ImportExcelCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_ImportExcelCustomer.Location = new System.Drawing.Point(746, 72);
            this.btn_ImportExcelCustomer.Name = "btn_ImportExcelCustomer";
            this.btn_ImportExcelCustomer.Size = new System.Drawing.Size(91, 41);
            this.btn_ImportExcelCustomer.TabIndex = 2;
            this.btn_ImportExcelCustomer.Text = "Browse";
            this.btn_ImportExcelCustomer.UseVisualStyleBackColor = false;
            this.btn_ImportExcelCustomer.Click += new System.EventHandler(this.btn_ImportExcelCustomer_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // txt_FileAdddress
            // 
            this.txt_FileAdddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FileAdddress.Location = new System.Drawing.Point(51, 81);
            this.txt_FileAdddress.Name = "txt_FileAdddress";
            this.txt_FileAdddress.Size = new System.Drawing.Size(631, 27);
            this.txt_FileAdddress.TabIndex = 3;
            this.txt_FileAdddress.TextChanged += new System.EventHandler(this.txt_FileAdddress_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(880, 72);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 41);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1127, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 601);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 571);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1127, 30);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 30);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 541);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1106, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 541);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(30, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1076, 20);
            this.panel5.TabIndex = 10;
            // 
            // frm_ImportExcelCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1157, 601);
            this.Controls.Add(this.dgv_ImportCustomer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_FileAdddress);
            this.Controls.Add(this.btn_ImportExcelCustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ImportExcelCustomer";
            this.Text = "frm_findCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImportCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ImportCustomer;
        private System.Windows.Forms.Button btn_ImportExcelCustomer;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.TextBox txt_FileAdddress;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}