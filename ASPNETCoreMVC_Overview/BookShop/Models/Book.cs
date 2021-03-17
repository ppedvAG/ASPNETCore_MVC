using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Book
    {
        public int ID { get; set; }

        [DisplayName("Titel")]
        public string Title { get; set; }


        [DisplayName("Autor")]
        public string Author { get; set; }


        [DisplayName("Preis")]
        [Required(ErrorMessage ="Bitte geben Sie einen Preis ein")]
        public decimal Price { get; set; }

        //[EmailAddress]
        //public string EmailAdress { get; set; }

        [DisplayName("Veröffentlichung")]
        [Required(ErrorMessage = "Bitte geben Sie einen Veröffentlichungsdatum ein")]
        public DateTime Published { get; set; }

        public bool AudioBook { get; set; } = false;

        public string PictureName { get; set; } //-> ID + BildFormat-Extentions -> Beispiel 1: 11.jpg ODER Beispiel 2: 11.gif 
    }
}
