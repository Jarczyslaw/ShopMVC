using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopMVC.DataAccess.Mock
{
    public class CoursesRepository : ICoursesRepository
    {
        public void Add(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Course, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Course Get(Expression<Func<Course, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetMany(Expression<Func<Course, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}