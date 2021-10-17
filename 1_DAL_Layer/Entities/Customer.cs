using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _1_DAL_Layer.Entities;

namespace _1_DAL_Layer.Entities
{
    public class Customer
    {
        [Key]
        [StringLength(20)]
        public string Ct_PhoneNumber { get; set; }
        [StringLength(50)]
        [Required]
        public string Ct_Name { get; set; }
        [StringLength(100)]
        [Required]
        public string Ct_Address { get; set; }
        [Required]
        public int Ct_Sex { get; set; }
        [ForeignKey("Employee")]
        [Required]
        [StringLength(20)]
        public string Ep_Code { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Customer_Order> Customer_Orders { get; set; } 
    }
}
