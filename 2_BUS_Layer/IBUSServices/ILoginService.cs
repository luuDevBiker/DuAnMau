using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;

namespace _2_BUS_Layer.IBUSServices
{
    public interface ILoginService
    {
        public bool CheckLogin(string mail, string password);
        public NhanVien SenderNhanVien(string Mail);
        public string DoiMatKhau(NhanVien nhanvien);
    }
}
