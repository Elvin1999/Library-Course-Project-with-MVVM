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
    class EFUserRepository : IUserRepository
    {
        public void AddData(User data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(User data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<User> GetAllData()
        {
            ObservableCollection<User> users;
            using (EFContext db=new EFContext())
            {
                users = new ObservableCollection<User>(db.Users);
            }
            return users;
        }

        public User GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(User data)
        {
            throw new NotImplementedException();
        }
    }
}
