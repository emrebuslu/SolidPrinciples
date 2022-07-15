namespace DIP.GoodExample
{
    public class ProductDataAccess : IProductDataAccess
    {
        public IProduct GetProductInfo(int id)
        {
            IProduct product = Factory.GetProductObject();
            product.Id = id;
            product.Name = "Mobile Phone";
            product.Price = 3000;
            product.Trademark = "Sansong";
            
            return product;
        }
    }
}
