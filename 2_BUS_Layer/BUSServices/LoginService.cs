using _2_BUS_Layer.IBUSServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.IDALService;
using System.Windows;
using _2_BUS_Layer.Utility;

namespace _2_BUS_Layer.BUSServices
{
    public class LoginService : ILoginService
    {
        private IAccountServices _iAccountServices = new _1_DAL_Layer.DALService.AccountServices();
        private Utility.utility utility = new Utility.utility();

        public bool CheckLogin(string mail, string password)
        {
            try
            {
                var nhanVien = _iAccountServices.getNhanVien(mail);
                bool result = nhanVien.MatKhau == utility.MaHoaPass(password) ? true : false;
                return result;
            }
            catch
            {
                return false;
            }
        }

        public _1_DAL_Layer.Entitys.NhanVien SenderNhanVien(string Mail)
        {
            return _iAccountServices.getNhanVien(Mail);
        }

        public string DoiMatKhau(_1_DAL_Layer.Entitys.NhanVien nhanvien)
        {
            nhanvien.MatKhau = utility.MaHoaPass(nhanvien.MatKhau);
            var result = _iAccountServices.updatePassword(nhanvien);
            return result;
        }
    }
}
