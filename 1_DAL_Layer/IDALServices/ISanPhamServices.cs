using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;



namespace _1_DAL_Layer.IDALServices
{
    public interface ISanPhamServices
    {
        public string GetlstHang();
        public List<Hang> SendlstHang();
        public string AddHang(Hang hang);


    }
}
