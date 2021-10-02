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
        public string SenderMaNV();
        public bool SenderTrangThaiMatKhau();
        public NhanVien SenderNhanVien(string Mail, string password);
        public string DoiMatKhau(NhanVien nhanvien);
    }
}
