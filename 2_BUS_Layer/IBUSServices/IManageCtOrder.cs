using _1_DAL_Layer.DALServices;
using _1_DAL_Layer.Entities;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.IBUSServices
{
    public interface IManageCtOrder
    {
        public string Add(Customer_Order customerOrder);
        public string Update(Customer_Order customerOrder);
        public string Delete(Customer_Order customerOrder);
        public List<ViewCustomerOrder> Getlst_View();
        public ViewCustomerOrder GetCtOrder(string Code);
        public int GetMaxId();
    }
}
