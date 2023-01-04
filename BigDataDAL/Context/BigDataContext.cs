using BigDataEntities.User;
using Microsoft.EntityFrameworkCore;

namespace BigDataDAL.Context
{
    public class BigDataContext : DbContext
    {
        public BigDataContext(DbContextOptions<BigDataContext> options) : base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(f => f.UserID)
                .ValueGeneratedOnAdd();


        }


        public virtual DbSet<User> Users { get; set; }

    }
}
