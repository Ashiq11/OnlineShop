using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopData
{
    public abstract class DataAccessFactory
    {
        public static IAdminDataAccess GetAdminDataAccess()
        {
            return new AdminDataAccess(new ProductDBContext());
        }
        public static ICustomerDataAccess GetCustomerDataAccess()
        {
            return new CustomerDataAccess(new ProductDBContext());
        }
        public static IProductDataAccess GetProductDataAccess()
        {
            return new ProductDataAccess(new ProductDBContext());
        }
        public static ICategoryDataAccess GetCategoryDataAccess()
        {
            return new CategoryDataAccess(new ProductDBContext());
        }
        public static IOrderDataAccess GetOrderDataAccess()
        {
            return new OrderDataAccess(new ProductDBContext());
        }
        public static IOrderDetailDataAccess GetOrderDetailDataAccess()
        {
            return new OrderDetailDataAccess(new ProductDBContext());
        }
        public static IPaymentDataAccess GetPaymentDataAccess()
        {
            return new PaymentDataAccess(new ProductDBContext());
        }
        public static IPaymentTypeDataAccess GetPaymentTypeDataAccess()
        {
            return new PaymentTypeDataAccess(new ProductDBContext());
        }
    }
}
