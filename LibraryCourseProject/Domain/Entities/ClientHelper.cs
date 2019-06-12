using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class ClientHelper
    {
        private List<Client> clients;
        public ClientHelper()
        {
            try
            {

                clients = App.Config.DeserializeClientsFromJson();
            }
            catch (Exception)
            {
            }
        }
        public bool isFilledRequestingPlaces(string name,string surname,DateTime dateTime,string phonenumber,
            string note)
        {
            if (name != null && surname != null && dateTime != null && phonenumber != null && note != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
