using _1_DAL_Layer.Entities;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface IManageCustomer
    {
        // add to list in BUS_Layer
        public string Add(ViewCustomer View_Ct);
        // update to list in BUS_Layer and database
        public string Update(ViewCustomer View_Ct);
        // delete to list in BUS_Layer and database
        public string Delete(ViewCustomer View_Ct);
        // Save to Database
        public string Save();
        // check number phone exits
        public bool CheckNumberPhone(string NumberPhone);
        // get list Employee 
        public void LoadlstView_Ct();
        // send list viewCustomer to GUI
        public List<ViewCustomer> GetlstView_Ct();
        // send status data save
        public bool StatusData();
        // select ViewCustomer with customer code
        public ViewCustomer GetViewCustomer(string Ct_Phone);
        // select Employee
        public Employee GetEmployee(string Ep_Code);
    }
}
