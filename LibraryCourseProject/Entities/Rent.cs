using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
    class Rent
    {
        public int Id { get; set; }
        public int No { get; set; }
        public double PricePerDay { get; set; }
        public double RealPrice { get; set; }
        public User User { get; set; }
        public int User_Id { get; set; }
        public Client Client { get; set; }
        public int Client_Id { get; set; }
        public Book Book { get; set; }
        public int Book_Id { get; set; }
        public DateTime RentDateTime { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";
    }
}
