using _1_DAL_Layer.Entitys;
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
                
        }

        public ViewProduct(Employee employee, Products products, bool status)
        {
            Employee = employee;
            Products = products;
            Status = status;
        }
    }
}
