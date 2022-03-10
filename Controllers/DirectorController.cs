using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmReview.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FilmReview.Controllers
{
    public class DirectorController : Controller
    {
        FilmReview_DBContext dBContext = new FilmReview_DBContext();
        [HttpGet]
        public IActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDirector(DirectorTable director)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                dBContext.DirectorTables.Add(director);
                dBContext.SaveChanges();
            }
            return RedirectToAction("AdminIndex", "User");
        }

        [HttpGet]
        public IActionResult ViewDirectors(string Name)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            var query = dBContext.DirectorTables.AsQueryable();

            if (!String.IsNullOrEmpty(Name))
            {
                query = query.Where(m => m.Name.StartsWith(Name));
            }

            ViewBag.DirectorList = query.ToList();

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            if (id == null)
            {
                return RedirectToAction("ViewDirectors", "Director");
            }
            var query = dBContext.DirectorTables.Where(m => m.Id == id).ToList();

            if (query.Count != 1)
            {
                return RedirectToAction("ViewDirectors", "Directors");
            }

            ViewBag.Director = query[0];
            DirectorTable director = dBContext.DirectorTables.Find(id);
            TempData["directorID"] = director.Id;
            return View(director);

        }

        [HttpPost]
        public IActionResult Edit(DirectorTable director)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            director.Id = (int)TempData["directorID"];

            if (ModelState.IsValid)
            {
                dBContext.Entry(director).State = EntityState.Modified;
                dBContext.SaveChanges();
            }
            return RedirectToAction("ViewDirectors", "Director");
        }
    }
}

