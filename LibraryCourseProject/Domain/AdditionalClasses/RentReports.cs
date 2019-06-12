using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class RentReports
    {
        public int Id { get; set; }
        public int No { get; set; }
        public ObservableCollection<Rent> AllRents { get; set; }
    }
}
