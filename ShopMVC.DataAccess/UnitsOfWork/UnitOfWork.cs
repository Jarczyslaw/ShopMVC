using ShopMVC.DataAccess.Factories;
using System.Data.Entity;
using System.Linq;

namespace ShopMVC.DataAccess.UnitsOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dataContext;

        public UnitOfWork(IDataContextFactory dataContextFactory)
        {
            dataContext = dataContextFactory.GetContext();
        }

        public void Commit()
        {
            dataContext.SaveChanges();
        }

        public void Dispose()
        {
            dataContext.Dispose();
        }

        public void Revert()
        {
            foreach (var entry in dataContext.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;

                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}