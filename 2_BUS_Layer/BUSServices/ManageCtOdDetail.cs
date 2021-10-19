using _1_DAL_Layer.DALServices;
using _1_DAL_Layer.Entities;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.BUSServices
{
    public class ManageCtOdDetail : IManageCtOdDetail
    {
        private CustomerOrderService _iCustomerOrderService;
        private CustomerOdDetailService _iCustomerOdDetailService;
        private List<ViewCustomerOrderDetail> _lstView;
        public ManageCtOdDetail()
        {
            _iCustomerOdDetailService = new CustomerOdDetailService();
            _iCustomerOrderService = new CustomerOrderService();
            _lstView = new List<ViewCustomerOrderDetail>();
        }

        public string Add(Customer_Order_Details order_Details)
        {
            return _iCustomerOdDetailService.Add(order_Details);
        }

        public string Delete(Customer_Order_Details order_Details)
        {
            return _iCustomerOdDetailService.Delete(order_Details);
        }

        public ViewCustomerOrderDetail GetCtOdDetail(string Code)
        {
            return _lstView.Where(x => x.Customer_Order_Details.CO_Code == Code).FirstOrDefault();
        }

        public List<ViewCustomerOrderDetail> Getlst_View()
        {
            return _lstView;
        }

        public string Save()
        {
            return _iCustomerOdDetailService.Save();
        }

        public string Update(Customer_Order_Details order_Details)
        {
            return _iCustomerOdDetailService.Update(order_Details);
        }
    }
}
