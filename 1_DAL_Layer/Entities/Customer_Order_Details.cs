using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_Layer.Entities
{
    public class Customer_Order_Details
    {
        [ForeignKey("Customer_Order")]
        [StringLength(20)]
        public string CO_Code { get; set; }
        public Customer_Order Customer_Order { get; set; }
        [ForeignKey("Products")]
        [StringLength(20)]
        public string Prd_Code { get; set; }
        public Products Products { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int ExportPrice { get; set; }
        [Required]
        public int Sale { get; set; }
        public int Total { get; set; }
    }
}
