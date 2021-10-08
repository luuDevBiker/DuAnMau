using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using _1_DAL_Layer.IDALServices;
using _1_DAL_Layer.DALServices;
using _1_DAL_Layer.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.BUSServices
{
    public class ManageProduct : IManageProduct
    {
        private IProductServices _iProductServices = new ProductService();
        private IEmployeeService _iEmployeeService = new EmployeeService();
        private List<Employee> _lstEps = new List<Employee>();
        private List<Products> _lstPrds = new List<Products>();
        private List<ViewProduct> _lstViewPrds = new List<ViewProduct>();


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
                    if(x.Status)_iProductServices.Add(x.Products);
                });
                _lstViewPrds.Clear();
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
                _lstViewPrds.Remove(Prd);
                return _iProductServices.Delete(Prd.Products);
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public List<ViewProduct> GetlstView_Prd()
        {
            return _lstViewPrds;
        }

        public int GetMaxID()
        {
            if (_lstViewPrds.Max(x => x.Products.Prd_Id) < 0) return 1000;
            return _lstViewPrds.Max(x => x.Products.Prd_Id);
        }

        public void LoadlstView_Prd()
        {
            _lstEps = _iEmployeeService.Getlst();
            _lstPrds = _iProductServices.Getlst();
            
        }

        public string Update(ViewProduct Prd)
        {
            try
            {
                var index = _lstViewPrds.FindIndex(x => x.Products.Ep_Code == Prd.Products.Ep_Code);
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
            return _iProductServices.Save();
        }
        public ViewProduct SelectViewProduct(string ViewPrd_Code)
        {
            return _lstViewPrds.Where(x => x.Products.Prd_Code == ViewPrd_Code).FirstOrDefault();
        }
    }
}
