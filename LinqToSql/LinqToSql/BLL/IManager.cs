using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BLL
{
    interface IManager<TEntity>
    {
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllbind();
        TEntity GetById(int Id);

        TEntity Add(TEntity entity);

        bool Delete(TEntity entity);

        bool Update(TEntity entity);
    }
}
