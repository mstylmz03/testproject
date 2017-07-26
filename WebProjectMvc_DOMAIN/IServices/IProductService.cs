using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN.Data.Entities;

namespace WebProjectMvc_DOMAIN.IServices
{
   public interface IProductService
    {
        IEnumerable<Product> GetList();
        int Save();
        void Insert(Product entity);

    }
}
