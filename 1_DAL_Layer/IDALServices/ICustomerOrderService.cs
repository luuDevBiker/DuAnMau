using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_Layer.IDALServices
{
    public interface ICustomerOrderService
    {
        public string Add(Customer_Order customer_Order);
        public string Update(Customer_Order customer_Order);
        public string Delete(Customer_Order customer_Order);
        public string Save();
        public List<Customer_Order> Getlst();
    }
}
