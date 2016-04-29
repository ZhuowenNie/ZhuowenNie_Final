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
           
            LoadData();
        }

        private void LoadData()
        {
            string Sql = "Select id,FlightNo, LeaveDate, SeatType,Number,IDCard,State from OrderInfo";

            dgrdView.DataSource = access.GetDataSource(Sql, "OrderInfo");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("exit the system?", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    string Sql = "Select id,FlightNo, LeaveDate, SeatType,Number,IDCard,State from OrderInfo";
                    Sql += " Where FlightNo = '" + feightNo + "' And IDCard = '" + CardID + "'";
                    
                    DataTable table = access.GetDataSource(Sql, "Query");
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No booking information!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgrdView.DataSource = table;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a query ID number!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a query flight number!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgrdView[0, dgrdView.CurrentRow.Index].Value.ToString());

            string Sql = "Update OrderInfo Set State='0' Where id=" + ID;
            if (access.ExcuteSql(Sql))
            {
                MessageBox.Show("Travelers have boarding!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("System error!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOnBorad_Click(object sender, EventArgs e)
        {
            string Sql = "Select id,FlightNo, LeaveDate, SeatType,Number,IDCard,State from OrderInfo";
            Sql += " Where State = '0'";

            dgrdView.DataSource = access.GetDataSource(Sql,"onBorad");
        }

        private void btnOffborad_Click(object sender, EventArgs e)
        {
            string Sql = "Select id,FlightNo, LeaveDate, SeatType,Number,IDCard,State from OrderInfo";
            Sql += " Where State = '1'";

            dgrdView.DataSource = access.GetDataSource(Sql, "offBorad");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgrdView[0, dgrdView.CurrentRow.Index].Value.ToString());
            string feightNo = dgrdView[1, dgrdView.CurrentRow.Index].Value.ToString();
            string Sql = "Delete From OrderInfo Where id=" + ID;
            Sql += " And State = '1'";

            if (access.ExcuteSql(Sql))
            {
                SetTicketCount(feightNo);
                MessageBox.Show("Flights unsubscribe success!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Flights unsubscribe fails passenger aircraft has landed!!!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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