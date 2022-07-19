using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project2.Logic;
using Project2.Models;
using System.Collections.Generic;

namespace Project2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ChangePassword()
        {
            return View();
        }
        public IActionResult Profile(List<bool> checkList)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
            //System.Diagnostics.Debug.WriteLine(user.CustomerId);
            ViewBag.CheckList = checkList;
            return View(user);
        }
       
        public IActionResult ChangeEmail(string mess)
        {
            string str = HttpContext.Session.GetString("User");
            User user = JsonConvert.DeserializeObject<User>(str);
            user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
            ViewBag.mess = mess;
            return View(user);
        }
        public IActionResult DoChangeEmail(UserDetail userDetail)
        {
            bool isExist = false;
            isExist = UserDetailManager.IsExistEmail(userDetail.Email);
            string mess = "Email is exist, try again!";
            if (isExist)
            {
                return RedirectToAction("ChangeEmail", "User",new {mess= mess});
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
            user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
            ViewBag.mess=mess;
            return View(user);
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




        //public IActionResult UpdateInfomation(UserDetail userDetail)
        //{
        //    string str = HttpContext.Session.GetString("User");
        //    User user = JsonConvert.DeserializeObject<User>(str);
        //    user.UserDetail = UserDetailManager.GetUserDetailByUserId(user.CustomerId);
            //bool isExist = false;
            //if (userDetail.Email != null)
            //{
            //    isExist = UserDetailManager.IsExistEmail(userDetail.Email);
            //}
            //if (userDetail.Phone != null)
            //{
            //    isExist = UserDetailManager.IsExistPhone(userDetail.Phone);
            //}

            //if (userDetail.Email == null && userDetail.Phone == null)
            //{
            //    return RedirectToAction("Profile", "User");
            //}
            //else
            //{

            //}
            //bool isExistEmail = false;
            //bool isExistPhone = false;

            //if (user.UserDetail.Email.Equals(userDetail.Email))
            //{
            //    isExistEmail = true;
            //}
            //if (user.UserDetail.Phone.Equals(userDetail.Phone))
            //{
            //    isExistPhone = true;
            //}
            //List<bool> checkList = new List<bool>();
            //checkList.Add(isExistEmail);
            //checkList.Add(isExistPhone);


            //if (isExistEmail == false && isExistPhone == false)
            //{

            //    return RedirectToAction("Profile", "User");

            //}
            //else
            //{
            //    return RedirectToAction("Profile", "User", new { checkList = checkList });

            //}

        //}

        public IActionResult Logout()
        {
            User user = null;
            return RedirectToAction("Home", "Guest", new { user = user });
        }
        public IActionResult AddInformation(List<bool> checkList)
        {
            if (checkList.Count == 0)
            {
                checkList.Add(true);
                checkList.Add(true);
            }
            ViewBag.CheckList = checkList;
            User user = UserManager.GetNewUser();
            ViewBag.id = user.CustomerId;
            return View();
        }
        public IActionResult DoAddInformation(UserDetail user)
        {

            UserDetail userDetail = new UserDetail();
            userDetail.Name = user.Name;
            userDetail.Address = user.Address;
            userDetail.Birthday = user.Birthday;

            bool isExistEmail = UserDetailManager.IsExistEmail(user.Email);
            bool isExistPhone = UserDetailManager.IsExistPhone(user.Phone);

            List<bool> checkList = new List<bool>();
            checkList.Add(isExistEmail);
            checkList.Add(isExistPhone);

            System.Diagnostics.Debug.WriteLine(isExistEmail);
            System.Diagnostics.Debug.WriteLine(isExistPhone);


            if (isExistEmail == true && isExistPhone == true)
            {
                userDetail.Email = user.Email;
                userDetail.Phone = user.Phone;
                UserDetailManager.SetNewUserDetail(userDetail);
                return RedirectToAction("Login", "Guest");

            }
            else
            {
                return RedirectToAction("AddInformation", "User", new { checkList = checkList });

            }
        }



    }
}
