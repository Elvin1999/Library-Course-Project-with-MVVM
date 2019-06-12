using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Rent
    {
        public int Id { get; set; }
        public int No { get; set; }
        public double PricePerDay { get; set; }
        public double RealPrice { get; set; }
        public int User_Id { get; set; }
        public int Book_Id { get; set; }
        public int Client_Id { get; set; }
        public DateTime RentDateTime { get; set; } = DateTime.Now;
        public DateTime ExactDateTime { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";
        public Client Client { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public Rent Clone()
        {
            Rent rent = new Rent()
            {
                 Book=this.Book,
                  Book_Id=this.Book_Id,
                   Client=this.Client,
                    Client_Id=this.Client_Id,
                     ExactDateTime=this.ExactDateTime,
                      Id=this.Id,
                       No=this.No,
                        Note=this.Note,
                         PricePerDay=this.PricePerDay,
                          RealPrice=this.RealPrice,
                           RentDateTime=this.RentDateTime,
                            User=this.User,
                             User_Id=this.User_Id
            };

            return rent;
        }
    }
}




