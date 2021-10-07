using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.DataBaseContext;
using _1_DAL_Layer.Entitys;
using _1_DAL_Layer.IDALServices;

namespace _1_DAL_Layer.DALServices
{
    
    public class CustomerService : ICustomerService
    {
        private DBcontext _DBcontext = new DBcontext();
        public string Add(Customer Customer)
        {
            try
            {
                _DBcontext.KhachHangs.Add(Customer);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Customer Customer)
        {
            try
            {
                _DBcontext.KhachHangs.Remove(Customer);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Customer> Getlst()
        {
            return _DBcontext.KhachHangs.ToList();
        }
        public string Save()
        {
            try
            {
                _DBcontext.SaveChanges();
                return "successful";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public string Update(Customer Customer)
        {
            try
            {
                _DBcontext.KhachHangs.Update(Customer);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
