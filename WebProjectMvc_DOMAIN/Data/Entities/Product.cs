using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN.Model;

namespace WebProjectMvc_DOMAIN.Data.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public short Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public int IsDisCountinued { get; set; }

        public int CategoryID { get; set; } //foregeankey alanım
        public virtual Category Category { get; set; } //Bir product ın bir categorisi var.

       
    }
}
