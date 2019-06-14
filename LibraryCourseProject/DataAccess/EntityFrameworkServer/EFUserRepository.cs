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
    class EFUserRepository : IUserRepository
    {
        public void AddData(User data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Users.Add(data);
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

        public void DeleteData(User item)
        {

            using (EFContext db = new EFContext())
            {
                bool oldvalid = db.Configuration.ValidateOnSaveEnabled;
                try
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Users.Attach(item);
                    db.Entry(item).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {

                }
            }
        }
        public int No { get; set; } = 0;
        ObservableCollection<User> users;
        public ObservableCollection<User> GetAllData()
        {
            using (EFContext db = new EFContext())
            {
                var permissions = db.Permissions
                        .Include(b => b.Users)
                        .ToList();
                var permissions2 = db.Permissions
                        .Include("Users")
                        .ToList();
                users = new ObservableCollection<User>(db.Users);
            }
            for (int i = 0; i < users.Count; i++)
            {
                users[i].No = i + 1;
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
