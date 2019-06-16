using LibraryCourseProject.Domain.Abstractions;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
    public class EFBookRepository : IBookRepository
    {
        public void AddData(Book data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Book data)
        {
            throw new NotImplementedException();
        }
        ObservableCollection<Book> books;
        public ObservableCollection<Book> GetAllData()
        {
            books = new ObservableCollection<Book>();
            using (EFContext db = new EFContext())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var b1 = db.Books.Include("Genre").ToList();
                var b2 = db.Books.Include("Author").ToList();
                books = new ObservableCollection<Book>(db.Books.ToList());
            }
            for (int i = 0; i < books.Count; i++)
            {
                books[i].No = i + 1;
            }
            return books;
        }

        public Book GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Book data)
        {
            throw new NotImplementedException();
        }
    }
}
