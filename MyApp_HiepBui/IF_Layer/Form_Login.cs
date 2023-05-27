using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyApp_HiepBui
{
    public partial class Form_Login : Form
    {
        public static Form_Login form_log;
        public string Account_Pass;
        public string Accont { get; set; }
        public string Password { get; set; }

        string connstr = "Data Source=HIEPBUI2812\\SQLEXPRESS;Initial Catalog=ConvenienceStoreManagement(new);Integrated Security=True";

        public Form_Login()
        {
            InitializeComponent();
            form_log = this;
        }
        
        private void ckb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_ShowPassword.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {

                txt_Password.UseSystemPasswordChar = true;
            }
        }
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connstr);
            this.Accont = txt_Account.Text.Trim();
            this.Password = txt_Password.Text.Trim();
            //try
            //{
            //    con.Open();
            //    string acc = txt_Account.Text;
            //    string pass = txt_Password.Text;
            //    string sql = "SELECT * FROM dbo.[v_Account&Authority] WHERE Username='" + acc + "' and Password='" + pass + "'";
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    SqlDataReader dta = cmd.ExecuteReader();
            //    //if (dta.Read() == true)
            //    //{
            //    //    MessageBox.Show("Đăng nhập thành công");
            //    //    Const.TypeOfAcc = dta.GetString(5);
            //    //    Form_Menu newProgram = new Form_Menu();
            //    //    newProgram.Show();
            //    //    this.Hide();
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("Nhập sai vui lòng nhập lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    //    txt_Account.Focus();
            //    //}
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Lỗi kết nối");
            //}

            Form_Menu newProgram = new Form_Menu();
            newProgram.Show();
            this.Hide();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Login_Click(sender, e);  
            }
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_Account_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
