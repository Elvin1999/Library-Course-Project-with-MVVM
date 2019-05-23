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
        public int Title { get; set; }
        public int PageCount { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Author Author { get; set; }
        public int Author_Id { get; set; }
        public Genre Genre { get; set; }
        public int Genre_Id { get; set; }
        public string Note { get; set; }
    }
}


