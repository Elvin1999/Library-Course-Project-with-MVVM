using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
    class Sale
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
    }
}
