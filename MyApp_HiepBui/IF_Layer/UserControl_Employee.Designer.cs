
namespace MyApp_HiepBui.IF_Layer
{
    partial class UserControl_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Employee));
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TypeEmp = new System.Windows.Forms.TextBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lb_TypeEmployee = new System.Windows.Forms.Label();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Diachi = new System.Windows.Forms.Label();
            this.lb_Ngaysinh = new System.Windows.Forms.Label();
            this.lb_Hoten = new System.Windows.Forms.Label();
            this.lb_IDNhanVien = new System.Windows.Forms.Label();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Salary = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_modifyEmployee = new System.Windows.Forms.Button();
            this.btn_delEmployee = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(950, 122);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 34);
            this.btn_Search.TabIndex = 27;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.Location = new System.Drawing.Point(592, 125);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(350, 30);
            this.txt_SearchName.TabIndex = 26;
            this.txt_SearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchName_KeyDown);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(330, 128);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(256, 25);
            this.label_Search.TabIndex = 25;
            this.label_Search.Text = "Search Name Of Employee:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_TypeEmp);
            this.panel1.Controls.Add(this.txt_Position);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.dateTimePicker_Ngaysinh);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.lb_TypeEmployee);
            this.panel1.Controls.Add(this.lb_Position);
            this.panel1.Controls.Add(this.lb_Phone);
            this.panel1.Controls.Add(this.lb_Diachi);
            this.panel1.Controls.Add(this.lb_Ngaysinh);
            this.panel1.Controls.Add(this.lb_Hoten);
            this.panel1.Controls.Add(this.lb_IDNhanVien);
            this.panel1.Location = new System.Drawing.Point(6, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 494);
            this.panel1.TabIndex = 30;
            this.panel1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee Information";
            // 
            // txt_TypeEmp
            // 
            this.txt_TypeEmp.Location = new System.Drawing.Point(183, 430);
            this.txt_TypeEmp.Name = "txt_TypeEmp";
            this.txt_TypeEmp.Size = new System.Drawing.Size(185, 22);
            this.txt_TypeEmp.TabIndex = 13;
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(183, 366);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(185, 22);
            this.txt_Position.TabIndex = 12;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(183, 300);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(185, 22);
            this.txt_Phone.TabIndex = 11;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(183, 240);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(185, 22);
            this.txt_Address.TabIndex = 10;
            // 
            // dateTimePicker_Ngaysinh
            // 
            this.dateTimePicker_Ngaysinh.CustomFormat = "dd-MM-yy";
            this.dateTimePicker_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Ngaysinh.Location = new System.Drawing.Point(183, 168);
            this.dateTimePicker_Ngaysinh.Name = "dateTimePicker_Ngaysinh";
            this.dateTimePicker_Ngaysinh.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker_Ngaysinh.TabIndex = 9;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(183, 111);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(185, 22);
            this.txt_Name.TabIndex = 8;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(183, 52);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(185, 30);
            this.txt_ID.TabIndex = 7;
            // 
            // lb_TypeEmployee
            // 
            this.lb_TypeEmployee.AutoSize = true;
            this.lb_TypeEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypeEmployee.Location = new System.Drawing.Point(16, 429);
            this.lb_TypeEmployee.Name = "lb_TypeEmployee";
            this.lb_TypeEmployee.Size = new System.Drawing.Size(164, 22);
            this.lb_TypeEmployee.TabIndex = 6;
            this.lb_TypeEmployee.Text = "Kind Of Employee:";
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Position.Location = new System.Drawing.Point(16, 365);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(81, 22);
            this.lb_Position.TabIndex = 5;
            this.lb_Position.Text = "Position:";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.Location = new System.Drawing.Point(16, 299);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(64, 22);
            this.lb_Phone.TabIndex = 4;
            this.lb_Phone.Text = "Phone:";
            // 
            // lb_Diachi
            // 
            this.lb_Diachi.AutoSize = true;
            this.lb_Diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diachi.Location = new System.Drawing.Point(16, 240);
            this.lb_Diachi.Name = "lb_Diachi";
            this.lb_Diachi.Size = new System.Drawing.Size(82, 22);
            this.lb_Diachi.TabIndex = 3;
            this.lb_Diachi.Text = "Address:";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.AutoSize = true;
            this.lb_Ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngaysinh.Location = new System.Drawing.Point(16, 168);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(113, 22);
            this.lb_Ngaysinh.TabIndex = 2;
            this.lb_Ngaysinh.Text = "DateOfBirth:";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.AutoSize = true;
            this.lb_Hoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.Location = new System.Drawing.Point(16, 111);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(62, 22);
            this.lb_Hoten.TabIndex = 1;
            this.lb_Hoten.Text = "Name:";
            // 
            // lb_IDNhanVien
            // 
            this.lb_IDNhanVien.AutoSize = true;
            this.lb_IDNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDNhanVien.Location = new System.Drawing.Point(16, 52);
            this.lb_IDNhanVien.Name = "lb_IDNhanVien";
            this.lb_IDNhanVien.Size = new System.Drawing.Size(36, 22);
            this.lb_IDNhanVien.TabIndex = 0;
            this.lb_IDNhanVien.Text = "ID:";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(406, 171);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.Size = new System.Drawing.Size(773, 492);
            this.dgv_NhanVien.TabIndex = 31;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Account.BackgroundImage = global::MyApp_HiepBui.Properties.Resources.login;
            this.btn_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Account.Location = new System.Drawing.Point(761, 19);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(109, 89);
            this.btn_Account.TabIndex = 29;
            this.btn_Account.Text = "&Account";
            this.btn_Account.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Account.UseVisualStyleBackColor = false;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Salary
            // 
            this.btn_Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Salary.BackgroundImage = global::MyApp_HiepBui.Properties.Resources.btn_Salary_Image;
            this.btn_Salary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Salary.FlatAppearance.BorderSize = 0;
            this.btn_Salary.ForeColor = System.Drawing.Color.White;
            this.btn_Salary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salary.Location = new System.Drawing.Point(644, 19);
            this.btn_Salary.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salary.Name = "btn_Salary";
            this.btn_Salary.Size = new System.Drawing.Size(109, 89);
            this.btn_Salary.TabIndex = 28;
            this.btn_Salary.Text = "&Salary";
            this.btn_Salary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salary.UseVisualStyleBackColor = false;
            this.btn_Salary.Click += new System.EventHandler(this.btn_Salary_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reload.BackgroundImage")));
            this.btn_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Reload.FlatAppearance.BorderSize = 0;
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Reload.Location = new System.Drawing.Point(523, 19);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(109, 89);
            this.btn_Reload.TabIndex = 24;
            this.btn_Reload.Text = "&Reload";
            this.btn_Reload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_modifyEmployee
            // 
            this.btn_modifyEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_modifyEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modifyEmployee.BackgroundImage")));
            this.btn_modifyEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modifyEmployee.FlatAppearance.BorderSize = 0;
            this.btn_modifyEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_modifyEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_modifyEmployee.Location = new System.Drawing.Point(406, 19);
            this.btn_modifyEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifyEmployee.Name = "btn_modifyEmployee";
            this.btn_modifyEmployee.Size = new System.Drawing.Size(109, 89);
            this.btn_modifyEmployee.TabIndex = 23;
            this.btn_modifyEmployee.Text = "&Modify";
            this.btn_modifyEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modifyEmployee.UseVisualStyleBackColor = false;
            this.btn_modifyEmployee.Click += new System.EventHandler(this.btn_modifyEmployee_Click);
            // 
            // btn_delEmployee
            // 
            this.btn_delEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_delEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delEmployee.BackgroundImage")));
            this.btn_delEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delEmployee.FlatAppearance.BorderSize = 0;
            this.btn_delEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_delEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delEmployee.Location = new System.Drawing.Point(289, 19);
            this.btn_delEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delEmployee.Name = "btn_delEmployee";
            this.btn_delEmployee.Size = new System.Drawing.Size(109, 89);
            this.btn_delEmployee.TabIndex = 22;
            this.btn_delEmployee.Text = "&Delete";
            this.btn_delEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delEmployee.UseVisualStyleBackColor = false;
            this.btn_delEmployee.Click += new System.EventHandler(this.btn_delEmployee_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_addEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addEmployee.BackgroundImage")));
            this.btn_addEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addEmployee.FlatAppearance.BorderSize = 0;
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addEmployee.Location = new System.Drawing.Point(172, 19);
            this.btn_addEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(109, 89);
            this.btn_addEmployee.TabIndex = 21;
            this.btn_addEmployee.Text = "&Add";
            this.btn_addEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::MyApp_HiepBui.Properties.Resources.exit_icon;
            this.btn_Exit.Location = new System.Drawing.Point(878, 19);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(109, 89);
            this.btn_Exit.TabIndex = 32;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // UserControl_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.btn_Salary);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_modifyEmployee);
            this.Controls.Add(this.btn_delEmployee);
            this.Controls.Add(this.btn_addEmployee);
            this.Name = "UserControl_Employee";
            this.Size = new System.Drawing.Size(1209, 666);
            this.Load += new System.EventHandler(this.UserControl_Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Salary;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_modifyEmployee;
        private System.Windows.Forms.Button btn_delEmployee;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TypeEmp;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ngaysinh;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lb_TypeEmployee;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Diachi;
        private System.Windows.Forms.Label lb_Ngaysinh;
        private System.Windows.Forms.Label lb_Hoten;
        private System.Windows.Forms.Label lb_IDNhanVien;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_Exit;
    }
}
