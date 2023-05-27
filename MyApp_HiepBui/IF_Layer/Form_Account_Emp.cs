using MyApp_HiepBui.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyApp_HiepBui.IF_Layer
{
    public partial class Form_Account_Emp : Form
    {
        string err;
        DataTable dtAccount = null;
        BLNhanVien dbNV = new BLNhanVien();
        bool Them = false;
        public Form_Account_Emp()
        {
            InitializeComponent();
        }
        void LoadDataInformation()
        {
            try
            {
                dtAccount = new DataTable();
                dtAccount.Clear();
                DataSet dsAccount = dbNV.Account_Employee();
                dtAccount = dsAccount.Tables[0];
                dgv_AccountEmp.DataSource = dtAccount;
                dgv_AccountEmp.AutoResizeColumns();
            }
            catch (SqlException)
            {

                throw;
            }
        }

        private void Form_Account_Emp_Load(object sender, EventArgs e)
        {
            LoadDataInformation();
            btn_Add.Enabled = true;
            btn_Modify.Enabled = true;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Exit.Enabled = true;
        }

        private void dgv_AccountEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_AccountEmp.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txt_ID.Text = dgv_AccountEmp.Rows[r].Cells[0].Value.ToString();
            txt_Username.Text = dgv_AccountEmp.Rows[r].Cells[2].Value.ToString();
            txt_Password.Text = dgv_AccountEmp.Rows[r].Cells[3].Value.ToString();
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Them = true;
            btn_Add.Enabled = false;
            btn_Modify.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLNhanVien blNhanVien = new BLNhanVien();
                    blNhanVien.Add_Account_Emp(txt_ID.Text, txt_Username.Text, txt_Password.Text, ref err);
                    // Thông báo
                    LoadDataInformation();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                try
                {
                    // Thực hiện lệnh
                    BLNhanVien blNhanVien = new BLNhanVien();
                    blNhanVien.Modify_Account_Emp(txt_ID.Text, txt_Username.Text, txt_Password.Text, ref err);
                    // Thông báo
                    LoadDataInformation();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = false;
            btn_Modify.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.ResetText();
            txt_Username.ResetText();
            txt_Password.ResetText();
            btn_Add.Enabled = true;
            btn_Modify.Enabled = true;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
