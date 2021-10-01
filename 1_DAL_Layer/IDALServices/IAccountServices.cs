using _1_DAL_Layer.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1_DAL_Layer.IDALService
{
    public interface IAccountServices
    {
        public NhanVien getNhanVien(string Mail , string password);
        public string updatePassword(NhanVien nhanVien);
    }
}
