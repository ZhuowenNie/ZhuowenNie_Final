using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineTicket
{
    public partial class frmAdd : Form
    {
        frmMain main;
        DataAccess access = new DataAccess();
        public frmAdd(frmMain frm)
        {
            main = frm;
            InitializeComponent();
        }
   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TicketInfo ticket = new TicketInfo();
            ticket.FlightNo= this.txtFeightNo.Text.Trim();
            ticket.SeatCount= Convert.ToInt32(this.txtSeatCount.Text.Trim());
            ticket.LeaveCity= this.txtLeaveCity.Text.Trim();
            ticket.Destination = this.txtArriveCity.Text.Trim();
            ticket.LeaveTime= Convert.ToDateTime(this.dtpLeaveTime.Text.Trim());
            ticket.ArriveTime= Convert.ToDateTime(this.dtpLeaveTime.Text.Trim());
            ticket.SecondClass = Convert.ToSingle(this.txtSecondPrice.Text.Trim());
            ticket.FirstClass= Convert.ToSingle(this.txtFirstPrice.Text.Trim());

    
            if (access.InsertTicket(ticket))
            {
                MessageBox.Show("Add Success!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Add Failed!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
                            MessageBox.Show("Cannot be empty");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("3£¡");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please insert number£¡");
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
                            MessageBox.Show("Cannot be empty");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("6£¡");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please insert number£¡");
            }
        }

        private void txtFirstPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            e.Handled = true;

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8) || (e.KeyChar ==(char)46))
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
                            MessageBox.Show("Cannot be empty");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("6£¡");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please insert number£¡");
            }
        }

       
    }
}