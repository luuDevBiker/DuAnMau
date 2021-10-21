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
    public class ManageCtOdDetail : IManageCtOdDetail
    {
        private ICustomerOdDetailService _iCustomerOdDetailService;
        private ICustomerOrderService _iCustomerOrder;
        private IProductService _iProduct;
        private List<ViewCustomerOrderDetail> _lstView;
        public ManageCtOdDetail()
        {
            _iCustomerOdDetailService = new CustomerOdDetailService();
            _iCustomerOrder = new CustomerOrderService();
            _iProduct = new ProductService();
            _lstView = new List<ViewCustomerOrderDetail>();
            loadData();
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
        private void loadData()
        {
            var lstprd = _iProduct.Getlst();
            var lstdetail = _iCustomerOdDetailService.Getlst();
            var lstorder = _iCustomerOrder.Getlst();
            var list = lstprd
                            .Join(lstdetail,
                            p => p.Prd_Code,
                            ctoddt => ctoddt.Prd_Code,
                            (prd, ctoddt) => new { product = prd, ctoddetail = ctoddt })
                            .Join(lstorder,
                            pr_ctoddt => pr_ctoddt.ctoddetail.CO_Code,
                            ctod => ctod.CO_Code,
                            (pr_ctoddt, ctod) => new { prd_ctoddetail = pr_ctoddt, ctorder = ctod })
                            .Select(x => new
                            {
                                customerorder = x.ctorder,
                                customeroddetail = x.prd_ctoddetail.ctoddetail,
                                prduct = x.prd_ctoddetail.product
                            }).ToList();
            list.ForEach(x =>
            {
                ViewCustomerOrderDetail view = new ViewCustomerOrderDetail();
                view.Customer_Order = x.customerorder;
                view.Customer_Order_Details = x.customeroddetail;
                view.Products = x.prduct;
                _lstView.Add(view);
            });
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
