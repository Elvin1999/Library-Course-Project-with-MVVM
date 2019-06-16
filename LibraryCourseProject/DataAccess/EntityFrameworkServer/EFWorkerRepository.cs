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
    public class EFWorkerRepository : IWorkerRepository
    {
        public void AddData(Worker data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Workers.Add(data);
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
        public void DeleteData(Worker data)
        {
            using (EFContext db = new EFContext())
            {
                bool oldvalid = db.Configuration.ValidateOnSaveEnabled;
                try
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Workers.Attach(data);
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                }
            }
        }
        ObservableCollection<Worker> workers;
        public ObservableCollection<Worker> GetAllData()
        {
            workers = new ObservableCollection<Worker>();
            using(EFContext db=new EFContext())
            {
                db.Configuration.LazyLoadingEnabled = false;
                workers =new ObservableCollection<Worker>(db.Workers.Include("Filial").ToList());
            }
            for (int i = 0; i < workers.Count; i++)
            {
                workers[i].No = i + 1;
            }
            return workers;
        }

        public Worker GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Worker data)
        {
            using (EFContext db = new EFContext())
            {
                try
                {
                    db.Entry(data).State = EntityState.Modified;
                    db.Entry(data.Filial).State = EntityState.Unchanged;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                }

            }
        }
    }
}
