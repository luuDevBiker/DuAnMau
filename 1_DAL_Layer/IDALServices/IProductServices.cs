using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entities;



namespace _1_DAL_Layer.IDALServices
{
    public interface IProductServices
    {
        public string Add(Products Products);
        public string Update(Products Products);
        public string Delete(Products Products);
        public string Save();
        public List<Products> Getlst();
    }
}
