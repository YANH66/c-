using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MySchool
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string password = txtPwd.Text;
            string connString = @"Data Source=localhost;Initial Catalog=MySchool;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            string sql = String.Format("select count (*) from [User] where UserName='{0}' and password='{1}'", userName, password);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                if (n == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误！请重试", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }
    }
}
