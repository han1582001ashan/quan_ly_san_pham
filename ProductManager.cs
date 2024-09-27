using System.Text.Json;
namespace PRODUCTMANAGER
{
    public class ProductManager
    {
        Product[]? products;
        private string sourceFilePath = @"/Users/loopo/OneDrive/Desktop/BT Codegym/quan_ly_san_pham/product.csv";
        public ProductManager()
        {
            products = new Product[]
            {
                new Product(1, "Iphone", 100),
                new Product(2, "Samsung", 200),
                new Product(3, "OPPO", 250)
            };
        }
        public Product[]? loadProduct()
        {
            var jsonData = File.ReadAllText(sourceFilePath);
            products = JsonSerializer.Deserialize<Product[]>(jsonData);
            if (products != null)
                return products;
            return null;
        }
        public void insertProduct(Product product)
        {
            products = loadProduct();
            if (product != null)
            {
                if (products != null)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = product;
                }
            }
            var jsonData = JsonSerializer.Serialize(products);
            File.WriteAllText(sourceFilePath, jsonData);
        }
        public Product? findById(int id)
        {
            products = loadProduct();
            if (products != null)
            {
                foreach (Product product in products)
                {
                    if (product.ProId == id)
                        return product;
                }
            }
            return null;
        }
        public void updateById(int id, Product _product)
        {
            products = loadProduct();
            if (products != null)
            {
                foreach (Product product in products)
                {
                    if (product.ProId == id)
                    {
                        product.ProName = _product.ProName;
                        product.ProPrice = _product.ProPrice;
                    }
                }
            }
            var jsonData = JsonSerializer.Serialize(products);
            File.WriteAllText(sourceFilePath, jsonData);
        }
    }
}