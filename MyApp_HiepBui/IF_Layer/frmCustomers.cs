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
using System.Xml.Serialization;
using System.Windows.Forms;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class frmCustomers : UserControl
    {

        string connstr = "Data Source=HIEPBUI2812\\SQLEXPRESS;Initial Catalog=ConvenienceStoreManagement(new);Integrated Security=True";


        //string connstr = @"Data Source=Hoangpro\HOANGPRO;Initial Catalog=ConvenienceStoreManagement;Integrated Security=True";


        string err;
        string IDCustomer;
        DataTable dtKhahcHang = null;
        BLCustomers dbKH = new BLCustomers();
        bool Add = false;
        bool Modify = false;
        bool Search = false;
        bool Delete = false;
        public frmCustomers()
        {
            InitializeComponent();
        }
        void loadDataCustomer()
        {
            try
            {
                dtKhahcHang = new DataTable();
                dtKhahcHang.Clear();
                DataSet ds = dbKH.GetInfo_KhachHang();
                dtKhahcHang = ds.Tables[0];
                dgv_Customer.DataSource = dtKhahcHang;
                dgv_Customer.AutoResizeColumns();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        void Refresh()
        {
            loadDataCustomer();
            frm_CustomerChart1.Update();
            frm_CustomerChart1.Hide();
            this.txt_AccumulatedPoint.ResetText();
            this.txt_Name_of_Customer.ResetText();
            this.txt_Phone.ResetText();
            this.dpk_LatestTransaction.ResetText();
            this.dpk_Oppeningdate.ResetText();
            this.txt_AccumulatedPoint.Enabled = false;
            this.txt_Phone.Enabled = false;
            this.txt_Name_of_Customer.Enabled = false;
            this.dpk_Oppeningdate.Enabled = false;
            this.dpk_LatestTransaction.Enabled = false;
            Add = false;
            Search = false;
            Modify = false;
            Delete = false;
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            frm_CustomerChart1.Hide();
            loadDataCustomer();
            this.txt_AccumulatedPoint.Enabled = false;
            this.txt_Phone.Enabled = false;
            this.txt_Name_of_Customer.Enabled = false;
            this.dpk_Oppeningdate.Enabled = false;
            this.dpk_LatestTransaction.Enabled = false;
            Textbox_PhoneLoad();

        }
        public void Textbox_PhoneLoad()
        {
            SqlConnection conn = new SqlConnection(connstr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Phone from CUSTOMERS", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr["Phone"].ToString());
            }
            txt_Phone.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Phone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Phone.AutoCompleteCustomSource = collection;
            dr.Close();
            conn.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Refresh();
            this.txt_Phone.Enabled = true;
            this.txt_Phone.Focus();
            Search = true;

        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            loadDataCustomer();
            Refresh();
            this.txt_AccumulatedPoint.Enabled = true;
            this.txt_Phone.Enabled = true;
            this.txt_Name_of_Customer.Enabled = true;
            this.dpk_Oppeningdate.Enabled = true;
            this.dpk_LatestTransaction.Enabled = true;
            this.txt_Phone.Focus();
            Add = true;
        }

        private void btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            DateTime OpeningDate = Convert.ToDateTime(this.dpk_Oppeningdate.Text);
            DateTime LatestTransaction = Convert.ToDateTime(this.dpk_LatestTransaction.Text);
            if (Add)
            {
                try
                {

                    BLCustomers bLCustomers = new BLCustomers();
                    bLCustomers.addCustomer(this.txt_Name_of_Customer.Text, this.txt_Phone.Text, OpeningDate.ToString("MM-dd-yyyy"), LatestTransaction.ToString("MM-dd-yyyy"), int.Parse(this.txt_AccumulatedPoint.Text), ref err);
                    loadDataCustomer();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Cannot add Customer. Error!!!");
                }
            }
            else if (Modify)
            {
                try
                {
                    BLCustomers bLCustomers = new BLCustomers();
                    bLCustomers.modifyCustomer(IDCustomer, this.txt_Name_of_Customer.Text, this.txt_Phone.Text, OpeningDate.ToString("MM-dd-yyyy"), LatestTransaction.ToString("MM-dd-yyyy"), int.Parse(this.txt_AccumulatedPoint.Text), ref err);
                    loadDataCustomer();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Cannot modify Customer. Error!!!");
                }
            }
            Refresh();
            Add = false;

        }
        private void btn_delCustomer_Click(object sender, EventArgs e)
        {
            Delete = true;
            try
            {
                foreach (DataGridViewRow row in dgv_Customer.SelectedRows)
                {
                    BLCustomers bLCustomers = new BLCustomers();
                    bLCustomers.delCustomer(row.Cells[0].Value.ToString(), ref err);
                }
                loadDataCustomer();
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot delete Customer. Error!!!");
            }
        }

        private void btn_modifyCustomer_Click(object sender, EventArgs e)
        {

            Modify = true;
            this.txt_AccumulatedPoint.Enabled = true;
            this.txt_Phone.Enabled = true;
            this.txt_Name_of_Customer.Enabled = true;
            this.dpk_Oppeningdate.Enabled = true;
            this.dpk_LatestTransaction.Enabled = true;
            this.txt_Phone.Focus();


            int r = dgv_Customer.CurrentCell.RowIndex;
            IDCustomer = dgv_Customer.Rows[r].Cells[0].Value.ToString();
            this.txt_Name_of_Customer.Text = dgv_Customer.Rows[r].Cells[1].Value.ToString();
            this.txt_Phone.Text = dgv_Customer.Rows[r].Cells[2].Value.ToString();
            this.dpk_Oppeningdate.Text = dgv_Customer.Rows[r].Cells[3].Value.ToString();
            this.dpk_LatestTransaction.Text = dgv_Customer.Rows[r].Cells[4].Value.ToString();
            this.txt_AccumulatedPoint.Text = dgv_Customer.Rows[r].Cells[6].Value.ToString();


        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            frm_CustomerChart1.Show();
            frm_CustomerChart1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            frm_CustomerChart1.Update();
        }

        public void ExportFileCustomer(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "ID Customer";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Name of Customer";

            cl2.ColumnWidth = 27.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Phone";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Opening Date";

            cl4.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Latest Transaction";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Type of Customer";

            cl6.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Accumulated Point";

            cl7.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên


            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void bnt_Export_Click(object sender, EventArgs e)
        {
            DataTable dtCustomer = new DataTable();
            DataColumn col1 = new DataColumn();
            DataColumn col2 = new DataColumn();
            DataColumn col3 = new DataColumn();
            DataColumn col4 = new DataColumn();
            DataColumn col5 = new DataColumn();
            DataColumn col6 = new DataColumn();
            DataColumn col7 = new DataColumn();

            dtCustomer.Columns.Add(col1);
            dtCustomer.Columns.Add(col2);
            dtCustomer.Columns.Add(col3);
            dtCustomer.Columns.Add(col4);
            dtCustomer.Columns.Add(col5);
            dtCustomer.Columns.Add(col6);
            dtCustomer.Columns.Add(col7);

            foreach (DataGridViewRow dgvRow in dgv_Customer.Rows)
            {
                DataRow dtRow = dtCustomer.NewRow();
                dtRow[0] = dgvRow.Cells[0].Value;
                dtRow[1] = dgvRow.Cells[1].Value;
                dtRow[2] = dgvRow.Cells[2].Value;
                dtRow[3] = dgvRow.Cells[3].Value;
                dtRow[4] = dgvRow.Cells[4].Value;
                dtRow[5] = dgvRow.Cells[5].Value;
                dtRow[6] = dgvRow.Cells[6].Value;

                dtCustomer.Rows.Add(dtRow);
            }
            ExportFileCustomer(dtCustomer, "List Customer ", "LIST OF CUSTOMER");
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            frm_ImportExcelCustomer frm = new frm_ImportExcelCustomer();
            frm.Show();
        }


        private void txt_Phone_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Search == true)
                {
                    try
                    {
                        BLCustomers bLCustomers = new BLCustomers();
                        dtKhahcHang = new DataTable();
                        //DataSet ds = bLCustomers.searchCustomer(this.txt_Phone.Text, this.txt_Name_of_Customer.Text);
                        dtKhahcHang = bLCustomers.searchCustomer(this.txt_Phone.Text, this.txt_Name_of_Customer.Text);
                        if (dtKhahcHang == null)
                        {
                            throw new Exception("No data found.");
                            //MessageBox.Show("Không tìm thấy khách hàng!");
                        }
                        else
                        {
                            dgv_Customer.DataSource = dtKhahcHang;
                            dgv_Customer.AutoResizeColumns();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");

                    }
                }


            }

        }

        private void txt_AccumulatedPoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SaveCustomer_Click(sender, e);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
