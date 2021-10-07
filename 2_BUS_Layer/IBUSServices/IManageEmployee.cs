using _2_BUS_Layer.Models;
using _1_DAL_Layer.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface IManageEmployee
    {
        // add Ep to temporary list in BUS_Layer
        public string Add(ViewEmployee Ep);
        // update Ep in BUS_Layer and Database
        public string Update(ViewEmployee Ep);
        // delate Ep in BUS_Layer and Database
        public string Delete(ViewEmployee Ep);
        // save data to database
        public string Save();
        // Send list Ep in BUS_Layer to GUI_Layer
        public List<ViewEmployee> GetlstView_Ep();
        // Load list Ep from DAL_Layer to BUS_Layer
        public void LoadlstView_Ep();
        // Take max Id of list Ep in list temporary Ep
        public int GetMaxID();
        // check Mail Exits
        public bool CheckMail(string Mail);
        // check status datasave 
        public bool StatusData();
        // Select a Employee with Ep_Code send GUI to do update
        public ViewEmployee SelectViewEp(string Ep_Code);
    }
}
