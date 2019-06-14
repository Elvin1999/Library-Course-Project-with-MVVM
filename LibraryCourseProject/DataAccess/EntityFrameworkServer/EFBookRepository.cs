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

        public ObservableCollection<Book> GetAllData()
        {
            throw new NotImplementedException();
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
