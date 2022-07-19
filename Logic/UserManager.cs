using Project2.Models;
using System;
using System.Linq;

namespace Project2.Logic
{
    public class UserManager
    {
        internal static User GetUserByName(string userName)
        {
            using (var context = new DBContext())
            {
                User user = context.Users.FirstOrDefault(x => x.UserName.Equals(userName));
                if (user == null)
                    return null;
                else
                {
                    return user;
                }
            }
        }

        internal static void SetNewUser(User user)
        {
           using(var context = new DBContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        internal static User GetNewUser()
        {
            User user = new User();
            using (var context = new DBContext())
            {
                user = context.Users.OrderByDescending(x => x.CustomerId).FirstOrDefault();
               
            }
            return user;
        }
    }
}
