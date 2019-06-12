using LibraryCourseProject.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
    class EFUnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository => throw new NotImplementedException();

        public IWorkerRepository WorkerRepository => throw new NotImplementedException();

        public IClientRepository ClientRepository => throw new NotImplementedException();

        public IFilialRepository FilialRepository => throw new NotImplementedException();

        public IBookRepository BookRepository => throw new NotImplementedException();

        public IRentRepository RentRepository => throw new NotImplementedException();

        public ISaleRepository SaleRepository => throw new NotImplementedException();

        public void SaveChanges()
        {
            
        }
    }
}
