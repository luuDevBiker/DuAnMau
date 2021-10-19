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
    public class Customer_Order
    {
        [Key]
        [StringLength(20)]
        public string CO_Code { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Total_Money { get; set; }
        [ForeignKey("Employee")]
        [StringLength(20)]
        public string Ep_Code { get; set; }
        [ForeignKey("Customer")]
        [StringLength(20)]
        public string Ct_Code { get; set; }
        public Customer Customer { get; set; }
    }
}
