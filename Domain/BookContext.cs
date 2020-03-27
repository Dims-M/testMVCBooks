using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Domain
{
    /// <summary>
    /// Контекст данных. Свзять и работа с БД
    /// </summary>
    public class BookContext : DbContext
    {
        /// <summary>
        /// Получение и обработка данных из БД(таблица Books )
        /// </summary>
        public DbSet<Book> Books { get; set; }
        /// <summary>
        /// Получение и обработка данных из БД(таблица Purchases, факт продажи )
        /// </summary>
        public DbSet<Purchase> Purchases { get; set; }

    }
}