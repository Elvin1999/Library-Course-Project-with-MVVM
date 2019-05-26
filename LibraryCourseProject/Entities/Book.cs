using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Book
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Author Author { get; set; }
        public int Author_Id { get; set; }
        public Genre Genre { get; set; }
        public int Genre_Id { get; set; }
        public string Note { get; set; }

        public Book Clone()
        {
            Book book = new Book
            {
                 Author=this.Author,
                  Author_Id=this.Author_Id,
                   Genre=this.Genre,
                    Genre_Id=this.Genre_Id,
                     Id=this.Id,
                      No=this.No,
                       Note=this.Note,
                        PageCount=this.PageCount,
                         PurchasePrice=this.PurchasePrice,
                          SalePrice=this.SalePrice,
                           Title=this.Title
            };
            return book;
        }
    }
}


