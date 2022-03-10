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
    public class ProducerController : Controller
    {
        FilmReview_DBContext dBContext = new FilmReview_DBContext();
        [HttpGet]
        public IActionResult AddProducer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProducer(ProducerTable producer)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                dBContext.ProducerTables.Add(producer);
                dBContext.SaveChanges();
            }
            return RedirectToAction("AdminIndex", "User");
        }

        [HttpGet]
        public IActionResult ViewProducers(string Name)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            var query = dBContext.ProducerTables.AsQueryable();

            if (!String.IsNullOrEmpty(Name))
            {
                query = query.Where(m => m.Name.StartsWith(Name));
            }

            ViewBag.ProducerList = query.ToList();

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
                return RedirectToAction("ViewProducers", "Producer");
            }
            var query = dBContext.ProducerTables.Where(m => m.Id == id).ToList();

            if (query.Count != 1)
            {
                return RedirectToAction("ViewProducers", "Producers");
            }

            ViewBag.Producer = query[0];
            ProducerTable producer = dBContext.ProducerTables.Find(id);
            TempData["producerId"] = producer.Id;
            return View(producer);

        }

        [HttpPost]
        public IActionResult Edit(ProducerTable producer)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            producer.Id = (int)TempData["producerID"];

            if (ModelState.IsValid)
            {
                dBContext.Entry(producer).State = EntityState.Modified;
                dBContext.SaveChanges();
            }
            return RedirectToAction("ViewProducers", "Producer");
        }
    }
}
