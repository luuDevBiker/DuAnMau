using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface ILoginService
    {
        public bool CheckLogin(string mail, string password);
        public string MaHoaPass(string password);
    }
}
