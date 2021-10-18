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
    public class CustomerOdDetailService : ICustomerOdDetailService
    {
        private DBcontext _DBcontext;
        public CustomerOdDetailService()
        {
            _DBcontext = new DBcontext();
        }

        public string Add(Customer_Order_Details customer_Order_Details)
        {
            try
            {
                _DBcontext.Customer_Order_Details.Add(customer_Order_Details);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Delete(Customer_Order_Details customer_Order_Details)
        {
            try
            {
                _DBcontext.Customer_Order_Details.Remove(customer_Order_Details);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<Customer_Order_Details> Getlst()
        {
            try
            {
                return _DBcontext.Customer_Order_Details.ToList();
            }
            catch (Exception e)
            {
                return null;
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

        public string Update(Customer_Order_Details customer_Order_Details)
        {
            try
            {
                _DBcontext.Customer_Order_Details.Update(customer_Order_Details);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
