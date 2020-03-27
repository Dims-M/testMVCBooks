using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    /// <summary>
    /// Описание нужного товара.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// ID книги
        /// </summary>
        [Key]
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Author { get; set; }
        // цена
        public int Price { get; set; }

    }
}