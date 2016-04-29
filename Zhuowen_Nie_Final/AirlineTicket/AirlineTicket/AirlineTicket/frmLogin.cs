using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AirlineTicket
{
    public partial class frmLogin : Form
    {
        DataAccess access = new DataAccess();
        ArrayList lt = new ArrayList();
         
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "MacOS.ssk";
            lt.Add(new TypeInfo("administrator", 1));
            lt.Add(new TypeInfo("consumer", 2));
            cmbType.Items.Clear();
            cmbType.DataSource = lt;
            cmbType.DisplayMember = "content";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int author=2;
            if (this.cmbType.Text == "administrator")
            {
                author = 1;
            }
            String username=txtName.Text.Trim();
            String password = txtPwd.Text.Trim();
            string sqlString = "select count(*) from user_login where author="+author+" and username='" + username + "' and pwd='" + password + "'";
           // MessageBox.Show(sqlString);
            if (access.ExcuteLogin(sqlString))
            {
                MessageBox.Show("Login success！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (author == 1)
                {
                    frmMain Main = new frmMain(username, author);
                    Main.Show();
                }
                else {
                    frmUserMain userMain = new frmUserMain(username, author);
                    userMain.Show();
                }
            }
            else
            {
                if (txtName.Text == " " || txtPwd.Text == "")
                {
                    MessageBox.Show("Username and password can not be empty, please enter!", "AlertDialog");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("User name or password error, please re-enter!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();
                }
            }
           
        }
    }
}