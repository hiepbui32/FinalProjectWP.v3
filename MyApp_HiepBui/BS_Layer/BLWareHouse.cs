using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyApp_HiepBui.DB_Layer;

namespace MyApp_HiepBui.BS_Layer
{
    internal class BLWareHouse
    {
        DBMain db;
        string err;
        public BLWareHouse()
        {
            db = new DBMain();
        }
        public DataSet CheckInventory()
        {
            string str = "SELECT * FROM v_Status_Of_WareHouse ";
            return db.ExecuteQueryDataSet(str, CommandType.Text);
        }
        public DataTable GetTypeOfItem()
        {
            string str = "SELECT NameTypeOfItem FROM TYPE_OF_ITEM";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public DataTable GetNameOfSupplier()
        {
            string str = "SELECT NameOfSupplier FROM SUPPLIER";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public bool AddNewItem(string name, int price, DateTime dateTime, string type, string supplier,
            int quantity, ref string err)
        {
            string str = "AddNewItem";
            var comm = db.new_comm(str);
            comm.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            comm.Parameters.Add("@Price", SqlDbType.Int).Value = price;
            comm.Parameters.Add("@MFGDate", SqlDbType.Date).Value = dateTime;
            comm.Parameters.Add("@Type", SqlDbType.NVarChar).Value = type;
            comm.Parameters.Add("@Supplier", SqlDbType.NVarChar).Value = supplier;
            comm.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
            return db.MyExecuteNonQuery(str, comm, CommandType.StoredProcedure, ref err);
        }
        public bool ModifyItem(string id, string name, int price, string type, string supplier, ref string err)
        {
            string str = "ModifyItem";
            var comm = db.new_comm(str);
            comm.Parameters.Add("@IDItem", SqlDbType.VarChar).Value = id;
            comm.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            comm.Parameters.Add("@Price", SqlDbType.Int).Value = price;
            comm.Parameters.Add("@Type", SqlDbType.NVarChar).Value = type;
            comm.Parameters.Add("@Supplier", SqlDbType.NVarChar).Value = supplier;
            return db.MyExecuteNonQuery(str, comm, CommandType.StoredProcedure, ref err);
        }
        public DataSet SearchInfo(string content, string category)
        {
            string str;
            if(category == "ID Item")
            {
                str = $"SELECT * FROM dbo.v_Status_Of_WareHouse " +
                    $"WHERE IDItem LIKE '%{content}%'";
                return db.ExecuteQueryDataSet(str, CommandType.Text);

            }
            if(category == "Name")
            {
                str = $"SELECT * FROM dbo.v_Status_Of_WareHouse " +
                    $"WHERE NameItem LIKE '%{content}%'";
                return db.ExecuteQueryDataSet(str, CommandType.Text);
            }
            if(category == "Type")
            {
                
                str = $"SELECT * FROM dbo.v_Status_Of_WareHouse " +
                    $"WHERE Type LIKE '%{content}%'";
                return db.ExecuteQueryDataSet(str, CommandType.Text);
            }
            if (category == "Supplier")
            {
                str = $"SELECT * FROM dbo.v_Status_Of_WareHouse " +
                    $"WHERE NameOfSupplier LIKE '%{content}%'";
                return db.ExecuteQueryDataSet(str, CommandType.Text);
            }
            return null;
        }

        public int GetTotalItemInInventory()
        {
            string str = "SELECT SUM(NumberOfItem) FROM WAREHOUSE";
            return db.MyExecuteDataReader(str,ref err);
        }

        public int GetGoodsNeedImported()
        {
            string str = "SELECT COUNT(ITEMS.IDItem) FROM WAREHOUSE, ITEMS " +
                "WHERE WAREHOUSE.IDItem = ITEMS.IDItem and NumberOfItem < 20";
            return db.MyExecuteDataReader(str, ref err);
        }
        public int GetGoodsImportedThisMonth()
        {
            string str =   "SELECT SUM(NumberOfItem) FROM WAREHOUSE, ITEMS " +
                           "WHERE WAREHOUSE.IDItem = ITEMS.IDItem and " +
                           "DATEDIFF(MONTH, GETDATE(), ProductionDate) = 0 AND " +
                           "DATEDIFF(YEAR, GETDATE(), ProductionDate) = 0";
            return db.MyExecuteDataReader(str, ref err);
        }
        public int GetMonthlySpending()
        {
            string str = "  SELECT SUM(ITEMS.Price * WAREHOUSE.NumberOfItem) " +
                "FROM ITEMS, WAREHOUSE " +
                "WHERE ITEMS.IDItem = WAREHOUSE.IDItem AND " +
                "DATEDIFF(MONTH, GETDATE(), ProductionDate) = 0 AND " +
                "DATEDIFF(YEAR, GETDATE(), ProductionDate) = 0";
            return db.MyExecuteDataReader(str, ref err);
        }
        public DataSet GetDataPieChart()
        {
            string str = "SELECT TYPE_OF_ITEM.NameTypeOfItem, SUM(WAREHOUSE.NumberOfItem) AS Quantity " +
                "FROM ITEMS, WAREHOUSE, TYPE_OF_ITEM " +
                "WHERE ITEMS.IDItem = WAREHOUSE.IDItem AND ITEMS.IDType = TYPE_OF_ITEM.IDType " +
                "GROUP BY TYPE_OF_ITEM.NameTypeOfItem";
            return db.ExecuteQueryDataSet(str, CommandType.Text);
        }


        public DataSet GetMonthlySpendingAllTime()
        {
            string str = "SELECT YEAR(ProductionDate) AS Year, MONTH(ProductionDate) AS Month, SUM(ITEMS.Price * WAREHOUSE.NumberOfItem) AS MonthlySpending " +
                "FROM ITEMS, WAREHOUSE " +
                "WHERE DATEDIFF(YEAR, GETDATE(), ProductionDate) = 0 " +
                "GROUP BY YEAR(ProductionDate), MONTH(ProductionDate) " +
                "ORDER BY YEAR(ProductionDate) DESC, MONTH(ProductionDate) DESC";
            return db.ExecuteQueryDataSet(str, CommandType.Text);
        }
    }
}
