using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectMvc_DOMAIN.Model
{
  public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        Nullable<DateTime> DeletedDate { get; set; }
        Nullable<DateTime> UpdatedDate { get; set; }
    }
}
