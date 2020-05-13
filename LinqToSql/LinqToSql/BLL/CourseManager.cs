using LinqToSql.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BLL
{
    class CourseManager : IManager<Course>
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public Course Add(Course entity)
        {
           try
            {
                ctx.Courses.InsertOnSubmit(entity);
                ctx.SubmitChanges();
                return entity;
            }
            catch
            {
                return null;
            }
        }

        public bool Delete(Course entity)
        {
            try
            {
                Course c = GetById(entity.Id);
                ctx.Courses.DeleteOnSubmit(c);
                ctx.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public IQueryable<Course> GetAll()
        {
            return ctx.Courses;
        }

        public List<Course> GetAllbind()
        {
            return GetAll().ToList();
        }

        public Course GetById(int Id)
        {
            return GetAll().FirstOrDefault(c => c.Id == Id);
        }

        public Course GetByTitle(String Title)
        {
            return GetAll().FirstOrDefault(c => c.Title == Title);
        }

        public bool Update(Course entity)
        {
            try
            {
                Course c = GetById(entity.Id);
                c.Title = entity.Title;
                c.Lec = entity.Lec;
                c.Lab = c.Lab;
                ctx.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
