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
    public interface IManageCtOdDetail
    {
        public string Add(Customer_Order_Details order_Details);
        public string Update(Customer_Order_Details order_Details);
        public string Delete(Customer_Order_Details order_Details);
        public List<ViewCustomerOrderDetail> Getlst_View();
        public ViewCustomerOrderDetail GetCtOdDetail(string Code);
    }
}
