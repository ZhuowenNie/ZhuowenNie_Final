using System;
using System.Collections.Generic;

using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using NUnit.Framework;

namespace AirlineTicket
{
    [TestFixture]
    public  class MyTest
    {
        public static SqlConnection conn;
        static string strConnection = ConfigurationManager.ConnectionStrings["connection"].ToString();//

        [SetUp]
        public static void init()
        {
            conn = new SqlConnection(strConnection);
        }

        [Test]
        public static void LoginTest()
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from User_Login where UserID='1' and Password='admin'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Assert.AreEqual(true, dt.Rows.Count > 0);
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                conn.Close();
            }
        }
        [Test]
        public static void QueryFlightsTest()
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from TicketInfo", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Assert.AreEqual(true, dt.Rows.Count > 0);
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
               conn.Close();
            }
        }
        [Test]
        public static void UpdateFlightsTest()
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update TicketInfo set SeatCount=SeatCount+1 where FlightNo='FM3303'", conn);
                Assert.AreEqual(1, cmd.ExecuteNonQuery());
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                conn.Close();
            }
        }
        [Test]
        public static void AddLogTest()
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into User_Login values("
                            + "'UserID'" + ","
                            + "'UserName.'" +"'Pwd'" +")", conn);
                Assert.AreEqual(1, cmd.ExecuteNonQuery());
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
