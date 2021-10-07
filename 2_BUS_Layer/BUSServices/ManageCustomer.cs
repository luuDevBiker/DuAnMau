using _1_DAL_Layer.DALServices;
using _1_DAL_Layer.IDALServices;
using _1_DAL_Layer.Entitys;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_Layer.BUSServices
{
    public class ManageCustomer : IManageCustomer
    {
        private ICustomerService _iCustomerService;
        private IEmployeeService _iEmployeeService;
        private List<Employee> _lstEps;
        private List<Customer> _lstCts;
        private List<ViewCustomer> _lstViewCts;
        private bool _StatusDataSave;
        public ManageCustomer()
        {
            _iCustomerService = new CustomerService();
            _iEmployeeService = new EmployeeService();
            _lstEps = new List<Employee>();
            _lstCts = new List<Customer>();
            _lstViewCts = new List<ViewCustomer>();
            _StatusDataSave = true;
            LoadlstView_Ct();
        }
        public string Add(ViewCustomer View_Ct)
        {
            _lstViewCts.Add(View_Ct);
            _StatusDataSave = true;
            return "Done";
        }

        public string Delete(ViewCustomer View_Ct)
        {
            try
            {
                _lstViewCts.Remove(View_Ct);
                _StatusDataSave = true;
                return _iCustomerService.Update(View_Ct.Customer);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Update(ViewCustomer View_Ct)
        {
            var status = View_Ct.Status;
            if (status)
            {
                var index = _lstViewCts.FindIndex(x => x.Employee.Ep_Code == View_Ct.Employee.Ep_Code);
                _lstViewCts[index] = View_Ct;
                _StatusDataSave = true;
                return _iCustomerService.Delete(View_Ct.Customer);
            }
            _StatusDataSave = true;
            return _iCustomerService.Delete(View_Ct.Customer);
        }
        public string Save()
        {
            _lstViewCts.ForEach(x =>
            {
                if (x.Status)
                {
                    _iCustomerService.Add(x.Customer);
                }
            });
            _StatusDataSave = false;
            return _iCustomerService.Save();
        }
        public bool CheckNumberPhone(string NumberPhone)
        {
            var item = _lstViewCts.FindIndex(x => x.Customer.Ct_PhoneNumber == NumberPhone);
            if (item >= 0) return true;
            return false;
        }

        public void LoadlstView_Ct()
        {
            _lstCts = _iCustomerService.Getlst();
            _lstEps = _iEmployeeService.Getlst();
            ViewCustomer view = new ViewCustomer();
            var lst = (from ct in _lstCts
                       join ep in _lstEps
                       on ct.Ep_Code equals ep.Ep_Code
                       select new
                       {
                           Customer = ct,
                           Employee = ep,
                           Status = false
                       }).ToList();
            lst.ForEach(x =>
            {
                view.Employee = x.Employee;
                view.Customer = x.Customer;
                view.Status = x.Status;
                _lstViewCts.Add(view);
            });
        }

        public List<ViewCustomer> GetlstView_Ct()
        {
            return _lstViewCts;
        }

        public bool StatusData()
        {
            return _StatusDataSave;
        }
    }
}
