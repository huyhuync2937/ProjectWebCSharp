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
    public class UserController : Controller
    {

        public IActionResult Profile(List<bool> checkList)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
                //System.Diagnostics.Debug.WriteLine(user.CustomerId);
                ViewBag.CheckList = checkList;
                return View(user);
            }

            else
            {
                return RedirectToAction("Login", "Guest");
            }
        }

        public IActionResult ChangeEmail(string mess)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {

                user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
                ViewBag.mess = mess;
                return View(user);
            }

            else
            {
                return RedirectToAction("Login", "Guest");
            }
        }
        public IActionResult DoChangeEmail(UserDetail userDetail)
        {
            bool isExist = false;
            isExist = UserDetailManager.IsExistEmail(userDetail.Email);
            string mess = "Email is exist, try again!";
            if (isExist)
            {
                return RedirectToAction("ChangeEmail", "User", new { mess = mess });
            }
            else
            {
                UserDetailManager.UpdateEmail(userDetail);
                return RedirectToAction("Profile", "User");
            }

        }


        public IActionResult ChangePhone(string mess)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {

                user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
                ViewBag.mess = mess;
                return View(user);
            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }
        }

        public IActionResult DoChangePhone(UserDetail userDetail)
        {
            bool isExist = false;
            isExist = UserDetailManager.IsExistPhone(userDetail.Phone);
            string mess = "Phone is exist, try again!";
            if (isExist)
            {
                return RedirectToAction("ChangePhone", "User", new { mess = mess });
            }
            else
            {
                UserDetailManager.UpdatePhone(userDetail);
                return RedirectToAction("Profile", "User");
            }

        }

        public IActionResult ChangePassword()
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
                return View(user);
            }
            else
            {
                return RedirectToAction("Login", "Guest");

            }
        }


        public IActionResult UpdateInfomation(UserDetail userDetail)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                userDetail.CustomerId = user.CustomerId;
                UserDetailManager.UpdateInformation(userDetail);
                return RedirectToAction("Profile", "User");
            }
            else
            {
                return RedirectToAction("Login", "Guest");

            }
        }
        public IActionResult DoChangePassword(User userNewPassword)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            userNewPassword.CustomerId = user.CustomerId;
            UserManager.UpdatePassword(userNewPassword);
            return RedirectToAction("ChangePassword", "User");
        }

        public IActionResult Logout()
        {
            User user = null;
            return RedirectToAction("Home", "Guest", new { user = user });
        }
        public IActionResult AddInformation(string mess1, string mess2)
        {
            ViewBag.mess1 = mess1;
            ViewBag.mess2 = mess2;
            User user = UserManager.GetNewUser();
            ViewBag.id = user.CustomerId;
            return View();
        }

        public IActionResult DoAddInformation(string customerId, string name, string address, string birthday, string phone, string email)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.CustomerId = Convert.ToInt32(customerId);
            userDetail.Name = name;
            userDetail.Address = address;
            userDetail.Birthday = DateTime.ParseExact(birthday, "dd/mm/yyyy", null);
            bool isExistEmail = UserDetailManager.IsExistEmail(email);
            bool isExistPhone = UserDetailManager.IsExistPhone(phone);
            string mess1 = "";
            string mess2 = "";
            System.Diagnostics.Debug.WriteLine(email);

            System.Diagnostics.Debug.WriteLine(isExistEmail);
            System.Diagnostics.Debug.WriteLine(isExistPhone);
            if (isExistEmail == false && isExistPhone == false)
            {


                userDetail.Email = email;
                userDetail.Phone = phone;
                UserDetailManager.SetNewUserDetail(userDetail);
                return RedirectToAction("Login", "Guest");

            }
            else if (isExistEmail == true && isExistPhone == false)
            {
                mess1 = "Email is exist";
                return RedirectToAction("AddInformation", "User", new { mess1 = mess1, mess2 = mess2 });

            }
            else if (isExistEmail == false && isExistPhone == true)
            {
                mess2 = "Phone is exist";
                return RedirectToAction("AddInformation", "User", new { mess1 = mess1, mess2 = mess2 });

            }
            else
            {
                mess1 = "Email is exist";
                mess2 = "Phone is exist";
                return RedirectToAction("AddInformation", "User", new { mess1 = mess1, mess2 = mess2 });

            }

        }

        public IActionResult AddProductToCart(int ProductID, int quantity)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            System.Diagnostics.Debug.WriteLine(user.IsAdmin);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                
                Bill bill = new Bill();
                DateTime now = DateTime.ParseExact(DateTime.Now.ToString("MM/dd/yyyy"), "MM/dd/yyyy", null);
                user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
                Product product = ProductManager.GetProductByProductID(ProductID);
                if (quantity > 0)
                {

                    bill = new Bill(user.CustomerId, product.ProductName, product.ProductId, product.SellPrice, quantity, now, false);
                }
                else
                {
                    bill = new Bill(user.CustomerId, product.ProductName, product.ProductId, product.SellPrice, 1, now, false);
                }
                BillManager.SetNewBill(bill);
                return RedirectToAction("Cart", "User");
            }
            else
            {
                return RedirectToAction("Login", "Guest");
            }

        }
        public IActionResult Cart()
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            if (user.UserName != null && user.IsAdmin == 0)
            {
                user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
                List<Bill> billList = new List<Bill>();
                billList = BillManager.GetBillByUserId(user.CustomerId);
                int? priceBill = 0;
                foreach (Bill bill in billList)
                {
                    priceBill += (bill.Number * bill.Price);
                }
                ViewBag.PriceBill = priceBill;
                ViewBag.billList = billList;

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Guest");

            }
        }
        public IActionResult DeleteProductToCart(int billID)
        {
            BillManager.DeleteBillByBillID(billID);
            return RedirectToAction("Cart", "User");
        }
        public IActionResult UpdateQuantityCart(int quantity, int billID)
        {
            BillManager.UpdateQuantity(quantity, billID);
            return RedirectToAction("Cart", "User");
        }
    }
}
