using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
    using LibraryCourseProject.Entities;
    using LibraryCourseProject.Migrations;
    using System.Data.Entity;
    public class EFContext : DbContext
    {
        // Your context has been configured to use a 'LibraryDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LibraryCourseProject.DataAccess.EntityFrameworkServer.LibraryDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LibraryDbContext' 
        // connection string in the application configuration file.
        public EFContext()
            : base("name=LibraryDbContext2")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Filial> Filials { get; set; }//
        public virtual DbSet<User> Users { get; set; }//
        public virtual DbSet<Book> Books { get; set; }//
        public virtual DbSet<Client> Clients { get; set; }//
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }//
        public virtual DbSet<Rent> Rents { get; set; }//
        public virtual DbSet<Sale> Sales { get; set; }//
        public virtual DbSet<Worker> Workers { get; set; }//
    }
}



