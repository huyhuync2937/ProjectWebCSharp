using System;
using System.Collections.Generic;

#nullable disable

namespace Project2.Models
{
    public partial class User
    {
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }

        public virtual UserDetail UserDetail { get; set; }

        public User(string userName, string password, int isAdmin)
        {
            UserName = userName;
            Password = password;
            IsAdmin = isAdmin;
        }

        public User()
        {
        }
    }

}
