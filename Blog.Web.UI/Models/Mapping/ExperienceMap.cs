using Blog.Web.UI.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Mapping
{
    public class ExperienceMap : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experiences", "dbo");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Title).HasColumnName("Title");
            builder.Property(x => x.CompanyName).HasColumnName("CompanyName");
            builder.Property(x => x.Description).HasColumnName("Description");
            builder.Property(x => x.DateOfFinish).HasColumnName("DateOfFinish");
            builder.Property(x => x.DateOfStart).HasColumnName("DateOfStart");
            builder.Property(x => x.Status).HasColumnName("Status");
        }
    }
}
