namespace MyApp_HiepBui.IF_Layer
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.pn_CustomerFunction = new System.Windows.Forms.Panel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.btn_modifyCustomer = new System.Windows.Forms.Button();
            this.bnt_Export = new System.Windows.Forms.Button();
            this.btn_delCustomer = new System.Windows.Forms.Button();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SaveCustomer = new System.Windows.Forms.Button();
            this.txt_AccumulatedPoint = new System.Windows.Forms.TextBox();
            this.lb_AccumulatePoint = new System.Windows.Forms.Label();
            this.dpk_LatestTransaction = new System.Windows.Forms.DateTimePicker();
            this.lb_Latesttransaction = new System.Windows.Forms.Label();
            this.lb_Openingdate = new System.Windows.Forms.Label();
            this.dpk_Oppeningdate = new System.Windows.Forms.DateTimePicker();
            this.lb_NameofCusomer = new System.Windows.Forms.Label();
            this.txt_Name_of_Customer = new System.Windows.Forms.TextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.cln_TypeofCus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Accumulated_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_LatestTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_OpeningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_Name_of_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.frm_CustomerChart1 = new MyApp_HiepBui.IF_Layer.frm_CustomerChart();
            this.pn_CustomerFunction.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_CustomerFunction
            // 
            this.pn_CustomerFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.pn_CustomerFunction.Controls.Add(this.btn_Import);
            this.pn_CustomerFunction.Controls.Add(this.btn_Search);
            this.pn_CustomerFunction.Controls.Add(this.btn_Chart);
            this.pn_CustomerFunction.Controls.Add(this.btn_modifyCustomer);
            this.pn_CustomerFunction.Controls.Add(this.bnt_Export);
            this.pn_CustomerFunction.Controls.Add(this.btn_delCustomer);
            this.pn_CustomerFunction.Controls.Add(this.btn_addCustomer);
            this.pn_CustomerFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_CustomerFunction.Location = new System.Drawing.Point(0, 0);
            this.pn_CustomerFunction.Margin = new System.Windows.Forms.Padding(4);
            this.pn_CustomerFunction.Name = "pn_CustomerFunction";
            this.pn_CustomerFunction.Size = new System.Drawing.Size(1498, 118);
            this.pn_CustomerFunction.TabIndex = 1;
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Import.BackgroundImage")));
            this.btn_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Import.FlatAppearance.BorderSize = 2;
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Import.Location = new System.Drawing.Point(749, 11);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(109, 89);
            this.btn_Import.TabIndex = 6;
            this.btn_Import.Text = "&Import";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(60, 11);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(109, 89);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "&Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Chart
            // 
            this.btn_Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Chart.BackgroundImage")));
            this.btn_Chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Chart.ForeColor = System.Drawing.Color.White;
            this.btn_Chart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Chart.Location = new System.Drawing.Point(519, 11);
            this.btn_Chart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(109, 89);
            this.btn_Chart.TabIndex = 4;
            this.btn_Chart.Text = "&Chart";
            this.btn_Chart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Chart.UseVisualStyleBackColor = false;
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // btn_modifyCustomer
            // 
            this.btn_modifyCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_modifyCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modifyCustomer.BackgroundImage")));
            this.btn_modifyCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modifyCustomer.FlatAppearance.BorderSize = 0;
            this.btn_modifyCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_modifyCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_modifyCustomer.Location = new System.Drawing.Point(404, 11);
            this.btn_modifyCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifyCustomer.Name = "btn_modifyCustomer";
            this.btn_modifyCustomer.Size = new System.Drawing.Size(109, 89);
            this.btn_modifyCustomer.TabIndex = 3;
            this.btn_modifyCustomer.Text = "&Modify";
            this.btn_modifyCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modifyCustomer.UseVisualStyleBackColor = false;
            this.btn_modifyCustomer.Click += new System.EventHandler(this.btn_modifyCustomer_Click);
            // 
            // bnt_Export
            // 
            this.bnt_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.bnt_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_Export.BackgroundImage")));
            this.bnt_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_Export.FlatAppearance.BorderSize = 2;
            this.bnt_Export.ForeColor = System.Drawing.Color.White;
            this.bnt_Export.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnt_Export.Location = new System.Drawing.Point(633, 11);
            this.bnt_Export.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_Export.Name = "bnt_Export";
            this.bnt_Export.Size = new System.Drawing.Size(109, 89);
            this.bnt_Export.TabIndex = 2;
            this.bnt_Export.Text = "&Export ";
            this.bnt_Export.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_Export.UseVisualStyleBackColor = false;
            this.bnt_Export.Click += new System.EventHandler(this.bnt_Export_Click);
            // 
            // btn_delCustomer
            // 
            this.btn_delCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_delCustomer.FlatAppearance.BorderSize = 0;
            this.btn_delCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_delCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_delCustomer.Image")));
            this.btn_delCustomer.Location = new System.Drawing.Point(289, 11);
            this.btn_delCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delCustomer.Name = "btn_delCustomer";
            this.btn_delCustomer.Size = new System.Drawing.Size(109, 89);
            this.btn_delCustomer.TabIndex = 1;
            this.btn_delCustomer.Text = "&Delete";
            this.btn_delCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delCustomer.UseVisualStyleBackColor = false;
            this.btn_delCustomer.Click += new System.EventHandler(this.btn_delCustomer_Click);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_addCustomer.FlatAppearance.BorderSize = 0;
            this.btn_addCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_addCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCustomer.Image")));
            this.btn_addCustomer.Location = new System.Drawing.Point(175, 11);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(109, 89);
            this.btn_addCustomer.TabIndex = 0;
            this.btn_addCustomer.Text = "&Add";
            this.btn_addCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addCustomer.UseVisualStyleBackColor = false;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 764);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1438, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 764);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.txt_Phone);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_SaveCustomer);
            this.panel3.Controls.Add(this.txt_AccumulatedPoint);
            this.panel3.Controls.Add(this.lb_AccumulatePoint);
            this.panel3.Controls.Add(this.dpk_LatestTransaction);
            this.panel3.Controls.Add(this.lb_Latesttransaction);
            this.panel3.Controls.Add(this.lb_Openingdate);
            this.panel3.Controls.Add(this.dpk_Oppeningdate);
            this.panel3.Controls.Add(this.lb_NameofCusomer);
            this.panel3.Controls.Add(this.txt_Name_of_Customer);
            this.panel3.Controls.Add(this.lb_Phone);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(60, 633);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 249);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(93, 70);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(212, 24);
            this.txt_Phone.TabIndex = 0;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            this.txt_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Phone_KeyDown_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(973, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SaveCustomer
            // 
            this.btn_SaveCustomer.Location = new System.Drawing.Point(811, 130);
            this.btn_SaveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaveCustomer.Name = "btn_SaveCustomer";
            this.btn_SaveCustomer.Size = new System.Drawing.Size(141, 49);
            this.btn_SaveCustomer.TabIndex = 5;
            this.btn_SaveCustomer.Text = "Save";
            this.btn_SaveCustomer.UseVisualStyleBackColor = true;
            this.btn_SaveCustomer.Click += new System.EventHandler(this.btn_SaveCustomer_Click);
            // 
            // txt_AccumulatedPoint
            // 
            this.txt_AccumulatedPoint.Location = new System.Drawing.Point(947, 65);
            this.txt_AccumulatedPoint.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AccumulatedPoint.Name = "txt_AccumulatedPoint";
            this.txt_AccumulatedPoint.Size = new System.Drawing.Size(212, 24);
            this.txt_AccumulatedPoint.TabIndex = 4;
            this.txt_AccumulatedPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AccumulatedPoint_KeyDown);
            // 
            // lb_AccumulatePoint
            // 
            this.lb_AccumulatePoint.AutoSize = true;
            this.lb_AccumulatePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccumulatePoint.Location = new System.Drawing.Point(807, 68);
            this.lb_AccumulatePoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AccumulatePoint.Name = "lb_AccumulatePoint";
            this.lb_AccumulatePoint.Size = new System.Drawing.Size(131, 18);
            this.lb_AccumulatePoint.TabIndex = 8;
            this.lb_AccumulatePoint.Text = "Accumulate Point: ";
            // 
            // dpk_LatestTransaction
            // 
            this.dpk_LatestTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_LatestTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_LatestTransaction.Location = new System.Drawing.Point(512, 153);
            this.dpk_LatestTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.dpk_LatestTransaction.Name = "dpk_LatestTransaction";
            this.dpk_LatestTransaction.Size = new System.Drawing.Size(229, 24);
            this.dpk_LatestTransaction.TabIndex = 3;
            // 
            // lb_Latesttransaction
            // 
            this.lb_Latesttransaction.AutoSize = true;
            this.lb_Latesttransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Latesttransaction.Location = new System.Drawing.Point(359, 156);
            this.lb_Latesttransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Latesttransaction.Name = "lb_Latesttransaction";
            this.lb_Latesttransaction.Size = new System.Drawing.Size(133, 18);
            this.lb_Latesttransaction.TabIndex = 6;
            this.lb_Latesttransaction.Text = "Latest transaction: ";
            // 
            // lb_Openingdate
            // 
            this.lb_Openingdate.AutoSize = true;
            this.lb_Openingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Openingdate.Location = new System.Drawing.Point(359, 68);
            this.lb_Openingdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Openingdate.Name = "lb_Openingdate";
            this.lb_Openingdate.Size = new System.Drawing.Size(106, 18);
            this.lb_Openingdate.TabIndex = 5;
            this.lb_Openingdate.Text = "Opening Date: ";
            // 
            // dpk_Oppeningdate
            // 
            this.dpk_Oppeningdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_Oppeningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_Oppeningdate.Location = new System.Drawing.Point(512, 68);
            this.dpk_Oppeningdate.Margin = new System.Windows.Forms.Padding(4);
            this.dpk_Oppeningdate.Name = "dpk_Oppeningdate";
            this.dpk_Oppeningdate.Size = new System.Drawing.Size(229, 24);
            this.dpk_Oppeningdate.TabIndex = 2;
            // 
            // lb_NameofCusomer
            // 
            this.lb_NameofCusomer.AutoSize = true;
            this.lb_NameofCusomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameofCusomer.Location = new System.Drawing.Point(31, 160);
            this.lb_NameofCusomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NameofCusomer.Name = "lb_NameofCusomer";
            this.lb_NameofCusomer.Size = new System.Drawing.Size(56, 18);
            this.lb_NameofCusomer.TabIndex = 3;
            this.lb_NameofCusomer.Text = "Name: ";
            // 
            // txt_Name_of_Customer
            // 
            this.txt_Name_of_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_of_Customer.Location = new System.Drawing.Point(93, 156);
            this.txt_Name_of_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name_of_Customer.Name = "txt_Name_of_Customer";
            this.txt_Name_of_Customer.Size = new System.Drawing.Size(212, 24);
            this.txt_Name_of_Customer.TabIndex = 1;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(31, 68);
            this.lb_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(55, 18);
            this.lb_Phone.TabIndex = 0;
            this.lb_Phone.Text = "Phone:";
            // 
            // cln_TypeofCus
            // 
            this.cln_TypeofCus.DataPropertyName = "NameTypeOfCustomer";
            this.cln_TypeofCus.FillWeight = 69.28934F;
            this.cln_TypeofCus.HeaderText = "Type of Customer";
            this.cln_TypeofCus.MinimumWidth = 6;
            this.cln_TypeofCus.Name = "cln_TypeofCus";
            // 
            // cln_Accumulated_Point
            // 
            this.cln_Accumulated_Point.DataPropertyName = "AccumulatedPoint";
            this.cln_Accumulated_Point.FillWeight = 69.28934F;
            this.cln_Accumulated_Point.HeaderText = "Accumulated Point";
            this.cln_Accumulated_Point.MinimumWidth = 6;
            this.cln_Accumulated_Point.Name = "cln_Accumulated_Point";
            // 
            // cln_LatestTransaction
            // 
            this.cln_LatestTransaction.DataPropertyName = "Latest transaction";
            this.cln_LatestTransaction.FillWeight = 69.28934F;
            this.cln_LatestTransaction.HeaderText = "Latest Transaction";
            this.cln_LatestTransaction.MinimumWidth = 6;
            this.cln_LatestTransaction.Name = "cln_LatestTransaction";
            // 
            // cln_OpeningDate
            // 
            this.cln_OpeningDate.DataPropertyName = "OpeningDate";
            this.cln_OpeningDate.FillWeight = 69.28934F;
            this.cln_OpeningDate.HeaderText = "Opening Date";
            this.cln_OpeningDate.MinimumWidth = 6;
            this.cln_OpeningDate.Name = "cln_OpeningDate";
            // 
            // cln_Phone
            // 
            this.cln_Phone.DataPropertyName = "Phone";
            this.cln_Phone.FillWeight = 69.28934F;
            this.cln_Phone.HeaderText = "Phone";
            this.cln_Phone.MinimumWidth = 6;
            this.cln_Phone.Name = "cln_Phone";
            // 
            // cln_Name_of_Customer
            // 
            this.cln_Name_of_Customer.DataPropertyName = "Name of Customer";
            this.cln_Name_of_Customer.FillWeight = 69.28934F;
            this.cln_Name_of_Customer.HeaderText = "Name of Customer";
            this.cln_Name_of_Customer.MinimumWidth = 6;
            this.cln_Name_of_Customer.Name = "cln_Name_of_Customer";
            // 
            // cln_IDCustomer
            // 
            this.cln_IDCustomer.DataPropertyName = "IDCustomer";
            this.cln_IDCustomer.FillWeight = 284.264F;
            this.cln_IDCustomer.HeaderText = "ID Customer";
            this.cln_IDCustomer.MinimumWidth = 6;
            this.cln_IDCustomer.Name = "cln_IDCustomer";
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AllowUserToAddRows = false;
            this.dgv_Customer.AllowUserToDeleteRows = false;
            this.dgv_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_IDCustomer,
            this.cln_Name_of_Customer,
            this.cln_Phone,
            this.cln_OpeningDate,
            this.cln_LatestTransaction,
            this.cln_Accumulated_Point,
            this.cln_TypeofCus});
            this.dgv_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customer.Location = new System.Drawing.Point(60, 118);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.Size = new System.Drawing.Size(1378, 515);
            this.dgv_Customer.TabIndex = 4;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // frm_CustomerChart1
            // 
            this.frm_CustomerChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_CustomerChart1.Location = new System.Drawing.Point(60, 118);
            this.frm_CustomerChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frm_CustomerChart1.Name = "frm_CustomerChart1";
            this.frm_CustomerChart1.Size = new System.Drawing.Size(1378, 515);
            this.frm_CustomerChart1.TabIndex = 7;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frm_CustomerChart1);
            this.Controls.Add(this.dgv_Customer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_CustomerFunction);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomers";
            this.Size = new System.Drawing.Size(1498, 882);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.pn_CustomerFunction.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_CustomerFunction;
        private System.Windows.Forms.Button btn_Chart;
        private System.Windows.Forms.Button btn_modifyCustomer;
        private System.Windows.Forms.Button bnt_Export;
        private System.Windows.Forms.Button btn_delCustomer;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_TypeofCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Accumulated_Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_LatestTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_OpeningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_Name_of_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_IDCustomer;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.Label lb_Openingdate;
        private System.Windows.Forms.DateTimePicker dpk_Oppeningdate;
        private System.Windows.Forms.Label lb_NameofCusomer;
        private System.Windows.Forms.TextBox txt_Name_of_Customer;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.TextBox txt_AccumulatedPoint;
        private System.Windows.Forms.Label lb_AccumulatePoint;
        private System.Windows.Forms.DateTimePicker dpk_LatestTransaction;
        private System.Windows.Forms.Label lb_Latesttransaction;
        private System.Windows.Forms.Button btn_SaveCustomer;
        private frm_CustomerChart frm_CustomerChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.TextBox txt_Phone;
    }
}
