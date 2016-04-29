using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess1
{
    public class DataAccess
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

        /// <summary>
        /// 执行Sql操作语句
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

        /// <summary>
        /// 生成数据表
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <param name="TableName">填充的表名</param>
        /// <returns></returns>
        public DataTable GetDataSource(string Sql,string TableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, conn);
            DataTable table = new DataTable(TableName);

            adapter.Fill(table);
            return table;
        }
    }
}
