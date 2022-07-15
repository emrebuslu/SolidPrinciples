namespace DIP.GoodExample
{
    public class ProductBusinessLogic
    {
        IProductDataAccess _productDataAccess;
        public ProductBusinessLogic(IProductDataAccess productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }

        public IProduct GetProductInfo(int id)
        {
            return _productDataAccess.GetProductInfo(id);
        }
    }
}
