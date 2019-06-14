using LibraryCourseProject.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
   public class EFUnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository => new EFUserRepository();
        public IPermissionRepository PermissionRepository => new EFPermissionRepository();
        public IWorkerRepository WorkerRepository => new EFWorkerRepository();

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
