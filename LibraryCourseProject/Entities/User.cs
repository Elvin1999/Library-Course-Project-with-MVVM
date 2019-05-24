using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class User
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Permission Permission { get; set; }
        public int Permission_Id { get; set; }
        public string Note { get; set; } = "empty";

        public User Clone()
        {
            User user = new User() {
                 Email=this.Email,
                  Id=this.Id,
                   No=this.No, 
                    Note=this.Note,
                     Password=this.Password,
                      Permission=this.Permission,
                       Permission_Id=this.Permission_Id,
                        Username=this.Username
            };
            return user;
        }
    }
}

