using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entities;

namespace _1_DAL_Layer.IDALServices
{
    public interface ICustomerService
    {
        public string Add(Customer Customer);
        public string Update(Customer Customer);
        public string Delete(Customer Customer);
        public string Save();
        public List<Customer> Getlst();
    }
}
