using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_Layer.IBUSServices;
using _1_DAL_Layer.Entitys;


namespace _2_BUS_Layer.BUSServices
{
    public class HangServices : _2_BUS_Layer.IBUSServices.IHangServices
    {
        private _1_DAL_Layer.IDALServices.ISanPhamServices _ISanPhamServices = new _1_DAL_Layer.DALServices.SanPhamService();
        public string AddSanPham(Hang hang)
        {
            return _ISanPhamServices.AddSanPham(hang);
        }

        public string DeleteSanPham(string MaHang)
        {
            return _ISanPhamServices.DeleteSanPham(MaHang);
        }

        public string GetlstSanPham()
        {
            return _ISanPhamServices.GetlstSanPham();
        }

        public string SaveSanPham()
        {
            return _ISanPhamServices.SaveSanPham();
        }

        public List<Hang> SendlstSanPham()
        {
            return _ISanPhamServices.SendlstSanPham();
        }

        public string UpdateSanPham(Hang hang)
        {
            return _ISanPhamServices.UpdateSanPham(hang);
        }
        public int GetMaHangMax()
        {
            if (_ISanPhamServices.SendlstSanPham().Count == 0) return 1000;
            return _ISanPhamServices.SendlstSanPham().Select(x=>x.ID_Hang).Max();
        }

        public bool checkHangExits(string TenHang)
        {
            try
            {
                var hang = SendlstSanPham().Where(x => x.TenHang == TenHang).FirstOrDefault();
                if(hang != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
        public int getMaxIDHang()
        {
            if (SendlstSanPham().Count == 0) return 1000;
            return SendlstSanPham().Max(x => x.ID_Hang);
        }
        public Hang SelectHang(string MaHang) 
        {
            return _ISanPhamServices.SelectHang(MaHang);
        }
    }
}
