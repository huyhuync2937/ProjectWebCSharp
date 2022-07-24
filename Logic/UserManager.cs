using Project2.Models;
using System;
using System.Collections.Generic;
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
            using (var context = new DBContext())
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

        internal static User GetUserById(int userID)
        {
            using (var context = new DBContext())
            {
                User user = context.Users.FirstOrDefault(x => x.CustomerId == userID);
                return user;
            }
        }

        internal static void ChangeIsAdmin(int type, int userID)
        {
            System.Diagnostics.Debug.WriteLine(type + " type change");

            using (var context = new DBContext())
            {
                User user = new User();

                user = context.Users.FirstOrDefault(x => x.CustomerId == userID);
                user.IsAdmin = type;
                context.SaveChanges();

            }
        }

        internal static void DeleteUserByUserId(int userID)
        {
            using(var context = new DBContext())
            {
                User user = context.Users.FirstOrDefault(x => x.CustomerId == userID);
                context.Users.Remove(user);
            }
        }

        internal static void UpdatePassword(User userNewPassword)
        {
            User user = new User();
            using (var context = new DBContext())
            {
                user = context.Users.FirstOrDefault(x => x.CustomerId == userNewPassword.CustomerId);
                user.Password = userNewPassword.Password;

                context.SaveChanges();
            }

        }

        internal static List<User> GetAllUser()
        {
            List<User> users = new List<User>();
            using (var context = new DBContext())
            {
                users = context.Users.ToList();
                foreach (var user in users)
                {
                    user.UserDetail = context.UserDetails.FirstOrDefault(x => x.CustomerId == user.CustomerId);
                }
            }
            return users;
        }
    }
}
