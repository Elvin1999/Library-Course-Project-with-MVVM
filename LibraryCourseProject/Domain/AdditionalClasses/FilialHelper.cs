using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class FilialHelper
    {
        private List<Filial> filials;
        public FilialHelper()
        {
            try
            {
                filials = new List<Filial>(App.DB.FilialRepository.GetAllData());
            }
            catch (Exception)
            {
            }
        }
        public bool IsFullRequestingPlaces(string name,string address)
        {
            if (name != null && address != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsExistFilialName(string name)
        {
            var item = filials.FirstOrDefault(x => x.Name == name);
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
