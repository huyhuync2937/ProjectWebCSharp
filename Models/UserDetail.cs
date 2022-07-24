using System;
using System.Collections.Generic;

#nullable disable

namespace Project2.Models
{
    public partial class UserDetail
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual User Customer { get; set; }
    }
}
