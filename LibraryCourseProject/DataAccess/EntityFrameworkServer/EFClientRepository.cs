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
    public class EFClientRepository : IClientRepository
    {
        public void AddData(Client data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Client data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Client> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Client GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Client data)
        {
            throw new NotImplementedException();
        }
    }
}
