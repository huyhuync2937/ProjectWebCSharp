using System;
using System.Collections.Generic;

#nullable disable

namespace Project2.Models
{
    public partial class ProductDetail
    {
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category Type { get; set; }
    }
}
