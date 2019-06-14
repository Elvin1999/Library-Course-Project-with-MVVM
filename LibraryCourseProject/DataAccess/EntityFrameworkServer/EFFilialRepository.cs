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
    public class EFFilialRepository : IFilialRepository
    {
        public void AddData(Filial data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Filial data)
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Filial> filials;
        public ObservableCollection<Filial> GetAllData()
        {
            filials = new ObservableCollection<Filial>();
            using (EFContext db = new EFContext())
            {

                filials = new ObservableCollection<Filial>(db.Filials);
            }
            return filials;
        }

        public Filial GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Filial data)
        {
            throw new NotImplementedException();
        }
    }
}
