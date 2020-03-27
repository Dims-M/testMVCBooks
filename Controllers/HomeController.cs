using BookStore.Domain;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //связь с БД
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books; // Получаем все данные из таблицы БД
            
            ViewBag.Books = books;
            
            return View();
            

        }

        public ActionResult About()
        {
            ViewBag.Message = "О приложении.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Связатся с нами!";

            return View();
        }
    }
}