namespace ShopMVC.DataAccess.Factories
{
    public interface IDataContextFactory
    {
        DataContext GetContext();
    }
}