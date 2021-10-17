using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.Models
{
    public class ViewEmployee
    {
        public Employee Employee { get; set; }
        public bool Status { get; set; }
        public ViewEmployee()
        {
            Employee = new Employee();
        }

        public ViewEmployee(Employee employee, bool status)
        {
            Employee = employee;
            Status = status;
        }
    }
}
