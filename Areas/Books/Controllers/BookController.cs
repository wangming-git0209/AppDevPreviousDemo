using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appdev.Models.Stores;
using appdev.Models;

namespace appdev.Models.Areas.Books
{
   
    [Area("Books")]
    [Route("books/book/[action]/{id?}")]
    public class BookController : Controller
        {
            private readonly AppDbContext _context;

            public BookController(AppDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {

                var query = from book in _context.Books select book; 
            
                // ViewBag.book = query;
                return View(query);
            } 

            [HttpGet]
            public IActionResult Create()
            {
        
                
                return View();
            } 

            [HttpPost]
            public IActionResult Create(Book book)
            {
                var newBook = new Book
                {
                    Isbn = book.Isbn,
                    Title = book.Title, 
                    Category = book.Category,
                    Pages = book.Pages, 
                    Price = book.Price, 
                    Desc = book.Desc, 
                    Author = book.Author
                }; 

                _context.Add(newBook); 
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            } 

            // Delete book using only GET 
            [HttpGet]
            public IActionResult Delete(string id)
            {

                var book = _context.Books.FirstOrDefault(b => b.Isbn == id);

                if (book == null)
                {
                    return NotFound();
                }
                else
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();   
                }
                return RedirectToAction("Index");
            }

            [HttpGet]
            public IActionResult Details(string id)
            {
                return View();
            }
            
            [HttpGet]
            public IActionResult Update(string id)
            {
            
                var bookToUpdate = _context.Books.Where(b => b.Isbn == id).FirstOrDefault();
                return View(bookToUpdate);
                // return View();
            }

            [HttpPost]
            public IActionResult Update(string id, [Bind("Title, Category, Pages, Price, Desc, Author")] Book book)
            {
                // if (id != book.Isbn)
                // {
                //     return NotFound();
                // }

                // Không hiểu tại sao sử dụng FirstOrDefault thì có thể update được
                var bookToUpdate = _context.Books.Where(b => b.Isbn == id).FirstOrDefault();

                if(bookToUpdate != null) 
                {
                        // bookToUpdate.Isbn = book.Isbn; 
                        bookToUpdate.Title = book.Title; 
                        bookToUpdate.Category = book.Category;
                        bookToUpdate.Pages = book.Pages;
                        bookToUpdate.Price = book.Price; 
                        bookToUpdate.Desc = book.Desc;
                        bookToUpdate.Author = book.Author;
                        
                        // _context.Update(bookToUpdate);
                        _context.SaveChanges();

                        return RedirectToAction("Index");

                }
                return RedirectToAction("Index");
            }
        }
}