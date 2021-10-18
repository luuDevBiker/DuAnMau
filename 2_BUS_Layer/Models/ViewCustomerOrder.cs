
using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.Models
{
    public class ViewCustomerOrder
    {
        public Customer Customer { get; set; }
        public Customer_Order Customer_Order { get; set; }
        public bool Status { get; set; }
        public ViewCustomerOrder()
        {
            Customer = new Customer();
            Customer_Order = new Customer_Order();
        }

        public ViewCustomerOrder(Customer customer, Customer_Order customer_Order , bool status)
        {
            Customer = customer;
            Customer_Order = customer_Order;
            Status = status;
        }
    }
}
