using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyApp_HiepBui.DB_Layer
{
    class DBMain
    {

        string connStr = "Data Source=HIEPBUI2812\\SQLEXPRESS;Initial Catalog=ConvenienceStoreManagement(new);Integrated Security=True";



        //string connStr = @"Data Source=Hoangpro\HOANGPRO;Initial Catalog=ConvenienceStoreManagement;Integrated Security=True";



        SqlConnection conn = null;
        SqlCommand  comm = null;
        SqlDataAdapter SqlAdapter= null;
        public DBMain() { 
            conn = new SqlConnection(connStr);
            comm = conn.CreateCommand();
        }
        public DBMain(string connstr)
        {
            conn = new SqlConnection(connStr);
            connStr = connstr;
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType commandType)
        {
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText =strSQL;
            comm.CommandType = commandType;
            SqlAdapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            SqlAdapter.Fill(ds);
            return ds;
        }

        public DataTable ExecuteQueryDataTable(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            SqlAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            SqlAdapter.Fill(dt);
            return dt;
        }
        public SqlCommand new_comm(string nameprocedure)
        {
            comm = new SqlCommand(nameprocedure, conn);
            comm.CommandType = CommandType.StoredProcedure;
            return comm;
        }
        public int MyExecuteDataReader(string strSQL, ref string error)
        {
            //bool f = false;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand command = new SqlCommand(strSQL, conn);
            SqlDataReader reader = command.ExecuteReader();
            int total = 0;
            //comm.CommandText = strSQL;
            //comm.CommandType = commandType;
            try
            {
                //command.ExecuteReader();
                //f = true;
                while (reader.Read())
                {
                    total = reader.GetInt32(0);
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally { conn.Close(); }
            return total;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType commandType, ref string error)
        {
            bool f = false;
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText =strSQL;
            comm.CommandType = commandType;
            try
            {
                comm.ExecuteNonQuery();
                f=true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally { conn.Close(); }
            return f;
        }
        public bool MyExecuteNonQuery(string strSQL, SqlCommand sqlcomm, CommandType commandType, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            sqlcomm.CommandText = strSQL;
            sqlcomm.CommandType = commandType;
            try
            {
                sqlcomm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally { conn.Close(); }
            return f;
        }
        public int AutoNumber()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand cmd= new SqlCommand("SELECT MAX(CAST(RIGHT(IDCustomer,2) AS INT)) FROM CUSTOMERS", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        public int Number_for_Analyse(int Month_of_OpeningDate)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string sqlQuery = "EXEC USP_AnalyseCustomer " + Month_of_OpeningDate;
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        public string ExecuteScalar(string strSQL, ref string error)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand command = new SqlCommand(strSQL, conn);
            object result = command.ExecuteScalar();

            conn.Close();
            return result.ToString();
        }
        public string MyExecuteDataReaderString(string strSQL, ref string error)
        {
            //bool f = false;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand command = new SqlCommand(strSQL, conn);
            SqlDataReader reader = command.ExecuteReader();
            string re = "";
            //comm.CommandText = strSQL;
            //comm.CommandType = commandType;
            try
            {
                //command.ExecuteReader();
                //f = true;
                while (reader.Read())
                {
                    re = reader.GetString(0);
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally { conn.Close(); }
            return re;
        }

    }
}
