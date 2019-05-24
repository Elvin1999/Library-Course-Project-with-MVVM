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
