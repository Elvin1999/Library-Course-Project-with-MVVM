using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class WorkerHelper
    {
        private List<Worker> workers;
        public WorkerHelper()
        {
            try
            {
                workers = App.Config.DeserializeWorkersFromJson();
            }
            catch (Exception)
            {
            }
        }
        public bool IsFilledRequestingPlaces(string name,string surname)
        {
            if (name != null && surname != null)
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
