using System;
using System.Collections.Generic;

#nullable disable

namespace Project2.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ImportPrice { get; set; }
        public int? SellPrice { get; set; }
        public int? NumberOfInventory { get; set; }
        public DateTime? DateAdd { get; set; }
        public bool? Status { get; set; }
        public string Image { get; set; }

        public Product(int productId, string productName, int? importPrice, int? sellPrice, int? numberOfInventory, DateTime? dateAdd, bool? status, string image)
        {
            ProductId = productId;
            ProductName = productName;
            ImportPrice = importPrice;
            SellPrice = sellPrice;
            NumberOfInventory = numberOfInventory;
            DateAdd = dateAdd;
            Status = status;
            Image = image;
        }
    }
}
