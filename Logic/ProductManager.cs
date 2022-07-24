using Microsoft.Data.SqlClient;
using Project2.DataAccess;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Project2.Logic
{
    public class ProductManager
    {
        internal static List<Product> GetProductBestSeller()
        {
            string sql = "select p.* from (select count(BillID) as [count],ProductID from Bill group by ProductID) as t left outer join Product as p on p.ProductID = t.ProductID";
            DataTable dataTable = DAO.GetDataBySql(sql);
            return ConvertToListProdcut(dataTable);

        }

        internal static List<Product> GetAllProduct()
        {
            using (var context = new DBContext())
            {

                return context.Products.ToList();
            }
        }

        internal static List<Product> GetProductNew()
        {
            List<Product> products = new List<Product>();
            using (var context = new DBContext())
            {
                products = context.Products.OrderBy(x => x.DateAdd).Take(8).ToList();
            }
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductId);
            }
            return products;
        }

        private static List<Product> ConvertToListProdcut(DataTable dataTable)
        {
            List<Product> products = new List<Product>();
            foreach (DataRow dr in dataTable.Rows)
            {
                products.Add(new Product(
                    Convert.ToInt32(dr[0]),
                    dr[1].ToString(),
                    Convert.ToInt32(dr[2]),
                    Convert.ToInt32(dr[3]),
                    Convert.ToInt32(dr[4]),
                    Convert.ToDateTime(dr[5]),
                    Convert.ToBoolean(dr[6]),
                    dr[7].ToString()
                    ));

            }
            return products;
        }

        internal static void SetNewProduct(Product product)
        {
            using (var context = new DBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        internal static int GetProductNewId()
        {
            using (var context = new DBContext())
            {
                return context.Products.OrderByDescending(x => x.ProductId).FirstOrDefault().ProductId;
            }
        }


        internal static void DeleteProductByProductID(int productID)
        {
            using (var context = new DBContext())
            {
                context.Products.Remove(context.Products.FirstOrDefault(x => x.ProductId == productID));
                context.SaveChanges();
            }
        }

        internal static Product GetProductByProductID(int productId)
        {
            using (var context = new DBContext())
            {
                return context.Products.FirstOrDefault(x => x.ProductId == productId);
            }
        }

        internal static int UpdateProduct(Product product)
        {
            string sql1 = "UPDATE [dbo].[Product] SET [ProductName] = @ProductName ,[ImportPrice] = @ImportPrice ,[SellPrice] = @SellPrice ,[Number of Inventory] = @number ,[Date add] = @date WHERE ProductID = @id";
            SqlParameter para1 = new SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar);
            para1.Value = product.ProductName;
            SqlParameter para2 = new SqlParameter("@ImportPrice", System.Data.SqlDbType.Int);
            para2.Value = product.ImportPrice;
            SqlParameter para3 = new SqlParameter("@SellPrice", System.Data.SqlDbType.Int);
            para3.Value = product.SellPrice;
            SqlParameter para4 = new SqlParameter("@number", System.Data.SqlDbType.Int);
            para4.Value = product.NumberOfInventory;
            SqlParameter para5 = new SqlParameter("@date", System.Data.SqlDbType.DateTime);
            para5.Value = product.DateAdd;
            SqlParameter para6 = new SqlParameter("@id", System.Data.SqlDbType.Int);
            para6.Value = product.ProductId;

         

            SqlParameter[] sqlParameters = { para1, para2, para3, para4, para5, para6 };
            return DAO.ExecuteSql(sql1, sqlParameters);
        }
    }
}
