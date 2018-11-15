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
    public partial class StudentFrm : Form
    {
        public StudentFrm()
        {
            InitializeComponent();
            current = 1;
            ShowCurrentStudent();
        }
        private int current = 1;
        string connString = @"Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True";
        private void ShowCurrentStudent()
        {
            string sql = String.Format("SELECT * FROM StudentMsg WHERE StudentNo='{0}'", current);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader.GetString(1);
                    string sex = reader.GetString(2);
                    if (sex == "男")
                        rdoMale.Checked = true;
                    else
                        rdoFemale.Checked = true;
                    dtBirthday.Value = reader.GetDateTime(3);
                    txtDept.Text = reader.GetString(4);
                    txtSpec.Text = reader.GetString(5);
                    string[] hobbies = new string[6];
                    hobbies = reader.GetString(6).Split('、');
                    checkBox1.Checked = false; checkBox2.Checked = false;
                    checkBox3.Checked = false; checkBox4.Checked = false;
                    checkBox5.Checked = false; checkBox6.Checked = false;
                    foreach (string s in hobbies)
                    {
                        switch (s)
                        {
                            case "阅读": checkBox1.Checked = true; break;
                            case "体育": checkBox1.Checked = true; break;
                            case "音乐": checkBox1.Checked = true; break;
                            case "上网": checkBox1.Checked = true; break;
                            case "旅游": checkBox1.Checked = true; break;
                            default: checkBox6.Checked = true; break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("前面或后面已经没有数据了", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrentStudent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrentStudent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rdoMale.Checked)
                sex = "男";
            else
                sex = "女";
            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            string sql = String.Format("UPDATE StudentMsg SET StudentName='{0}',sex='{1}',Birthday='{2}',Department='{3}',Speciality='{4}',Hobby='{5}' WHERE StudentNo='{6}'", txtName.Text, sex, dtBirthday.Value, txtDept.Text, txtSpec.Text, hobby, current);
            string connString = @"Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n <= 0)
                {
                    MessageBox.Show("数据更新失败！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("数据更新成功！", "数据库已更新！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = String.Format("DELETE FROM StudentMsg WHERE StudentNo='{0}'", current);
            string connString = @"Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n <= 0)
                {
                    MessageBox.Show("删除数据失败！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("删除数据成功！", "操作数据库成功！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    current--;
                    ShowCurrentStudent();
                }
            }

        }
    }
}
