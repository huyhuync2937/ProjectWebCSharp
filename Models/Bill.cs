using System;
using System.Collections.Generic;

#nullable disable

namespace Project2.Models
{
    public partial class Bill
    {
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int? Price { get; set; }
        public int? Number { get; set; }
        public DateTime? DateTrading { get; set; }
        public bool? Status { get; set; }
        public int BillId { get; set; }

        public virtual User Customer { get; set; }
        public virtual Product Product { get; set; }

        public Bill(int customerId, string productName, int productId, int? price, int? number, DateTime? dateTrading, bool? status, int billId)
        {
            CustomerId = customerId;
            ProductName = productName;
            ProductId = productId;
            Price = price;
            Number = number;
            DateTrading = dateTrading;
            Status = status;
            BillId = billId;
           
        }
    }
}
