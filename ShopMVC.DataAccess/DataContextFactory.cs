using System;

namespace ShopMVC.DataAccess
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