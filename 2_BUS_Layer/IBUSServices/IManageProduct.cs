using _1_DAL_Layer.Entities;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface IManageProduct
    {
        // add Prd to temporary list in BUS_Layer
        public string Add(ViewProduct Prd);
        // add Prd new_add in BUS_Layer to Database and Reload list
        public string Add();
        // update Prd in BUS_Layer and Database
        public string Update(ViewProduct Prd);
        // delate Prd in BUS_Layer and Database
        public string Delete(ViewProduct Prd);
        // save data to database
        public string Save();
        // Send list Prd in BUS_Layer to GUI_Layer
        public List<ViewProduct> GetlstView_Prd();
        // Load list Prd from DAL_Layer to BUS_Layer
        public void LoadlstView_Prd();
        // Take max Id of list Prd in list temporary Prd
        public int GetMaxID();
        // check name product exits 
        public bool CheckNamePrd(string NamePrd);
        // get viewproduct with viewproduct_code
        public ViewProduct SelectViewProduct(string ViewPrd_Code);
        // get Employee add Product
        public Employee GetEmployee(string Ep_code);
    }
}
