using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.Models
{
    public class ViewCustomerOrderDetail
    {
        public Products Products { get; set; }
        public Customer_Order_Details Customer_Order_Details { get; set; }
        public Customer_Order Customer_Order { get; set; }
        public ViewCustomerOrderDetail()
        {
            Products = new Products();
            Customer_Order_Details = new Customer_Order_Details();
            Customer_Order = new Customer_Order();
        }

        public override bool Equals(object obj)
        {
            return obj is ViewCustomerOrderDetail detail &&
                   EqualityComparer<Products>.Default.Equals(Products, detail.Products) &&
                   EqualityComparer<Customer_Order_Details>.Default.Equals(Customer_Order_Details, detail.Customer_Order_Details) &&
                   EqualityComparer<Customer_Order>.Default.Equals(Customer_Order, detail.Customer_Order);
        }
    }
}
