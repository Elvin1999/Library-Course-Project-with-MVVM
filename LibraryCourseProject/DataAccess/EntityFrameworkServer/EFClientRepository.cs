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
    public class EFClientRepository : IClientRepository
    {
        public void AddData(Client data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Clients.Add(data);
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

        public void DeleteData(Client data)
        {
            using (EFContext db = new EFContext())
            {
                bool oldvalid = db.Configuration.ValidateOnSaveEnabled;
                try
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Clients.Attach(data);
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    
                }
            }
        }

        ObservableCollection<Client> clients;
        public ObservableCollection<Client> GetAllData()
        {
            clients = new ObservableCollection<Client>();
            using (EFContext db = new EFContext())
            {
                clients = new ObservableCollection<Client>(db.Clients);
            }
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].No = i + 1;
            }
            return clients;
        }

        public Client GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Client data)
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
