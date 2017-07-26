using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN.Data.Entities;

namespace WebProjectMvc_INFRASTRUCTURE.Mapping
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(t => t.ID);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(80);

        }

    }
}
