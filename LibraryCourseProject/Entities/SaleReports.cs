using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
    class SaleReports
    {
        public int Id { get; set; }
        public int No { get; set; }
        public ObservableCollection<Sale>AllSales { get; set; }
    }
}
