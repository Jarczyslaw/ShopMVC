using System;

namespace ShopMVC.DataAccess.Abstraction
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Revert();
    }
}