using Project2.Models;
using System;
using System.Linq;

namespace Project2.Logic
{
    public class UserDetailManager
    {
        internal static bool IsExistEmail(string email)
        {
            UserDetail userDetail = new UserDetail();
            using (var context = new DBContext())
            {
                userDetail = context.UserDetails.FirstOrDefault(x => x.Email.Equals(email));
                if (userDetail == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        internal static UserDetail GetUserDetailByUserId(int customerId)
        {
            UserDetail userDetail = new UserDetail();
            using (var context = new DBContext())
            {
                userDetail = context.UserDetails.FirstOrDefault(x => x.CustomerId == customerId);
            }
            return userDetail;
        }

        internal static bool IsExistPhone(string phone)
        {
            UserDetail userDetail = new UserDetail();
            using (var context = new DBContext())
            {
                userDetail = context.UserDetails.FirstOrDefault(x => x.Phone.Equals(phone));
                //System.Diagnostics.Debug.WriteLine(userDetail.Name);

                if (userDetail == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        internal static void SetNewUserDetail(UserDetail userDetail)
        {
            using (var context = new DBContext())
            {
                context.UserDetails.Add(userDetail);
                context.SaveChanges();
            }
        }

        internal static void UpdateEmail(UserDetail userDetail)
        {
            using (var context = new DBContext())
            {
                UserDetail detail = context.UserDetails.FirstOrDefault(x => x.CustomerId.Equals(userDetail.CustomerId));
                if (detail != null)
                    detail.Email = userDetail.Email;
                context.SaveChanges();
            }
        }

        internal static void UpdatePhone(UserDetail userDetail)
        {
            using (var context = new DBContext())
            {
                UserDetail detail = context.UserDetails.FirstOrDefault(x => x.CustomerId.Equals(userDetail.CustomerId));
                if (detail != null)
                    detail.Phone = userDetail.Phone;
                context.SaveChanges();
            }
        }
    }
}
