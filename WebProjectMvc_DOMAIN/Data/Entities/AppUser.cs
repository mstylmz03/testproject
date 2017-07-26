using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN.Model;

namespace WebProjectMvc_DOMAIN.Data.Entities
{
   public class AppUser :BaseEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirtName { get; set; }
        public string SecondName { get; set; }
    }
}
