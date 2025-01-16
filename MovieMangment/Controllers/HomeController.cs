using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMangment.Models;
using System.Diagnostics;

namespace MovieMangment.Controllers
{
    public class HomeController : Controller
    {


        dacdbcontext dbContext = new dacdbcontext();

        public ViewResult Index()
        {
           return View();
        }
        public ViewResult Index1()
       {
         List<user> users = dbContext.Alluser.ToList();
           return View(users);
        }

        public ViewResult Details()
        {
            List<user> users = dbContext.Alluser.ToList();
            return View(users);
        }


        public ViewResult Create()
        {
            return View();
        }

        public IActionResult AfterCreate(user u)
        {
            dbContext.Alluser.Add(u);
            dbContext.SaveChanges();

            return Redirect("/Home/Index1");

        }

        public IActionResult Edit(int id)
        {
            user userToEdit = dbContext.Alluser.Find(id);
            if (userToEdit != null)
            {
                return View(userToEdit);
            }
            return null;
        }

        public IActionResult AfterEdit(user updateduser)
        {

            dbContext.Alluser.Update(updateduser);
            dbContext.SaveChanges();

            return Redirect("/Home/Index1");


            return null;
        }

        public IActionResult Delete(int id)
        {
            user userToDelete = dbContext.Alluser.Find(id);
            dbContext.Alluser.Remove(userToDelete);
            dbContext.SaveChanges();
            return Redirect("/Home/Index1");

        }



    }
}
