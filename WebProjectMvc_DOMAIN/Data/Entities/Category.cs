using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN.Model;

namespace WebProjectMvc_DOMAIN.Data.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Product> Products { get; set; } //bir kategoride birden fazla product var.

    }
}
