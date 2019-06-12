using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Client
    {
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ConnectionTime { get; set; } = DateTime.Now;
        public ICollection<Rent> Rents { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public string Note { get; set; } = "empty";

        public Client Clone()
        {
            Client client = new Client()
            {
                 ConnectionTime=this.ConnectionTime,
                  Id=this.Id,
                   Name=this.Name,
                    No=this.No,
                     Note=this.Note,
                      PhoneNumber=this.PhoneNumber,
                       Surname=this.Surname
            };
            return client;
        }
    }
}
