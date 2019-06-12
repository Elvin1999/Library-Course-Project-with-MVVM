using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Book
    {
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        [NotMapped]
        public Author Author { get; set; }
        public ICollection<Rent> Rents { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public int AuthorId { get; set; }
        [NotMapped]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public string Note { get; set; }

        public Book Clone()
        {
            Book book = new Book
            {
                 Author=this.Author,
                  AuthorId=this.AuthorId,
                   Genre=this.Genre,
                    GenreId=this.GenreId,
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


