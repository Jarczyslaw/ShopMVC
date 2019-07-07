namespace ShopMVC.DataAccess
{
    public interface IDataContextFactory
    {
        DataContext GetContext();
    }
}