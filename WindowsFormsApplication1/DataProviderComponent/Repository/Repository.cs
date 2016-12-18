using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace Controller.Repository
{
    public class Repository<T>
    where T : Entity
    {
        private Context Context;
        public Repository(Context context)
        {
            Context = context;
        }

        public virtual void Add(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;
        }

        public virtual void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remove(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public virtual List<T> GetAll()
        {
            return GetQuery().ToList();
        }

        public virtual T GetById(int id)
        {
            return GetQuery().FirstOrDefault(entity => entity.Id == id);
        }

        public IQueryable<T> GetQuery()
        {
            return Context.Set<T>();
        }
    }
}
