using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectMvc_DOMAIN.Model
{
   public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
