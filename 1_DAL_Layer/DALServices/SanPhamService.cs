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
        public string GetlstHang()
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

        public List<Hang> SendlstHang()
        {
            try
            {
                return _lstHang;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
