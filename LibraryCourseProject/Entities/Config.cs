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
        public Config()
        {
            Users = new List<User>();
        }
        public void SeriailizeToJson()
        {
            using (StreamWriter sw = new StreamWriter("config.json",true))
            {

                var item = JsonConvert.SerializeObject(Users);
                sw.WriteLine(item);
            }
        }
        public List<User> DeserializeFromJson()
        {
            List<User> items = new List<User>();
            //var text = File.ReadAllText("config.json");
            //
            //try
            //{

            //items = JsonConvert.DeserializeObject<List<User>>(text);
            //}
            //catch (Exception)
            //{
            //}
            using(StreamReader sr=new StreamReader("config.json"))
            {
                string text = sr.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<User>>(text);
                Users = items;
            }
            return items;
        }
    }
}
