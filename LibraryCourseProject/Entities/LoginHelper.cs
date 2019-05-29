using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class LoginHelper
    {
        private List<User> Users;
        public LoginHelper()
        {
            try
            {
                Users = App.Config.DeserializeFromJson();//for users
            }
            catch (Exception)
            {

            }
        }
        public bool IsExist(string username)
        {
            var item = Users.FirstOrDefault(x => x.Username == username);
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
