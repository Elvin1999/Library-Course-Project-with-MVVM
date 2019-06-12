using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class LogUpHelper
    {
        private List<User> users;
        public LogUpHelper()
        {
            try
            {
                users = App.Config.DeserializeFromJson();//for users
            }
            catch (Exception)
            {
            }
        }
        public bool IsExistUsername(string username)
        {
            var item = users.FirstOrDefault(x => x.Username == username);
            if (item != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFullRequestingPlaces(string username,string email,string password)
        {
            if (username != null && email != null && password != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsExistEmail(string email)
        {
            var item = users.FirstOrDefault(x => x.Email == email);
            if (item != null)
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
