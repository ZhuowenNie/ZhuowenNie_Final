using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AirLineTicketClient
{
    class DataAccess
    {
        public static SqlConnection conn;
        string strConnection = ConfigurationManager.ConnectionStrings["connection"].ToString();//��ȡ�����ļ�������Ϣ

        /// <summary>
        /// ���캯��
        /// </summary>
        public DataAccess()
        {
            conn = new SqlConnection(strConnection);
        }

        /// <summary>
        /// ִ��Sql�������
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
        /// �������ݱ�
        /// </summary>
        /// <param name="Sql">SQL���</param>
        /// <param name="TableName">���ı���</param>
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
