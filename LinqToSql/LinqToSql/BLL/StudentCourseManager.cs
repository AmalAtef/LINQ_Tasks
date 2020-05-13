using LinqToSql.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BLL
{
    class StudentCourseManager : IManager<StudentCourse>
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public StudentCourse Add(StudentCourse entity)
        {
            try
            {
                ctx.StudentCourses.InsertOnSubmit(entity);
                ctx.SubmitChanges();
                return entity;
            }
            catch
            {
                return null;
            }
        }

        public bool Delete(StudentCourse entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StudentCourse> GetAll()
        {
            return ctx.StudentCourses;
        }

        public List<StudentCourse> GetAllbind()
        {
            throw new NotImplementedException();
        }

        public StudentCourse GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(StudentCourse entity)
        {
            throw new NotImplementedException();
        }
    }
}
