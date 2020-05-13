using LinqToSql.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager sm = new StudentManager();
            CourseManager cm = new CourseManager();
            StudentCourseManager scm = new StudentCourseManager();

            //a
            //var res = sm.GetAll().Where(s => s.Name[0]=='A' | s.Name[0] == 'a');

            //b
            //var res = sm.GetByName("ahmed ali");
            //var co = cm.GetByTitle("c#");
            // res.StudentCourses.Add(new DAL.StudentCourse{StudentId=res.Id,CourseId=co.Id});


            //c
            //var res= sm.Add(new DAL.Student { Id = 8, Name = "Amal", Age = 23 });

            //d
            //var res = sm.GetById(14);
            //res.Name = "Hend";
            //bool r= sm.Update(res);

            //e
            //var res = sm.GetById(14);
            //bool re= sm.Delete(res);

            //f
            //var res = sm.GetAll()
            //    .Join(scm.GetAll(), s => s.Id, sc => sc.StudentId, (s, sc) => new { s, sc })
            //    .Join(cm.GetAll(), scc => scc.sc.CourseId, c => c.Id, (scc, c) => new { scc, c })
            //    .GroupBy(r => r.c.Title)
            //    .Select(grp => new { key = grp.Key, studentsName = grp.Select(s =>s.scc.s.Name) });





        }
    }
}