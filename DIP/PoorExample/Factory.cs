namespace DIP.PoorExample
{
    public class Factory
    {
        public static ProductDataAccess GetProductDataAccessObject()
        {
            return new ProductDataAccess();
        }
        public static Product GetProductObject()
        {
            return new Product();
        }
    }
}
