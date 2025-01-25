using Microsoft.EntityFrameworkCore;

namespace BackendTemplate
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {   
        }

        //public DbSet<Entity> EntitesName { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>(builder =>
            {
                //set Entity constraints and roles
                //builder.HasIndex(s => s.Code).IsUnique();
                //chek more att : https://learn.microsoft.com/en-us/ef/core/modeling/keys?tabs=data-annotations
            });
        }*/
    }
}
