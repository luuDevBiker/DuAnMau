
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface IManageLogin
    {
        // check acc exits
        public ViewEmployee CheckAccount(string Mail,string Pass);
        // get acc with Email
        public ViewEmployee GetAccount(string Mail);
        // update password
        public string Update(string Mail, string Pass,bool statuspass);
    }
}
