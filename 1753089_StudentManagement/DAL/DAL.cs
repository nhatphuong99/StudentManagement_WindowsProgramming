using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.OleDb;
using System.Configuration;

namespace DAL
{
    public class DAL
    {
        public List<Student> GetStudentsFromDB()
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "select * from SINHVIEN"
                };
                var rd = cmd.ExecuteReader();
                var students = new List<Student>();

                while (rd.Read())
                {
                    students.Add(new Student(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetDateTime(5), rd.GetString(6), rd.GetString(7)));
                }
                cnn.Close();
                return students;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Teacher> GetTeachersFromDB()
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "select * from GIAOVU"
                };
                var rd = cmd.ExecuteReader();
                var teachers = new List<Teacher>();

                while (rd.Read())
                {
                    teachers.Add(new Teacher(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetDateTime(4), rd.GetString(5), rd.GetString(6)));
                }
                cnn.Close();
                return teachers;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool ImportStudent(Student s)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;

            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "insert into SINHVIEN values (?, ?, ?, ?, ?, ?, ?, ?)"
                };
                cmd.Parameters.AddWithValue("?", s.studentid);
                cmd.Parameters.AddWithValue("?", s.socialid);
                cmd.Parameters.AddWithValue("?", s.studentname);
                cmd.Parameters.AddWithValue("?", s.pass);
                cmd.Parameters.AddWithValue("?", s.classid);
                cmd.Parameters.AddWithValue("?", s.dob);
                cmd.Parameters.AddWithValue("?", s.address);
                cmd.Parameters.AddWithValue("?", s.sex);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool ImportSchedule(Schedule sch)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;

            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "insert into THOIKHOABIEU values (?, ?, ?, ?, ?, ?)"
                };

                cmd.Parameters.AddWithValue("?", sch.classid);
                cmd.Parameters.AddWithValue("?", sch.subjectid);
                cmd.Parameters.AddWithValue("?", sch.semester);
                cmd.Parameters.AddWithValue("?", sch.year);
                cmd.Parameters.AddWithValue("?", sch.room);
                cmd.Parameters.AddWithValue("?", sch.publictosee);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }


        public bool ImportScore(Score scr)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;

            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "insert into DIEM values (?, ?, ?, ?, ?, ?, ?, ?)"
                };
                cmd.Parameters.AddWithValue("?", scr.studentid);
                cmd.Parameters.AddWithValue("?", scr.classid);
                cmd.Parameters.AddWithValue("?", scr.subjectid);
                cmd.Parameters.AddWithValue("?", scr.semester);
                cmd.Parameters.AddWithValue("?", scr.midterm);
                cmd.Parameters.AddWithValue("?", scr.final);
                cmd.Parameters.AddWithValue("?", scr.other);
                cmd.Parameters.AddWithValue("?", scr.total);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }
        public bool ImportSubject(Subject sub)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "insert into MONHOC values (?, ?)"
                };

                cmd.Parameters.AddWithValue("?", sub.subjectid);
                cmd.Parameters.AddWithValue("?", sub.subjectname);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool ImportClass(Class c)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "insert into LOP values (?, ?)"
                };

                cmd.Parameters.AddWithValue("?", c.classid);
                cmd.Parameters.AddWithValue("?", c.classname);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        

        public List<Score> GetScoresFromDB()
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = $"select * from DIEM"
                };
                var rd = cmd.ExecuteReader();
                var scores = new List<Score>();

                while (rd.Read())
                {
                    var score = new Score();
                    score.studentid = rd.GetString(0);
                    score.classid = rd.GetString(1);
                    score.subjectid = rd.GetString(2);
                    score.semester = rd.GetString(3);
                    score.midterm = (float)rd.GetDouble(4);
                    score.final = (float)rd.GetDouble(5);
                    score.other = (float)rd.GetDouble(6);
                    score.total = (float)rd.GetDouble(7);
                    scores.Add(score);
                }
                cnn.Close();
                return scores;
            }
            finally
            {
                cnn.Close();
            }
        }

       

        public List<Class> GetClassesFromDB()
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = $"select * from LOP"
                };
                var rd = cmd.ExecuteReader();
                var classes = new List<Class>();

                while (rd.Read())
                {
                    classes.Add(new Class(rd.GetString(0), rd.GetString(1)));
                }
                cnn.Close();
                return classes;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Subject> GetSubjectsFromDB()
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = $"select * from MONHOC"
                };
                var rd = cmd.ExecuteReader();
                var subjects = new List<Subject>();

                while (rd.Read())
                {
                    subjects.Add(new Subject(rd.GetString(0), rd.GetString(1)));
                }
                cnn.Close();
                return subjects;
            }
            finally
            {
                cnn.Close();
            }
        }


        public List<Schedule> GetSchedulesFromDB()
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = $"select * from THOIKHOABIEU"
                };
                var rd = cmd.ExecuteReader();
                var schedules = new List<Schedule>();

                while (rd.Read())
                {
                    schedules.Add(new Schedule(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5).ToCharArray()[0]));
                }
                cnn.Close();
                return schedules;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Subject> GetSubjectofStudentFromDB(string stuid)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = $"select * from THOIKHOABIEU join MONHOC on (THOIKHOABIEU.MAMON = MONHOC.MAMON) join SINHVIEN on (SINHVIEN.LOP = THOIKHOABIEU.MALOP) where SINHVIEN.MSSV = '{stuid}'"
                };
                var rd = cmd.ExecuteReader();
                var subjects = new List<Subject>();

                while (rd.Read())
                {
                    subjects.Add(new Subject(rd.GetString(1), rd.GetString(7)));
                }
                cnn.Close();
                return subjects;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool UpdatePassStudent(string id, string _pass)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "update SINHVIEN set PASS = ? where MSSV = ?"
                };

                cmd.Parameters.AddWithValue("?", _pass);
                cmd.Parameters.AddWithValue("?", id);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool UpdatePassTeacher(string id, string _pass)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "update GIAOVU  set PASS = ? where MAGV = ?"
                };

                cmd.Parameters.AddWithValue("?", _pass);
                cmd.Parameters.AddWithValue("?", id);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool UpdatePublicCondition(char pub, string subid, string cid, string sem)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "update THOIKHOABIEU  set CONGKHAIBANGDIEM = ? where MALOP = ? and MAMON = ? and HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", pub);
                cmd.Parameters.AddWithValue("?", cid);
                cmd.Parameters.AddWithValue("?", subid);
                cmd.Parameters.AddWithValue("?", sem);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool UpdateScore(float mid, float fin, float oth, float ttl, string stuid, string subid, string cid, string sem)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "update DIEM  set DIEMGK = ?, DIEMCK = ?, DIEMKHAC = ?, DIEMTONG = ? where MSSV = ? and MALOP = ? and MAMON = ? and HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", mid);
                cmd.Parameters.AddWithValue("?", fin);
                cmd.Parameters.AddWithValue("?", oth);
                cmd.Parameters.AddWithValue("?", ttl);
                cmd.Parameters.AddWithValue("?", stuid);
                cmd.Parameters.AddWithValue("?", cid);
                cmd.Parameters.AddWithValue("?", subid);
                cmd.Parameters.AddWithValue("?", sem);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool DeleteScoreFromDB(Score sc)
        {
            var cnn = new OleDbConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["cnnstr"].ConnectionString;
            try
            {
                cnn.Open();
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "delete from DIEM where MSSV = ? and MALOP = ? and MAMON = ? and HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", sc.studentid);
                cmd.Parameters.AddWithValue("?", sc.classid);
                cmd.Parameters.AddWithValue("?", sc.subjectid);
                cmd.Parameters.AddWithValue("?", sc.semester);
                var rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd == 1;
            }
            finally
            {
                cnn.Close();
            }
        }

        
    }
}
