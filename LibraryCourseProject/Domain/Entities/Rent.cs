using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Rent
    {
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        public double PricePerDay { get; set; }
        public double RealPrice { get; set; }
        public int? UserId { get; set; }
        public int? BookId { get; set; }
        public int? ClientId { get; set; }
        public DateTime RentDateTime { get; set; } = DateTime.Now;
        public DateTime ExactDateTime { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public Rent Clone()
        {
            Rent rent = new Rent()
            {
                 Book=this.Book,
                  BookId=this.BookId,
                   Client=this.Client,
                    ClientId=this.ClientId,
                     ExactDateTime=this.ExactDateTime,
                      Id=this.Id,
                       No=this.No,
                        Note=this.Note,
                         PricePerDay=this.PricePerDay,
                          RealPrice=this.RealPrice,
                           RentDateTime=this.RentDateTime,
                            User=this.User,
                             UserId=this.UserId
            };

            return rent;
        }
    }
}




