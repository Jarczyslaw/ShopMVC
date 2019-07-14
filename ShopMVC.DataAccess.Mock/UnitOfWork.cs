using ShopMVC.DataAccess.Abstraction;

namespace ShopMVC.DataAccess.Mock
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContextProvider dataContextProvider;

        public UnitOfWork(IDataContextProvider dataContextProvider)
        {
            this.dataContextProvider = dataContextProvider;
        }

        public void Commit()
        {
            dataContextProvider.Save();
        }

        public void Dispose()
        {
        }

        public void Revert()
        {
            dataContextProvider.Load();
        }
    }
}