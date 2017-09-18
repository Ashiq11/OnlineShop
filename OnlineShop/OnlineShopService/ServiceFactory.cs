using OnlineShopData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public abstract class ServiceFactory
    {
        public static IAdminService GetAdminService()
        {
            return new AdminService(DataAccessFactory.GetAdminDataAccess());
        }
        public static ICustomerService GetCustomerService()
        {
            return new CustomerService(DataAccessFactory.GetCustomerDataAccess());
        }
        public static ICategoryService GetCategoryService()
        {
            return new CategoryService(DataAccessFactory.GetCategoryDataAccess());
        }
        public static IProductService GetProductService()
        {
            return new ProductService(DataAccessFactory.GetProductDataAccess());
        }
        public static IOrderService GetOrderService()
        {
            return new OrderService(DataAccessFactory.GetOrderDataAccess());
        }
        public static IOrderDetailService GetOrderDetailService()
        {
            return new OrderDetailService(DataAccessFactory.GetOrderDetailDataAccess());
        }
        public static IPaymentService GetPaymentService()
        {
            return new PaymentService(DataAccessFactory.GetPaymentDataAccess());
        }
        public static IPaymentTypeService GetPaymentTypeService()
        {
            return new PaymentTypeService(DataAccessFactory.GetPaymentTypeDataAccess());
        }
    }
}
