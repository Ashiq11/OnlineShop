using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class AdminService : IAdminService
    {
        private IAdminDataAccess data;

        public AdminService(IAdminDataAccess data)
        {
            this.data = data;
        }

        public Admin Get(int id)
        {
            return this.data.Get(id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return this.data.GetAll();
        }

        public bool ValidateCredentials(Admin admin)
        {
            return this.data.ValidateCredentials(admin);
        }
    }
}
