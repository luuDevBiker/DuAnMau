using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_Layer.IDALServices
{
    public interface ICustomerOrderDetails
    {
        public string Add(Customer_Order_Details customer_Order_Details);
        public string Update(Customer_Order_Details customer_Order_Details);
        public string Delete(Customer_Order_Details customer_Order_Details);
        public string Save();
        public List<Customer_Order_Details> Getlst();
    }
}
