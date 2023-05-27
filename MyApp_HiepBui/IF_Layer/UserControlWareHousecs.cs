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
    public partial class UserControlWareHousecs : UserControl
    {
        DataTable dtInven;
        BLWareHouse blInven;
        bool modify = false;
        string err;
        public UserControlWareHousecs()
        {
            InitializeComponent();
            blInven = new BLWareHouse();

        }
        private void UserControlWareHousecs_Load(object sender, EventArgs e)
        {
            cbType.DataSource = blInven.GetTypeOfItem();
            cbType.DisplayMember = "NameTypeOfItem";
            cbSupplier.DataSource = blInven.GetNameOfSupplier();
            cbSupplier.DisplayMember = "NameOfSupplier";
            txtID.Enabled = false; txtID.BackColor = Color.White;
            txtName.Enabled = false; txtName.BackColor = Color.White;
            txtPrice.Enabled = false; txtPrice.BackColor = Color.White;
            cbType.Enabled = false; cbType.BackColor = Color.White;
            txtQuantity.Enabled = false; txtQuantity.BackColor = Color.White;
            txtMFG.Enabled = false; txtMFG.BackColor = Color.White;
            txtEXP.Enabled = false; txtEXP.BackColor = Color.White;
            cbSupplier.Enabled = false; cbSupplier.BackColor = Color.White;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;


        }

        public void LoadData()
        {
            dtInven = new DataTable();
            dtInven.Clear();
            DataSet ds = blInven.CheckInventory();
            dtInven = ds.Tables[0];
            dgvInfo.DataSource = dtInven;
        }
        private void btnCheckInven_Click(object sender, EventArgs e)
        {
            dtInven = new DataTable();
            dtInven.Clear();
            DataSet ds = blInven.CheckInventory();
            dtInven = ds.Tables[0];
            dgvInfo.DataSource = dtInven;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frm_AddItem frmAdd = new frm_AddItem();
            frmAdd.Show();
            LoadData();
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvInfo.CurrentCell.RowIndex;
            txtID.Text = dgvInfo.Rows[row].Cells[0].Value.ToString();
            txtName.Text = dgvInfo.Rows[row].Cells[1].Value.ToString();
            txtPrice.Text = dgvInfo.Rows[row].Cells[2].Value.ToString();
            cbType.Text = dgvInfo.Rows[row].Cells[3].Value.ToString();
            txtQuantity.Text = dgvInfo.Rows[row].Cells[5].Value.ToString();
            cbSupplier.Text = dgvInfo.Rows[row].Cells[4].Value.ToString();
            txtMFG.Text = dgvInfo.Rows[row].Cells[6].Value.ToString();
            txtEXP.Text = dgvInfo.Rows[row].Cells[7].Value.ToString();

        }

        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                modify = true;
                txtName.Enabled = true;
                txtPrice.Enabled = true;
                cbType.Enabled = true;
                cbSupplier.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                try
                {
                    string newName = txtName.Text.Trim();
                    int newPrice = int.Parse(txtPrice.Text.Trim());
                    string newType = cbType.Text.Trim();
                    string newSupplier = cbSupplier.Text.Trim();
                    blInven.ModifyItem(txtID.Text, newName, newPrice, newType, newSupplier, ref err);
                    MessageBox.Show("Modify success!");

                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something happened, couldn't modify.");
                }
                modify = false;
                txtName.Enabled = false;
                txtPrice.Enabled = false;
                cbType.Enabled = false;
                cbSupplier.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnCheckInven.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            modify = false;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            cbType.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            cbSupplier.Enabled = false;

            btnCheckInven.Focus();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frm_ImportItem frm_import = new frm_ImportItem();
            frm_import.Show();
            LoadData();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            frm_Statistic frmStatistic = new frm_Statistic();
            frmStatistic.Show();
        }
    }
}
