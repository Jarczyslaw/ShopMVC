using ShopMVC.DataAccess.Abstraction;
using ShopMVC.DataAccess.Models;
using System;
using System.Collections.Generic;

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

        public Category GetCategoryById(int id)
        {
            return categoriesRepository.GetById(id);
        }
    }
}