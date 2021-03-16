using BookShop.Models;
using BookShop.Services;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        //ctor + tab + tab -> Konstruktor
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index(string query, bool audioBook=false) // Get - Methode
        {
            BooksVM booksVM = new(); //C# 9.0 BooksVM booksVM = new BooksVM()

            booksVM.Books = _bookService.GetBooks(query, audioBook);
            booksVM.NewestPublishedBook = _bookService.GetNewestPublishedBook();
            booksVM.NewestPublishedAudioBook = _bookService.GetNewestPublishedAudioBook();


            return View(booksVM);
            //return View(_bookService.GetBooks(string.Empty, false));
        }

        public IActionResult Details(int? id)
        {
            if (!id.HasValue)
                return NotFound();

            Book book = _bookService.GetById(id.Value);

            if (book == null)
                return NotFound();


            return View(book);
        }


        //Get Methode
        public IActionResult Create()
        {
            return View(); //In .NET Framework 4.8 - return View (new Book());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book = _bookService.InsertBook(book);
            }

            return RedirectToAction("Index");
        }

        #region Partial with jQuery
        public IActionResult GetNewestBookPartial() =>
            new PartialViewResult
            {
                ViewName = "_NewestBookPartial",
                ViewData = ViewData,
            };

        public IActionResult GetNewestAudioBookPartial() =>
            new PartialViewResult
            {
                ViewName = "_NewestAudioBookPartial",
                ViewData = ViewData,
            };
        #endregion
    }
}
