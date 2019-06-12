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
        public int BookId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public double RealPrice { get; set; }
        public double SalePrice { get; set; }
        public DateTime SaleDateTime { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";

        public Sale Clone()
        {
            Sale sale = new Sale()
            {
                 Book=this.Book,
                  BookId=this.BookId,
                   Client=this.Client,
                    ClientId=this.ClientId,
                     Id=this.Id,
                      No=this.No,
                       Note=this.Note,
                        RealPrice=this.RealPrice,
                         SaleDateTime=this.SaleDateTime,
                          SalePrice=this.SalePrice,
                           User=this.User,
                            UserId=this.UserId
            };
            return sale;
        }
    }
}
