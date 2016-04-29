using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineTicket
{
    public partial class frmOrder : Form
    {
        DataAccess access = new DataAccess();

        
        private string feightNo;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string FeightNo
        {
            get { return feightNo; }
            set { feightNo = value; }
        }
        

        frmUserMain main;
        public frmOrder(frmUserMain frm)
        {
            main = frm;
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtFeightNo.Text = feightNo;
        }

      
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
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
                    int len = txtCount.Text.Length;
                    if (len < 3)
                    {
                        if (len == 0 && e.KeyChar != '0')
                        {
                            e.Handled = false;
                            return;
                        }
                        else if (len == 0)
                        {
                            MessageBox.Show("ID can not begin with 0");
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string Type = "";
            if (cbxType.Text == "")
            {
                MessageBox.Show("Please select the type of seat!!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Type = cbxType.Text;
            }

            OrderInfo order = new OrderInfo();
            order.FlightNo = feightNo;
            order.LeaveDate = dtpLeaveTime.Text;
            order.SeatType = Type;
            order.Number = Convert.ToInt32(txtCount.Text);
            order.IDCard = txtCardID.Text;
            order.Username = username;
            order.State = "1";

            
            if (access.InsertOrder(order))
            {
                OrderTicket(feightNo);
                MessageBox.Show("Ticket booking, please bring your ID card at the airport check-in!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadData();
                main.LoadMyData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Flights fail!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void OrderTicket(string FeightNo)
        {

            int SeatNo = Convert.ToInt32(txtCount.Text.Trim());
            string Sql = "Update TicketInfo Set SeatCount = SeatCount - " + SeatNo + " Where FlightNo = '" + FeightNo + "'";
            access.ExcuteSql(Sql);
        }

        private void dtpLeaveTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

      

       
    }
}