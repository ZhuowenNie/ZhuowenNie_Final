using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineTicket
{
    public partial class frmMain : Form
    {
        DataAccess access = new DataAccess();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Height = 360;
            skinEngine1.SkinFile = "MP10.ssk";
            LoadData();
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        public void LoadData()
        {
            string Sql = "SELECT Id 编号, FlightNO 航班号, LeaveCity 出发地," +
               " Destination 目的地, LeaveTime 出发时间,arriveTime 到达时间, SecondClass 经济仓价" +
               ", FirstClass 头等仓价 ,SeatCount 座位数 FROM TicketInfo";
            dgridView.DataSource = access.GetDataSource(Sql,"Ticket");
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd(this);
            add.ShowDialog();
        }
        private void btnShowQuery_Click(object sender, EventArgs e)
        {
            if (this.Height == 360)
            {
                this.Height = 460;
            }
            else
            {
                this.Height = 360;
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgridView.Columns["航班号"].Visible = chkFeightNo.Checked;
            dgridView.Columns["出发地"].Visible = chkLeaveCity.Checked;
            dgridView.Columns["目的地"].Visible = chkArriveCity.Checked;
            dgridView.Columns["经济仓价"].Visible = chkSecondClass.Checked;
            dgridView.Columns["头等仓价"].Visible = chkFirstClass.Checked;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除这条航班信息吗?","提示信息",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgridView.CurrentRow.Index > -1)
                {
                    int nID = (int)dgridView[0, dgridView.CurrentRow.Index].Value;

                    string Sql = "Delete From TicketInfo Where Id=" + nID;

                    if (access.ExcuteSql(Sql))
                    {
                        MessageBox.Show("删除信息成功!!!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("删除信息失败!!!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要删除的信息!!!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string leaveCity = txtLeaveCity.Text.Trim();
            string arriceCity = txtArriveCity.Text.Trim();

            string Sql = "SELECT Id 编号, FlightNO 航班号, SeatCount 座位数,LeaveCity 出发地," +
               " Destination 目的地, LeaveTime 出发时间,arriveTime 到达时间, SecondClass 经济仓价" +
               ", FirstClass 头等仓价 FROM TicketInfo Where LeaveCity like '%" + leaveCity + "%' and "+
               "Destination like'%" + arriceCity + "%'";

            dgridView.DataSource = access.GetDataSource(Sql,"Query");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //获取需要修改的数据
            int ID = Convert.ToInt32(dgridView[0, dgridView.CurrentRow.Index].Value.ToString());
            string feightNo = dgridView[1, dgridView.CurrentRow.Index].Value.ToString();
            string leaveCity = dgridView[2, dgridView.CurrentRow.Index].Value.ToString();
            string destination = dgridView[3, dgridView.CurrentRow.Index].Value.ToString();
            DateTime leaveTime = Convert.ToDateTime(dgridView[4, dgridView.CurrentRow.Index].Value.ToString());
            DateTime arriveTime =  Convert.ToDateTime(dgridView[5, dgridView.CurrentRow.Index].Value.ToString());
            float secondClass = Convert.ToSingle(dgridView[6, dgridView.CurrentRow.Index].Value.ToString());
            float firstClass =  Convert.ToSingle(dgridView[7, dgridView.CurrentRow.Index].Value.ToString());
            int seatCount = Convert.ToInt32(dgridView[8, dgridView.CurrentRow.Index].Value.ToString());

            frmModify modify = new frmModify(this);
            modify.Id = ID;
            modify.FeightNo = feightNo;
            modify.LeaveCity = leaveCity;
            modify.Destination = destination;
            modify.LeaveTime = leaveTime;
            modify.ArriveTime = arriveTime;
            modify.SecondClass = secondClass;
            modify.FirstClass = firstClass;
            modify.SeatCount = seatCount;

            modify.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出系统?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string feightNo = dgridView[1, dgridView.CurrentRow.Index].Value.ToString();
        
            frmOrder order = new frmOrder(this);
            order.FeightNo = feightNo;
         
            order.ShowDialog();

        }

      
    }
}