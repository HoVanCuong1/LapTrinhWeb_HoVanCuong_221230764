using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Day2_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthourId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //danh sách các cuốn sách 
        public List<Book> getBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id= 1,
                    Title ="Chi Pheo",
                    AuthourId= 1,
                    GenreId =1,
                    Image ="/images/products/1.jpg",
                    Price = 500000,
                    Sumary ="",
                    TotalPage =250
                },
                new Book()
                {
                    Id= 2,
                    Title ="Nam Cao",
                    AuthourId= 1,
                    GenreId =1,
                    Image ="/images/products/2.jpg",
                    Price = 500000,
                    Sumary ="",
                    TotalPage =250
                },
                new Book()
                {
                    Id= 3,
                    Title ="Chi Pheo",
                    AuthourId= 1,
                    GenreId =1,
                    Image ="/images/products/3.jpg",
                    Price = 500000,
                    Sumary ="",
                    TotalPage =250
                },
                new Book()
                {
                    Id= 4,
                    Title ="Chi Pheo",
                    AuthourId= 1,
                    GenreId =1,
                    Image ="/images/products/4.jpg",
                    Price = 500000,
                    Sumary ="",
                    TotalPage =250
                },
            };

            return books;
        }
        //Chi tiết một cuốn sách theo id (using System.linq)
        public Book getBookById(int id)
        {
            Book book = this.getBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        //SelectListItem Authors 
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao" },
            new SelectListItem {Value = "2", Text = "Ngô Tuất Tố" },
            new SelectListItem {Value = "3", Text = "Adamkhoom" },
            new SelectListItem {Value = "4", Text = "Thiền Sư" }
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyện trnah" },
            new SelectListItem {Value = "2", Text = "Văn Học đương đại" },
            new SelectListItem {Value = "3", Text = "Phật học phổ thông" },
            new SelectListItem {Value = "4", Text = "Truyện cười" }
        };
    }
}
