using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Nelibur.ObjectMapper;
using ShopMVC.Commons;

namespace ShopMVC.DataAccess.Mock
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly IDataContextProvider dataContextProvider;

        public CategoriesRepository(IDataContextProvider dataContextProvider)
        {
            this.dataContextProvider = dataContextProvider;
        }

        public void Add(Category entity)
        {
            entity.CategoryId = GetNextId();
            dataContextProvider.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var category = GetById(entity.CategoryId);
            dataContextProvider.Categories.Remove(category);
        }

        public void Delete(Expression<Func<Category, bool>> where)
        {
            var category = dataContextProvider.Categories.AsQueryable().SingleOrDefault(where);
            if (category != null)
            {
                dataContextProvider.Categories.Remove(category);
            }
        }

        public Category Get(Expression<Func<Category, bool>> where)
        {
            return dataContextProvider.Categories.AsQueryable().SingleOrDefault(where);
        }

        public IEnumerable<Category> GetAll()
        {
            return dataContextProvider.Categories;
        }

        public Category GetById(int id)
        {
            return dataContextProvider.Categories.SingleOrDefault(c => c.CategoryId == id);
        }

        public IEnumerable<Category> GetMany(Expression<Func<Category, bool>> where)
        {
            return dataContextProvider.Categories.AsQueryable().Where(where);
        }

        public void Update(Category entity)
        {
            var category = GetById(entity.CategoryId);
            TinyMapper.Map(entity, category);
        }

        private int GetNextId()
        {
            return dataContextProvider.Categories.SafeMax(c => c.CategoryId) + 1;
        }
    }
}