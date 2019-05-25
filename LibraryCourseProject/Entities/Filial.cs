using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Filial
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpeningDate { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";

        public Filial Clone()
        {
            Filial filial = new Filial()
            {
                 Address=this.Address,
                  Id=this.Id,
                   Name=this.Name,
                    No=this.No,
                     Note=this.Note,
                      OpeningDate=this.OpeningDate
            };
            return filial;
        }
    }
}

