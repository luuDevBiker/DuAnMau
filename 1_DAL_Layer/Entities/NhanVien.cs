using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace _1_DAL_Layer.Entitys
{

    public class NhanVien
    {
        public int ID_NhanVien { get; set; }
        [StringLength(20)]
        [Required]
        [Key]
        public string Ma_NhanVien { get; set; }
        [StringLength(50)]
        [Required]
        public string TenNhanVien { get; set; }
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        [Required]
        public int VaiTro { get; set; }
        
        [StringLength(100)]
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [Required]
        public bool TrangThaiMatKhau { get; set; }

        public ICollection<Hang> Hangs { get; set; }
        public ICollection<KhachHang> KhachHangs { get; set; }
    }
}
