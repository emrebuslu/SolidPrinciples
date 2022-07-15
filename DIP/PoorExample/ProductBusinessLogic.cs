namespace DIP.PoorExample
{
    public class ProductBusinessLogic
    {
        ProductDataAccess _productDataAccess;
        public ProductBusinessLogic()
        {
            _productDataAccess = Factory.GetProductDataAccessObject();
        }
        public Product GetProductInfo(int id)
        {
            return _productDataAccess.GetProductInfo(id);
        }
    }
}
