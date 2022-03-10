using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmReview.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilmReview.Controllers
{
    public class MovieController : Controller
    {
        FilmReview_DBContext dBContext = new FilmReview_DBContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddMovie()
        {
            var producerList = new List<SelectListItem>();
            var directorList = new List<SelectListItem>();
            var actorList = new List<SelectListItem>();

            foreach (var producer in dBContext.ProducerTables.ToList())
            {
                producerList.Add(new SelectListItem
                {
                    Text = producer.Name,
                    Value = producer.Id.ToString()
                });
            }

            foreach (var actor in dBContext.ActorsTables.ToList())
            {
                actorList.Add(new SelectListItem
                {
                    Text = actor.Name,
                    Value = actor.Id.ToString()
                });
            }

            foreach (var director in dBContext.DirectorTables.ToList())
            {
                directorList.Add(new SelectListItem
                {
                    Text = director.Name,
                    Value = director.Id.ToString()
                });
            }
            ViewBag.producerList = producerList;
            ViewBag.directorList = directorList;
            ViewBag.actorList = actorList;
            return View();

        }
        [HttpPost]
        public IActionResult AddMovie(MovieTable movie, string[] DirectorId, string[] ProducerId, string[] ActorId)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            var movieTemp = new MovieTable();
            if (ModelState.IsValid)
            {
                movie.IsActive = true;
                movie.AverageRating = 0;

                movieTemp = dBContext.MovieTables.Add(movie).Entity;
                dBContext.SaveChanges();
            }
            int movieId = movieTemp.Id;

            foreach (var element in DirectorId)
            {
                var temp = new DirectorsToMovie();
                temp.MovieId = movieId;
                temp.DirectorId = Int32.Parse(element);
                dBContext.DirectorsToMovies.Add(temp);
                dBContext.SaveChanges();
            }

            foreach (var element in ProducerId)
            {
                var temp = new ProducersToMovie();
                temp.MovieId = movieId;
                temp.ProducerId = Int32.Parse(element);
                dBContext.ProducersToMovies.Add(temp);
                dBContext.SaveChanges();
            }

            foreach (var element in ActorId)
            {
                var temp = new ActorsToMovie();
                temp.MovieId = movieId;
                temp.ActorId = Int32.Parse(element);
                dBContext.ActorsToMovies.Add(temp);
                dBContext.SaveChanges();
            }

            return RedirectToAction("AdminIndex", "User");
        }

        public IActionResult ViewMovies(string Name)
        {
            var query = dBContext.MovieTables.AsQueryable().Where(m => m.IsActive == true);
            if(HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                query = dBContext.MovieTables.AsQueryable();
            }
            if (!String.IsNullOrEmpty(Name))
            {
                query = query.Where(m => m.Name.StartsWith(Name));
            }

            ViewBag.movieList = query.ToList();
            TempData["isAdmin"] = HttpContext.Session.GetInt32("isAdmin");
            return View();
        }

        public IActionResult Comment(int? id)
        {
            var movieList = dBContext.MovieTables.AsQueryable().Where(m => m.Id == id).ToList();
            if(movieList.Count == 0)
            {
                return RedirectToAction("ViewMovies", "Movies");
            }
            MovieTable movie = movieList[0];

            var producerList = new List<ProducerTable>();
            foreach (var producer in dBContext.ProducersToMovies.Where(m => m.MovieId == id).ToList())
            {
                var temp = dBContext.ProducerTables.Where(m => m.Id == producer.ProducerId).FirstOrDefault();
                producerList.Add(temp);
            }
            var directorList = new List<DirectorTable>();
            foreach (var director in dBContext.DirectorsToMovies.Where(m=>m.MovieId == id).ToList())
            {
                var temp = dBContext.DirectorTables.Where(m => m.Id == director.DirectorId).FirstOrDefault();
                directorList.Add(temp);
            }

            var actorList = new List<ActorsTable>();
            foreach (var actor in dBContext.ActorsToMovies.Where(m=>m.MovieId == id).ToList())
            {
                var temp = dBContext.ActorsTables.Where(m => m.Id == actor.ActorId).FirstOrDefault();
                actorList.Add(temp);
            }

            var commentList = new List<RatingTable>();
            foreach(var comment in dBContext.RatingTables.Where(m => m.MovieId == id).ToList())
            {
                commentList.Add(comment);
            }
            bool notCommented = true;
            if (dBContext.RatingTables.Where(m => m.MovieId == id && m.UserId == HttpContext.Session.GetInt32("userID")).ToList().Count() != 0)
            {
                notCommented = false;
            }
            ViewBag.movie = movie;
            ViewBag.producerList = producerList;
            ViewBag.directorList = directorList;
            ViewBag.actorList = actorList;
            ViewBag.commentList = commentList;
            ViewBag.userList = dBContext.UserTables.ToList();
            TempData["notCommented"] = notCommented;
            TempData["movieId"] = movie.Id;
            return View();
        }
        [HttpPost]
        public IActionResult Comment(string Comment, int Rating)
        {
            int movieId = (int)TempData["movieId"];
            RatingTable ratingE = new RatingTable();
            ratingE.MovieId = movieId;
            ratingE.Comment = Comment;
            ratingE.Rating = Rating;
            ratingE.CommentDate = DateTime.Now;
            ratingE.UserId = (int)HttpContext.Session.GetInt32("userID");

            MovieTable movie = dBContext.MovieTables.Where(m => m.Id == movieId).ToList()[0];
            int commentCount = dBContext.RatingTables.Where(m => m.MovieId == movieId).ToList().Count();
            double rating = movie.AverageRating;
            rating *= commentCount;
            rating = (rating + Rating) / (commentCount + 1);
            movie.AverageRating = rating;

            dBContext.MovieTables.Update(movie);
            dBContext.RatingTables.Add(ratingE);
            dBContext.SaveChanges();

            
            return RedirectToAction("ViewMovies", "Movie");
            
        }

        public IActionResult ChangeStatus(int? id)
        {
            if (id != null)
            {
                MovieTable movie = dBContext.MovieTables.AsQueryable().Where(m => m.Id == id).ToList()[0];
                movie.IsActive = !movie.IsActive;
                dBContext.MovieTables.Update(movie);
                dBContext.SaveChanges();
            }
            return RedirectToAction("ViewMovies", "Movie");
        }
    }
}
