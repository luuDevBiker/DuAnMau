using _1_DAL_Layer.DALServices;
using _1_DAL_Layer.Entities;
using _1_DAL_Layer.IDALServices;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.BUSServices
{
    public class ManageCtOrder : IManageCtOrder
    {
        private ICustomerOrderService _iCustomerOrder;
        private ICustomerService _iCustomer;
        private List<ViewCustomerOrder> _viewCustomerOrders;
        public ManageCtOrder()
        {
            _iCustomerOrder = new CustomerOrderService();
            _iCustomer = new CustomerService();
            _viewCustomerOrders = new List<ViewCustomerOrder>();
            loadData();
        }
        public Customer_Order Add(string Phone, int Pay)
        {
            var CtOd = new Customer_Order();
            CtOd.Date = DateTime.Now;
            CtOd.Id = GetMaxId() + 1;
            CtOd.Total_Money = Pay;
            CtOd.CO_Code = "HD" + CtOd.Id;
            CtOd.Ep_Code = "NV1001";
            CtOd.Ct_Code = Phone;
            _iCustomerOrder.Add(CtOd);
            _iCustomerOrder.Save();
            return CtOd;
        }

        public ViewCustomerOrder GetCtOrder(string Code)
        {
            return _viewCustomerOrders.Where(x => x.Customer_Order.CO_Code == Code).FirstOrDefault();
        }

        public List<ViewCustomerOrder> Getlst_View()
        {
            return _viewCustomerOrders;
        }

        public int GetMaxId()
        {
            return _viewCustomerOrders.Max(x => x.Customer_Order.Id);
        }

        public string Update(Customer_Order customerOrder)
        {
            throw new NotImplementedException();
        }
        // method run only one when class created new
        private void loadData()
        {
            var lstCt = _iCustomer.Getlst();
            var lstCtOrder = _iCustomerOrder.Getlst();
            var lstView = from ct in lstCt
                          join ctOd in lstCtOrder
                          on ct.Ep_Code equals ctOd.Ep_Code
                          select new
                          {
                              Customer = ct,
                              CustomerOrder = ctOd,
                              Status = false
                          };
            lstView.ToList().ForEach(x =>
            {
                var item = new ViewCustomerOrder(x.Customer, x.CustomerOrder, x.Status);
                _viewCustomerOrders.Add(item);
            });
        }




    }
}
