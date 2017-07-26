using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN;
using WebProjectMvc_DOMAIN.Data.Entities;
using WebProjectMvc_DOMAIN.IServices;
using WebProjectMvc_INFRASTRUCTURE.BaseServices;

namespace WebProjectMvc_SERVICE.Services
{
   public class CategoryService : ICategoryService
    {
        private IRepository<Category> CategoryRepo;

        public CategoryService()
        {
            CategoryRepo = new GenericRepository<Category>();
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return CategoryRepo.GetList();
        }
    }
}
