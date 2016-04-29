using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AirlineTicket
{
    class DataAccess
    {
        public static SqlConnection conn;
        string strConnection = ConfigurationManager.ConnectionStrings["connection"].ToString();//读取配置文件连接信息

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataAccess()
        {
            conn = new SqlConnection(strConnection);
        }
        public bool ExcuteLogin(string sqlStr)
         {
             if (conn.State == ConnectionState.Closed)
             {
                 conn.Open();
                 SqlCommand cmd = new SqlCommand(sqlStr, conn);
                int num= cmd.ExecuteNonQuery();
                Object obj = cmd.ExecuteScalar();
                if (Convert.ToInt32(obj) == 0)
                {
                    return false;
                }
                 return true;
             }
             else
             {
                 return false;
             }
         }

        /// <summary>

        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool ExcuteSql(string sql)
        {
            int Rows = 0;

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                Rows = command.ExecuteNonQuery();

                if (Rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                string error = ex.ToString();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

     
        public DataTable GetDataSource(string Sql,string TableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, conn);
            DataTable table = new DataTable(TableName);

            adapter.Fill(table);
            return table;
        }
    }
}
