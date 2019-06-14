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
using System.Windows;

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
            users = new ObservableCollection<User>();
            using (EFContext db = new EFContext())
            {
                db.Configuration.LazyLoadingEnabled = false;
                users = new ObservableCollection<User>(db.Users.Include("Permission").ToList());
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
