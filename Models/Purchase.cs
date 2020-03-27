using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    /// <summary>
    /// Модель отвечающаяя  за факт продажи с описанием свойств.
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// ID покупки
        /// </summary>
        [Key]
        public int PurchaseId { get; set; }

        /// <summary>
        /// имя и фамилия покупателя
        /// </summary>
        public string Person { get; set; }

        /// <summary>
        /// адрес покупателя
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// ID книги
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// дата покупки
        /// </summary>
        public DateTime Date { get; set; }

    }
}