using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;
using _1_DAL_Layer.IDALService;
using _1_DAL_Layer.DataBaseContext;

namespace _1_DAL_Layer.DALService
{
    public class AccountServices : IAccountServices
    {
        private DBcontext DbContext = new DBcontext();

        public NhanVien getNhanVien(string Mail, string password)
        {
            try
            {
                var NhanVien = DbContext.NhanViens.ToList().Where(x => x.Email == Mail && x.MatKhau == password).ToList()[0];
                return NhanVien;
            }
            catch (Exception e)
            { 
                return null;
            }
        }

        public string updatePassword(NhanVien nhanVien)
        {
            try
            {
                DbContext.NhanViens.Update(nhanVien);
                DbContext.SaveChanges();
                return "update successful";
            }
            catch
            {
                return "update error";
            }
        }
    }
}
