using Microsoft.AspNetCore.Mvc;
using Lab03_View.Models;
namespace Lab03_View.Controllers

{
    public class BookController : Controller
    {
        private Book book = new Book();
        public IActionResult Index()
        {
            //danh sách genres convert SelectListItem để hiển thị trên combobox
            ViewBag.authors = book.Authors;// truyền dữ liệu SelectionListItem qua View
            ViewBag.genres = book.Genres; // Truyền dữ liệu SelecttionListItem qua View
            var books = book.getBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.gennes = book.Genres;
            Book model = new Book();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.authors = book.Authors;
            ViewBag.gennes = book.Genres;
            Book model = book.getBookById(id);
            return View(model);
        }
    }
}
