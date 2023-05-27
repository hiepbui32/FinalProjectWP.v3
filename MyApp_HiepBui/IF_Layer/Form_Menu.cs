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

using MyApp_HiepBui.IF_Layer;

namespace MyApp_HiepBui
{
    public partial class Form_Menu : Form
    {

        public Form_Menu()
        {
            InitializeComponent();
        }
        void Refresh()
        {
            frmCustomers1.Hide();
            userControlWareHousecs2.Hide();

            addNewOrder2.Hide();

            userControl_Employee1.Hide();

        }
        private void Form_Programm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lb_clock1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            
            Refresh();

        }


        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            fl.Account_Pass = "";
            MessageBox.Show("HI");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login fl = new Form_Login();
            fl.Show();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void mnuCustomers_Click_1(object sender, EventArgs e)
        {
            Refresh();
            frmCustomers1.Show();
            frmCustomers1.BringToFront();
        }

        private void frmCustomers1_Load(object sender, EventArgs e)
        {

        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {

            Form_DSNhanVien fNV = new Form_DSNhanVien();
            fNV.Show();
            fNV.BringToFront();

            //if (Const.TypeOfAcc == "IncompleteAuthority")
            //{
            //    MessageBox.Show("Bạn không được quyền truy cập");
            //}
            //else
            //{
            //    Form_DSNhanVien fNV = new Form_DSNhanVien();
            //    fNV.Show();
            //    fNV.BringToFront();
            //}
            //Form_DSNhanVien fNV = new Form_DSNhanVien();
            //fNV.Show();
            //fNV.BringToFront();
            userControl_Employee1.Show();
            userControl_Employee1.BringToFront();

        }

        private void mnuWarehouse_Click(object sender, EventArgs e)
        {
            Refresh();
            if (Const.TypeOfAcc == "IncompleteAuthority")
            {
                MessageBox.Show("Bạn không được quyền truy cập");
            }
            else
            {
                userControlWareHousecs2.Show();
                userControlWareHousecs2.BringToFront();
            }

        }

        private void mnuOrders_Click(object sender, EventArgs e)
        {
            addNewOrder2.Show();
            addNewOrder2.BringToFront();
        }

        private void mnuSystem_Click(object sender, EventArgs e)
        {
        }
    }
}

