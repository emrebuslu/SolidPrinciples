namespace DIP.GoodExample
{
    public class Factory
    {
        public static IProductDataAccess GetProductDataAccessObject()
        {
            return new ProductDataAccess();
        }
        public static IProduct GetProductObject()
        {
            return new Product();
        }
    }
}
