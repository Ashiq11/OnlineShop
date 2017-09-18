using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public interface IAdminService
    {
        IEnumerable<Admin> GetAll();
        Admin Get(int id);
        bool ValidateCredentials(Admin admin);
    }
}
