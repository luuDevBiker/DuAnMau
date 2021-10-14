using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _1_DAL_Layer.Entities;

namespace _1_DAL_Layer.Entitys
{
    public class Products
    {
        public int Prd_Id { get; set; }
        [StringLength(20)]
        [Required]
        [Key]
        public string Prd_Code { get; set; }
        [StringLength(20)]
        [Required]
        public string Prd_Name { get; set; }
        [Required]
        public byte[] Img_Barcode { get; set; }
        [Required]
        public int Prd_Quantity { get; set; }
        [Required]
        public int Prd_STTQuantity { get; set; }
        [Required]
        public int Prd_ImportPrice { get; set; }
        [Required]
        public int Prd_ExportPrice { get; set; }
        public int Prd_Sale { get; set; }
        [Required]
        public byte[] Prd_Image { get; set; }
        public string Prd_Note { get; set; }
        [ForeignKey("Employee")]
        [Required]
        [StringLength(20)]
        public string Ep_Code { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Customer_Order_Details> Customer_Order_Details { get; set; }
    }
}
