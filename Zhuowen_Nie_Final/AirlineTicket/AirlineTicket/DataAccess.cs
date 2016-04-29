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
        string strConnection = ConfigurationManager.ConnectionStrings["connection"].ToString();//

        /// <summary>
        /// Destructor
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
                int num = cmd.ExecuteNonQuery();
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


        public DataTable GetDataSource(string Sql, string TableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, conn);
            DataTable table = new DataTable(TableName);

            adapter.Fill(table);
            return table;
        }

        public bool InsertTicket(TicketInfo ticket)
        {


            string Sql = string.Format("Insert into TicketInfo values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})", ticket.FlightNo, ticket.LeaveCity, ticket.Destination, ticket.LeaveTime, ticket.ArriveTime, ticket.SecondClass, ticket.FirstClass, ticket.SeatCount);

            return ExcuteSql(Sql);
        }


        public bool UpdateTicket(TicketInfo ticket)
        {


            string Sql = string.Format("Update TicketInfo Set FlightNO='{0}', LeaveCity='{1}',Destination='{2}',LeaveTime='{3}',arriveTime='{4}',SecondClass={5},FirstClass={6},SeatCount={7} Where Id={8}", ticket.FlightNo, ticket.LeaveCity, ticket.Destination, ticket.LeaveTime, ticket.ArriveTime, ticket.SecondClass, ticket.FirstClass, ticket.SeatCount, ticket.Id);

            return ExcuteSql(Sql);
        }

        public bool DeleteTicket(TicketInfo ticket)
        {


            string Sql = "Delete From TicketInfo Where Id=" + ticket.Id;

            return ExcuteSql(Sql);
        }

        public DataTable InquireTicket(TicketInfo ticket)
        {


            string Sql = "SELECT Id, FlightNO, SeatCount,LeaveCity," +
          " Destination, LeaveTime,arriveTime, SecondClass" +
          ", FirstClass FROM TicketInfo Where LeaveCity like '%" + ticket.LeaveCity + "%' and " +
          "Destination like'%" + ticket.Destination + "%'";

            return GetDataSource(Sql, "Query");
        }

        public DataTable AllTicket()
        {
            string Sql = "SELECT Id, FlightNO, LeaveCity," +
             " Destination, LeaveTime,arriveTime, SecondClass" +
             ", FirstClass ,SeatCount FROM TicketInfo";
            return GetDataSource(Sql, "Ticket");

        }

        public bool InsertOrder(OrderInfo orderinfo)
        {

            string Sql = "Insert into OrderInfo (FlightNo,LeaveDate,SeatType,Number,IDCard,username,State) values ('" + orderinfo.FlightNo + "', '" + orderinfo.LeaveDate + "', '" + orderinfo.SeatType + "', " + orderinfo.Number + ", " + orderinfo.IDCard + ", '" + orderinfo.Username + "', '"+orderinfo.State+"')";

  
            return ExcuteSql(Sql);
        }

        public DataTable AllOrder(string username)
        {
            string Sql = "select Id,FlightNo,LeaveDate,SeatType,Number,IDCard,State from OrderInfo where username='" + username + "'";
            return GetDataSource(Sql, "Ticket");

        }
    }
}
