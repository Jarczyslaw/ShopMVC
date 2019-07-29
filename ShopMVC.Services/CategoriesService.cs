using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVC.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICategoriesRepository categoriesRepository;

        public CategoriesService(ICategoriesRepository categoriesRepository, IUnitOfWork unitOfWork)
        {
            this.categoriesRepository = categoriesRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetAll()
        {
            return categoriesRepository.GetAll();
        }

        public IEnumerable<Category> GetCategoriesList()
        {
            return GetAll().OrderBy(c => c.Title);
        }

        public Category GetCategoryById(int id)
        {
            return categoriesRepository.GetById(id);
        }
    }
}