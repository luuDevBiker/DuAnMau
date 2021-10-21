using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using _1_DAL_Layer.IDALServices;
using _1_DAL_Layer.DALServices;
using _1_DAL_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.BUSServices
{
    public class ManageProduct : IManageProduct
    {
        private IProductService _iProductServices;
        private IEmployeeService _iEmployeeService;
        private List<Employee> _lstEps;
        private List<Products> _lstPrds;
        private List<ViewProduct> _lstViewPrds;

        public ManageProduct()
        {
            _iProductServices = new ProductService();
            _iEmployeeService = new EmployeeService();
            _lstEps = new List<Employee>();
            _lstPrds = new List<Products>();
            _lstViewPrds = new List<ViewProduct>();
            LoadlstView_Prd();
        }
        public string Add(ViewProduct Prd)
        {
            try
            {
                _lstViewPrds.Add(Prd);
                return "Successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Add()
        {
            try
            {
                _lstViewPrds.ForEach(x =>
                {
                    if (x.Status == true)
                    {
                        _iProductServices.Add(x.Products);
                        x.Status = false;
                    }
                });
                return "Successful";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string Delete(ViewProduct Prd)
        {
            try
            {
                var i = _lstViewPrds.FindIndex(x => x.Products.Prd_Code == Prd.Products.Prd_Code);
                _lstViewPrds.RemoveAt(i);
                return _iProductServices.Delete(Prd.Products);
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public List<ViewProduct> GetlstView_Prd()
        {
            var a = _lstViewPrds;
            return a;
        }

        public int GetMaxID()
        {
            if (_lstViewPrds.Count == 0) return 1000;
            return _lstViewPrds.Max(x => x.Products.Prd_Id);
        }

        public void LoadlstView_Prd()
        {
            _lstEps = _iEmployeeService.Getlst();
            _lstPrds = _iProductServices.Getlst();
            var listview = (from ep in _lstEps
                            join Pr in _lstPrds
                            on ep.Ep_Code equals Pr.Ep_Code
                            select new
                            {
                                Employee = ep,
                                Products = Pr,
                                Status = false
                            }).ToList();
            listview.ForEach(x =>
            {
                ViewProduct view = new ViewProduct();
                view.Employee = x.Employee;
                view.Products = x.Products;
                view.Status = x.Status;
                _lstViewPrds.Add(view);
            });
        }

        public string Update(ViewProduct Prd)
        {
            try
            {
                var index = _lstViewPrds.FindIndex(x => x.Products.Prd_Code == Prd.Products.Prd_Code);
                _lstViewPrds[index] = Prd;
                return _iProductServices.Update(Prd.Products);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public bool CheckNamePrd(string NamePrd)
        {
            if (_lstPrds.Where(x => x.Prd_Name == NamePrd).FirstOrDefault() != null) return true;
            return false;
        }
        public string Save()
        {
            Add();
            return _iProductServices.Save();
        }
        public ViewProduct SelectViewProduct(string ViewPrd_Code)
        {
            return _lstViewPrds.Where(x => x.Products.Prd_Code == ViewPrd_Code).FirstOrDefault();
        }

        public Employee GetEmployee(string Ep_code)
        {
            return _lstEps.Where(x => x.Ep_Code == Ep_code).FirstOrDefault();
        }
    }
}
