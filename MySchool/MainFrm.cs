using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class MainFrm : Form
    {
        private bool isLogined = false;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmNewStudent_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentMsgFrm sForm = new StudentMsgFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmNewCourse_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseMsgFrm cForm = new CourseMsgFrm();
                cForm.MdiParent = this;
                cForm.Show();
                tssMsg.Text = cForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
            tssMsg.Text = about.Text;
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            Login lForm = new Login();
            tssMsg.Text = lForm.Text;
            if (lForm.ShowDialog() == DialogResult.OK)
            {
                if ((bool)lForm.Tag)
                {
                    isLogined = true;
                    tssMsg.Text = "恭喜您,已经成功登陆系统！";
                }
                else
                {
                    isLogined = false;
                    tssMsg.Text = "注意，必须先登陆才能使用本系统！";
                    MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tsmStuMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentFrm sForm = new StudentFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmCurMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseFrm cForm = new CourseFrm();
                cForm.MdiParent = this;
                cForm.Show();
                tssMsg.Text = cForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmScoreMsg_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                ScoreMsgFrm sForm = new ScoreMsgFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbNewStudent_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentMsgFrm sForm = new StudentMsgFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbStuMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentFrm sForm = new StudentFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbNewCourse_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseMsgFrm cForm = new CourseMsgFrm();
                cForm.MdiParent = this;
                cForm.Show();
                tssMsg.Text = cForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbCurMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseFrm cForm = new CourseFrm();
                cForm.MdiParent = this;
                cForm.Show();
                tssMsg.Text = cForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbScoreMsg_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                ScoreMsgFrm sForm = new ScoreMsgFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
                MessageBox.Show("注意，必须先登录才能使用本系统！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
 }
