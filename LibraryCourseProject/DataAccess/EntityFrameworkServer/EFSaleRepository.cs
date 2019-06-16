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
    public class EFSaleRepository : ISaleRepository
    {
        public void AddData(Sale data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Sales.Add(data);
                    db.Entry(data.Book).State = EntityState.Unchanged;
                    db.Entry(data.User).State = EntityState.Unchanged;
                    db.Entry(data.Client).State = EntityState.Unchanged;
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

        public void DeleteData(Sale data)
        {
            using (EFContext db = new EFContext())
            {
                bool oldvalid = db.Configuration.ValidateOnSaveEnabled;
                try
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Sales.Attach(data);
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {

                }
            }
        }
        ObservableCollection<Sale> sales;
        public ObservableCollection<Sale> GetAllData()
        {
            sales = new ObservableCollection<Sale>();
            using (EFContext db = new EFContext())
            {
                var s1 = db.Sales.Include("Book").ToList();
                var s2 = db.Sales.Include("User").ToList();
                var s3 = db.Sales.Include("Client").ToList();
                sales = new ObservableCollection<Sale>(db.Sales);
            }
            for (int i = 0; i < sales.Count; i++)
            {
                sales[i].No = i + 1;
            }
            return sales;
        }

        public Sale GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Sale data)
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
