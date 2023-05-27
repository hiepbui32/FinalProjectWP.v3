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
    public partial class frm_Statistic : Form
    {
        BLWareHouse blwarehouse;
        DataTable dt;
        public frm_Statistic()
        {
            InitializeComponent();
            blwarehouse = new BLWareHouse();
        }

        private void LoadLineChart()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = blwarehouse.GetMonthlySpendingAllTime();
            dt = ds.Tables[0];

            linechart.Titles.Add("Line Chart");
            //linechart.Series["Series2"].IsValueShownAsLabel = true;
            foreach (DataRow row in dt.Rows)
            {
                int month = Convert.ToInt32(row["Month"]);
                int money = Convert.ToInt32(row["MonthlySpending"]) / 1000;
                linechart.Series["Series2"].Points.AddXY(month, money);

            }
            linechart.ChartAreas[0].AxisX.Title = "Month";
            linechart.ChartAreas[0].AxisY.Title = "Money (k)";
        }

        private void LoadPieChart()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = blwarehouse.GetDataPieChart();
            dt = ds.Tables[0];

            piechart.Titles.Add("Pie Chart");
            piechart.Series["Series1"].IsValueShownAsLabel = true;
            foreach (DataRow row in dt.Rows)
            {
                piechart.Series["Series1"].Points.AddXY(row["NameTypeOfItem"], row["Quantity"]);

            }


        }

        private void frm_Statistic_Load(object sender, EventArgs e)
        {
            int quantity;
            quantity = blwarehouse.GetTotalItemInInventory();
            lbResultQuantity.Text = quantity.ToString();
            int goodsNeedImported;
            goodsNeedImported = blwarehouse.GetGoodsNeedImported();
            lbResultItemsNeedImport.Text = goodsNeedImported.ToString();
            int goodsImportedThisMonth = blwarehouse.GetGoodsImportedThisMonth();
            lbResultGoodsImported.Text = goodsImportedThisMonth.ToString();
            int monthlySpending = blwarehouse.GetMonthlySpending();
            var moneySpending = String.Format("{0:C}", monthlySpending);
            lbMonthlySpending.Text = moneySpending;



            LoadPieChart();
            LoadLineChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact to members in Group 3 to more details", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
