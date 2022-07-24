using Microsoft.Data.SqlClient;
using Project2.DataAccess;
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

        internal static void DeleteUserDetailByUserId(int userID)
        {
            using (var context = new DBContext())
            {
                UserDetail userDetail = context.UserDetails.FirstOrDefault(x => x.CustomerId == userID);
                context.UserDetails.Remove(userDetail);
            }
        }

        internal static int SetNewUserDetail(UserDetail userDetail)
        {
            //using (var context = new DBContext())
            //{
            //    context.UserDetails.Add(userDetail);
            //    context.SaveChanges();
            //}
            string sql = "INSERT INTO[dbo].[User_Detail] ([CustomerID],[Name],[Address],[Birthday],[Phone] ,[Email]) VALUES (@CustomerID,@Name,@Address,@Birthday,@Phone,@Email)";
            SqlParameter sql1 = new SqlParameter("@CustomerID", System.Data.SqlDbType.Int);
            sql1.Value = userDetail.CustomerId;
            SqlParameter sql2 = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
            sql2.Value = userDetail.Name;
            SqlParameter sql3 = new SqlParameter("@Address", System.Data.SqlDbType.NVarChar);
            sql3.Value = userDetail.Address;
            SqlParameter sql4 = new SqlParameter("@Birthday", System.Data.SqlDbType.Date);
            sql4.Value = userDetail.Birthday; 
            SqlParameter sql5 = new SqlParameter("@Phone", System.Data.SqlDbType.NVarChar);
            sql5.Value = userDetail.Phone;
            SqlParameter sql6 = new SqlParameter("@Email", System.Data.SqlDbType.NVarChar);
            sql6.Value = userDetail.Email;
            SqlParameter[] sqlParameters = { sql1,sql2,sql3,sql4,sql5,sql6 };
            return DAO.ExecuteSql(sql, sqlParameters);


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

        internal static void UpdateInformation(UserDetail userDetail)
        {
            using (var context = new DBContext())
            {
                UserDetail detail = context.UserDetails.FirstOrDefault(x => x.CustomerId.Equals(userDetail.CustomerId));
                if (detail != null)
                {
                    detail.Name = userDetail.Name;
                    detail.Address = userDetail.Address;
                    detail.Birthday = userDetail.Birthday;
                }

                context.SaveChanges();
            }
        }

       
    }
}
