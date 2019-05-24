using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
    public class Config
    {
        public List<User> Users { get; set; }

        public void SeriailizeToJson()
        {
            using (StreamWriter sw = new StreamWriter("config.json"))
            {
                User admin = new User()
                {
                    Email = "admin@gmail.com",
                    Id = 1,
                    No = 1,
                    Note = "none",
                    Password = "admin",
                    Permission = new Permission()
                    {
                        No = 1,
                        Id = 1,
                        CanCreateBook = true,
                        CanCreateCustomer = true,
                        CanCreateFilial = true,
                        CanCreateUser = true,
                        CanRent = true
                    },
                    Permission_Id = 1,
                    Username = "admin"

                };
                Users = new List<User>();
                Users.Add(admin);
                var item = JsonConvert.SerializeObject(Users);
                sw.WriteLine(item);
            }
        }
        public List<User> DeserializeFromJson()
        {
            var text = File.ReadAllText("config.json");
            var items = JsonConvert.DeserializeObject<List<User>>(text);
            return items;
        }
    }
}
