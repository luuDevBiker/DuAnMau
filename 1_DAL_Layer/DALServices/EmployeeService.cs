using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entitys;
using _1_DAL_Layer;
namespace _1_DAL_Layer.DALServices
{
    public class EmployeeService : IDALServices.IEmployeeService
    {
        private _1_DAL_Layer.DataBaseContext.DBcontext _DBcontext = new DataBaseContext.DBcontext();
        public string Add(Employee Employee)
        {
            try
            {
                _DBcontext.Add(Employee);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Update(Employee Employee)
        {
            try
            {
                _DBcontext.NhanViens.Update(Employee);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Employee Employee)
        {
            try
            {
                _DBcontext.NhanViens.Remove(Employee);
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
        public List<Employee> Getlst()
        {
            return _DBcontext.NhanViens.ToList();
        }
    }
}
