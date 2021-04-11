using Microsoft.EntityFrameworkCore;

namespace dontTrustMe.Models
{
    public class YummyContext : DbContext
    {     
        public YummyContext() 
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Data Source=yum.db");
        }
        public DbSet<Yummy> Yummies { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}

