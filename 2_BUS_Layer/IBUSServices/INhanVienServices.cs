using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;

namespace _2_BUS_Layer.IBUSServices
{

    public interface INhanVienServices
    {
        public string UpdateNhanVien(NhanVien nhanVien);
        public string AddNhanVien(NhanVien nhanVien);
        public string DeleteNhanVien(string maNhanVien);
        public string SaveNhanVien();
        public NhanVien SelectNhanVien(string maNhanVien);
        public void GetlstNhanVien();
        public List<NhanVien> SendlstNhanVien();

    }
}
