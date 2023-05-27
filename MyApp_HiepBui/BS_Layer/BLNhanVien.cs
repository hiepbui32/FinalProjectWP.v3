using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyApp_HiepBui.DB_Layer;
namespace MyApp_HiepBui.BS_Layer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public BLNhanVien(string connstr)
        {
            db = new DBMain(connstr);
        }
        public DataSet Lay_DSNhanVien_DangLamViec()
        {
            return db.ExecuteQueryDataSet("select * from [Employees View]", CommandType.Text);
        }
        public DataSet Lay_DSNhanVien_Full()
        {
            return db.ExecuteQueryDataSet("select * from [EMPLOYEES]", CommandType.Text);
        }
        public DataSet Get_List_StatusEmp()
        {
            return db.ExecuteQueryDataSet("select IDEmp,Name, DateOfBirth, Address, Phone, Status_emp from [EMPLOYEES]", CommandType.Text);
        }
        public DataSet Get_List_Kind_Of_Employee()
        {
            return db.ExecuteQueryDataSet("select * from [KIND_OF_EMPLOYEE]", CommandType.Text);
        }
        public DataSet Get_List_Group_Of_Employee()
        {
            return db.ExecuteQueryDataSet("select * from [GROUP_OF_EMPLOYEE]", CommandType.Text);
        }
        public DataSet Get_List_Type_Of_User()
        {
            return db.ExecuteQueryDataSet("select * from [TYPE_OF_USER]", CommandType.Text);
        }
        public DataTable GetIDOfKindOfEmployee()
        {
            string str = "SELECT IDKindEmp FROM KIND_OF_EMPLOYEE";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public DataTable GetIDOfGroupOfEmployee()
        {
            string str = "SELECT IDGroup FROM GROUP_OF_EMPLOYEE";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public DataTable GetIDOfTypeOfUser()
        {
            string str = "SELECT IDTypeUser FROM TYPE_OF_USER";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public bool ThemNhanVien(string hoten, string ngaysinh, string diachi, string sdt,
                                    int tinhtrang, string idKindEmp, string idGroup, string idTypeUser, string idStore, ref string err)
        {
            string sqlString = "EXEC Add_Employee @name=N'"
                               + hoten + "', @dateofbirth=" +
                               "'" + ngaysinh + "', @address=" +
                               "N'" + diachi + "', @phone=" +
                               "'" + sdt +
                               "', @status_emp=" + tinhtrang + ",@idkindemp='" +
                               idKindEmp +
                               "',@idgroup= '" + idGroup +
                               "',@idtypeuser= '" + idTypeUser +
                               "',@idstore= '" + idStore + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaNhanVien(string id, string hoten, string ngaysinh, string diachi, string sdt,
                                    int tinhtrang, string idKindEmp, string idGroup, string idTypeUser, string idStore, ref string err)
        {
            string sqlString = "EXEC Edit_Employee @ide='"+id+"',@name=N'"
                               + hoten + "', @dateofbirth=" +
                               "'" + ngaysinh + "', @address=" +
                               "N'" + diachi + "', @phone=" +
                               "'" + sdt +
                               "', @status_emp=" + tinhtrang + ",@id_kind_emp='" +
                               idKindEmp +
                               "',@id_group= '" + idGroup +
                               "',@id_type_user= '" + idTypeUser +
                               "',@id_store= '" + idStore + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(string id, ref string err)
        {
            string sqlString = "DELETE FROM EMPLOYEES WHERE IDEmp='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        //public DataSet SearchInfo(string content)
        //{
        //    string str;
        //    str = $"SELECT * FROM dbo.[Employees View] " +
        //        $"WHERE Name LIKE N'%{content}%'";
        //    return db.ExecuteQueryDataSet(str, CommandType.Text);
        //}
        public DataTable SearchInfo(string content)
        {
            try
            {
                string str;
                str = $"SELECT * FROM dbo.[Employees View] " +
                    $"WHERE Name LIKE N'%{content}%'";
                //return db.ExecuteQueryDataSet(str, CommandType.Text);
                var tb = db.ExecuteQueryDataTable(str, CommandType.Text);
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


        public DataSet Salary_Of_Employee()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM dbo.[Salary_Of_Employee]", CommandType.Text);
        }
        public DataSet Account_Employee()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM dbo.[v_Account&Authority]", CommandType.Text);
        }
        public bool Add_Account_Emp(string id, string username, string password, ref string err)
        {
            string sqlString = "EXEC Add_Account @ide='"
                               + id + "', @username=" +
                               "'" + username + "', @password=" +
                               "'" + password +"'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Modify_Account_Emp(string id, string username, string password, ref string err)
        {
            string sqlString = "EXEC Edit_Account @ide='"
                               + id + "', @username=" +
                               "'" + username + "', @password=" +
                               "'" + password + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Add_Salary_Emp(string id, string totaltime, ref string err)
        {
            
            string sqlString = "EXEC Add_WorkingTime @ide='"
                               + id + "', @totaltime=" +
                               "'" + Convert.ToInt32(totaltime) + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Modify_Salary_Emp(string id, string totaltime, ref string err)
        {
            string sqlString = "EXEC Edit_WorkingTime @ide='"
                               + id + "', @totaltime=" +
                               "'" + Convert.ToInt32(totaltime) + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
