using System.Text.Json;
namespace PRODUCTMANAGER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            /*  productManager.updateById(2, new Product(2, "Samsung A300", 270));  */
              Product product2 = new Product(10,"Samsung Galaxy S24", 2300);
           productManager.insertProduct(product2); 
           /*  Product? product = productManager.findById(5);

            if (product != null)
            {
                Console.WriteLine(product.ProId);
                Console.WriteLine(product.ProName);
                Console.WriteLine(product.ProPrice);
            } */
           /*  Product[]? products = productManager.loadProduct(); */
         /*    if (products != null)
            {
                foreach (Product product1 in products)
                {
                    Console.WriteLine("ProId: "  + product1.ProId);
                    Console.WriteLine("ProName: " + product1.ProName);
                    Console.WriteLine("ProPrice:"+ product1.ProPrice);
                    Console.WriteLine("-------------------");
                }
            }
          
            Console.ReadLine();  */
           
        }
    }
}