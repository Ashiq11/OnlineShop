using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class AdminDataAccess : IAdminDataAccess
    {
        private ProductDBContext context;

        public AdminDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public Admin Get(int id)
        {
            return this.context.Admins.SingleOrDefault(x => x.AdminID == id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return this.context.Admins.ToList();
        }

        public bool ValidateCredentials(Admin admin)
        {
            Admin ad = this.context.Admins.SingleOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (ad == null)
            {
                return false;
            }
            else
            {
                admin.AdminID = ad.AdminID;
                return true;
            }
        }
    }
}
