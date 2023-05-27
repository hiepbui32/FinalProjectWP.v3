using MyApp_HiepBui.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp_HiepBui.IF_Layer
{
    public partial class frm_CustomerChart : UserControl
    {
        string err;
        public frm_CustomerChart()
        {
            InitializeComponent();
        }

        private void frm_CustomerChart_Load(object sender, EventArgs e)
        {
            BLCustomers bLCustomers = new BLCustomers();
            chartCustomer.Series["Number of Members"].Points.AddXY("January", bLCustomers.analyseCustomer(1, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("February", bLCustomers.analyseCustomer(2, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("March", bLCustomers.analyseCustomer(3, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("April", bLCustomers.analyseCustomer(4, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("May", bLCustomers.analyseCustomer(5, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("June", bLCustomers.analyseCustomer(6, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("July", bLCustomers.analyseCustomer(7, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("August", bLCustomers.analyseCustomer(8, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("September", bLCustomers.analyseCustomer(9, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("October", bLCustomers.analyseCustomer(10, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("November", bLCustomers.analyseCustomer(11, ref err));
            chartCustomer.Series["Number of Members"].Points.AddXY("December", bLCustomers.analyseCustomer(12, ref err));
        }
    }
}
