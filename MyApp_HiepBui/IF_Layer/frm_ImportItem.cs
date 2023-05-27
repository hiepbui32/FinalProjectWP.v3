using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;

using MyApp_HiepBui.DB_Layer;
using MyApp_HiepBui.BS_Layer;
using System.Data.SqlClient;
using System.Globalization;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class frm_ImportItem : Form
    {
        BLWareHouse blwarehouse;
        DataTable dt;
        string err;
        public frm_ImportItem()
        {
            InitializeComponent();
            blwarehouse = new BLWareHouse();
        }
        private void frm_ImportItem_Load(object sender, EventArgs e)
        {
            LoadData();
            cbType.DataSource = blwarehouse.GetTypeOfItem();
            cbType.DisplayMember = "NameTypeOfItem";
            cbSupplier.DataSource = blwarehouse.GetNameOfSupplier();
            cbSupplier.DisplayMember = "NameOfSupplier";


            txtName.Enabled = false;
            txtPrice.Enabled = false;
            dtpMFGDate.Enabled = false;
            cbType.Enabled = false;
            cbSupplier.Enabled = false;
            txtQuantity.Enabled = false;
            btnGoToDGV.Enabled = false;

        }
        public void LoadData()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = blwarehouse.CheckInventory();
            dt = ds.Tables[0];
            dgvDetails.DataSource = dt;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtContent.Text != "Input something" && cbCategories.Text != "Categories")
            {
                try
                {
                    string str = txtContent.Text.Trim();
                    string category = cbCategories.Text.Trim();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    DataSet ds = blwarehouse.SearchInfo(str, category);
                    dt = ds.Tables[0];

                    dgvDetails.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something happed, try again!");
                }
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    DataSet ds = blwarehouse.CheckInventory();
                    dt = ds.Tables[0];
                }
                catch (Exception)
                {

                    MessageBox.Show("Something happed, try again!");
                }
            }
        }

        private void txtContent_Click(object sender, EventArgs e)
        {
            if (txtContent.Text == "Input something")
            {
                txtContent.Text = "";
                txtContent.ForeColor = Color.Black;
            }
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                txtContent.Text = "Input something";
                txtContent.ForeColor = Color.DarkGray;
            }
        }

        private void cbCategories_Click(object sender, EventArgs e)
        {
            if (cbCategories.Text == "Categories")
            {
                cbCategories.Text = "";
                cbCategories.ForeColor = Color.Black;
            }
        }

        private void cbCategories_Leave(object sender, EventArgs e)
        {
            if (cbCategories.Text == "")
            {
                cbCategories.Text = "Categories";
                cbCategories.ForeColor = Color.Black;
            }

        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text != "Input something" && cbCategories.Text != "Categories")
            {
                try
                {
                    string str = txtContent.Text.Trim();
                    string category = cbCategories.Text.Trim();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    DataSet ds = blwarehouse.SearchInfo(str, category);
                    dt = ds.Tables[0];

                    dgvDetails.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something happed, try again!");
                }

            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            frm_ImportItemFromFileExcel_WareHouse frm_ImportItemFromFile = new frm_ImportItemFromFileExcel_WareHouse();
            frm_ImportItemFromFile.Show();
        }
        private void copyAlltoClipboard()
        {
            dgvDetails.SelectAll();
            DataObject dataObj = dgvDetails.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDetails.DataSource = null;
            while (dgvDetails.Columns.Count > 0)
            {
                dgvDetails.Columns.RemoveAt(0);
            }
            Thread.Sleep(500);
            LoadData();
            MessageBox.Show("Refreshed.");
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            frm_Statistic frmStatistic = new frm_Statistic();
            frmStatistic.Show();
        }

        private void btnImportNew_Click(object sender, EventArgs e)
        {
            dgvDetails.DataSource = null;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            dtpMFGDate.Enabled = true;
            cbType.Enabled = true;
            cbSupplier.Enabled = true;
            txtQuantity.Enabled = true;
            btnGoToDGV.Enabled = true;

        }

        private void btnGoToDGV_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int price = int.Parse(txtPrice.Text);
            int day = dtpMFGDate.Value.Day;
            int month = dtpMFGDate.Value.Month;
            int year = dtpMFGDate.Value.Year;

            DateTime datetime = new DateTime(year, month, day);
            string type = cbType.Text;
            string supplier = cbSupplier.Text;
            int quantity = int.Parse(txtQuantity.Text);

            if (dgvDetails.Columns.Count == 0)
            {

                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Name",
                    Name = "Name"
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Price",
                    Name = "Price"
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantity",
                    Name = "Quantity"
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Type",
                    Name = "Type"
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Supplier",
                    Name = "Supplier"
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "MFG Date",
                    Name = "Columm6"
                });
            }
            dgvDetails.Rows.Add(new object[] { name, price, quantity, type, supplier, datetime });
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                int price;
                string date;

                string type;
                DateTime dateTime;
                string supplier;
                int quantity;
                int temp = dgvDetails.Rows.Count;
                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    name = dgvDetails.Rows[i].Cells[0].Value.ToString();
                    price = Int32.Parse(dgvDetails.Rows[i].Cells[1].Value.ToString());
                    quantity = Int32.Parse(dgvDetails.Rows[i].Cells[2].Value.ToString());

                    type = dgvDetails.Rows[i].Cells[3].Value.ToString();
                    supplier = dgvDetails.Rows[i].Cells[4].Value.ToString();
                    date = dgvDetails.Rows[i].Cells[5].Value.ToString();

                    if (date.ToString().Length == 22)
                    {
                        int month = int.Parse($"{date[0]}{date[1]}");
                        int day = int.Parse($"{date[3]}{date[4]}");
                        int year = int.Parse($"{date[6]}{date[7]}{date[8]}{date[9]}");
                        dateTime = new DateTime(year, month, day);
                        blwarehouse.AddNewItem(name, price, dateTime, type, supplier, quantity, ref err);

                    }
                    if (date.ToString().Length == 21)
                    {
                        int month = int.Parse($"{date[0]}");
                        int day = int.Parse($"{date[2]}{date[3]}");
                        int year = int.Parse($"{date[5]}{date[6]}{date[7]}{date[8]}");
                        dateTime = new DateTime(year, month, day);
                        blwarehouse.AddNewItem(name, price, dateTime, type, supplier, quantity, ref err);

                    }

                }
                MessageBox.Show("Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Something happened, try again!");
            }
        }

        private void btnClearDataInDGV_Click(object sender, EventArgs e)
        {
            dgvDetails.DataSource = null;
            while (dgvDetails.Columns.Count > 0)
            {
                dgvDetails.Columns.RemoveAt(0);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtName.Focus();
        }
    }
}
