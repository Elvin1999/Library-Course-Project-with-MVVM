using LibraryCourseProject.Domain.Abstractions;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.DataAccess.EntityFrameworkServer
{
    public class EFPermissionRepository : IPermissionRepository
    {
        public void AddData(Permission data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Permission data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Permission> GetAllData()
        {
            using (EFContext db = new EFContext())
            {

                permissions = new ObservableCollection<Permission>(db.Permissions);
            }
            for (int i = 0; i < permissions.Count; i++)
            {
                permissions[i].No = i + 1;
            }
            return permissions;
        }
        ObservableCollection<Permission> permissions;
        public Permission GetData(int id)
        {
            Permission permission = new Permission();
            var items = GetAllData();
                var item = items.SingleOrDefault(x => x.Id == id);
                if (item != null)
                {
                    permission = item;
                }

            return permission;
        }

        public void UpdateData(Permission data)
        {
            throw new NotImplementedException();
        }
    }
}
