using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmReview.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace FilmReview.Controllers
{
    public class UserController : Controller
    {
        FilmReview_DBContext dBContext = new FilmReview_DBContext();


        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("ViewMovies", "Movie");
            }

            return View();
        }
        [HttpPost]
        public IActionResult Login(String username, string password)
        {
            var query = dBContext.UserTables.AsQueryable();
            var temp = query.Where(m => m.Name.Equals(username) && m.Password.Equals(password)).ToList();
            if (temp.Count == 0)
            {
                ViewBag.Error = "Please check your username and password";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetInt32("userID", temp[0].Id);
                int isAdmin = temp[0].IsAdmin ? 1 : 0;
                HttpContext.Session.SetInt32("isAdmin", isAdmin);
                return RedirectToAction("ViewMovies", "Movie");
            }
       

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "User");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserTable user)
        {
            if (ModelState.IsValid)
            {
                try {
                dBContext.UserTables.Add(user);
                dBContext.SaveChanges();
                }
                catch (Exception)
                {
                    ViewBag.Error = "Username already exist";
                    return View();
                }
            }
            return RedirectToAction("Login", "User");
        }

        public IActionResult AdminIndex()
        {
            return View();
        }
    }
}
