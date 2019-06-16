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
    public class EFFilialRepository : IFilialRepository
    {
        public void AddData(Filial data)
        {
            using (EFContext db = new EFContext())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    db.Filials.Add(data);
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

        public void DeleteData(Filial data)
        {
            using (EFContext db = new EFContext())
            {
                bool oldvalid = db.Configuration.ValidateOnSaveEnabled;
                try
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Filials.Attach(data);
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {

                }
            }
        }

        ObservableCollection<Filial> filials;
        public ObservableCollection<Filial> GetAllData()
        {
            filials = new ObservableCollection<Filial>();
            using (EFContext db = new EFContext())
            {

                filials = new ObservableCollection<Filial>(db.Filials);
            }
            for (int i = 0; i < filials.Count; i++)
            {
                filials[i].No = i + 1;
            }
            return filials;
        }

        public Filial GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Filial data)
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
