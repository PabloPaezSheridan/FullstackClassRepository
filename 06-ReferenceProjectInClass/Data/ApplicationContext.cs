using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data{
    public class ApplicationContext : DbContext
    {
        public DbSet<Article> Articles {get;set;}
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Article>()
                .Property(a => a.Skill)
                .HasConversion(new EnumToStringConverter<ExperienceSkillEnum>());
        }

    }
}