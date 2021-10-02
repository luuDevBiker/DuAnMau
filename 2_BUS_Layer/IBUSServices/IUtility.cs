using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface IUtility
    {
        // utility
        public string MaHoaPass(string password);
        public string PassRandom();
        public string SenderMail(string Mail, string Pass);
    }
}
