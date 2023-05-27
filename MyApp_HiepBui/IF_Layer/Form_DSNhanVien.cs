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
    public partial class Form_DSNhanVien : Form
    {
        string err = "";
        DataTable dtNhanVien = null;
        BLNhanVien dbNV = new BLNhanVien();
        bool Them = false;
        bool Sua = false;
        public Form_DSNhanVien()
        {

            InitializeComponent();
            dateTimePicker_Ngaysinh.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Ngaysinh.CustomFormat = "dd-MM-yyyy";
        }
        void loadDataNV()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbNV.Lay_DSNhanVien_DangLamViec();
                dtNhanVien = ds.Tables[0];
                dgv_NhanVien.DataSource = dtNhanVien;
                dgv_NhanVien.AutoResizeColumns();
                txt_ID.Enabled = false;
                txt_Name.Enabled = false;
                dateTimePicker_Ngaysinh.Enabled = false;
                txt_Address.Enabled = false;
                txt_Phone.Enabled = false;
                txt_Position.Enabled = false;
                txt_TypeEmp.Enabled = false;
                //
                txt_ID.ResetText();
                txt_Name.ResetText();
                dateTimePicker_Ngaysinh.ResetText();
                txt_Phone.ResetText();
                txt_Address.ResetText();
                txt_Position.ResetText();
                txt_TypeEmp.ResetText();
            }
            catch (SqlException)
            {

                throw;
            }
        }

        private void Form_DSNhanVien_Load(object sender, EventArgs e)
        {
            loadDataNV();

        }

        private void Form_DSNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            btn_addEmployee.Enabled = true;
            btn_modifyEmployee.Enabled = true;
            btn_delEmployee.Enabled = true;
            loadDataNV();
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker_Ngaysinh.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Ngaysinh.CustomFormat = "dd-MM-yyyy";
            int r = dgv_NhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txt_ID.Text = dgv_NhanVien.Rows[r].Cells[0].Value.ToString();
            txt_Name.Text = dgv_NhanVien.Rows[r].Cells[1].Value.ToString();
            dateTimePicker_Ngaysinh.Text = dgv_NhanVien.Rows[r].Cells[2].Value.ToString();
            txt_Phone.Text = dgv_NhanVien.Rows[r].Cells[3].Value.ToString();
            txt_Address.Text = dgv_NhanVien.Rows[r].Cells[4].Value.ToString();
            //txt_Position.Text = dgv_NhanVien.Rows[r].Cells[5].Value.ToString();
            //txt_TypeEmp.Text = dgv_NhanVien.Rows[r].Cells[6].Value.ToString();
        }

        private void lb_Thongtinnhanvien_Click(object sender, EventArgs e)
        {

        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmp = new FormAddEmployee();
            formAddEmp.Show();
            loadDataNV();
        }




        private void btn_delEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgv_NhanVien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNhanVien =
                dgv_NhanVien.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    try
                    {
                        dbNV.XoaNhanVien(strNhanVien, ref err);
                        if(err != "")
                        {
                            MessageBox.Show(err);
                            return;
                        }
                    }
                    catch (SqlException)
                    {

                        MessageBox.Show("You do not have permission to do this task.");
                    }
                    // Cập nhật lại DataGridView
                    loadDataNV();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btn_modifyEmployee_Click(object sender, EventArgs e)
        {
            FormModifyEmp formModifyEmp = new FormModifyEmp();
            formModifyEmp.Show();
            loadDataNV();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchName = txt_SearchName.Text.Trim();
            if (!string.IsNullOrEmpty(searchName))
            {
                try
                {
                    DataTable dtSearchName = new DataTable();
                    dtSearchName.Clear();
                    //DataSet dsSearchName = dbNV.SearchInfo(searchName);
                    dtSearchName = dbNV.SearchInfo(searchName);
                    if (dtSearchName == null)
                    {
                        throw new Exception("No data found.");
                        //MessageBox.Show("Không tìm thấy nhân viên");
                    }
                    else
                    {
                        dgv_NhanVien.DataSource = dtSearchName;
                        dgv_NhanVien.AutoResizeColumns();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");

                }

            }
        }

        private void mList_of_Employee_Click(object sender, EventArgs e)
        {

        }

        private void txt_SearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search.PerformClick();
            }
        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            Form_Salary formSalary = new Form_Salary();
            formSalary.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Form_Account_Emp formAccount = new Form_Account_Emp();
            formAccount.Show();
        }
    }
}
