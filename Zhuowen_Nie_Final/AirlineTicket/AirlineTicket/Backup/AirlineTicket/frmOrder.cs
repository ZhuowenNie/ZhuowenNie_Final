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

        #region ��װ����ʵ��
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
            //��ֹ�Ӽ��������
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
                            MessageBox.Show("��Ų�����0��ͷ��");
                            return;
                        }
                        e.Handled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("������ֻ������3λ���֣�");
                    }
                }
            }
            else
            {
                MessageBox.Show("���ֻ���������֣�");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string Type = "";
            if (cbxType.Text == "")
            {
                MessageBox.Show("��ѡ����ҪԤ���Ĳ�λ����!!!", "������Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Type = cbxType.Text;
            }

            string Sql = string.Format("Insert into OrderInfo values('{0}','{1}','{2}',{3},'{4}','{5}')", feightNo, dtpLeaveTime.Text, Type,txtCount.Text,txtCardID.Text,"��Ч");

            if (access.ExcuteSql(Sql))
            {
                OrderTicket(feightNo);
                MessageBox.Show("��ƱԤ���ɹ�,��Я�����֤�������ǻ�!!!", "��ʾ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("��ƱԤ��ʧ��!!!", "��ʾ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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