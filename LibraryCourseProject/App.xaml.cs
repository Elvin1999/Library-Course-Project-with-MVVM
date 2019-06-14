using LibraryCourseProject.DataAccess.EntityFrameworkServer;
using LibraryCourseProject.Domain.Abstractions;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryCourseProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Config Config;
        public static IUnitOfWork DB;
        private App()
        {
            Config = new Config();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("az");
            DB = new EFUnitOfWork();
            using (EFContext db = new EFContext())
            {

                Author author = new Author()
                {
                    Name = "Agata",
                    Surname = "Cristy",
                    No = 1
                };
                db.Authors.Add(author);
                Client client = new Client()
                {
                    No = 1,
                    Name = "Elxan",
                    Surname = "Elxanli",
                    Note = "",
                    PhoneNumber = "+994515848762",
                };
                db.Clients.Add(client);
                Filial filial = new Filial()
                {
                    Name = "Nizami filiali",
                    Address = "Nizami mt stansiyasi",
                    Note = "",
                    No = 1
                };
                db.Filials.Add(filial);
                Genre genre = new Genre()
                {
                    No = 1,
                    Name = "Drama"
                };
                db.Genres.Add(genre);
                Permission permission = new Permission()
                {
                    No = 1,
                    CanCreateBook = true,
                    CanCreateClient = true,
                    CanCreateFilial = true,
                    CanCreateUser = true,
                    CanCreateWorker = true
                };
                db.Permissions.Add(permission);
                User user = new User()
                {
                    No = 1,
                    Email = "admin@gmail.com",
                    Note = "",
                    Password = "admin",
                    Username = "admin",
                    PermissionId = 1,

                };
                db.Users.Add(user);
                Worker worker = new Worker()
                {
                    No = 1,
                    Note = "",
                    Age = 22,
                    FilialId = 1,
                    Name = "Arif",
                    PhoneNumber = "+994505849469",
                    Salary = 5000,
                    Surname = "Arifli",
                };
                db.Workers.Add(worker);
                Book book = new Book()
                {
                    No = 1,
                    AuthorId = 1,
                    GenreId = 1,
                    Note = "",
                    PageCount = 250,
                    PurchasePrice = 100,
                    SalePrice = 150,
                    Title = "MyMind"
                };
                db.Books.Add(book);
                Rent rent = new Rent()
                {
                    No = 1,
                    Note = "",
                    BookId = 1,
                    ClientId = 1,
                    PricePerDay = 12,
                    RealPrice = 120,
                    UserId = 1
                };
                db.Rents.Add(rent);
                Sale sale = new Sale()
                {
                    No = 1,
                    UserId = 1,
                    ClientId = 1,
                    BookId = 1,
                    Note = "",
                    SalePrice = 120.5,
                    RealPrice = 100
                };
                db.Sales.Add(sale);
            }

        }
    }
    }

