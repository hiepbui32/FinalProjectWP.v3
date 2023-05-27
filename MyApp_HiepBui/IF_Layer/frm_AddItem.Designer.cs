namespace MyApp_HiepBui.IF_Layer
{
    partial class frm_AddItem
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
            this.lbNameItem = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbProDate = new System.Windows.Forms.Label();
            this.dtpProduction = new System.Windows.Forms.DateTimePicker();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNameItem
            // 
            this.lbNameItem.AutoSize = true;
            this.lbNameItem.Location = new System.Drawing.Point(115, 92);
            this.lbNameItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameItem.Name = "lbNameItem";
            this.lbNameItem.Size = new System.Drawing.Size(75, 25);
            this.lbNameItem.TabIndex = 0;
            this.lbNameItem.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 30);
            this.txtName.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(115, 153);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(67, 25);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(218, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // lbProDate
            // 
            this.lbProDate.AutoSize = true;
            this.lbProDate.Location = new System.Drawing.Point(115, 211);
            this.lbProDate.Name = "lbProDate";
            this.lbProDate.Size = new System.Drawing.Size(159, 25);
            this.lbProDate.TabIndex = 4;
            this.lbProDate.Text = "Production date :";
            // 
            // dtpProduction
            // 
            this.dtpProduction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProduction.Location = new System.Drawing.Point(294, 211);
            this.dtpProduction.Name = "dtpProduction";
            this.dtpProduction.Size = new System.Drawing.Size(151, 30);
            this.dtpProduction.TabIndex = 5;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(115, 267);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(68, 25);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Type :";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(218, 264);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(227, 33);
            this.cbType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add new item";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(92, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 51);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(252, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 51);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(408, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 51);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(218, 323);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(228, 33);
            this.cbSupplier.TabIndex = 13;
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Location = new System.Drawing.Point(115, 326);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(95, 25);
            this.lbSupplier.TabIndex = 12;
            this.lbSupplier.Text = "Supplier :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(218, 378);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(227, 30);
            this.txtQuantity.TabIndex = 15;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(116, 381);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(96, 25);
            this.lbQuantity.TabIndex = 14;
            this.lbQuantity.Text = "Quantity :";
            // 
            // frm_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.dtpProduction);
            this.Controls.Add(this.lbProDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbNameItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new item";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbProDate;
        private System.Windows.Forms.DateTimePicker dtpProduction;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
    }
}