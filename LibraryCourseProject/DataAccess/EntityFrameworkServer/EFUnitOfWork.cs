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

        public IClientRepository ClientRepository => new EFClientRepository();

        public IFilialRepository FilialRepository => new EFFilialRepository();

        public IBookRepository BookRepository => new EFBookRepository();

        public IRentRepository RentRepository => new EFRentRepository();

        public ISaleRepository SaleRepository => new EFSaleRepository();
        
        public void SaveChanges()
        {
            
        }
    }
}
