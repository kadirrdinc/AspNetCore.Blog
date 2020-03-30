using Blog.Web.UI.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Mapping
{
    public class EducationMap : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations", "dbo");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.SchoolName).HasColumnName("SchoolName");
            builder.Property(x => x.SectionName).HasColumnName("SectionName");
            builder.Property(x => x.DateOfStart).HasColumnName("DateOfStart");
            builder.Property(x => x.DateOfFinish).HasColumnName("DateOfFinish");
            builder.Property(x => x.Status).HasColumnName("Status");
        }
    }
}
