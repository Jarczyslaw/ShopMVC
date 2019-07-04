﻿using ShopMVC.DataAccess.Models;
using ShopMVC.DataAccess.Repositories;
using ShopMVC.DataAccess.UnitsOfWork;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ShopMVC.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICoursesRepository coursesRepository;

        public CoursesService(ICoursesRepository coursesRepository, IUnitOfWork unitOfWork)
        {
            this.coursesRepository = coursesRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Course> GetAll()
        {
            return coursesRepository.GetAll();
        }

        public IEnumerable<Course> GetBestsellers(int count = 3)
        {
            var courses = coursesRepository.GetMany(c => !c.Hidden && c.Bestseller);
            return courses.OrderBy(_ => Guid.NewGuid()).Take(count).ToList();
        }

        public Course GetCourseById(int id)
        {
            return coursesRepository.GetById(id);
        }

        public IEnumerable<Course> GetCoursesInCategory(int categoryId)
        {
            return coursesRepository.GetMany(c => c.CategoryId == categoryId).ToList();
        }

        public IEnumerable<Course> GetNewCourses(int count = 3)
        {
            var courses = coursesRepository.GetMany(c => !c.Hidden);
            return courses.OrderBy(c => c.AddedDate).Take(count).ToList();
        }
    }
}