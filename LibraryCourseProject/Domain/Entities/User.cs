using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class User
    {
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? PermissionId { get; set; }
        public string Note { get; set; } = "empty";
        public ICollection<Rent> Rents { get; set; }
        public ICollection<Sale> Sales { get; set; }
        [NotMapped]
        public Permission Permission { get; set; }
        public User Clone()
        {
            User user = new User() {
                 Email=this.Email,
                  Id=this.Id,
                   No=this.No, 
                    Note=this.Note,
                     Password=this.Password,
                      Permission=this.Permission,
                       PermissionId=this.PermissionId,
                        Username=this.Username
            };
            return user;
        }
    }
}

