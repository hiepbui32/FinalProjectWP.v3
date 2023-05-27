using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyApp_HiepBui.BS_Layer;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class AddNewOrder : UserControl
    {
        BLOrder blOrder;
        DataTable nameitems, phoneofcus;
        public AddNewOrder()
        {
            InitializeComponent();
            blOrder = new BLOrder();
            txtTotalPrice.Text = "0";
            phoneofcus = blOrder.GetPhoneOfCus();
            List<string> autocompletePhone = new List<string>();
            foreach (DataRow row in phoneofcus.Rows)
            {
                autocompletePhone.Add(row["Phone"].ToString());
            }

            txtPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPhone.AutoCompleteCustomSource.AddRange(autocompletePhone.ToArray());


            nameitems = blOrder.GetNameOfItem();
            List<string> autocompleteData = new List<string>();
            foreach (DataRow row in nameitems.Rows)
            {
                autocompleteData.Add(row["NameItem"].ToString());
            }

            txtNameOfItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNameOfItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNameOfItem.AutoCompleteCustomSource.AddRange(autocompleteData.ToArray());


            pnDetails.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;

            List<string> categories = new List<string> { "Name", "Phone" };

            cbCategories.DataSource = categories;

        }

        private void btnCheckCus_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            string nameCus = blOrder.TakeNameCus(phone);
            if (nameCus == "")
            {

            }
            else
            {

                txtNameCus.Text = nameCus;


            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtQuantity.Text == "" || txtNameOfItem.Text == "")
            {
                MessageBox.Show("Please input enough information.");
                return;
            }
            string idItem = txtItemID.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int price = int.Parse(txtUnitPrice.Text);
            string nameofItem = txtNameOfItem.Text;
            int total = quantity * price;
            if (dgvOrders.Columns.Count == 0)
            {
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID Item",
                    Name = "c1"
                });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Name Item",
                    Name = "c2"
                });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Price",
                    Name = "c3"
                });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantity",
                    Name = "c4"
                });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Total price",
                    Name = "c5"
                });
            }
            dgvOrders.Rows.Add(new object[] { idItem, nameofItem, price, quantity, total });
            txtNameOfItem.Clear();
            txtItemID.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();

            txtTotalPrice.Text = (Convert.ToInt64(txtTotalPrice.Text) + total).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string newIDOrder = blOrder.GetNewIDOrder();
                string phone = txtPhone.Text;
                blOrder.CreateNewOrder(newIDOrder, phone);
                string idItem;
                int quantity;

                for (int i = 0; i < dgvOrders.Rows.Count - 1; i++)
                {
                    idItem = dgvOrders.Rows[i].Cells[0].Value.ToString();
                    quantity = int.Parse(dgvOrders.Rows[i].Cells[3].Value.ToString());

                    blOrder.AddNewOrder(newIDOrder, phone, idItem, quantity);
                }
                MessageBox.Show("Added new order success!");
                
            }
            catch (Exception)
            {
                MessageBox.Show("wojad");

            }

        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = blOrder.GetAllOrders();

            dt = ds.Tables[0];
            dgvOrders.DataSource = dt;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            pnDetails.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            dgvOrders.DataSource = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvOrders.Columns.Clear();
            dgvOrders.DataSource = null;
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = blOrder.GetAllOrders();

            dt = ds.Tables[0];
            dgvOrders.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNameOfItem.Clear();
            txtNameCus.Clear();
            txtItemID.Clear();
            txtPhone.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            txtUnitPrice.Clear();
            pnDetails.Enabled = false;
            btnRefresh.Focus();
            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            frmStatisticOrder frmsttOrder = new frmStatisticOrder();
            frmsttOrder.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string content = txtSearchInfo.Text.Trim();
                string category = cbCategories.Text;
                DataTable dt = new DataTable();
                dt = blOrder.SearchingInfo(content, category);
                if (dt == null)
                {
                    //MessageBox.Show("Không tìm thấy hóa đơn!");
                    throw new Exception("No data found.");
                }
                //else { 
                dgvOrders.DataSource = dt;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void txtSearchInfo_Enter(object sender, EventArgs e)
        {
            if (txtSearchInfo.Text == "Input something")
            {
                txtSearchInfo.Text = "";
                txtSearchInfo.ForeColor = Color.Black;
            }
        }

        private void txtSearchInfo_Leave(object sender, EventArgs e)
        {
            if (txtSearchInfo.Text == "")
            {
                txtSearchInfo.Text = "Input something";
                txtSearchInfo.ForeColor = Color.Gray;
            }
        }

        private void cbCategories_TextChanged(object sender, EventArgs e)
        {
            if (cbCategories.Text == "Phone")
            {
                List<string> autocompletePhone = new List<string>();
                foreach (DataRow row in phoneofcus.Rows)
                {
                    autocompletePhone.Add(row["Phone"].ToString());
                }

                txtSearchInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearchInfo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearchInfo.AutoCompleteCustomSource.AddRange(autocompletePhone.ToArray());
            }
            else
            {

            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            int r = dgvOrders.CurrentCell.RowIndex;
            string idCus = dgvOrders.Rows[r].Cells[0].Value.ToString();
            ExportReceipt exportReceipt = new ExportReceipt(idCus);
            exportReceipt.Show();
        }

        private void txtNameOfItem_Enter(object sender, EventArgs e)
        {
            string idofitem = "";
            int price = 0;
            foreach (DataRow item in nameitems.Rows)
            {
                if (item["NameItem"].ToString() == txtNameOfItem.Text.ToString())
                {
                    idofitem = item["IDItem"].ToString();
                    price = int.Parse(item["Price"].ToString());
                    txtItemID.Text = idofitem;
                    txtUnitPrice.Text = price.ToString();
                    return;
                }
            }

        }

    }
}
