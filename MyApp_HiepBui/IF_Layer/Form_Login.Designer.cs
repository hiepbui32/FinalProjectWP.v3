namespace MyApp_HiepBui
{
    partial class Form_Login
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
            this.lb_Account = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.ckb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Account.Location = new System.Drawing.Point(104, 78);
            this.lb_Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Account.Name = "lb_Account";
            this.lb_Account.Size = new System.Drawing.Size(81, 22);
            this.lb_Account.TabIndex = 1;
            this.lb_Account.Text = "Account:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(104, 154);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(94, 22);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password:";
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(225, 79);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(291, 22);
            this.txt_Account.TabIndex = 1;
            this.txt_Account.TextChanged += new System.EventHandler(this.txt_Account_TextChanged);
            this.txt_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Account_KeyPress);
            // 
            // ckb_ShowPassword
            // 
            this.ckb_ShowPassword.AutoSize = true;
            this.ckb_ShowPassword.Location = new System.Drawing.Point(225, 219);
            this.ckb_ShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_ShowPassword.Name = "ckb_ShowPassword";
            this.ckb_ShowPassword.Size = new System.Drawing.Size(125, 20);
            this.ckb_ShowPassword.TabIndex = 4;
            this.ckb_ShowPassword.Text = "Show Password";
            this.ckb_ShowPassword.UseVisualStyleBackColor = true;
            this.ckb_ShowPassword.CheckedChanged += new System.EventHandler(this.ckb_ShowPassword_CheckedChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(225, 155);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(285, 22);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::MyApp_HiepBui.Properties.Resources.gnome_session_logout;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(207, 271);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(187, 37);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::MyApp_HiepBui.Properties.Resources.application_exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(415, 271);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(187, 37);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 382);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.ckb_ShowPassword);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Account);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Login_FormClosed);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Account;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.CheckBox ckb_ShowPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Password;
    }
}