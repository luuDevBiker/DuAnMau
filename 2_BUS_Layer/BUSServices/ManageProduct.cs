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
    public class ManageProduct// : IManageProduct
    {
        //private IProductServices _iProductServices = new ProductService();
        //private IEmployeeService _iEmployeeService = new EmployeeService();
        //private List<Employee> _lstEps = new List<Employee>();
        //private List<Products> _lstPrds = new List<Products>();
        //private List<ViewProduct> _lstViewPrds = new List<ViewProduct>();
        //private List<ViewProduct> _lstNewViewPrds = new List<ViewProduct>();

        //public Products resultProduct(ViewProduct View_Prd)
        //{
        //    var Prd = new Products();
        //    Prd.Prd_Id = View_Prd.Prd_Id;
        //    Prd.Prd_Code = View_Prd.Prd_Code;
        //    Prd.Ep_Code = View_Prd.Prd_EpCode;
        //    Prd.Prd_Name = View_Prd.Prd_Name;
        //    Prd.Prd_Quantity = View_Prd.Prd_Quanlity;
        //    Prd.Prd_ImportPrice = View_Prd.Prd_ImpPrice;
        //    Prd.Prd_ExportPrice = View_Prd.Prd_ExpPrice;
        //    Prd.Prd_Image = View_Prd.Prd_Img;
        //    Prd.Prd_Note = View_Prd.Prd_Note;
        //    return Prd;
        //}
        //public string Add(ViewProduct Prd)
        //{
        //    try
        //    {
        //        _lstViewPrds.Add(Prd);
        //        _lstNewViewPrds.Add(Prd);
        //        return "Successful";
        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        //public string Add()
        //{
        //    try
        //    {
        //        _lstNewViewPrds.ForEach(x =>
        //        {
        //            _iProductServices.Add(resultProduct(x));
        //        });
        //        _lstNewViewPrds.Clear();
        //        return "Successful";
        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        //public string Delete(ViewProduct Prd)
        //{
        //    try
        //    {
        //        // update to list temporary
        //        var index_new = _lstNewViewPrds.FindIndex(x => x.Prd_Code == Prd.Prd_Code);
        //        _lstNewViewPrds.RemoveAt(index_new);
        //        // update to list main
        //        var index = _lstViewPrds.FindIndex(x => x.Prd_Code == Prd.Prd_Code);
        //        _lstViewPrds.RemoveAt(index);
        //        // update to database
        //        var product = _lstPrds.Where(x => x.Ep_Code == Prd.Prd_Code).FirstOrDefault();
        //        return _iProductServices.Delete(product);
        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        //public List<ViewProduct> GetlstView_Prd()
        //{
        //    return _lstViewPrds;
        //}

        //public int GetMaxID()
        //{
        //    if (_lstViewPrds.Max(x => x.Prd_Id) < 0) return 1000;
        //    return _lstViewPrds.Max(x => x.Prd_Id);
        //}

        //public void LoadlstView_Prd()
        //{
        //    _lstEps = _iEmployeeService.Getlst();
        //    _iProductServices.Getlst().ForEach(x =>
        //    {
        //        var view = new ViewProduct();
        //        view.Prd_Id = x.Prd_Id;
        //        view.Prd_Code = x.Prd_Code;
        //        view.Prd_EpCode = x.Ep_Code;
        //        view.Prd_EpName = _lstEps.Where(x => x.Ep_Code == view.Prd_EpCode).Select(x => x.Ep_Name).FirstOrDefault();
        //        view.Prd_Name = x.Prd_Name;
        //        view.Prd_Quanlity = x.Prd_Quantity;
        //        view.Prd_ImpPrice = x.Prd_ImportPrice;
        //        view.Prd_ExpPrice = x.Prd_ExportPrice;
        //        view.Prd_Img = x.Prd_Image;
        //        view.Prd_Note = x.Prd_Note;
        //        _lstViewPrds.Add(view);
        //    });
        //}

        //public string Update(ViewProduct Prd)
        //{
        //    try
        //    {
        //        // update to list temporary
        //        var index_new = _lstNewViewPrds.FindIndex(x => x.Prd_Code == Prd.Prd_Code);
        //        _lstNewViewPrds[index_new] = Prd;
        //        // update to list main
        //        var index = _lstViewPrds.FindIndex(x => x.Prd_Code == Prd.Prd_Code);
        //        _lstViewPrds[index] = Prd;
        //        // update to database
        //        var product = _lstPrds.Where(x => x.Ep_Code == Prd.Prd_Code).FirstOrDefault();
        //        product.Prd_Name = Prd.Prd_Name;
        //        product.Prd_Quantity = Prd.Prd_Quanlity;
        //        product.Prd_ImportPrice = Prd.Prd_ImpPrice;
        //        product.Prd_ExportPrice = Prd.Prd_ExpPrice;
        //        product.Prd_Image = Prd.Prd_Img;
        //        product.Prd_Note = Prd.Prd_Note;
        //        return _iProductServices.Update(product);
        //    }
        //    catch (Exception e)
        //    {
        //        return e.Message;
        //    }
        //}
        //public bool CheckNamePrd(string NamePrd)
        //{
        //    if (_lstPrds.Where(x => x.Prd_Name == NamePrd).FirstOrDefault() != null) return true;
        //    return false;
        //}
        //public string Save()
        //{
        //    return _iProductServices.Save();
        //}
        //public ViewProduct SelectViewProduct(string ViewPrd_Code)
        //{
        //    return _lstViewPrds.Where(x => x.Prd_Code == ViewPrd_Code).FirstOrDefault();
        //}
    }
}
