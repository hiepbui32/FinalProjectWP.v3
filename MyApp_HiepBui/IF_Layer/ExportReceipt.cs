using Microsoft.Reporting.WebForms;
using MyApp_HiepBui.DB_Layer;
using MyApp_HiepBui.ItemsInOrderTableAdapters;
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
    public partial class ExportReceipt : Form
    {
        DBMain db;
        string IDCus;
        public ExportReceipt(string iDCus)
        {
            InitializeComponent();
            IDCus = iDCus;
        }

        private void ExportReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsInOrder.v_Order_Detail' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void ExportOrder(string idCus)
        {
            SqlConnection connection = new SqlConnection("Data Source=HIEPBUI2812\\SQLEXPRESS;Initial Catalog=ConvenienceStoreManagement(new);Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from [v_Order_Detail_For_Export] where [ID Order] = '" + idCus + "' ",connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
           
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource source = new Microsoft.Reporting.WinForms.ReportDataSource("ItemsInOrder", dt);
            reportViewer1.LocalReport.ReportPath = "D:\\NAM 2_ Ky 2\\LT_WinDows\\Do_An\\FinalProject\\FinalProjectWP.v1\\MyApp_HiepBui\\IF_Layer\\ExportOrder.rdlc"; //vo folder da tai ve, copy path cua folder roi paste truoc ExportOrder.rdlc
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ExportOrder(IDCus);
        }
    }
}
