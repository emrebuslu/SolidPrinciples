using DIP.PoorExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            PoorExample();

            Console.ReadKey();
        }
        static void PoorExample()
        {
            ProductBusinessLogic productBusinessLogic = new ProductBusinessLogic();
            Product product = productBusinessLogic.GetProductInfo(1);
            Console.WriteLine($"Product's name : {product.Name} \nProduct's price : {product.Price}\nProduct's trademark : {product.Trademark}");
        }
    }
}
