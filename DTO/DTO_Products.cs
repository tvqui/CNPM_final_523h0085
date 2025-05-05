using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Products
    {
        public string ProductID { get; set; }
        public string PName { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public DTO_Products() { }

        public DTO_Products(string productID, string pName, string brand, string color, string type, decimal price, int stockQuantity, string imagePath, DateTime createdAt, DateTime updatedAt)
        {
            ProductID = productID;
            PName = pName;
            Brand = brand;
            Color = color;
            Type = type;
            Price = price;
            StockQuantity = stockQuantity;
            ImagePath = imagePath;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
