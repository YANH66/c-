using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace MySchool
{
    [Table(Name = "StudentMsg")]
    public class StudentMsg
    {
        private int _StudentId;
        private string _StudentName;
        public StudentMsg(int sid, string sname)
        {
            _StudentId = sid;
            _StudentName = sname;
        }
        public StudentMsg()
        {

        }
        [Column(IsPrimaryKey = true, Storage = "_StudentId")]
        public int StudentNo
        {
            get
            {
                return _StudentId;
            }
            set
            {
                _StudentId = value;
            }
        }
        [Column(IsPrimaryKey = false, Storage = "_StudentName")]
        public string StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                _StudentName = value;
            }
        }
    }
        [Table(Name = "CourseMsg")]
        public class CourseMsg
        {
            private int _CourseId;
            private string _CourseName;
            public CourseMsg(int cid, string cname)
            {
                _CourseId = cid;
                _CourseName = cname;
            }
        public CourseMsg()
        { }
            [Column(IsPrimaryKey = true, Storage = "_CourseId")]
            public int CourseId
            {
                get
                {
                    return _CourseId;
                }
                set
                {
                    _CourseId = value;
                }
            }
            [Column(Storage = "_CourseName")]
            public string CourseName
            {
                get
                {
                    return _CourseName;
                }
                set
                {
                    _CourseName = value;
                }
            }

        }
        [Table(Name = "ScoreMsg")]
        public class ScoreMsg
        {
            private int _CourseId;
            private int _StudentId;
            private int _Score;
            public ScoreMsg(int cid, int sid, int score)
            {
                _CourseId = cid;
                _StudentId = sid;
                _Score = score;
            }
            public ScoreMsg()
            {

            }
            [Column(IsPrimaryKey = true, Storage = "_CourseId")]
            public int CourseId
            {
                get
                {
                    return _CourseId;
                }
                set
                {
                    _CourseId = value;
                }
            }
            [Column(IsPrimaryKey = true, Storage = "_StudentId")]
            public int StudentNo
            {
                get
                {
                    return _StudentId;
                }
                set
                {
                    _StudentId = value;
                }
            }
            [Column(IsPrimaryKey = false, Storage = "_Score")]
            public int Score
            {
                get
                {
                    return _Score;
                }
                set
                {
                    _Score = value;
                }
            }
        }
        public class MySchoolDBContext : DataContext
        {
            public Table<StudentMsg> students;
            public Table<CourseMsg> courses;
            public Table<ScoreMsg> scores;
            public MySchoolDBContext(string connection) : base(connection) { }
        }
    }
    
