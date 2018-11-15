using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class CourseMsgFrm : Form
    {
        public CourseMsgFrm()
        {
            InitializeComponent();
        }
        string courseName;
        string courseClass;
        string required;
        int credit;
        int prelectionCredit;
        int experimentCredit;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
                MessageBox.Show("输入的信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                tabControl1.SelectedIndex = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("输入的信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    courseName = txtName.Text;
                    courseClass = cboClass.SelectedItem.ToString();
                    required = rdoRequired.Checked ? "必修" : "选修";
                    credit = (int)nudCredit.Value;
                    prelectionCredit = (int)nudPrelection.Value;
                    experimentCredit = (int)nudExp.Value;
                    string message = String.Format("课程名:{0}\n课程类别:{1}\n课程性质:{2}\n学分:{3}\n理论学时:{4}\n实验学时:{5}", courseName, courseClass, required, credit, prelectionCredit, experimentCredit);
                    richTextBox1.Text = message;
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fd.Font;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = cd.Color;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            bool req = true;
            if (rdoRequired.Checked)
                req = true;
            else
                req = false;
            string cob= cboClass.SelectedItem.ToString();
            string sql = String.Format("INSERT INTO CourseMsg(courseName, courseClass, required, credit, prelectionCredit, experimentCredit)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", txtName.Text,cob,req,nudCredit.Value,nudPrelection.Value,nudExp.Value);
            string connString = @"Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("添加课程信息成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加课程信息失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool req = true;
            if (rdoRequired.Checked)
                req = true;
            else
                req = false;
            string cob = cboClass.SelectedItem.ToString();
            string sql = String.Format("INSERT INTO CourseMsg(courseName, courseClass, required, credit, prelectionCredit, experimentCredit)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", txtName.Text, cob, req, nudCredit.Value, nudPrelection.Value, nudExp.Value);
            string connString = @"Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("添加课程信息成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加课程信息失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
