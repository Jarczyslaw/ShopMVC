using System.Data.Entity;

namespace ShopMVC.DataAccess
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            DataSeeder.SeedDatabase(context);
            base.Seed(context);
        }
    }
}