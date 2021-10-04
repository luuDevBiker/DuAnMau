using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;
using _1_DAL_Layer.IDALServices;
using _1_DAL_Layer.DataBaseContext;


namespace _1_DAL_Layer.DALServices
{
    public class SanPhamService : ISanPhamServices
    {
        private DBcontext _DBcontext = new DBcontext();
        private List<Hang> _lstHang;

        public string AddSanPham(Hang hang)
        {
            try
            {
                _DBcontext.Hangs.Add(hang);
                _lstHang.Add(hang);
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteSanPham(string MaHang)
        {
            try
            {
                var hang = _lstHang.Where(x => x.MaHang == MaHang).FirstOrDefault();
                _DBcontext.Hangs.Remove(hang);
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetlstSanPham()
        {
            try
            {
                _lstHang = _DBcontext.Hangs.ToList();
                return "Lấy dữ liệu hàng thành công";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public string SaveSanPham()
        {
            try
            {
                _DBcontext.SaveChanges();
                return "Lưu dữ liệu thành công";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public Hang SelectHang(string MaHang)
        {
            return _lstHang.Where(x => x.MaHang == MaHang).FirstOrDefault();
        }

        public List<Hang> SendlstSanPham()
        {
            try
            {
                return _lstHang;
            }
            catch
            {
                return null;
            }
        }

        public string UpdateSanPham(Hang hang)
        {
            try
            {
                var index = _lstHang.FindIndex(x => x.MaHang == hang.MaHang);
                _lstHang[index] = hang;
                _DBcontext.Hangs.Update(hang);
                return "Cập nhật thành công";
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
    }
}
