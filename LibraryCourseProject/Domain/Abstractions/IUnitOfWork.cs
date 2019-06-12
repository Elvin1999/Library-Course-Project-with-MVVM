using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Domain.Abstractions
{
   public interface IUnitOfWork
    {
        void SaveChanges();
        IUserRepository UserRepository { get; }
        IWorkerRepository WorkerRepository { get; }
        IClientRepository ClientRepository { get; }
        IFilialRepository FilialRepository { get; }
        IBookRepository BookRepository { get; }
        IRentRepository RentRepository { get; }
        ISaleRepository SaleRepository { get; }
    }
}
