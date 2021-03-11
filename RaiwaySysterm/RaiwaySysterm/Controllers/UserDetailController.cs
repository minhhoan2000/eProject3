using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Security.Cryptography;
using RaiwaySysterm.Models;
namespace RaiwaySysterm.Controllers
{
    
    public class UserDetailController : Controller
    {
        RaiwayContext db;
        public UserDetailController(RaiwayContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detai()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterDetail users)
        {
            if (ModelState.IsValid)
                {
                var check = db.RegisterDetail.FirstOrDefault(s => s.NameAccount == users.NameAccount);
                if(check == null)
                    {
                    db.RegisterDetail.Add(users);
                    db.SaveChanges();

                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.Msg = "Account name already exists";
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string pass)
        {
            try
            {
                var user = db.UserDetail.SingleOrDefault(m => m.NameAccount.Equals(username));
                if (user != null)
                {
                    if (user.Password.Equals(pass))
                    {
                        if (user.Role == true && username != null && pass != null)
                        {
                            HttpContext.Session.SetString("username", username);
                            HttpContext.Session.SetInt32("userid", user.UserID);
                            return RedirectToAction("Index", "UserDetail");
                        }
                        else
                        {
                            HttpContext.Session.SetString("username", username);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ViewBag.error = "Invalid Password";
                    }

                }
                else
                {
                    ViewBag.error = "invalid username and password.";
                }
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
            }
            return View();

        }
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            UserDetail detail = db.UserDetail.SingleOrDefault(m => m.UserID.Equals(id));
            return View(detail);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserDetail userDetail)
        {
            if (ModelState.IsValid)
            {
                var res = db.UserDetail.Add(userDetail);
                db.SaveChanges();
                ViewBag.Msg = "Congratulation";
                return RedirectToAction("Profile");
            }
            else
            {
                ViewBag.Msg = "Create Fail";
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int userId)
        {
            try
            {
                var res = db.UserDetail.SingleOrDefault(m => m.UserID.Equals(userId));
                if (res != null)
                {
                    db.UserDetail.Remove(res);
                    db.SaveChanges();
                    return RedirectToAction("Profile");
                }
                else
                {
                    return BadRequest();
                }


            }
            catch (Exception e)
            {

                ViewBag.Msg = e.Message;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var res = db.UserDetail.SingleOrDefault(m => m.UserID.Equals(id));
            return View(res);
        }
        [HttpPost]
        public IActionResult Update(UserDetail userDetail)
        {
            try
            {
                UserDetail res = db.UserDetail.Where(m => m.UserID.Equals(userDetail.UserID)).SingleOrDefault();
                if (res != null)
                {
                    res.FullName = userDetail.FullName;
                    res.Password = userDetail.Password;
                    res.Age = userDetail.Age;
                    res.Gender = userDetail.Gender;
                    res.Role = userDetail.Role;
                    


                    db.SaveChanges();
                    return RedirectToAction("Profile", "UserDetail");


                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception e)
            {

                ViewBag.Msg = e.Message;
            }
            return View();
        }
        public IActionResult UpdateUser(int id)
        {
            var res = db.UserDetail.SingleOrDefault(m => m.UserID.Equals(id));
            return View(res);
        }
        [HttpPost]
        public IActionResult UpdateUser(UserDetail userDetail)
        {
            try
            {
                UserDetail res = db.UserDetail.Where(m => m.UserID.Equals(userDetail.UserID)).SingleOrDefault();
                if (res != null)
                {
                    res.FullName = userDetail.FullName;
                    res.Password = userDetail.Password;
                    res.Age = userDetail.Age;
                    res.Gender = userDetail.Gender;
                   



                    db.SaveChanges();
                    return RedirectToAction("UserProfile", "UserDetail");


                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception e)
            {

                ViewBag.Msg = e.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult UserProfile(string username)
        {
            UserDetail detail = db.UserDetail.SingleOrDefault(m => m.NameAccount.Equals(username));
            return View(detail);
        }


    }

    }





