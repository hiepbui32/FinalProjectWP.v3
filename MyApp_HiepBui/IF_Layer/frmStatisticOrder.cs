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
    public partial class frmStatisticOrder : Form
    {
        DataTable dt;
        BLOrder blOrder;
        public frmStatisticOrder()
        {
            InitializeComponent();
            blOrder = new BLOrder();
            dt = new DataTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoadLineChart()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = blOrder.GetRevenueByYear();
            dt = ds.Tables[0];

            lineChart.Titles.Add("Line Chart");
            //linechart.Series["Series2"].IsValueShownAsLabel = true;
            foreach (DataRow row in dt.Rows)
            {
                int month = Convert.ToInt32(row["Month"]);
                int money = Convert.ToInt32(row["Revenue"]) / 1000;
                lineChart.Series["Series1"].Points.AddXY(month, money);

            }
            lineChart.ChartAreas[0].AxisX.Title = "Month";
            lineChart.ChartAreas[0].AxisY.Title = "Money (k)";
        }


        private void frmStatisticOrder_Load(object sender, EventArgs e)
        {
            lbResultOrdersThisMonth.Text = blOrder.GetOrdersInMonth().ToString();
            lbCusVisited.Text = blOrder.GetCustomerVisitedThisMonth().ToString();

            int weeklySpending = blOrder.GetMonthlyRevenue();
            var moneySpendingweek = String.Format("{0:C}", weeklySpending);

            lbWeeklyRevenue.Text = moneySpendingweek;
            int monthlySpending = blOrder.GetMonthlyRevenue();
            var moneySpending = String.Format("{0:C}", monthlySpending);
            lbMonthlyRevenue.Text = moneySpending;

            LoadLineChart();

        }
    }
}
