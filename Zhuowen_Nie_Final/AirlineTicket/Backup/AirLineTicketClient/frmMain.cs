using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace AirLineTicketClient
{
    public partial class frmMain : Form
    {
        //DataAccess1 access = new DataAccess1();
        DataAccess1.DataAccess access =new DataAccess1.DataAccess();
        // DataAccess access = new DataAccess();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "MSN.ssk";
            LoadData();
        }

        private void LoadData()
        {
            string Sql = "Select id 订单号,FlightNo 航班号, LeaveDate 起飞时间, SeatType 仓位类型,Number 订座数量,IDCard 身份证号,State 状态 from OrderInfo";

            dgrdView.DataSource = access.GetDataSource(Sql, "OrderInfo");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出系统?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string feightNo = this.txtFeightNo.Text;
            string CardID = this.txtCardID.Text;

            if (feightNo != "")
            {
                if (CardID != "")
                {
                    string Sql = "Select id 订单号,FlightNo 航班号, LeaveDate 起飞时间, SeatType 仓位类型,Number 订座数量,IDCard 身份证号,State 状态 from OrderInfo";
                    Sql += " Where FlightNo = '" + feightNo + "' And IDCard = '" + CardID + "'";
                    
                    DataTable table = access.GetDataSource(Sql, "Query");
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("没有相关的订票信息!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgrdView.DataSource = table;
                    }
                }
                else
                {
                    MessageBox.Show("请输入需要查询的证件号!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请输入需要查询的航班号!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgrdView[0, dgrdView.CurrentRow.Index].Value.ToString());

            string Sql = "Update OrderInfo Set State='无效' Where id=" + ID;
            if (access.ExcuteSql(Sql))
            {
                MessageBox.Show("旅客已登机!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("系统出错!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOnBorad_Click(object sender, EventArgs e)
        {
            string Sql = "Select id 订单号,FlightNo 航班号, LeaveDate 起飞时间, SeatType 仓位类型,Number 订座数量,IDCard 身份证号,State 状态 from OrderInfo";
            Sql += " Where State = '无效'";

            dgrdView.DataSource = access.GetDataSource(Sql,"onBorad");
        }

        private void btnOffborad_Click(object sender, EventArgs e)
        {
            string Sql = "Select id 订单号,FlightNo 航班号, LeaveDate 起飞时间, SeatType 仓位类型,Number 订座数量,IDCard 身份证号,State 状态 from OrderInfo";
            Sql += " Where State = '有效'";

            dgrdView.DataSource = access.GetDataSource(Sql, "offBorad");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgrdView[0, dgrdView.CurrentRow.Index].Value.ToString());
            string feightNo = dgrdView[1, dgrdView.CurrentRow.Index].Value.ToString();
            string Sql = "Delete From OrderInfo Where id=" + ID;
            Sql += " And State = '有效'";

            if (access.ExcuteSql(Sql))
            {
                SetTicketCount(feightNo);
                MessageBox.Show("机票退订成功!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("机票退订失败,旅客已登陆飞机!!!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetTicketCount(string FlightNo)
        {
            int SeatNo = Convert.ToInt32(dgrdView[4, dgrdView.CurrentRow.Index].Value.ToString());
            string Sql = "Update TicketInfo Set SeatCount = SeatCount +" + SeatNo +  "Where FlightNo = '" + FlightNo + "'";
            access.ExcuteSql(Sql);
        }

        private void gboxQuery_Enter(object sender, EventArgs e)
        {

        }
    }
}