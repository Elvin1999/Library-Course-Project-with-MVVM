using LibraryCourseProject.Domain.Abstractions;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
    public class EFBookRepository : IBookRepository
    {
        public void AddData(Book data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Books.Add(data);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (DbEntityValidationResult validationResult in ex.EntityValidationErrors)
                    {
                        string entityName = validationResult.Entry.Entity.GetType().Name;
                        foreach (DbValidationError error in validationResult.ValidationErrors)
                        {
                            errorMessages.Add(entityName + "." + error.PropertyName + ": " + error.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void DeleteData(Book data)
        {
            using (EFContext db = new EFContext())
            {
                bool oldvalid = db.Configuration.ValidateOnSaveEnabled;
                try
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Books.Attach(data);
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {

                }
            }
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
            using (EFContext db = new EFContext())
            {
                try
                {
                    db.Entry(data).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                }

            }
        }
    }
}
