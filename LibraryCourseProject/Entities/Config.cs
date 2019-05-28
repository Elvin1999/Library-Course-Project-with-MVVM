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
        public List<Client> Clients { get; set; }
        public List<Book> Books { get; set; }
        public Config()
        {
            Users = new List<User>();
            Clients = new List<Client>();
            Books = new List<Book>();
        }
        public void SeriailizeBooksToJson()
        {

            using (StreamWriter sw = new StreamWriter("configBooks.json"))
            {
                var item = JsonConvert.SerializeObject(Books);
                sw.WriteLine(item);
            }
        }
        public List<Book> DeserializeBooksFromJson()
        {
            try
            {
                var context = File.ReadAllText("configBooks.json");
                Books = JsonConvert.DeserializeObject<List<Book>>(context);
            }
            catch (Exception)
            {
            }

            return Books;
        }
        public void SeriailizeClientsToJson()
        {

            using (StreamWriter sw = new StreamWriter("configClients.json"))
            {
                var item = JsonConvert.SerializeObject(Clients);
                sw.WriteLine(item);
            }
        }
        public List<Client> DeserializeClientsFromJson()
        {
            try
            {
                var context = File.ReadAllText("configClients.json");
                Clients = JsonConvert.DeserializeObject<List<Client>>(context);
            }
            catch (Exception)
            {
            }

            return Clients;
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
