using System;
using System.Collections.Generic;

#nullable disable

namespace Project2.Models
{
    public partial class Category
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int ParentId { get; set; }
    }
}
