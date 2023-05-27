using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyApp_HiepBui.DB_Layer;
namespace MyApp_HiepBui.BS_Layer
{
     class BLCustomers
    {
        DBMain db = null;
        public BLCustomers()
        {
            db=new DBMain();
        }

        
        public DataSet GetInfo_KhachHang()
        {
            return db.ExecuteQueryDataSet("Select * from [v_Info_Of_Customers]", CommandType.Text);
        }
        public bool addCustomer(string Name, string Phone, string OpeningDate, string TransactionDate, int AccumulatedPoint, ref string error)
        {
            string IdCus;
            double val =0;
            int index = db.AutoNumber();
            index++;
            if (index==99) 
            {
                val++;
                index = 0;
            }
            IdCus = "CU" + val + index;
            string sqlQuery = "EXEC dbo.USP_AddCustomer '"+IdCus+"', "+"N'"+Name+"', "+"'"+Phone+"', " + "'" + OpeningDate + "', " + "'" + TransactionDate + "', "+"'" + AccumulatedPoint + "'";
            return db.MyExecuteNonQuery(sqlQuery, CommandType.Text, ref error);
        }
        public DataTable searchCustomer(string Phone, string Name)
        {
            //string sqlQuery = "Select * from [v_Info_Of_Customers] Where Phone = '" + Phone + "'";
            //return db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            try
            {
                string sqlQuery = "Select * from [v_Info_Of_Customers] Where Phone = '" + Phone + "'";
                var tb = db.ExecuteQueryDataTable(sqlQuery, CommandType.Text);
                if (tb.Rows.Count == 0)
                {
                    throw new Exception("No results found");
                }
                return tb;
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message to the user
                Console.WriteLine($"An error occurred while executing the query: {ex.Message}");
                return null;
            }
        }
        public bool delCustomer(string IDCustomer, ref string error)
        {
            string sqlQuery = "DELETE from CUSTOMERS Where IDCustomer = '" + IDCustomer+"'";
            return db.MyExecuteNonQuery(sqlQuery, CommandType.Text, ref error);
        }
        public bool modifyCustomer(string IDCustomer,string Name, string Phone, string OpeningDate, string TransactionDate, int AccumulatedPoint, ref string error) {
            string sqlQuery = "EXEC dbo.USP_Update_InfoCustomer '" + IDCustomer + "', " + "N'" + Name + "', " + "'" + Phone + "', " + "'" + OpeningDate + "', " + "'" + TransactionDate + "', " + "'" + AccumulatedPoint + "'";
            return db.MyExecuteNonQuery(sqlQuery, CommandType.Text, ref error);
        }
        public int analyseCustomer(int Month_of_OpeningDate,ref string error)
        {
            return db.Number_for_Analyse(Month_of_OpeningDate);
        }
    }
}
