using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineTicket
{
    public class OrderInfo
    {
        private String flightNo;
        private String leaveDate;
        private String seatType;
        private int number;
        private int id;
        private String iDCard;
        private String  state;
        private int userID;
        private String username;

        public string FlightNo
        {
            get
            {
                return flightNo;
            }

            set
            {
                flightNo = value;
            }
        }

        public string LeaveDate
        {
            get
            {
                return leaveDate;
            }

            set
            {
                leaveDate = value;
            }
        }

        public string SeatType
        {
            get
            {
                return seatType;
            }

            set
            {
                seatType = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string IDCard
        {
            get
            {
                return iDCard;
            }

            set
            {
                iDCard = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

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
    }
}
