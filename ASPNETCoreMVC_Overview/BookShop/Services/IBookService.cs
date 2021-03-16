using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Services
{
    public interface IBookService
    {
        IList<Book> GetBooks(string query, bool onlyAudioBooks);

        int GetCount();

        Book GetById(int id);
    }
}
