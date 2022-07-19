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

        internal static List<Product> GetProductNew()
        {
            List<Product> products = new List<Product>();
            using(var context = new DBContext())
            {
                products = context.Products.OrderBy(x => x.DateAdd).Take(8).ToList();
            }
            foreach(var product in products)
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
    }
}
