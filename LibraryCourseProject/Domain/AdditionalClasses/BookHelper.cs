using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class BookHelper
    {
        private List<Book> books;
        public BookHelper()
        {
            try
            {
                books = App.Config.Books;
            }
            catch (Exception)
            {
            }
        }
        public bool IsFilledRequestingPlaces(string title,Author author,Genre genre)
        {
            if (title != null && author != null && genre != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
