using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Sale
    {
        public int Id { get; set; }
        public int No { get; set; }
        public Book Book { get; set; }
        public int Book_Id { get; set; }
        public Client Client { get; set; }
        public int Client_Id { get; set; }
        public User User { get; set; }
        public int User_Id { get; set; }
        public double RealPrice { get; set; }
        public double SalePrice { get; set; }
        public DateTime SaleDateTime { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";

        public Sale Clone()
        {
            Sale sale = new Sale()
            {
                 Book=this.Book,
                  Book_Id=this.Book_Id,
                   Client=this.Client,
                    Client_Id=this.Client_Id,
                     Id=this.Id,
                      No=this.No,
                       Note=this.Note,
                        RealPrice=this.RealPrice,
                         SaleDateTime=this.SaleDateTime,
                          SalePrice=this.SalePrice,
                           User=this.User,
                            User_Id=this.User_Id
            };
            return sale;
        }
    }
}
