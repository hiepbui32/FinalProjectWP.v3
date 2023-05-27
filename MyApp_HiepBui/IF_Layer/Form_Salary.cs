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
    public partial class Form_Salary : Form
    {
        string err;
        DataTable dtSalary = null;
        BLNhanVien dbNV = new BLNhanVien();
        bool Them = false; 
        public Form_Salary()
        {
            InitializeComponent();
        }
        void LoadDataInformation()
        {
            try
            {
                dtSalary = new DataTable();
                dtSalary.Clear();
                DataSet dsSalary = dbNV.Salary_Of_Employee();
                dtSalary = dsSalary.Tables[0];
                dgv_Salary.DataSource = dtSalary;
                dgv_Salary.AutoResizeColumns();


            }
            catch (SqlException)
            {

                throw;
            }
        }
        private void Form_Salary_Load(object sender, EventArgs e)
        {
            LoadDataInformation();
            btn_Add.Enabled = true;
            btn_Modify.Enabled = true;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Exit.Enabled = true;
        }

        private void Form_Salary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void dgv_Salary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Salary.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txt_ID.Text = dgv_Salary.Rows[r].Cells[0].Value.ToString();
            txt_TotalTime.Text = dgv_Salary.Rows[r].Cells[6].Value.ToString();
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
                    blNhanVien.Add_Salary_Emp(txt_ID.Text, txt_TotalTime.Text, ref err);
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
                    blNhanVien.Modify_Salary_Emp(txt_ID.Text, txt_TotalTime.Text, ref err);
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_ID.ResetText();
            txt_TotalTime.ResetText();
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
