using Nelibur.ObjectMapper;
using ShopMVC.Commons;
using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopMVC.DataAccess.Mock
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly IDataContextProvider dataContextProvider;

        public CoursesRepository(IDataContextProvider dataContextProvider)
        {
            this.dataContextProvider = dataContextProvider;
        }

        public void Add(Course entity)
        {
            entity.CourseId = GetNextId();
            dataContextProvider.Courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var course = GetById(entity.CourseId);
            dataContextProvider.Courses.Remove(course);
        }

        public void Delete(Expression<Func<Course, bool>> where)
        {
            var course = dataContextProvider.Courses.AsQueryable().SingleOrDefault(where);
            if (course != null)
            {
                dataContextProvider.Courses.Remove(course);
            }
        }

        public Course Get(Expression<Func<Course, bool>> where)
        {
            return dataContextProvider.Courses.AsQueryable().SingleOrDefault(where);
        }

        public IEnumerable<Course> GetAll()
        {
            return dataContextProvider.Courses;
        }

        public Course GetById(int id)
        {
            return dataContextProvider.Courses.SingleOrDefault(c => c.CourseId == id);
        }

        public IEnumerable<Course> GetMany(Expression<Func<Course, bool>> where)
        {
            return dataContextProvider.Courses.AsQueryable().Where(where);
        }

        public void Update(Course entity)
        {
            var course = GetById(entity.CourseId);
            TinyMapper.Map(entity, course);
        }

        private int GetNextId()
        {
            return dataContextProvider.Categories.SafeMax(c => c.CategoryId) + 1;
        }
    }
}