using MyApp_HiepBui.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class frm_ImportExcelCustomer : Form
    {
        string err;
        public frm_ImportExcelCustomer()
        {
            InitializeComponent();
        }

        private void btn_ImportExcelCustomer_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFD.Filter = "Excel Office | *.xls; *.xlsx";
            openFD.ShowDialog();
            txt_FileAdddress.Text = openFD.FileName;
            strFileName = openFD.FileName;

            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = xlWorkBook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;
                int i = 0;

                for (xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    dgv_ImportCustomer.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text);
                    i++;
                }
                xlWorkBook.Close();
                xlApp.Quit();
            }
        }

        private void txt_FileAdddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_ImportCustomer.Rows.Count; i++)
            {
                if (dgv_ImportCustomer.Rows[i].Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("Import file succeed!!!");
                    return;
                }
                string Name_of_Customer = dgv_ImportCustomer.Rows[i].Cells[0].Value.ToString();
                string Phone = '0' + dgv_ImportCustomer.Rows[i].Cells[1].Value.ToString();
                DateTime OpeningDate = Convert.ToDateTime(this.dgv_ImportCustomer.Rows[i].Cells[2].Value.ToString());
                DateTime LatestTransaction = Convert.ToDateTime(this.dgv_ImportCustomer.Rows[i].Cells[3].Value.ToString());
                int Accumulated_Point = int.Parse(dgv_ImportCustomer.Rows[i].Cells[4].Value.ToString());
                BLCustomers bLCustomers = new BLCustomers();
                bLCustomers.addCustomer(Name_of_Customer, Phone, OpeningDate.ToString("MM-dd-yyyy"), LatestTransaction.ToString("MM-dd-yyyy"), Accumulated_Point, ref err);
            }
        }
    }
}
