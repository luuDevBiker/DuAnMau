using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace _1_DAL_Layer.Entities
{

    public class Employee
    {
        public int Ep_Id { get; set; }
        [StringLength(20)]
        [Required]
        [Key]
        public string Ep_Code { get; set; }
        [StringLength(50)]
        [Required]
        public string Ep_Name { get; set; }
        [StringLength(50)]
        [Required]
        public string Ep_Email { get; set; }
        [Required]
        public int Ep_Role { get; set; }
        
        [StringLength(100)]
        [Required]
        public string Ep_Password { get; set; }
        [StringLength(100)]
        [Required]
        public string Ep_Address { get; set; }
        [Required]
        public bool Ep_Status { get; set; }
        [Required]
        public bool Ep_StatusPassword { get; set; }

        public ICollection<Products> Products { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}
