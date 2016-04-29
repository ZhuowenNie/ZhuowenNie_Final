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

        #region 封装数据实体
        private string feightNo;
        public string FeightNo
        {
            get { return feightNo; }
            set { feightNo = value; }
        }
        #endregion

        frmMain main;
        public frmOrder(frmMain frm)
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string Type = "";
            if (cbxType.Text == "")
            {
                MessageBox.Show("请选择需要预订的仓位类型!!!", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Type = cbxType.Text;
            }

            string Sql = string.Format("Insert into OrderInfo values('{0}','{1}','{2}',{3},'{4}','{5}')", feightNo, dtpLeaveTime.Text, Type,txtCount.Text,txtCardID.Text,"有效");

            if (access.ExcuteSql(Sql))
            {
                OrderTicket(feightNo);
                MessageBox.Show("机票预订成功,请携带身份证到机场登机!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("机票预订失败!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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