using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using MyApp_HiepBui.DB_Layer;

namespace MyApp_HiepBui.BS_Layer
{
    public class BLOrder
    {
        DBMain dB = null;
        string err;
        public BLOrder()
        {
            dB = new DBMain();
        }
        public DataSet GetInfo_ORDERS()
        {
            return dB.ExecuteQueryDataSet("select * from ORDERS", CommandType.Text);
        }
        public DataSet GetInfo_ITEMS()
        {
            return dB.ExecuteQueryDataSet("select IDItem, NameItem, Price AS UnitPrice from ITEMS", CommandType.Text);
        }
        public DataSet GetInfo_ITEM_IN_ORDER()
        {
            return dB.ExecuteQueryDataSet("select * from ITEM_IN_ORDER", CommandType.Text);
        }
        public DataSet GetInfo_CUSTOMERS()
        {
            return dB.ExecuteQueryDataSet("select * from CUSTOMERS", CommandType.Text);
        }
        public DataSet GetInfo_EMPLOYEES()
        {
            return dB.ExecuteQueryDataSet("select * from EMPLOYEES", CommandType.Text);
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }
        public bool LoadDataForOrder(string IDOrder, ref string error)
        {
            string sql;
            sql = "SELECT ITEMS.IDItem, ITEMS.NameItem, ITEMS.Price, ITEM_IN_ORDER.NumberItem AS Quantity, ORDERS.TotalPrice = ITEM_IN_ORDER.Quantity * ITEMS.Price " +
                "from ITEMS, ITEM_IN_ORDER, ORDERS " +
                "where ITEMS.IDItem=ITEM_IN_ORDER.IDItem and ITEM_IN_ORDER.IDOrder = N'" + IDOrder +"'";
            return dB.MyExecuteNonQuery(IDOrder, CommandType.Text, ref error);

        }

        public DataTable GetNameOfItem()
        {
            string str = "SELECT IDItem, NameItem, Price FROM ITEMS ";
            return dB.ExecuteQueryDataTable(str, CommandType.Text);


        }
        public DataTable GetPhoneOfCus()
        {
            string str = "SELECT Phone FROM CUSTOMERS ";
            return dB.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public string TakeNameCus(string phone)
        {
            string str = $"SELECT Name FROM CUSTOMERS WHERE PHONE = '{phone}'";
            return dB.MyExecuteDataReaderString(str, ref err);
        }

        //public DataTable SearchingInfo(string content, string category)
        //{
        //    string str = "";
        //    if (category == "Phone")
        //    {
        //        str = $"SELECT ORDERS.IDOrder AS [ID Order], Name AS [Name customer], ORDERS.TotalPrice AS [Total price], " +
        //            $"(SELECT SUM(WH.NumberOfItem) FROM WAREHOUSE WH WHERE WH.IDItem = WAREHOUSE.IDItem) AS[Total quantity], " +
        //            $"ORDERS.InvoiceDay AS[Day transaction] " +
        //            $"FROM WAREHOUSE, ORDERS, CUSTOMERS, ITEMS, ITEM_IN_ORDER " +
        //            $"WHERE ITEMS.IDItem = WAREHOUSE.IDItem AND ORDERS.IDCustomer = CUSTOMERS.IDCustomer AND " +
        //            $"ORDERS.IDOrder = ITEM_IN_ORDER.IDOrder AND ITEM_IN_ORDER.IDItem = ITEMS.IDItem " +
        //            $"AND CUSTOMERS.Phone = '{content}'";
        //    }
        //    else if (category == "Name")
        //    {
        //        str = $"SELECT ORDERS.IDOrder AS [ID Order], Name AS [Name customer], ORDERS.TotalPrice AS [Total price], " +
        //            $"(SELECT SUM(WH.NumberOfItem) FROM WAREHOUSE WH WHERE WH.IDItem = WAREHOUSE.IDItem) AS[Total quantity], " +
        //            $"ORDERS.InvoiceDay AS[Day transaction] " +
        //            $"FROM WAREHOUSE, ORDERS, CUSTOMERS, ITEMS, ITEM_IN_ORDER " +
        //            $"WHERE ITEMS.IDItem = WAREHOUSE.IDItem AND ORDERS.IDCustomer = CUSTOMERS.IDCustomer AND " +
        //            $"ORDERS.IDOrder = ITEM_IN_ORDER.IDOrder AND ITEM_IN_ORDER.IDItem = ITEMS.IDItem " +
        //            $"AND CUSTOMERS.Name = N'{content}'";

        //    }
        //    var tb = dB.ExecuteQueryDataTable(str, CommandType.Text);
        //    if (tb.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    return tb;
        //}
        public DataTable SearchingInfo(string content, string category)
        {
            try
            {
                string str = "";
                if (category == "Phone")
                {
                    str = $"SELECT ORDERS.IDOrder AS [ID Order], Name AS [Name customer], ORDERS.TotalPrice AS [Total price], " +
                        $"(SELECT SUM(WH.NumberOfItem) FROM WAREHOUSE WH WHERE WH.IDItem = WAREHOUSE.IDItem) AS[Total quantity], " +
                        $"ORDERS.InvoiceDay AS[Day transaction] " +
                        $"FROM WAREHOUSE, ORDERS, CUSTOMERS, ITEMS, ITEM_IN_ORDER " +
                        $"WHERE ITEMS.IDItem = WAREHOUSE.IDItem AND ORDERS.IDCustomer = CUSTOMERS.IDCustomer AND " +
                        $"ORDERS.IDOrder = ITEM_IN_ORDER.IDOrder AND ITEM_IN_ORDER.IDItem = ITEMS.IDItem " +
                        $"AND CUSTOMERS.Phone = '{content}'";
                }
                else if (category == "Name")
                {
                    str = $"SELECT ORDERS.IDOrder AS [ID Order], Name AS [Name customer], ORDERS.TotalPrice AS [Total price], " +
                        $"(SELECT SUM(WH.NumberOfItem) FROM WAREHOUSE WH WHERE WH.IDItem = WAREHOUSE.IDItem) AS[Total quantity], " +
                        $"ORDERS.InvoiceDay AS[Day transaction] " +
                        $"FROM WAREHOUSE, ORDERS, CUSTOMERS, ITEMS, ITEM_IN_ORDER " +
                        $"WHERE ITEMS.IDItem = WAREHOUSE.IDItem AND ORDERS.IDCustomer = CUSTOMERS.IDCustomer AND " +
                        $"ORDERS.IDOrder = ITEM_IN_ORDER.IDOrder AND ITEM_IN_ORDER.IDItem = ITEMS.IDItem " +
                        $"AND CUSTOMERS.Name = N'{content}'";

                }
                var tb = dB.ExecuteQueryDataTable(str, CommandType.Text);
                if (tb.Rows.Count == 0)
                {
                    throw new Exception("No results found");
                }
                return tb;
            }
            catch (Exception ex)
            {
                throw new Exception("Error while executing SQL query: " + ex.Message);
            }
        }

        public string GetNewIDOrder()
        {
            //string str = "SELECT dbo.AutoGenerateIDOrder() ";
            return dB.ExecuteScalar("SELECT dbo.AutoGenerateIDOrder() ", ref err);
        }
        public int GetOrdersInMonth()
        {
            string str = "SELECT COUNT(*) FROM ORDERS WHERE MONTH(GETDATE()) - MONTH(ORDERS.InvoiceDay) = 0 AND YEAR(GETDATE()) - YEAR(ORDERS.InvoiceDay) = 0 ";
            return dB.MyExecuteDataReader(str, ref err);
        }
        public int GetCustomerVisitedThisMonth()
        {
            string str = "SELECT COUNT(*) FROM ORDERS, CUSTOMERS WHERE MONTH(GETDATE()) - MONTH(ORDERS.InvoiceDay) = 0 AND YEAR(GETDATE()) - YEAR(ORDERS.InvoiceDay) = 0 " +
                "AND ORDERS.IDCustomer = CUSTOMERS.IDCustomer ";
            return dB.MyExecuteDataReader(str, ref err);

        }
        public int GetWeeklyRevenue()
        {
            string str = "SELECT SUM(ORDERS.TotalPrice) FROM ORDERS WHERE MONTH(GETDATE()) -MONTH(ORDERS.InvoiceDay) = 0 AND YEAR(GETDATE()) -YEAR(ORDERS.InvoiceDay) = 0 AND DAY(GETDATE()) - DAY(ORDERS.InvoiceDay) <= 7";
            return dB.MyExecuteDataReader(str, ref err);
        }
        public int GetMonthlyRevenue()
        {
            string str = "SELECT SUM(ORDERS.TotalPrice) FROM ORDERS WHERE MONTH(GETDATE()) -MONTH(ORDERS.InvoiceDay) = 0 AND YEAR(GETDATE()) -YEAR(ORDERS.InvoiceDay) = 0";
            return dB.MyExecuteDataReader(str, ref err);
        }
        public DataSet GetRevenueByYear()
        {
            string str = "SELECT YEAR(InvoiceDay) AS Year, MONTH(InvoiceDay) AS Month, SUM(TotalPrice) AS Revenue " +
                "FROM ORDERS GROUP BY YEAR(InvoiceDay), MONTH(InvoiceDay) ORDER BY YEAR(InvoiceDay) DESC, MONTH(InvoiceDay) DESC ";
            return dB.ExecuteQueryDataSet(str, CommandType.Text);
        }

        public bool AddNewOrder(string idOrder, string phone, string idItem, int quantity)
        {
            string str = "AddNewOrder";
            var comm = dB.new_comm(str);
            comm.Parameters.Add("@IDOrder", SqlDbType.VarChar).Value = idOrder;
            comm.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
            comm.Parameters.Add("@IDItem", SqlDbType.VarChar).Value = idItem;
            comm.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            return dB.MyExecuteNonQuery(str, comm, CommandType.StoredProcedure, ref err);
        }
        public bool CreateNewOrder(string idOrder, string phone)
        {
            string str = "CreateNewOrder";
            var comm = dB.new_comm(str);
            comm.Parameters.Add("@NewIDOrder", SqlDbType.VarChar).Value = idOrder;
            comm.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;

            return dB.MyExecuteNonQuery(str, comm, CommandType.StoredProcedure, ref err);
        }
        public DataSet GetAllOrders()
        {
            string str = "SELECT * FROM v_Order_Detail ";
            return dB.ExecuteQueryDataSet(str, CommandType.Text);
        }
        
        
    }
}
