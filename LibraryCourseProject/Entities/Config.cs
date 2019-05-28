using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace LibraryCourseProject.Entities
{
    public class Config
    {
        public List<User> Users { get; set; }
        public Config()
        {
            Users = new List<User>();
        }
        public void SeriailizeToJson()
        {
            
            using (StreamWriter sw = new StreamWriter("config.json"))
            {
                var item = JsonConvert.SerializeObject(Users);
                sw.WriteLine(item);
            }
        }
        public List<User> DeserializeFromJson()
        {
            List<User> items = new List<User>();
            try
            {
                var context = File.ReadAllText("config.json");
                Users = JsonConvert.DeserializeObject<List<User>>(context);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            return Users;
        }
    }
}
