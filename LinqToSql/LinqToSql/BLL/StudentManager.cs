using LinqToSql.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BLL
{
    class StudentManager:IManager<Student>
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();

        public Student Add(Student entity)
        {
            try
            {
                ctx.Students.InsertOnSubmit(entity);
                ctx.SubmitChanges();
                return entity;
            }
            catch
            {
                return null;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                Student s = GetById(entity.Id);
                ctx.Students.DeleteOnSubmit(s);
                ctx.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<Student> GetAll()
        {
            return ctx.Students;
        }

        public List<Student> GetAllbind()
        {
            return GetAll().ToList();
        }

        public Student GetById(int Id)
        {
            return GetAll().FirstOrDefault(s => s.Id == Id);
        }

        public Student GetByName(string name)
        {
            return GetAll().FirstOrDefault(s => s.Name == name);
        }

        public bool Update(Student entity)
        {
            try
            {
                Student s = GetById(entity.Id);
                s.Name = entity.Name;
                s.Age = entity.Age;
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
