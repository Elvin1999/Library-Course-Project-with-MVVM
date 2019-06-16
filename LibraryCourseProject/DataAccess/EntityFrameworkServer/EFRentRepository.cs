using LibraryCourseProject.Domain.Abstractions;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
    public class EFRentRepository : IRentRepository
    {
        public void AddData(Rent data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Rents.Add(data);
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

        public void DeleteData(Rent data)
        {
            throw new NotImplementedException();
        }
        ObservableCollection<Rent> rents;
        public ObservableCollection<Rent> GetAllData()
        {

            rents = new ObservableCollection<Rent>();
            using (EFContext db = new EFContext())
            {
                var s1 = db.Rents.Include("Book").ToList();
                var s2 = db.Rents.Include("User").ToList();
                var s3 = db.Rents.Include("Client").ToList();
                rents = new ObservableCollection<Rent>(db.Rents);
            }
            for (int i = 0; i < rents.Count; i++)
            {
                rents[i].No = i + 1;
            }
            return rents;
        }

        public Rent GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Rent data)
        {
            throw new NotImplementedException();
        }
    }
}
