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
    public class EFWorkerRepository : IWorkerRepository
    {
        public void AddData(Worker data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Worker data)
        {
            throw new NotImplementedException();
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
            return workers;
        }

        public Worker GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Worker data)
        {
            throw new NotImplementedException();
        }
    }
}
