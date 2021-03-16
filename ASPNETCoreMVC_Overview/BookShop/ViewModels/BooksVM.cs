using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.ViewModels
{
    public class BooksVM
    {
        public IList<Book> Books { get; set; }

        public bool AudioBookFilter { get; set; }
    }
}
