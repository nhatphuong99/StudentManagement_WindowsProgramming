using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DAL;
using Entity;
using System.Windows.Forms;

namespace BLL
{
    public class BLL
    {
        public int CheckLogin(string usrn, string pass)
        {
            if (usrn == "giaovu")
            {
                var teachers = new DAL.DAL().GetTeachersFromDB();
                foreach (var teacher in teachers)
                {
                    if (pass == teacher.pass)
                        return 2;
                }
            }

            var students = new DAL.DAL().GetStudentsFromDB();
            foreach (var student in students)
            {
                if (usrn == student.studentid)
                    if (pass == student.pass)
                        return 1;

            }

            
            return 0;
        }

        public List<Student> ReadStudentsFromFile(string path)
        {
            var students = new List<Student>();
            using (var rd = new StreamReader(path))
            {
                var classid = rd.ReadLine();
                var _class = new Class(classid, classid);
                CheckClass(_class);

                rd.ReadLine(); 
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    var s = line.Split(',');
                    var id = s[1];
                    var name = s[2];
                    var sex = s[3];
                    var soid = s[4];
                    var dob = s[5];
                    var date = dob.Split('/');
                    var _dob = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                    var add = s[6];
                    var student = new Student(id, soid, name, classid, _dob, add, sex);
                    students.Add(student);
                }
            }
            return students;
        }


        public bool CheckClass(Class cl)
        {
            var cls = new DAL.DAL().GetClassesFromDB();
            foreach (var c in cls)
            {
                if (c.classid == cl.classid)
                    return false;
            }
            var dal = new DAL.DAL();
            dal.ImportClass(cl);
            return true;
        }

        public bool CheckSubject(Subject sub)
        {
            var subj = new DAL.DAL().GetSubjectsFromDB();
            foreach (var s in subj)
            {
                if (s.subjectid == sub.subjectid)
                    return false;
            }
            var dal = new DAL.DAL();
            dal.ImportSubject(sub);
            return true;
        }

        public bool CheckStudent(Student stu)
        {
            var stus= new DAL.DAL().GetStudentsFromDB();
            foreach (var s in stus)
            {
                if (s.studentid == stu.studentid)
                    return false;
            }
            var dal = new DAL.DAL();
            dal.ImportStudent(stu);
            return true;
        }

        public bool CheckScore(Score sc)
        {
            var scrs = new DAL.DAL().GetScoresFromDB();
            foreach (var scr in scrs)
            {
                if (sc.classid == scr.classid && sc.studentid == scr.studentid && sc.subjectid == scr.subjectid && sc.semester == scr.semester)
                    return false;
            }
            var dal = new DAL.DAL();
            dal.ImportScore(sc);
            return true;
        }

        public bool CheckScoreEndterm(Score sc)
        {
            var scrs = new DAL.DAL().GetScoresFromDB();
            foreach (var scr in scrs)
            {
                if (sc == scr)
                    return false;
            }
            var dal = new DAL.DAL();
            dal.ImportScore(sc);
            return true;
        }

        public bool CheckSchedule(Schedule sch)
        {
            var schs = new DAL.DAL().GetSchedulesFromDB();
            foreach (var s in schs)
            {
                if (s.subjectid == sch.subjectid && s.classid == sch.classid && s.semester == sch.semester)
                    return false;
            }
            var dal = new DAL.DAL();
            dal.ImportSchedule(sch);
            return true;
        }

        public List<Schedule> ReadScheduleFromFile(string path)
        {
            var schedules = new List<Schedule>();
            using (var rd = new StreamReader(path))
            {
                var cid = rd.ReadLine();

                rd.ReadLine();
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    var s = line.Split(',');

                    var subid = s[1];
                    var subname = s[2];
                    var subject = new Subject(subid, subname);
                    CheckSubject(subject);

                    var room = s[3];
                    var sem = s[4];
                    var y = s[5];
                    var schedule = new Schedule(cid, subid, sem, y, room, '0');
                    schedules.Add(schedule);
                }
            }
            return schedules;
        }


        public List<Score> ReadScoreboardFromFile(string path)
        {
            var scores = new List<Score>();
            using (var rd = new StreamReader(path))
            {
                var temp = rd.ReadLine().Split(',');
                var cid = temp[0];
                var subid = temp[1];
                var schs = new DAL.DAL().GetSchedulesFromDB();
                var sem = "";
                foreach (var sch in schs)
                {
                    if (sch.subjectid == subid && sch.classid == cid)
                        sem = sch.semester;
                }
                if (sem == "")
                    return scores;

                rd.ReadLine();
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    var s = line.Split(',');

                    var stuid = s[1];
                    var stuname = s[2];
                    var mid = float.Parse(s[3]);
                    var fin = float.Parse(s[4]);
                    var oth = float.Parse(s[5]);
                    var ttl = float.Parse(s[6]);

                    
                    var score = new Score(stuid, cid, subid, sem, mid, fin, oth, ttl);
                    scores.Add(score);
                }
            }
            return scores;
        }

        public bool ImportScoresEndterm(List<Score> scrs)
        {
            if (scrs.Count == 0)
                return false;
            try
            {
                foreach (var scr in scrs)
                   UpdateStudentScore(scr.midterm, scr.final,scr.other,scr.total,scr.studentid, scr.subjectid, scr.classid, scr.semester);

                var schs = new DAL.DAL().GetSchedulesFromDB();
                foreach (var sch in schs)
                {
                    if (sch.classid == scrs[0].classid && sch.subjectid == scrs[0].subjectid && sch.semester == scrs[0].semester)
                    {
                        UpdatePublic('1', sch.subjectid, sch.classid, sch.semester);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ImportSchedules(List<Schedule> s)
        {
            if (s.Count == 0)
                return false;
            try
            {
                foreach (var sch in s)
                {
                    if (CheckSchedule(sch))
                    {
                        var stus = new DAL.DAL().GetStudentsFromDB();
                        foreach (var stu in stus)
                        {
                            if (stu.classid == sch.classid)
                            {
                                var scr = new Score(stu.studentid, sch.classid, sch.subjectid, sch.semester);
                                CheckScore(scr);
                            }
                        }
                    }
                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ImportStudentsFromListStudent(List<Student> s)
        {
            if (s.Count == 0)
                return false;
            try
            {
                foreach (var stu in s)
                {
                    CheckStudent(stu);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<Student> ViewStudentsListinClassFromDB(string cid)
        {
            var temp = new DAL.DAL().GetStudentsFromDB();
            var result = new List<Student>();
            foreach (Student stu in temp)
            {
                if (stu.classid == cid)
                    result.Add(stu);
            }
            return result;
        }

        public List<Score> ViewScoreboardsc(string cid, string subid)
        {
            var temp = new DAL.DAL().GetScoresFromDB();
            var result = new List<Score>();
            foreach (Score sc in temp)
            {
                if (sc.classid == cid && sc.subjectid == subid)
                    result.Add(sc);
            }
            return result;
        }

        public List<Score> ViewScoreboardclass(string cid)
        {
            var temp = new DAL.DAL().GetScoresFromDB();
            var result = new List<Score>();
            foreach (Score sc in temp)
            {
                if (sc.classid == cid)
                    result.Add(sc);
            }
            return result;
        }

        public List<Score> ViewScoreboardsub(string subid)
        {
            var temp = new DAL.DAL().GetScoresFromDB();
            var result = new List<Score>();
            foreach (Score sc in temp)
            {
                if (sc.subjectid == subid)
                    result.Add(sc);
            }
            return result;
        }

        public List<Schedule> ViewSchedulesc(string cid, string subid)
        {
            var temp = new DAL.DAL().GetSchedulesFromDB();
            var result = new List<Schedule>();
            foreach (Schedule sch in temp)
            {
                if (sch.classid == cid && sch.subjectid == subid)
                    result.Add(sch);
            }
            return result;
        }

        public List<Schedule> ViewScheduleclass(string cid)
        {
            var temp = new DAL.DAL().GetSchedulesFromDB();
            var result = new List<Schedule>();
            foreach (Schedule sch in temp)
            {
                if (sch.classid == cid)
                    result.Add(sch);
            }
            return result;
        }

        public List<Schedule> ViewSchedulesub(string subid)
        {
            var temp = new DAL.DAL().GetSchedulesFromDB();
            var result = new List<Schedule>();
            foreach (Schedule sch in temp)
            {
                if (sch.subjectid == subid)
                    result.Add(sch);
            }
            return result;
        }

        public List<Class> GetClassesIDFromDB()
        {
            var result = new DAL.DAL().GetClassesFromDB();
            return result;
        }

        public List<Subject> GetSubjectsIDFromDB()
        {
            var result = new DAL.DAL().GetSubjectsFromDB();
            return result;
        }

        public List<Subject> GetSubjectIDofStudentFromDB(string id)
        {
            var result = new DAL.DAL().GetSubjectofStudentFromDB(id);
            return result;
        }

        public List<Score> GetScoresStudent(string s)
        {
            var scrs = new DAL.DAL().GetScoresFromDB();
            var schs = new DAL.DAL().GetSchedulesFromDB();
            var res = new List<Score>();

            foreach (var scr in scrs)
            {
                if (s == scr.studentid)
                {
                    foreach (var sch in schs)
                    {
                        if (scr.classid == sch.classid && scr.subjectid == sch.subjectid && scr.semester == sch.semester && sch.publictosee == '1')
                            res.Add(scr);
                    }
                }
            }
            return res;

        }

        public Student GetStudent(string sid)
        {
            var stus = new DAL.DAL().GetStudentsFromDB();
            foreach(var stu in stus)
            {
                if (stu.studentid == sid)
                    return stu;
            }
            return null;
        }

        public bool ChangepassStudent(string usrn, string passold, string passnew)
        {
            var students = new DAL.DAL().GetStudentsFromDB();
            foreach (var student in students)
            {
                if (usrn == student.studentid)
                    if (passold == student.pass)
                    {
                        var change = new DAL.DAL().UpdatePassStudent(usrn, passnew);
                        return change;
                    }

            }

           
            return false;
        }

        public bool ChangepassTeaCher(string id, string passold, string passnew)
        {
          
            var teachers = new DAL.DAL().GetTeachersFromDB();
            foreach (var teacher in teachers)
            {
                if (id == teacher.teacherid)
                    if (passold == teacher.pass)
                    {
                        var change = new DAL.DAL().UpdatePassTeacher(id, passnew);
                        return true;
                    }

            }
            return false;
        }

        public bool UpdatePublic(char pub, string subid, string cid, string sem)
        {
            var dal = new DAL.DAL().UpdatePublicCondition(pub, subid, cid, sem);
            return dal ;
        }

        public bool UpdateStudentScore(float mid, float fin, float oth, float ttl, string stuid, string subid, string cid, string sem)
        {
            var dal = new DAL.DAL().UpdateScore(mid, fin, oth, ttl, stuid, subid, cid, sem);
            return dal;
        }


        public bool AddNewStudent(Student s)
        {
            var _class = new Class(s.classid, s.classid);
            CheckClass(_class);

            bool ck = CheckStudent(s);
            var schs = new DAL.DAL().GetSchedulesFromDB();
            foreach(var sch in schs)
            {
                if (s.classid == sch.classid)
                {
                    var score = new Score(s.studentid, s.classid, sch.subjectid, sch.semester);
                    CheckScore(score);
                }
            }
            return ck;
        }

        public bool DeleteScore(Score sc)
        {
            var dlt = new DAL.DAL().DeleteScoreFromDB(sc);
            return dlt;

        }

        public bool UpdateScore(float mid, float fin, float oth, float ttl, string stuid, string subid, string cid, string sem)
        {
            var upd = new DAL.DAL().UpdateScore(mid, fin, oth, ttl, stuid, subid, cid, sem);
            return upd;
        }

        public bool AddNewScore(Score sc)
        {
            var schs = new DAL.DAL().GetSchedulesFromDB();
            var stus = new DAL.DAL().GetStudentsFromDB();

            foreach (var sch in schs)
            {
                if (sc.classid == sch.classid && sc.subjectid == sch.subjectid && sc.semester == sch.semester)
                {
                    foreach (var stu in stus)
                    {
                        if (sc.studentid == stu.studentid)
                            return CheckScore(sc);
                    }
                }
            }
            return false;

            
        }
    }
}
