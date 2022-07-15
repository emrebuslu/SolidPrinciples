namespace DIP.PoorExample
{
    public class ProductDataAccess
    {
        public Product GetProductInfo(int id)
        {
            Product product = Factory.GetProductObject();
            product.Id = id;
            product.Name = "Mobile Phone";
            product.Price = 3000;
            product.Trademark = "Sansong";
            return product;
        }
    }
}
