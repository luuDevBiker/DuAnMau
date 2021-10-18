using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.DataBaseContext;
using _1_DAL_Layer.Entities;
using _1_DAL_Layer.IDALServices;

namespace _1_DAL_Layer.DALServices
{
    public class CustomerOrderService : ICustomerOrderService
    {
        private DBcontext _DBcontext;

        public CustomerOrderService()
        {
            _DBcontext = new DBcontext();
        }
        public string Add(Customer_Order customer_Order)
        {
            try
            {
                _DBcontext.Customer_Orders.Add(customer_Order);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Delete(Customer_Order customer_Order)
        {
            try
            {
                _DBcontext.Customer_Orders.Remove(customer_Order);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<Customer_Order> Getlst()
        {
            try
            {
                return _DBcontext.Customer_Orders.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Save()
        {
            try
            {
                _DBcontext.SaveChanges();
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Update(Customer_Order customer_Order)
        {
            try
            {
                _DBcontext.Customer_Orders.Update(customer_Order);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
