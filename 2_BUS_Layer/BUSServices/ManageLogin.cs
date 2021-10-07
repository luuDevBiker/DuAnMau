using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_Layer.Models;

namespace _2_BUS_Layer.BUSServices
{
    public class ManageLogin //: IManageLogin
    {
        //private IManageEmployee _iManagaEmployee = new ManageEmployee();
        //private Utility.Utility _Utility = new Utility.Utility();
        //public ManageLogin()
        //{

        //}
        //public ViewEmployee CheckAccount(string mail, string pass)
        //{
        //    var acc = _iManagaEmployee.GetlstView_Ep()
        //        .Where(x => x.Ep_Mail == mail && x.Ep_Password == _Utility.EncodePass(pass)).FirstOrDefault();
        //    return acc;
        //}

        //public ViewEmployee GetAccount(string Mail)
        //{
        //    var acc =  _iManagaEmployee.GetlstView_Ep().Where(x => x.Ep_Mail == Mail).FirstOrDefault();
        //    return acc;
        //}

        //public string Update(string mail, string pass , bool statusPass)
        //{
        //    try
        //    {
        //        var acc = _iManagaEmployee.GetlstView_Ep()
        //            .Where(x => x.Ep_Mail == mail).FirstOrDefault();
        //        acc.Ep_Password = _Utility.EncodePass(pass);
        //        acc.Ep_StatusPassword = statusPass;
        //        _iManagaEmployee.Update(acc);
        //        return "Successful";
        //    }
        //    catch(Exception e)
        //    {
        //        return e.Message;
        //    }
        //}
    }
}
