namespace DTO
{
    public class DTO_Orders
    {
        public string OrderID { get; set; }
        public string Username { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductID { get; set; }
        public string PName { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public string PStatus { get; set; }

        public DTO_Orders() { }

        public DTO_Orders(string orderID, string username, DateTime orderDate, string productID, string pName, string brand, string color, int quantity, decimal unitPrice, string imagePath, string status)
        {
            OrderID = orderID;
            Username = username;
            OrderDate = orderDate;
            ProductID = productID;
            PName = pName;
            Brand = brand;
            Color = color;
            Quantity = quantity;
            UnitPrice = unitPrice;
            ImagePath = imagePath;
            PStatus = status;
        }
    }
}