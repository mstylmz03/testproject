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
   public class ProductService : IProductService
    {
        IRepository<Product> ProductRepo;

        public ProductService()
        {
            ProductRepo = new GenericRepository<Product>();
        }

        public IEnumerable<Product> GetList()
        {
            return ProductRepo.GetList(); 
        }

        public void Insert(Product entity)
        {
            ProductRepo.Insert(entity);
        }

        public int Save()
        {
            return ProductRepo.Save();
        }
    }
}
