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
        int usertype;
        String username;
        public frmMain( String username,int usertype)
        {
            InitializeComponent();
            this.username = username;
            this.usertype = usertype;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
           
            LoadData();
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadData()
        {
            string Sql = "SELECT Id, FlightNO, LeaveCity," +
               " Destination, LeaveTime,arriveTime, SecondClass" +
               ", FirstClass ,SeatCount FROM TicketInfo";
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
           

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("OK to delete this information it flights?","Tips",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgridView.CurrentRow.Index > -1)
                {
                    int nID = (int)dgridView[0, dgridView.CurrentRow.Index].Value;

                    string Sql = "Delete From TicketInfo Where Id=" + nID;

                    if (access.ExcuteSql(Sql))
                    {
                        MessageBox.Show("Removal Information Success!!!", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Delete information failed!!!", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select the information to be deleted!!!", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string leaveCity = txtLeaveCity.Text.Trim();
            string arriceCity = txtArriveCity.Text.Trim();

            string Sql = "SELECT Id, FlightNO, SeatCount,LeaveCity," +
               " Destination, LeaveTime,arriveTime, SecondClass" +
               ", FirstClass FROM TicketInfo Where LeaveCity like '%" + leaveCity + "%' and "+
               "Destination like'%" + arriceCity + "%'";

            dgridView.DataSource = access.GetDataSource(Sql,"Query");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //
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
            if (MessageBox.Show("OK to exit the system?", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
        
            //frmOrder order = new frmOrder(this);
           // order.FeightNo = feightNo;
         
           // order.ShowDialog();

        }

       

      
    }
}