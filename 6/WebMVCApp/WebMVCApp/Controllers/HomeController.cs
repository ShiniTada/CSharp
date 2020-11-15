using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApp.Models;

namespace WebMVCApp.Controllers
{
    public class HomeController : Controller
    {

        // создаем контекст данных
       // ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Students
            //IEnumerable<Student> students = db.Students;
            // передаем все объекты в динамическое свойство Students в ViewBag
            //ViewBag.Students = students;
            // возвращаем представление
            return View();
        }

   /*     public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}