
namespace MyApp_HiepBui.IF_Layer
{
    partial class AddNewOrder
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnDetails = new System.Windows.Forms.Panel();
            this.txtNameOfItem = new System.Windows.Forms.TextBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lxNameItem = new System.Windows.Forms.Label();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCheckCus = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.btn_Export = new System.Windows.Forms.Button();

            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvOrders.Location = new System.Drawing.Point(17, 86);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(712, 597);
            this.dgvOrders.TabIndex = 0;
            // 
            // pnDetails
            // 
            this.pnDetails.BackColor = System.Drawing.Color.White;
            this.pnDetails.Controls.Add(this.txtNameOfItem);
            this.pnDetails.Controls.Add(this.lbItem);
            this.pnDetails.Controls.Add(this.txtUnitPrice);
            this.pnDetails.Controls.Add(this.txtQuantity);
            this.pnDetails.Controls.Add(this.txtItemID);
            this.pnDetails.Controls.Add(this.lbUnitPrice);
            this.pnDetails.Controls.Add(this.lbQuantity);
            this.pnDetails.Controls.Add(this.lxNameItem);
            this.pnDetails.Controls.Add(this.txtNameCus);
            this.pnDetails.Controls.Add(this.lbName);
            this.pnDetails.Controls.Add(this.btnCheckCus);
            this.pnDetails.Controls.Add(this.txtPhone);
            this.pnDetails.Controls.Add(this.lbPhone);
            this.pnDetails.Location = new System.Drawing.Point(759, 86);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(431, 399);
            this.pnDetails.TabIndex = 1;
            // 
            // txtNameOfItem
            // 
            this.txtNameOfItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfItem.Location = new System.Drawing.Point(171, 208);
            this.txtNameOfItem.Name = "txtNameOfItem";
            this.txtNameOfItem.Size = new System.Drawing.Size(215, 26);
            this.txtNameOfItem.TabIndex = 17;
            this.txtNameOfItem.TextChanged += new System.EventHandler(this.txtNameOfItem_Enter);
            this.txtNameOfItem.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtNameOfItem_Enter);
            this.txtNameOfItem.Leave += new System.EventHandler(this.txtNameOfItem_Enter);
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(26, 157);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(66, 20);
            this.lbItem.TabIndex = 16;
            this.lbItem.Text = "Item ID:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(155, 263);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(231, 26);
            this.txtUnitPrice.TabIndex = 14;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(155, 322);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(231, 26);
            this.txtQuantity.TabIndex = 13;
            // 
            // txtItemID
            // 
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(144, 157);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(242, 26);
            this.txtItemID.TabIndex = 12;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPrice.Location = new System.Drawing.Point(27, 266);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(81, 20);
            this.lbUnitPrice.TabIndex = 9;
            this.lbUnitPrice.Text = "Unit Price:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(30, 322);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(72, 20);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lxNameItem
            // 
            this.lxNameItem.AutoSize = true;
            this.lxNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lxNameItem.Location = new System.Drawing.Point(26, 211);
            this.lxNameItem.Name = "lxNameItem";
            this.lxNameItem.Size = new System.Drawing.Size(109, 20);
            this.lxNameItem.TabIndex = 7;
            this.lxNameItem.Text = "Name of Item:";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCus.Location = new System.Drawing.Point(144, 69);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.ReadOnly = true;
            this.txtNameCus.Size = new System.Drawing.Size(242, 26);
            this.txtNameCus.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(30, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 20);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name :";
            // 
            // btnCheckCus
            // 
            this.btnCheckCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCus.Location = new System.Drawing.Point(299, 105);
            this.btnCheckCus.Name = "btnCheckCus";
            this.btnCheckCus.Size = new System.Drawing.Size(87, 43);
            this.btnCheckCus.TabIndex = 3;
            this.btnCheckCus.Text = "Check";
            this.btnCheckCus.UseVisualStyleBackColor = true;
            this.btnCheckCus.Click += new System.EventHandler(this.btnCheckCus_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(144, 16);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 26);
            this.txtPhone.TabIndex = 2;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(27, 16);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(63, 20);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Phone :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(914, 501);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(231, 26);
            this.txtTotalPrice.TabIndex = 15;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(790, 501);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(87, 20);
            this.lbTotalPrice.TabIndex = 10;
            this.lbTotalPrice.Text = "Total Price:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(745, 584);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "<--";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(863, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(986, 584);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(725, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 47);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(963, 18);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(102, 47);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInfo.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchInfo.Location = new System.Drawing.Point(17, 24);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(430, 26);
            this.txtSearchInfo.TabIndex = 7;
            this.txtSearchInfo.Text = "Input something";
            this.txtSearchInfo.Enter += new System.EventHandler(this.txtSearchInfo_Enter);
            this.txtSearchInfo.Leave += new System.EventHandler(this.txtSearchInfo_Leave);
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(453, 24);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(138, 28);
            this.cbCategories.TabIndex = 8;
            this.cbCategories.TextChanged += new System.EventHandler(this.cbCategories_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(606, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 47);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(844, 18);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(102, 47);
            this.btnNewOrder.TabIndex = 16;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1082, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 47);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 

            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(1104, 584);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(106, 39);
            this.btn_Export.TabIndex = 18;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);

            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "ID Order";
            this.Column1.HeaderText = "ID Order";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 103;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Name customer";
            this.Column2.HeaderText = "Name customer";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 144;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Total price";
            this.Column3.HeaderText = "Total price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 108;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "Day transaction";
            this.Column5.HeaderText = "Day transaction";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 143;

            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtSearchInfo);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnDetails);
            this.Controls.Add(this.dgvOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewOrder";
            this.Size = new System.Drawing.Size(1239, 706);
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCheckCus;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lxNameItem;
        private System.Windows.Forms.TextBox txtNameOfItem;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btn_Export;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}
