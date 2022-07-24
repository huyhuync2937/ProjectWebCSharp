using Microsoft.Data.SqlClient;
using Project2.DataAccess;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Logic
{
    public class ProductDetailManager
    {
        internal static int SetNewProduct(ProductDetail productDetailNew)
        {
            string sql = "INSERT INTO [dbo].[Product_Detail] ([ProductID],[Brand],[Origin],[Description],[TypeID]) VALUES(@ProductID,@Brand,@Origin,@Description,@TypeID)";
            SqlParameter sqlParameter1 = new SqlParameter("@ProductID", System.Data.SqlDbType.Int);
            sqlParameter1.Value = productDetailNew.ProductId;
            SqlParameter sqlParameter2 = new SqlParameter("@Brand", System.Data.SqlDbType.NVarChar);
            sqlParameter2.Value = productDetailNew.Brand;
            SqlParameter sqlParameter3 = new SqlParameter("@Origin", System.Data.SqlDbType.NVarChar);
            sqlParameter3.Value = productDetailNew.Origin;
            SqlParameter sqlParameter4 = new SqlParameter("@Description", System.Data.SqlDbType.NVarChar);
            sqlParameter4.Value = productDetailNew.Description;
            SqlParameter sqlParameter5 = new SqlParameter("@TypeID", System.Data.SqlDbType.Int);
            sqlParameter5.Value = productDetailNew.TypeId;
            SqlParameter[] sqlParameters = { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5 };
            return DAO.ExecuteSql(sql, sqlParameters);

            //using(var context = new DBContext())
            //{
            //    context.ProductDetails.Add(productDetailNew);
            //    context.SaveChanges();
            //}
        }

        internal static List<ProductDetail> GetAllProductDetail()
        {
            List<ProductDetail> productDetails = new List<ProductDetail>();
            using (var context = new DBContext())
            {
                productDetails = context.ProductDetails.ToList();
                foreach (var productDetail in productDetails)
                {
                    productDetail.Product = context.Products.FirstOrDefault(x => x.ProductId == productDetail.ProductId);

                }
            }
            return productDetails;


        }

        internal static List<ProductDetail> GetProductByTypeID(int typeID)
        {
            List<ProductDetail> productDetails = new List<ProductDetail>();
            foreach (ProductDetail productDetail in ProductDetailManager.GetAllProductDetail())
            {
                if (productDetail.TypeId == typeID)
                {
                    productDetails.Add(productDetail);
                }
            }
            return productDetails;

        }

        internal static List<ProductDetail> GetProductDetailPaging(int typeID, int Offset, int pageSize)
        {
            List<ProductDetail> productDetails = new List<ProductDetail>();
            using (var context = new DBContext())
            {
                productDetails= context.ProductDetails.Where(x => x.TypeId == typeID).Skip(Offset - 1).Take(pageSize).ToList();
                foreach (ProductDetail pr in productDetails)
                {
                    pr.Product = context.Products.FirstOrDefault(x => x.ProductId == pr.ProductId);
                }
            }
            return productDetails;
        }

        internal static int DeleteProductDetailByProductID(int productID)
        {

            string sql = "DELETE FROM  Product_Detail WHERE ProductID = @s";
            SqlParameter sqlParameter = new SqlParameter("@s", System.Data.SqlDbType.Int);
            sqlParameter.Value = productID;
            SqlParameter[] sqlParameters = { sqlParameter };
            return DAO.ExecuteSql(sql, sqlParameters);
        }

        internal static int GetNumerOfProduct(int typeID)
        {
            using (var context = new DBContext())
            {
                return context.ProductDetails.Where(x => x.TypeId == typeID).Count();
            }
        }

        internal static ProductDetail GetProductDetailByProductID(int productId)
        {
            using (var context = new DBContext())
            {
                ProductDetail productDetail = context.ProductDetails.FirstOrDefault(x => x.ProductId == productId);
                productDetail.Product = ProductManager.GetProductByProductID(productId);
                return productDetail;
            }
        }

        internal static int UpdateProduct(ProductDetail productDetail)
        {
            string sql1 = "UPDATE [dbo].[Product_Detail] SET [Brand] = @Brand ,[Origin] = @Origin, [Description] = @Description ,[TypeID] = @TypeID WHERE ProductID = @id ";
            SqlParameter para1 = new SqlParameter("@Brand", System.Data.SqlDbType.NVarChar);
            para1.Value =productDetail.Brand;
            SqlParameter para2 = new SqlParameter("@Origin", System.Data.SqlDbType.NVarChar);
            para2.Value = productDetail.Origin;
            SqlParameter para3 = new SqlParameter("@Description", System.Data.SqlDbType.NVarChar);
            para3.Value = productDetail.Description;
            SqlParameter para4 = new SqlParameter("@TypeID", System.Data.SqlDbType.Int);
            para4.Value = productDetail.TypeId;
            SqlParameter para5 = new SqlParameter("@id", System.Data.SqlDbType.Int);
            para5.Value = productDetail.ProductId;
            SqlParameter[] sqlParameters = { para1, para2, para3, para4, para5 };


            return DAO.ExecuteSql(sql1, sqlParameters);
        }
    }
}
