using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineTicket
{
    public partial class frmModify : Form
    {
        frmMain main;
        DataAccess access = new DataAccess();

        
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string feightNo;
        public string FeightNo
        {
            get { return feightNo; }
            set { feightNo = value; }
        }

        private string leaveCity;
        public string LeaveCity
        {
            get { return leaveCity; }
            set { leaveCity = value; }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        private DateTime leaveTime;
        public DateTime LeaveTime
        {
            get { return leaveTime; }
            set { leaveTime = value; }
        }

        private DateTime arriveTime;
        public DateTime ArriveTime
        {
            get { return arriveTime; }
            set { arriveTime = value; }
        }

        private float secondClass;
        public float SecondClass
        {
            get { return secondClass; }
            set { secondClass = value; }
        }

        private float firstClass;
        public float FirstClass
        {
            get { return firstClass; }
            set { firstClass = value; }
        }

        private int seatCount;
        public int SeatCount
        {
            get { return seatCount; }
            set { seatCount = value; }
        }
      


        private void frmModify_Load(object sender, EventArgs e)
        {
            txtFeightNo.Text = feightNo;
            txtLeaveCity.Text = leaveCity;
            txtArriveCity.Text = destination;
            dtpLeaveTime.Text = leaveTime.ToString();
            dtpArriveTime.Text = arriveTime.ToString();
            txtSecondPrice.Text = secondClass.ToString();
            txtFirstPrice.Text = firstClass.ToString();
            txtSeatCount.Text = seatCount.ToString();
        }










        public frmModify(frmMain frm)
        {
            main = frm;
            InitializeComponent();
        }

        private void txtSeatCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = true;

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8))
            {
                if ((e.KeyChar == (char)8))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    int len = txtSeatCount.Text.Length;
                    if (len < 3)
                    {
                        if (len == 0 && e.KeyChar != '0')
                        {
                            e.Handled = false;
                            return;
                        }
                        else if (len == 0)
                        {
                            MessageBox.Show("ID can not begin with 0£¡");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Number maximum of 3 digits£¡");
                    }
                }
            }
            else
            {
                MessageBox.Show("Number Enter numbers only£¡");
            }
        }

        private void txtSecondPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            e.Handled = true;

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8) || (e.KeyChar == (char)46))
            {
                if ((e.KeyChar == (char)8))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    int len = txtSecondPrice.Text.Length;
                    if (len < 6)
                    {
                        if (len == 0 && e.KeyChar != '0')
                        {
                            e.Handled = false;
                            return;
                        }
                        else if (len == 0)
                        {
                            MessageBox.Show("ID can not begin with 0£¡");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Maximum number of digital input 6£¡");
                    }
                }
            }
            else
            {
                MessageBox.Show("Number Enter numbers only£¡");
            }
        }

        private void txtFirstPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            e.Handled = true;

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8) || (e.KeyChar == (char)46))
            {
                if ((e.KeyChar == (char)8))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    int len = txtFirstPrice.Text.Length;
                    if (len < 6)
                    {
                        if (len == 0 && e.KeyChar != '0')
                        {
                            e.Handled = false;
                            return;
                        }
                        else if (len == 0)
                        {
                            MessageBox.Show("ID can not begin with 0£¡");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Maximum number of digital input 6£¡");
                    }
                }
            }
            else
            {
                MessageBox.Show("Number Enter numbers only£¡");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string FeightNo = this.txtFeightNo.Text.Trim();
            int Seat = Convert.ToInt32(this.txtSeatCount.Text.Trim());
            string leaveCity = this.txtLeaveCity.Text.Trim();
            string arriveCity = this.txtArriveCity.Text.Trim();
            DateTime leaveTime = Convert.ToDateTime(this.dtpLeaveTime.Text.Trim());
            DateTime arriveTime = Convert.ToDateTime(this.dtpArriveTime.Text.Trim());
            float SecondPrice = Convert.ToSingle(this.txtSecondPrice.Text.Trim());
            float FirstPrice = Convert.ToSingle(this.txtFirstPrice.Text.Trim());

            string Sql = string.Format("Update TicketInfo Set FlightNO='{0}', LeaveCity='{1}',Destination='{2}',LeaveTime='{3}',arriveTime='{4}',SecondClass={5},FirstClass={6},SeatCount={7} Where Id={8}", FeightNo, leaveCity, arriveCity, leaveTime, arriveTime, SecondPrice, FirstPrice, Seat,id);

            if (access.ExcuteSql(Sql))
            {
                MessageBox.Show("Information changed successfully!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Information modification fails!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}