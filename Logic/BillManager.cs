using Microsoft.Data.SqlClient;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Project2.DataAccess;

namespace Project2.Logic
{
    public class BillManager
    {
        private static List<Bill> ConvertToListBill(DataTable dt)
        {
            List<Bill> BillList = new List<Bill>();
            foreach (DataRow dr in dt.Rows)
            {
                BillList.Add(new Bill(
                   Convert.ToInt32(dr[0]),
                    dr[1].ToString(),
                    Convert.ToInt32(dr[2]),
                    Convert.ToInt32(dr[3]),
                    Convert.ToInt32(dr[4]),
                    Convert.ToDateTime(dr[5]),
                    Convert.ToBoolean(dr[6]),
                    Convert.ToInt32(dr[7])
                   ));
            }
            return BillList;
        }

        internal static void DeleteBillByUserId(int userID)
        {
            List<Bill> bills = new List<Bill>();
            using (var context = new DBContext())
            {
                bills = context.Bills.Where(x => x.CustomerId == userID).ToList();
                context.Bills.RemoveRange(bills);
            }
        }

        internal static void DeleteBillByProductID(int productID)
        {
            List<Bill> billList = new List<Bill>();
            using (var context = new DBContext())
            {
                billList = context.Bills.Where(x => x.ProductId == productID).ToList();
                if (billList.Count > 0)
                {
                    context.Bills.RemoveRange(billList);

                }
                context.SaveChanges();
            }
        }

        internal static int SetNewBill(Bill bill)
        {
            string sql = "INSERT INTO [dbo].[Bill]\n"
                + "           ([CustomerID]\n"
                + "           ,[ProductName]\n"
                + "           ,[ProductID]\n"
                + "           ,[Price]\n"
                + "           ,[Number]\n"
                + "           ,[Date Trading],[Status]  )\n"
                + "     VALUES(@CustomerID,@ProductName,@ProductID,@Price,@Number,@Date,@Status)";
            SqlParameter para1 = new SqlParameter("@CustomerID", System.Data.SqlDbType.Int);
            para1.Value = bill.CustomerId;
            SqlParameter para2 = new SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar);
            para2.Value = bill.ProductName;
            SqlParameter para3 = new SqlParameter("@ProductID", System.Data.SqlDbType.Int);
            para3.Value = bill.ProductId;
            SqlParameter para4 = new SqlParameter("@Price", System.Data.SqlDbType.Int);
            para4.Value = bill.Price;
            SqlParameter para5 = new SqlParameter("@Number", System.Data.SqlDbType.Int);
            para5.Value = bill.Number;
            SqlParameter para6 = new SqlParameter("@Date", System.Data.SqlDbType.Date);
            para6.Value = bill.DateTrading;
            SqlParameter para7 = new SqlParameter("@Status", System.Data.SqlDbType.Bit);
            para7.Value = bill.Status;
            SqlParameter[] sqlParameters = { para1, para2, para3, para4, para5, para6, para7 };

            return DAO.ExecuteSql(sql, sqlParameters);
        }

        internal static List<Bill> GetBillByUserId(int customerId)
        {
            List<Bill> billList = new List<Bill>();
            using (var context = new DBContext())
            {
                billList = context.Bills.Where(x => x.CustomerId == customerId).ToList();
                foreach (var bill in billList)
                {

                    bill.Product = context.Products.FirstOrDefault(x => x.ProductId == bill.ProductId);
                }
            }
            return billList;
        }

        internal static int DeleteBillByBillID(int billID)
        {
            string sql = "DELETE FROM [dbo].[Bill] WHERE BillID = @billID";
            SqlParameter sql1 = new SqlParameter("@billID", System.Data.SqlDbType.Int);
            sql1.Value = billID;
            SqlParameter[] sqlParameters = { sql1 };

            return DAO.ExecuteSql(sql, sqlParameters);
        }

        internal static int UpdateQuantity(int quantity, int billID)
        {
            string sql = "UPDATE[dbo].[Bill]  SET [Number] = @quantity WHERE [BillID]= @billID";
            SqlParameter sql1 = new SqlParameter("@quantity", System.Data.SqlDbType.Int);
            sql1.Value = quantity;
            SqlParameter sql2 = new SqlParameter("@billID", System.Data.SqlDbType.Int);
            sql2.Value = billID;
            SqlParameter[] sqlParameters = { sql1, sql2 };
            return DAO.ExecuteSql(sql, sqlParameters);
        }
    }
}
