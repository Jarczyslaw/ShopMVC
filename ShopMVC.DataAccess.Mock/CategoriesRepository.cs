using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopMVC.DataAccess.Mock
{
    public class CategoriesRepository : ICategoriesRepository
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Category, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetMany(Expression<Func<Category, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}