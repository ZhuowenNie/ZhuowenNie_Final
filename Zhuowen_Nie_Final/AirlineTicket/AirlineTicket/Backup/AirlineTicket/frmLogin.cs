using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineTicket
{
    public partial class frmLogin : Form
    {
        DataAccess access = new DataAccess();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "MacOS.ssk";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sqlString = "select count(*) from user_login where username='"+txtName.Text.Trim()+"'and password='"+txtPwd.Text.Trim()+"'";
            if (access.ExcuteLogin(sqlString))
            {
                MessageBox.Show("登录成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain Main = new frmMain();
                Main.Show();
            }
            else
            {
                if (txtName.Text == " " || txtPwd.Text == "")
                {
                    MessageBox.Show("用户名和密码都不能为空，请输入！", "提示对话框");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误,请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();
                }
            }
           
        }
    }
}