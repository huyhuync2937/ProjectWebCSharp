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

                //System.Diagnostics.Debug.WriteLine(user.CustomerId);
                return RedirectToAction("AddInformation", "User");
            }
            else
            {
                mess = "Username is exist, Try again!";
                return RedirectToAction("Register", "Guest", new { mess = mess });
            }

        }


        public IActionResult OurShop()
        {
            return View();
        }
        public IActionResult DetailProduct()
        {
            return View();
        }
    }
}
