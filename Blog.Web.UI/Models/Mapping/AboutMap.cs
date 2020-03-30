using Blog.Web.UI.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Mapping
{
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable("Abouts", "dbo");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Description).HasColumnName("Description");
            builder.Property(x => x.Title).HasColumnName("Title");
            builder.Property(x => x.Address).HasColumnName("Address");
            builder.Property(x => x.Email).HasColumnName("Email");
        }
    }
}
