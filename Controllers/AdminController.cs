using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project2.Logic;
using Project2.Models;
using System;
using System.Collections.Generic;

namespace Project2.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult DisplayProduct()
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                List<Product> products = new List<Product>();
                List<Category> categories = new List<Category>();

                products = ProductManager.GetAllProduct();
                categories = CategoryManager.GetAllCategory();

                ViewBag.Products = products;
                ViewBag.Categories = categories;
                return View();

            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }

        }
        public IActionResult DisplayUser()
        {

            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                List<User> userList = new List<User>();
                userList = UserManager.GetAllUser();
                ViewBag.userList = userList;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }

        }
        public IActionResult AddProduct()
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                List<Category> categories = CategoryManager.GetAllCategory();
                ViewBag.categories = categories;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }

        }

        public IActionResult DoAddProduct(string Name, string ImportPrice, string SellPrice, string Description, int TypeID, string Brand, string Origin, string DateAdd, string NumberOfInventory)
        {
            ProductDetail productDetail = new ProductDetail();
            Product product = new Product();
            product.ProductName = Name;
            product.ImportPrice = Convert.ToInt32(ImportPrice);
            product.SellPrice = Convert.ToInt32(SellPrice);
            productDetail.Description = Description;
            productDetail.TypeId = TypeID;
            productDetail.Brand = Brand;
            productDetail.Origin = Origin;
            product.DateAdd = DateTime.ParseExact(DateAdd, "dd/MM/yyyy", null);
            product.NumberOfInventory = Convert.ToInt32(NumberOfInventory);
            productDetail.Product = product;

            ProductManager.SetNewProduct(product);
            int id = ProductManager.GetProductNewId();
            productDetail.ProductId = id;

            ProductDetailManager.SetNewProduct(productDetail);
            string mess = "";
            return RedirectToAction("AddProduct", "Admin", new { mess = mess });
        }

        public IActionResult AddCategory(string mess)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                List<Category> categories = CategoryManager.GetAllCategory();
                if (mess != null)
                {
                    if (mess.Equals("Category is exist"))
                        ViewBag.mess1 = "Category is exist";
                    else
                        ViewBag.mess1 = "Type category is exist";
                }


                return View(categories);
            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }

        }

        public IActionResult DeleteProduct(int productID)
        {
            BillManager.DeleteBillByProductID(productID);
            ProductDetailManager.DeleteProductDetailByProductID(productID);
            ProductManager.DeleteProductByProductID(productID);
            return RedirectToAction("DisplayProduct", "Admin");

        }

        public IActionResult DoAddNewCategory(Category category)
        {
            string mess = "Category is exist";
            if (!CategoryManager.IsExistCategory(category.TypeName))
            {
                category.ParentId = 0;
                CategoryManager.SetNewCategory(category);
                return RedirectToAction("AddCategory", "Admin");
            }
            else
            {
                return RedirectToAction("AddCategory", "Admin", new { mess = mess });
            }
        }
        public IActionResult ChangeIsAdmin(int type, int userID)
        {

            UserManager.ChangeIsAdmin(type, userID);
            //System.Diagnostics.Debug.WriteLine(user.CustomerId);


            return RedirectToAction("DisplayUser", "Admin");
        }
        public IActionResult HideUser(int userID)
        {
            UserManager.ChangeIsAdmin(2, userID);
            return RedirectToAction("DisplayUser", "Admin");

        }
        public IActionResult UnHideUser(int userID)
        {
            UserManager.ChangeIsAdmin(0, userID);
            return RedirectToAction("DisplayUser", "Admin");

        }
        public IActionResult UpdateProduct(int productID)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                System.Diagnostics.Debug.WriteLine(productID);
                ProductDetail productDetail = ProductDetailManager.GetProductDetailByProductID(productID);
                List<Category> categories = CategoryManager.GetAllCategory();
                ViewBag.categories = categories;
                return View(productDetail);
            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }
        }
        public IActionResult DoUpdateProduct(string ProductId, string Name, string ImportPrice, string SellPrice, string Description, string TypeID, string Brand, string Origin, string DateAdd, string NumberOfInventory)
        {

            ProductDetail productDetail = ProductDetailManager.GetProductDetailByProductID(Convert.ToInt32(ProductId));
            Product product = new Product();
            product.ProductName = Name;
            product.ImportPrice = Convert.ToInt32(ImportPrice);
            product.SellPrice = Convert.ToInt32(SellPrice);
            productDetail.Description = Description;
            productDetail.TypeId = Convert.ToInt32(TypeID);
            productDetail.Brand = Brand;
            productDetail.Origin = Origin;
            product.ProductId = Convert.ToInt32(ProductId);
            product.DateAdd = DateTime.ParseExact(DateAdd, "dd/MM/yyyy", null);
            product.NumberOfInventory = Convert.ToInt32(NumberOfInventory);
            productDetail.Product = product;
            ProductDetailManager.UpdateProduct(productDetail);
            ProductManager.UpdateProduct(productDetail.Product);
            System.Diagnostics.Debug.WriteLine(ProductId);


            return RedirectToAction("UpdateProduct", "Admin", new { productId = productDetail.ProductId });
        }
    }
}
