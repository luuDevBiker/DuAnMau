using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entities;
namespace _1_DAL_Layer.IDALServices
{
    public interface IEmployeeService
    {
        public string Update(Employee Employee);
        public string Add(Employee Employee);
        public string Delete(Employee Employee);
        public string Save();
        public List<Employee> Getlst();
    }
}
