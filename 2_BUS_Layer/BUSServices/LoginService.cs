using _2_BUS_Layer.IBUSServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.IDALService;
using System.Windows;
using System.Security.Cryptography;

namespace _2_BUS_Layer.BUSServices
{
    public class LoginService : ILoginService
    {
        private IAccountServices _iAccountServices = new _1_DAL_Layer.DALService.AccountServices();
        public bool CheckLogin(string mail, string password)
        {
            try
            {
                var nhanVien = _iAccountServices.getNhanVien(mail, MaHoaPass(password));
                bool result = nhanVien.MatKhau == MaHoaPass(password) ? true : false;
                return result;
            }
            catch
            {
                return false;
            }
        }

        public string MaHoaPass(string password)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
