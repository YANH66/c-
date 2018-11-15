namespace MySchool
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSysteMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudentMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStuMsgMag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCourseMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurMsgMag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScoreMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbStuMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbCurMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScoreMsg = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSysteMsg,
            this.tsmStudentMsg,
            this.tsmCourseMsg,
            this.tsmScoreMsg,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSysteMsg
            // 
            this.tsmSysteMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmExit});
            this.tsmSysteMsg.Name = "tsmSysteMsg";
            this.tsmSysteMsg.Size = new System.Drawing.Size(120, 24);
            this.tsmSysteMsg.Text = "系统管理（&S）";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(208, 26);
            this.tsmLogin.Text = "登陆（&L）";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExit.Size = new System.Drawing.Size(208, 26);
            this.tsmExit.Text = "退出（&X）";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmStudentMsg
            // 
            this.tsmStudentMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewStudent,
            this.tsmStuMsgMag});
            this.tsmStudentMsg.Name = "tsmStudentMsg";
            this.tsmStudentMsg.Size = new System.Drawing.Size(126, 24);
            this.tsmStudentMsg.Text = "学生管理（&M）";
            // 
            // tsmNewStudent
            // 
            this.tsmNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmNewStudent.Image")));
            this.tsmNewStudent.Name = "tsmNewStudent";
            this.tsmNewStudent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmNewStudent.Size = new System.Drawing.Size(314, 26);
            this.tsmNewStudent.Text = "添加学生信息（&A）";
            this.tsmNewStudent.Click += new System.EventHandler(this.tsmNewStudent_Click);
            // 
            // tsmStuMsgMag
            // 
            this.tsmStuMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsmStuMsgMag.Image")));
            this.tsmStuMsgMag.Name = "tsmStuMsgMag";
            this.tsmStuMsgMag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmStuMsgMag.Size = new System.Drawing.Size(314, 26);
            this.tsmStuMsgMag.Text = "学生信息管理（&I）";
            this.tsmStuMsgMag.Click += new System.EventHandler(this.tsmStuMsgMag_Click);
            // 
            // tsmCourseMsg
            // 
            this.tsmCourseMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewCourse,
            this.tsmCurMsgMag});
            this.tsmCourseMsg.Name = "tsmCourseMsg";
            this.tsmCourseMsg.Size = new System.Drawing.Size(121, 24);
            this.tsmCourseMsg.Text = "课程管理（&C）";
            // 
            // tsmNewCourse
            // 
            this.tsmNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsmNewCourse.Image")));
            this.tsmNewCourse.Name = "tsmNewCourse";
            this.tsmNewCourse.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tsmNewCourse.Size = new System.Drawing.Size(285, 26);
            this.tsmNewCourse.Text = "添加课程（&A）";
            this.tsmNewCourse.Click += new System.EventHandler(this.tsmNewCourse_Click);
            // 
            // tsmCurMsgMag
            // 
            this.tsmCurMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsmCurMsgMag.Image")));
            this.tsmCurMsgMag.Name = "tsmCurMsgMag";
            this.tsmCurMsgMag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmCurMsgMag.Size = new System.Drawing.Size(285, 26);
            this.tsmCurMsgMag.Text = "课程信息管理（&I）";
            this.tsmCurMsgMag.Click += new System.EventHandler(this.tsmCurMsgMag_Click);
            // 
            // tsmScoreMsg
            // 
            this.tsmScoreMsg.Name = "tsmScoreMsg";
            this.tsmScoreMsg.Size = new System.Drawing.Size(122, 24);
            this.tsmScoreMsg.Text = "成绩管理（&A）";
            this.tsmScoreMsg.Click += new System.EventHandler(this.tsmScoreMsg_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(93, 24);
            this.tsmHelp.Text = "帮助（&H）";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsmAbout.Image")));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(155, 26);
            this.tsmAbout.Text = "关于（&A）";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Image = ((System.Drawing.Image)(resources.GetObject("tssStatus.Image")));
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(59, 20);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(114, 20);
            this.tssMsg.Text = "请选择一个操作";
            this.tssMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewStudent,
            this.tsbStuMsgMag,
            this.toolStripSeparator1,
            this.tsbNewCourse,
            this.tsbCurMsgMag,
            this.toolStripSeparator2,
            this.tsbScoreMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "常用命令";
            // 
            // tsbNewStudent
            // 
            this.tsbNewStudent.AutoSize = false;
            this.tsbNewStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewStudent.Image")));
            this.tsbNewStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewStudent.Name = "tsbNewStudent";
            this.tsbNewStudent.Size = new System.Drawing.Size(48, 52);
            this.tsbNewStudent.Text = "添加学生信息";
            this.tsbNewStudent.Click += new System.EventHandler(this.tsbNewStudent_Click);
            // 
            // tsbStuMsgMag
            // 
            this.tsbStuMsgMag.AutoSize = false;
            this.tsbStuMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStuMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbStuMsgMag.Image")));
            this.tsbStuMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStuMsgMag.Name = "tsbStuMsgMag";
            this.tsbStuMsgMag.Size = new System.Drawing.Size(48, 52);
            this.tsbStuMsgMag.Text = "学生信息管理";
            this.tsbStuMsgMag.Click += new System.EventHandler(this.tsbStuMsgMag_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbNewCourse
            // 
            this.tsbNewCourse.AutoSize = false;
            this.tsbNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCourse.Image")));
            this.tsbNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCourse.Name = "tsbNewCourse";
            this.tsbNewCourse.Size = new System.Drawing.Size(48, 52);
            this.tsbNewCourse.Text = "添加课程信息";
            this.tsbNewCourse.Click += new System.EventHandler(this.tsbNewCourse_Click);
            // 
            // tsbCurMsgMag
            // 
            this.tsbCurMsgMag.AutoSize = false;
            this.tsbCurMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurMsgMag.Image")));
            this.tsbCurMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurMsgMag.Name = "tsbCurMsgMag";
            this.tsbCurMsgMag.Size = new System.Drawing.Size(48, 52);
            this.tsbCurMsgMag.Text = "课程信息管理";
            this.tsbCurMsgMag.Click += new System.EventHandler(this.tsbCurMsgMag_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbScoreMsg
            // 
            this.tsbScoreMsg.AutoSize = false;
            this.tsbScoreMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreMsg.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreMsg.Image")));
            this.tsbScoreMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreMsg.Name = "tsbScoreMsg";
            this.tsbScoreMsg.Size = new System.Drawing.Size(48, 52);
            this.tsbScoreMsg.Text = "成绩管理";
            this.tsbScoreMsg.Click += new System.EventHandler(this.tsbScoreMsg_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "学生成绩管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSysteMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmStudentMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmStuMsgMag;
        private System.Windows.Forms.ToolStripMenuItem tsmCourseMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmNewCourse;
        private System.Windows.Forms.ToolStripMenuItem tsmCurMsgMag;
        private System.Windows.Forms.ToolStripMenuItem tsmScoreMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewStudent;
        private System.Windows.Forms.ToolStripButton tsbStuMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNewCourse;
        private System.Windows.Forms.ToolStripButton tsbCurMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbScoreMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
    }
}