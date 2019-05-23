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
        public DateTime Opening_Date { get; set; } = DateTime.Now;
        public string Note { get; set; } = "empty";
    }
}

