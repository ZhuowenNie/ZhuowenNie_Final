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
            string FeightNo = this.txtFeightNo.Text.Trim();
            int Seat = Convert.ToInt32(this.txtSeatCount.Text.Trim());
            string leaveCity = this.txtLeaveCity.Text.Trim();
            string arriveCity = this.txtArriveCity.Text.Trim();
            DateTime leaveTime = Convert.ToDateTime(this.dtpLeaveTime.Text.Trim());
            DateTime arriveTime = Convert.ToDateTime(this.dtpArriveTime.Text.Trim());
            float SecondPrice = Convert.ToSingle(this.txtSecondPrice.Text.Trim());
            float FirstPrice = Convert.ToSingle(this.txtFirstPrice.Text.Trim());

            string Sql = string.Format("Insert into TicketInfo values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})", FeightNo, leaveCity, arriveCity, leaveTime, arriveTime, SecondPrice, FirstPrice, Seat);

            if (access.ExcuteSql(Sql))
            {
                MessageBox.Show("信息添加成功!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("信息添加失败!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSeatCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //阻止从键盘输入键
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
                            MessageBox.Show("编号不能以0开头！");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("编号最多只能输入3位数字！");
                    }
                }
            }
            else
            {
                MessageBox.Show("编号只能输入数字！");
            }
        }

        private void txtSecondPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //阻止从键盘输入键
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
                            MessageBox.Show("编号不能以0开头！");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("编号最多只能输入6位数字！");
                    }
                }
            }
            else
            {
                MessageBox.Show("编号只能输入数字！");
            }
        }

        private void txtFirstPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //阻止从键盘输入键
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
                            MessageBox.Show("编号不能以0开头！");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("编号最多只能输入6位数字！");
                    }
                }
            }
            else
            {
                MessageBox.Show("编号只能输入数字！");
            }
        }

       
    }
}