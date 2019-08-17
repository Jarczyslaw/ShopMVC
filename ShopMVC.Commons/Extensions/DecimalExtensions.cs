namespace ShopMVC.Commons.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToCurrency(this decimal value)
        {
            return value.ToString("C");
        }
    }
}