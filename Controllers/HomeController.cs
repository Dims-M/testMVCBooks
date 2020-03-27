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

        [HttpGet]
        public ActionResult Buy(int id )
        {
            ViewBag.Message = "Приобретение товара";
            ViewBag.BookId = id; // Получаем id 
            return View();
        }

        [HttpPost] //получаем форму
        public ActionResult Buy(Purchase purchase) //получаем модель данных из формы(введеными пользователями) 
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);

            // сохраняем в бд все изменения
            db.SaveChanges();

            return Content("<h2>Спасибо, "+purchase.Person+", за покупку!!</h2>");
          //  return $"Спасибо, {purchase.Person}  , за покупку!";
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