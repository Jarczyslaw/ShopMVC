using System;

namespace ShopMVC.DataAccess.Factories
{
    public class DataContextFactory : IDataContextFactory, IDisposable
    {
        private DataContext dataContext;

        public DataContext GetContext()
        {
            return dataContext ?? (dataContext = new DataContext());
        }

        public void Dispose()
        {
            dataContext?.Dispose();
        }
    }
}