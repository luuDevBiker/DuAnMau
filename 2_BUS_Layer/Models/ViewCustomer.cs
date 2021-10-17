using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.Models
{
    public class ViewCustomer
    {
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public bool Status { get; set; }
        public ViewCustomer()
        {
            Employee = new Employee();
            Customer = new Customer();
        }

        public ViewCustomer(Customer customer, Employee employee, bool status)
        {
            Customer = customer;
            Employee = employee;
            Status = status;
        }
    }
}
