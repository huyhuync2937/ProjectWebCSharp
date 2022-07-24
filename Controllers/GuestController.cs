using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project2.Logic;
using Project2.Models;
using System;
using System.Collections.Generic;

namespace Project2.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Home(User user)
        {
            List<Category> categories = CategoryManager.GetAllCategory();
            List<Product> productsNew = ProductManager.GetProductNew();
            List<Product> productsBest = ProductManager.GetProductBestSeller();
            HttpContext.Session.SetString("User", JsonConvert.SerializeObject(user));
            HttpContext.Session.SetString("categoryList", JsonConvert.SerializeObject(categories));


            ViewBag.productsNew = productsNew;
            ViewBag.productsBest = productsBest;

            return View(categories);
        }
        public IActionResult Login(string mess)
        {
            ViewBag.mess = mess;
            return View();
        }
        public IActionResult DoLogin(User user)
        {
            string mess = "";
            User userLogin = new User();
            userLogin = UserManager.GetUserByName(user.UserName);
            System.Diagnostics.Debug.WriteLine(userLogin.CustomerId);

            if (userLogin != null)
            {
                if (userLogin.Password.Equals(user.Password))
                {
                    return RedirectToAction("Home", userLogin);
                }
                else
                {
                    mess = "Password is wrong";
                    return RedirectToAction("Login", "Guest", new { mess = mess });
                }
            }
            else
            {
                mess = "Username is wrong";
                return RedirectToAction("Login", "Guest", new { mess = mess });
            }

        }
        public IActionResult Register(string mess)
        {
            ViewBag.mess = mess;
            return View();
        }
        public IActionResult DoRegister(User NewUser)
        {
            string mess = "";
            User user = UserManager.GetUserByName(NewUser.UserName);
            if (user == null)
            {
                user = new User(NewUser.UserName, NewUser.Password, 0);
                UserManager.SetNewUser(user);
                return RedirectToAction("AddInformation", "User");
            }
            else
            {
                mess = "Username is exist, Try again!";
                return RedirectToAction("Register", "Guest", new { mess = mess });
            }

        }

        public IActionResult OurShop(int TypeID, int Page)
        {

            if (Page <= 0) Page = 1;
            int PageSize = 3;
            List<ProductDetail> productDetail = new List<ProductDetail>();
            productDetail = ProductDetailManager.GetProductDetailPaging(TypeID, (Page - 1) * PageSize + 1, PageSize);
            int TotalProduct = ProductDetailManager.GetNumerOfProduct(TypeID);
            int TotalPage = TotalProduct / PageSize;
            if (TotalProduct % PageSize != 0) TotalPage++;
            ViewData["TotalPage"] = TotalPage;
            ViewData["CurrentPage"] = Page;
            ViewData["PrePage"] = Page - 1;
            ViewData["NextPage"] = Page + 1;
            ViewData["CurrentProduct"] = TypeID;
            ViewBag.productDetail = productDetail;

            return View();

        }
        public IActionResult FilterCategory( int TypeID)
        {
            return RedirectToAction("OurShop", "Guest", new { TypeID = TypeID, Page = -1 });

        }
       
        public IActionResult DetailProduct(int productID)
        {
            ProductDetail productDetail = ProductDetailManager.GetProductDetailByProductID(productID);
            return View(productDetail);
        }
    }
}
