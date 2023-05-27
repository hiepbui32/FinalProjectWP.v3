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

using MyApp_HiepBui.BS_Layer;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class frm_AddItem : Form
    {
        BLWareHouse blwarehouse;
        string err;

        public frm_AddItem()
        {
            InitializeComponent();
            blwarehouse = new BLWareHouse();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            cbType.DataSource = blwarehouse.GetTypeOfItem();
            cbType.DisplayMember = "NameTypeOfItem";
            cbSupplier.DataSource = blwarehouse.GetNameOfSupplier();
            cbSupplier.DisplayMember = "NameOfSupplier";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                int price = int.Parse(txtPrice.Text.Trim());
                int day = dtpProduction.Value.Day;
                int month = dtpProduction.Value.Month;
                int year = dtpProduction.Value.Year;

                DateTime date = new DateTime(year, month, day);
                string type = cbType.Text.Trim();
                string supplier = cbSupplier.Text.Trim();
                int quantity = int.Parse(txtQuantity.Text.Trim());
                blwarehouse.AddNewItem(name, price, date, type, supplier, quantity, ref err);
                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
