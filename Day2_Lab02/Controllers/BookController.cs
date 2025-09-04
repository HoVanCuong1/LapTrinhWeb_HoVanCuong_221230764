using Microsoft.AspNetCore.Mvc;
using Day2_Lab2.Models;
namespace Day2_Lab2.Controllers

{
    public class BookController : Controller
    {
        private Book book = new Book();
        public IActionResult Index()
        {
            //danh sách genres convert SelectListItem để hiển thị trên combobox
            ViewBag.authours = book.Authors;// truyền dữ liệu SelectionListItem qua View
            ViewBag.genres = book.Genres; // Truyền dữ liệu SelecttionListItem qua View
            var books = book.getBookList();
            return View(books);
        }
    }
}
