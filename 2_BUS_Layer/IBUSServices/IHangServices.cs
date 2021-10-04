using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;


namespace _2_BUS_Layer.IBUSServices
{
    public interface IHangServices
    {
        public string GetlstSanPham();
        public List<Hang> SendlstSanPham();
        public string AddSanPham(Hang hang);
        public string UpdateSanPham(Hang hang);
        public string DeleteSanPham(string MaHang);
        public string SaveSanPham();
        public bool checkHangExits(string TenHang);
        public int getMaxIDHang();

        public Hang SelectHang(string MaHang);
    }
}
