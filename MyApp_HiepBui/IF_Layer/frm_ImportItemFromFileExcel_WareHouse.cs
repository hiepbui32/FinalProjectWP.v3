using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyApp_HiepBui.BS_Layer;
using MyApp_HiepBui.DB_Layer;
using System.Globalization;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class frm_ImportItemFromFileExcel_WareHouse : Form
    {
        string err;
        BLWareHouse blwarehouse;
        public frm_ImportItemFromFileExcel_WareHouse()
        {
            InitializeComponent();
            blwarehouse = new BLWareHouse();
        }
        private void btnImportFile_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;


            int xlRow;
            string strFileName;
            openFD.Filter = "Excel Office |*xls; *xlsx";
            openFD.ShowDialog();
            strFileName = openFD.FileName;
            txtSource.Text = strFileName;
            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;
                int i = 0;
                for (xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    if (xlRange.Cells[xlRow, 1].Text != "")
                    {
                        i++;
                        dgvDataExcel.Rows.Add(i, xlRange.Cells[xlRow, 1].Text,
                                                xlRange.Cells[xlRow, 2].Text,
                                                xlRange.Cells[xlRow, 3].Text,
                                                xlRange.Cells[xlRow, 4].Text,
                                                xlRange.Cells[xlRow, 5].Text,
                                                xlRange.Cells[xlRow, 6].Text);
                    }
                }
                xlWorkbook.Close();
                xlApp.Quit();

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                int price;
                string date;
                DateTime dateTime;
                string type;
                string supplier;
                int quantity;
                int temp = dgvDataExcel.Rows.Count;
                for (int i = 0; i < dgvDataExcel.Rows.Count - 1; i++)
                {
                    name = dgvDataExcel.Rows[i].Cells[1].Value.ToString();
                    price = Int32.Parse(dgvDataExcel.Rows[i].Cells[2].Value.ToString());
                    quantity = Int32.Parse(dgvDataExcel.Rows[i].Cells[3].Value.ToString());
                    date = dgvDataExcel.Rows[i].Cells[4].Value.ToString();

                    type = dgvDataExcel.Rows[i].Cells[5].Value.ToString();
                    supplier = dgvDataExcel.Rows[i].Cells[6].Value.ToString();

                    dateTime = DateTime.ParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture);
                    blwarehouse.AddNewItem(name, price, dateTime, type, supplier, quantity, ref err);
                }
                MessageBox.Show("Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Something happened, try again!");
            }



        }

        private void frm_ImportItemFromFileExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
