namespace PRODUCTMANAGER
{
    public class Product
    {
        private int proId;
        private string? proName;
        private double proPrice;
        public Product(){}
        public Product(int proId, string proName, double proPrice)
        {
            this.ProId = proId;
            this.ProName = proName;
            this.ProPrice = proPrice;
        }
        public int ProId { get => proId; set => proId = value; }
        public string? ProName { get => proName; set => proName = value; }
        public double ProPrice { get => proPrice; set => proPrice = value; }
    }
}