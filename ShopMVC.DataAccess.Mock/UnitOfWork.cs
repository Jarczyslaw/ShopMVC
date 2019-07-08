using ShopMVC.DataAccess.Abstraction;

namespace ShopMVC.DataAccess.Mock
{
    public class UnitOfWork : IUnitOfWork
    {
        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Revert()
        {
            throw new System.NotImplementedException();
        }
    }
}