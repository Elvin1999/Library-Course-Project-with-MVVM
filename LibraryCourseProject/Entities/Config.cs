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
        public List<Worker> Workers { get; set; }
        public List<Filial> Filials { get; set; }
        public Config()
        {
            Users = new List<User>();
            Clients = new List<Client>();
            Books = new List<Book>();
            Workers = new List<Worker>();
            Filials = new List<Filial>();
        }
        public void SeriailizeFilialsToJson()
        {

            using (StreamWriter sw = new StreamWriter("configFilials.json"))
            {
                var item = JsonConvert.SerializeObject(Filials);
                sw.WriteLine(item);
            }
        }
        public List<Filial> DeserializeFilialsFromJson()
        {
            try
            {
                var context = File.ReadAllText("configFilials.json");
                Filials = JsonConvert.DeserializeObject<List<Filial>>(context);
            }
            catch (Exception)
            {
            }

            return Filials;
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
        public void SeriailizeWorkersToJson()
        {

            using (StreamWriter sw = new StreamWriter("configWorkers.json"))
            {
                var item = JsonConvert.SerializeObject(Workers);
                sw.WriteLine(item);
            }
        }
        public List<Worker> DeserializeWorkersFromJson()
        {
            try
            {
                var context = File.ReadAllText("configWorkers.json");
                Workers = JsonConvert.DeserializeObject<List<Worker>>(context);
            }
            catch (Exception)
            {
            }

            return Workers;
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
