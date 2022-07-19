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
        public string Ingredient { get; set; }
        public string UserManual { get; set; }
        public string Description { get; set; }
        public string TypeName { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category TypeNameNavigation { get; set; }
    }
}
