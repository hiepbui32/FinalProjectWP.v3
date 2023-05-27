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
    public partial class UserControl_ThemNhanVien : UserControl
    {

        string err;
        DataTable dtKindOfEmp = null;
        DataTable dtGroupEmp = null;
        DataTable dtTypeUser = null;
        DataTable dtNhanVien = null;
        BLNhanVien dbNV = new BLNhanVien();
        bool Them = false;
        public UserControl_ThemNhanVien()
        {
            InitializeComponent();
            dateTimePicker_AddDOB.Format = DateTimePickerFormat.Custom;
            dateTimePicker_AddDOB.CustomFormat = "dd-MM-yyyy";
        }
        void loadDataNV()
        {
            try
            {
                dtKindOfEmp = new DataTable();
                dtKindOfEmp.Clear();
                DataSet dsKOE = dbNV.Get_List_Kind_Of_Employee();
                dtKindOfEmp = dsKOE.Tables[0];
                dgv_KindOfEmployee.DataSource = dtKindOfEmp;
                dgv_KindOfEmployee.AutoResizeColumns();
                //
                dtGroupEmp = new DataTable();
                dtGroupEmp.Clear();
                DataSet dsGroupEmp = dbNV.Get_List_Group_Of_Employee();
                dtGroupEmp = dsGroupEmp.Tables[0];
                dgv_GroupEmp.DataSource = dtGroupEmp;
                dgv_GroupEmp.AutoResizeColumns();
                //
                dtTypeUser = new DataTable();
                dtTypeUser.Clear();
                DataSet dsTypeUser = dbNV.Get_List_Type_Of_User();
                dtTypeUser = dsTypeUser.Tables[0];
                dgv_TypeUser.DataSource = dtTypeUser;
                dgv_TypeUser.AutoResizeColumns();

            }
            catch (SqlException)
            {

                throw;
            }
        }

        private void UserControl_ThemNhanVien_Load(object sender, EventArgs e)
        {
            loadDataNV();
        }

        

       

        private void label_Ngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                BLNhanVien blNhanVien = new BLNhanVien();
                int value_StatusEmp = Convert.ToInt32(txt_AddStatusEmp.Text);
                dateTimePicker_AddDOB.CustomFormat = "yyyy-MM-dd";
                blNhanVien.ThemNhanVien(txt_AddName.Text, dateTimePicker_AddDOB.Text, txt_AddAddress.Text, txt_AddPhone.Text,
                    value_StatusEmp, txt_AddIDKindEmp.Text, txt_AddGroupEmp.Text,
                    txt_AddTypeUser.Text, txt_AddIDStore.Text, ref err);
                if (err != "")
                {
                    MessageBox.Show(err);
                    return;
                }
                // Thông báo
                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_AddName.Clear();
            dateTimePicker_AddDOB.ResetText();
            txt_AddAddress.Clear();
            txt_AddPhone.Clear();
            txt_AddStatusEmp.Clear();
            txt_AddIDKindEmp.Clear();
            txt_AddGroupEmp.Clear();
            txt_AddTypeUser.Clear();
            txt_AddIDStore.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
