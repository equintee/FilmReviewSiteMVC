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
    public class ActorController : Controller
    {
        FilmReview_DBContext dBContext = new FilmReview_DBContext();
        [HttpGet]
        public IActionResult AddActor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddActor(ActorsTable actor)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                dBContext.ActorsTables.Add(actor);
                dBContext.SaveChanges();
            }
            return RedirectToAction("AdminIndex", "User");
        }

        [HttpGet]
        public IActionResult ViewActors(string Name)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            var query = dBContext.ActorsTables.AsQueryable();

            if (!String.IsNullOrEmpty(Name))
            {
                query = query.Where(m => m.Name.StartsWith(Name));
            }

            ViewBag.ActorList = query.ToList();

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
                return RedirectToAction("ViewActors", "Actor");
            }
            var query = dBContext.ActorsTables.Where(m => m.Id == id).ToList();

            if (query.Count != 1)
            {
                return RedirectToAction("ViewActors", "Actor");
            }

            ViewBag.Actor = query[0];
            ActorsTable actor = dBContext.ActorsTables.Find(id);
            TempData["actorID"] = actor.Id;
            return View(actor);

        }

        [HttpPost]
        public IActionResult Edit(ActorsTable actor)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            actor.Id = (int)TempData["actorID"];

            if(ModelState.IsValid)
            {
                dBContext.Entry(actor).State = EntityState.Modified;
                dBContext.SaveChanges();
            }
            return RedirectToAction("AdminIndex", "User");
        }
    }
}
