using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomerResturant.Controllers
{
    public class BasicMethods
    {
        static CustomerResturantDB Context = new CustomerResturantDB();
        SqlConnection con = new SqlConnection(Context.Database.Connection.ConnectionString);
        SqlDataAdapter da = new SqlDataAdapter();

        public int val(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool ExecuteNonQuery(String sqlstatment)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.Text;
                MyCmd.CommandText = sqlstatment;

                MyCmd.ExecuteNonQuery();
                MyCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool ExecuteNonQuery(String StoredName, string[] ParaName, string[] ParaValue)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.StoredProcedure;
                MyCmd.CommandText = StoredName;

                for (int i = 0; i < ParaName.Length; i++)
                {
                    MyCmd.Parameters.Add("@" + ParaName[i], SqlDbType.VarChar);
                    MyCmd.Parameters["@" + ParaName[i]].Value = ParaValue[i];
                }

                MyCmd.ExecuteNonQuery();
                MyCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public string ExecuteScalar(String sqlstatment)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.Text;
                MyCmd.CommandText = sqlstatment;

                string s = MyCmd.ExecuteScalar().ToString().Trim();
                MyCmd.Connection.Close();
                return s;
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public string ExecuteScalar(String StoredName, string[] ParaName, string[] ParaValue)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.StoredProcedure;
                MyCmd.CommandText = StoredName;

                for (int i = 0; i < ParaName.Length; i++)
                {
                    MyCmd.Parameters.Add("@" + ParaName[i], SqlDbType.VarChar);
                    MyCmd.Parameters["@" + ParaName[i]].Value = ParaValue[i];
                }

                string s = MyCmd.ExecuteScalar().ToString().Trim();
                MyCmd.Connection.Close();
                return s;
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public string ExecuteScalar(String StoredName, string[] ParaName, Object[] ParaValue, SqlDbType[] ParaType)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.StoredProcedure;
                MyCmd.CommandText = StoredName;

                for (int i = 0; i < ParaName.Length; i++)
                {
                    MyCmd.Parameters.Add("@" + ParaName[i], ParaType[i]);
                    MyCmd.Parameters["@" + ParaName[i]].Value = ParaValue[i];
                }

                string s = MyCmd.ExecuteScalar().ToString().Trim();
                MyCmd.Connection.Close();
                return s;
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public DataTable ExecuteAdapter(String sqlstatment)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                DataTable dt = new DataTable("Tbl");
                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.Text;
                MyCmd.CommandText = sqlstatment;
                da.SelectCommand = MyCmd;
                da.Fill(dt);
                MyCmd.Connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }

        public DataTable ExecuteAdapter(String StoredName, string[] ParaName, string[] ParaValue)
        {
            SqlConnection c = new SqlConnection(con.ConnectionString);
            try
            {
                SqlCommand MyCmd = c.CreateCommand();
                if (MyCmd.Connection.State == ConnectionState.Closed)
                {
                    MyCmd.Connection.Open();
                }

                DataTable dt = new DataTable("Tbl");
                MyCmd.CommandTimeout = 72000000;
                MyCmd.Parameters.Clear();
                MyCmd.CommandType = CommandType.StoredProcedure;
                MyCmd.CommandText = StoredName;

                for (int i = 0; i < ParaName.Length; i++)
                {
                    MyCmd.Parameters.Add("@" + ParaName[i], SqlDbType.VarChar);
                    MyCmd.Parameters["@" + ParaName[i]].Value = ParaValue[i];
                }

                da.SelectCommand = MyCmd;
                da.Fill(dt);
                MyCmd.Connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }

    }
}