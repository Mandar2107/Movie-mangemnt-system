using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMangment.Models;
using System.Diagnostics;

namespace MovieMangment.Controllers
{
    public class movieController : Controller
    {


        dacdbcontext dbContext = new dacdbcontext();

        public ViewResult Allmovie()
        {
            List<Movie> movies = dbContext.Allmovie.ToList();
            return View(movies);
        }
      

        


        public ViewResult CreateMovie()
        {
            return View();
        }

        public IActionResult AfterCreateMovie(Movie movie)
        {
            dbContext.Allmovie.Add(movie);
            dbContext.SaveChanges();

            return Redirect("/movie/Allmovie");

        }

        public IActionResult EditMovie(int id)
        {
            Movie userToEdit = dbContext.Allmovie.Find(id);
            if (userToEdit != null)
            {
                return View(userToEdit);
            }
            return null;
        }

        public IActionResult AfterEditMovie(Movie updateduser)
        {

            dbContext.Allmovie.Update(updateduser);
            dbContext.SaveChanges();

            return Redirect("/movie/Allmovie");


            return null;
        }

        public IActionResult DeleteMovie(int id)
        {
            Movie userToDelete = dbContext.Allmovie.Find(id);
            dbContext.Allmovie.Remove(userToDelete);
            dbContext.SaveChanges();
            return Redirect("/movie/Allmovie");

        }



    }
}
