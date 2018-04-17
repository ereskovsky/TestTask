using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask.Models;
namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        UserRepository repo = UserRepository.Current;
        DepartmentRepository deprep = DepartmentRepository.Current;
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Deps = deprep.GetDeps();
            ViewBag.Users = repo.GetUsers();
            return View(repo.GetUsers());
        }
        public ActionResult AddUser(User u)
        {
            repo.AddUser(u);
            return Redirect("/");
        }
        public ActionResult UpdateUser(User u)
        {
            if (repo.UpdateUser(u) == "UpdateSuccesfull")
                return RedirectToAction("Index");
            return View("Index");

        }

    }
}