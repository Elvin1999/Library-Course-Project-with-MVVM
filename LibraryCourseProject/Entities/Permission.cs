using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Permission
    {
        public int Id { get; set; }
        public int No { get; set; }
        public bool CanCreateBook { get; set; }
        public bool CanCreateUser { get; set; }
        public bool CanCreateFilial { get; set; }
        public bool CanCreateClient { get; set; }
        public bool CanCreateWorker { get; set; }
    }
}
