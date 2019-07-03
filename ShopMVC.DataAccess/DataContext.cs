using ShopMVC.DataAccess.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ShopMVC.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DataContext() : base(nameof(DataContext))
        {
            // dont initialize database every time
            //Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}