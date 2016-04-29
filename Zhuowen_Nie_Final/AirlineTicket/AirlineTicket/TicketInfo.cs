using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineTicket
{
    public class TicketInfo
    {
        private int id;
        private String flightNo;
        private String leaveCity;
        private String destination;
        private DateTime leaveTime;
        private DateTime arriveTime;
        private float secondClass;
        private float firstClass;
        private int seatCount;

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

        public string LeaveCity
        {
            get
            {
                return leaveCity;
            }

            set
            {
                leaveCity = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public DateTime LeaveTime
        {
            get
            {
                return leaveTime;
            }

            set
            {
                leaveTime = value;
            }
        }

        public DateTime ArriveTime
        {
            get
            {
                return arriveTime;
            }

            set
            {
                arriveTime = value;
            }
        }

        public float SecondClass
        {
            get
            {
                return secondClass;
            }

            set
            {
                secondClass = value;
            }
        }

        public float FirstClass
        {
            get
            {
                return firstClass;
            }

            set
            {
                firstClass = value;
            }
        }

        public int SeatCount
        {
            get
            {
                return seatCount;
            }

            set
            {
                seatCount = value;
            }
        }
    }
       
}
