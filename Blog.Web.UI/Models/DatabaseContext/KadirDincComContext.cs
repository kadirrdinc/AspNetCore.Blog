using Blog.Web.UI.Models.Entity;
using Blog.Web.UI.Models.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.DatabaseContext
{
    public class KadirDincComContext : DbContext
    {
        public KadirDincComContext(DbContextOptions<KadirDincComContext> options) : base(options)
        {

        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<About>(new AboutMap());
            modelBuilder.ApplyConfiguration<Education>(new EducationMap());
            modelBuilder.ApplyConfiguration<Experience>(new ExperienceMap());
            modelBuilder.ApplyConfiguration<Project>(new ProjectMap());
            modelBuilder.ApplyConfiguration<Reference>(new ReferenceMap());
            modelBuilder.ApplyConfiguration<Skill>(new SkillMap());
        }

    }


}
