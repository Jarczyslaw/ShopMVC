using System;

namespace ShopMVC.DataAccess.UnitsOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Revert();
    }
}