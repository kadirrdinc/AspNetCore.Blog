using Blog.Web.UI.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Mapping
{
    public class ReferenceMap : IEntityTypeConfiguration<Reference>
    {
        public void Configure(EntityTypeBuilder<Reference> builder)
        {
            builder.ToTable("References", "dbo");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.FullName).HasColumnName("FullName");
            builder.Property(x => x.CompanyName).HasColumnName("CompanyName");
            builder.Property(x => x.Title).HasColumnName("Title");
            builder.Property(x => x.Email).HasColumnName("Email");
        }
    }
}
