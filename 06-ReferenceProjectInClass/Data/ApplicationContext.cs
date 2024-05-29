using Microsoft.EntityFrameworkCore;

namespace Data{
    public class ApplicationContext : DbContext
    {
        public DbSet<Article> Articles {get;set;}
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}