using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;
using _1_DAL_Layer.IDALServices;
using _1_DAL_Layer.DataBaseContext;


namespace _1_DAL_Layer.DALServices
{
    public class ProductService : IProductServices
    {
        private DBcontext _DBcontext = new DBcontext();
        public string Add(Products Products)
        {
            try
            {
                _DBcontext.Products.Add(Products);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Update(Products Products)
        {
            try
            {
                _DBcontext.Products.Update(Products);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
        public string Delete(Products Products)
        {
            try
            {
                _DBcontext.Products.Remove(Products);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Save()
        {
            try
            {
                _DBcontext.SaveChanges();
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Products> Getlst()
        {
            try
            {
                return _DBcontext.Products.ToList();  
            }
            catch
            {
                return null;
            }

        }
    }
}
