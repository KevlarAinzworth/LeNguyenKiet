namespace LeNguyenKiet.Models
{
    public class ProductListModel
    {
        public string ProductName { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public double ProductDiscount { get; set; }
        public double DiscountAmount { get; set; }
        public double TotalBefore { get; set; }
        public double TotalAfter { get; set; }
        //int Id { get; set; }

        public ProductListModel() { }
        public ProductListModel(string name,int quantity, int price, double discount)
        {
            this.ProductName = name;
            this.ProductQuantity = quantity;   
            this.ProductPrice = price;
            this.ProductDiscount = discount;
            this.TotalBefore = price * quantity;
            this.DiscountAmount = TotalBefore * (discount / 100);
            this.TotalAfter = TotalBefore - DiscountAmount;
        }
    }
}
