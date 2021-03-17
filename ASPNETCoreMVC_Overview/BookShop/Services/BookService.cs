using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Services
{
    public class BookService : IBookService
    {
        private IList<Book> _bookService = new List<Book>();


        public BookService()
        {
            _bookService.Add(new Book { ID = 1, Title = "Heimweg", Author = "Fritzek", Price = 10.99m, Published = new DateTime(2020, 12, 5)});
            _bookService.Add(new Book { ID = 2, Title = "The Green Mile", Author = "Steven King", Price = 9.99m, Published = new DateTime(1999, 12, 5) });
            _bookService.Add(new Book { ID = 3, Title = "ASP.NET WebForms", Author = "Hannes Preishuber", Price = 49.95m, Published = new DateTime(2021, 3, 5) });
            _bookService.Add(new Book { ID = 4, Title = "Ein verheißenes Land", Author = "Obama", Price = 49.95m, Published = new DateTime(2021, 2, 5) });
            _bookService.Add(new Book { ID = 5, Title = "Ohne Schuld", Author = "Charlotte Link", Price = 19.99m, Published = new DateTime(2020,1, 5) });
            _bookService.Add(new Book { ID = 6, Title = "Ostfriesenzorn", Author = "Klaus-Peter Wolf", Price = 10.99m, AudioBook = true , Published = new DateTime(2020, 1, 5) });
            _bookService.Add(new Book { ID = 7, Title = "Arbeitsweg", Author = "Fritzek", Price = 20m, Published = new DateTime(2020, 1, 5) });
            _bookService.Add(new Book { ID = 8, Title = "Westfriesenlieb", Author = "Klaus-Peter Wolf", Price = 9.99m, Published = new DateTime(2020, 3, 5) });
            _bookService.Add(new Book { ID = 9, Title = "Ostfriesenmelodie", Author = "Klaus-Peter Wolf", Price = 9.99m, Published = new DateTime(2020, 4, 5) });
            _bookService.Add(new Book { ID = 10, Title = "Coding des Schreckens - Ein JavaScript Rundumblick", Author = "Kevin Winter", Price = 8.99m, AudioBook = true, Published = new DateTime(1999, 1, 5) });
            _bookService.Add(new Book { ID = 11, Title = "Relaxed Yoga", Author = "Wiebkle Roland", Price = 12.99m, Published = new DateTime(2020, 5, 5) });
            _bookService.Add(new Book { ID = 12, Title = "Der neunte Arm des Oktopus", Author = "Rossmann", Price = 19.99m, AudioBook = true, Published = new DateTime(2020, 7, 5) });
        }


        public IList<Book> GetBooks(string query, bool onlyAudioBooks = false)
        {
            IList<Book> results;
            if (string.IsNullOrEmpty(query))
            {
                if (onlyAudioBooks)
                    results = _bookService.Where(q => q.AudioBook == onlyAudioBooks).ToList(); //Anzeige der gesamten Audio

                else
                    results = _bookService.ToList();

            }
            else
            {
                if (onlyAudioBooks)
                    results = _bookService.Where(q => q.Title.Contains(query) && q.AudioBook == onlyAudioBooks).ToList();
                else
                    results = _bookService.Where(q => q.Title.Contains(query)).ToList();
            }

            return results;
        }

        public Book GetById(int id)
        {
            return _bookService.Where(n => n.ID == id).FirstOrDefault();
        }

        public int GetCount()
        {
            return _bookService.Count;
        }

        public Book GetNewestPublishedBook()
        {
            if (_bookService.Where(n => n.AudioBook == false).Count() == 0)
                return new Book();

            return _bookService.Where(n => n.AudioBook == false).OrderByDescending(o => o.Published).First();
        }

        public Book GetNewestPublishedAudioBook()
        {
            if (_bookService.Where(n => n.AudioBook == true).Count() == 0)
                return new Book();

            return _bookService.Where(n => n.AudioBook == true).OrderByDescending(o => o.Published).First();
        }

        public Book InsertBook(Book book)
        {
            Guid myID = Guid.Empty;

            if (myID == Guid.Empty)
                myID = Guid.NewGuid();

            book.ID = _bookService.Max(n => n.ID) + 1;
            _bookService.Add(book);

            return book; 
        }


        public Book InsertBook(Book book, string pictureFullName)
        {
            book.ID = _bookService.Max(n => n.ID) + 1; //Simulation, dass SQL SErver mit eine ID vergibt. 
            book.PictureName = book.ID + pictureFullName;
            
            _bookService.Add(book);
            //SaveChanges();
            return book;
        }
    }
}
