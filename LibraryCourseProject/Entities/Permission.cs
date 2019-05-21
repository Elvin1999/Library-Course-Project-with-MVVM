using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
    class Permission
    {
        public int Id { get; set; }
        public int No { get; set; }
        public bool CanCreateBook { get; set; }
        public bool CanCreateUser { get; set; }
        public bool CanCreateBranch { get; set; }
        public bool CanCreateCustamer { get; set; }
        public bool CanRent { get; set; }
        /*CanCreateBook, CanCreateUser, CanCreateBranch, CanCreateCustomer, CanRent*/
    }
}
