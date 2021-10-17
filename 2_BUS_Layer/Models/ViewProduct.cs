using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.Models
{
    public class ViewProduct
    {
        public Employee Employee { get; set; }
        public Products Products { get; set; }
        public bool Status { get; set; }
        public ViewProduct()
        {
            Employee = new Employee();
            Products = new Products();
        }

        public ViewProduct(Employee employee, Products products, bool status)
        {
            Employee = employee;
            Products = products;
            Status = status;
        }
    }
}
