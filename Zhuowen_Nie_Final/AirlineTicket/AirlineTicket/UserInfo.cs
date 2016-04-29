using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineTicket
{
    public class UserInfo
    {
        private string username;
        private string password;
        private int author;
    

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public String LoginSql() {
           return "select count(*) from user_login where author=" + author + " and username='" + username + "' and pwd='" + password + "'";
        }
    }
}
