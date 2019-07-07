using ShopMVC.DataAccess.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ShopMVC.DataAccess
{
    public class BaseRepository<T> : IRepository<T>
        where T : class
    {
        protected BaseRepository(IDataContextFactory dataContextFactory)
        {
            DataContext = dataContextFactory.GetContext();
            DbSet = DataContext.Set<T>();
        }

        public DataContext DataContext { get; }
        public IDbSet<T> DbSet { get; }

        public virtual void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            foreach (T obj in DbSet.Where(where).AsEnumerable())
            {
                DbSet.Remove(obj);
            }
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return DbSet.Where(where).FirstOrDefault();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return DbSet.Where(where).ToList();
        }

        public virtual void Update(T entity)
        {
            if (DataContext.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}