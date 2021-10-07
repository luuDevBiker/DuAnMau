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
    public class ManageEmployee : IManageEmployee
    {
        private IEmployeeService _iEmployeeService;
        private Utility.Utility _Utility;
        private List<Employee> _lstEps = new List<Employee>();
        private List<ViewEmployee> _lstViewEps;
        private bool _StatusSaveData;
        private string _messSendMail = "Hãy đăng nhập để đổi mật khẩu.";
        public ManageEmployee()
        {
            _iEmployeeService = new EmployeeService();
            _Utility = new Utility.Utility();
            _lstEps = new List<Employee>();
            _lstViewEps = new List<ViewEmployee>();
            _StatusSaveData = true;
            LoadlstView_Ep();
        }

        #region Method Interface
        public string Add(ViewEmployee Ep)
        {
            try
            {
                _lstViewEps.Add(Ep);
                _StatusSaveData = false;
                return "Done";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool CheckMail(string Mail)
        {
            if (_lstViewEps.Where(x => x.Employee.Ep_Email == Mail).FirstOrDefault() != null) return true;
            return false;
        }

        public string Delete(ViewEmployee Ep)
        {
            var index = _lstViewEps.FindIndex(x => x.Employee.Ep_Id == Ep.Employee.Ep_Id);
            _lstViewEps.RemoveAt(index);
            _StatusSaveData = false;
            return _iEmployeeService.Delete(Ep.Employee);
        }

        public List<ViewEmployee> GetlstView_Ep()
        {
            return _lstViewEps;
        }

        public int GetMaxID()
        {
            if (_lstViewEps.Count == 0) return 1000;
            return _lstViewEps.Max(x => x.Employee.Ep_Id);
        }
        public void LoadlstView_Ep()
        {
            _lstEps = _iEmployeeService.Getlst();
            _lstEps.ForEach(x =>
             {
                 ViewEmployee viewEmployee = new ViewEmployee();
                 viewEmployee.Employee = x;
                 viewEmployee.Status = false;
                 _lstViewEps.Add(viewEmployee);
             });
        }

        public string Save()
        {
            _lstViewEps.ForEach(x =>
            {
                if (x.Status == true)
                {
                    var maill = x.Employee.Ep_Email;
                    var pass = x.Employee.Ep_Password;
                    x.Employee.Ep_Password = _Utility.EncodePass(pass);
                    _iEmployeeService.Add(x.Employee);
                    _Utility.SenderMail(maill, pass, _messSendMail);
                }
            });
            _StatusSaveData = true;
            return _iEmployeeService.Save();
        }

        public ViewEmployee SelectViewEp(string Ep_Code)
        {
            return _lstViewEps.Where(x => x.Employee.Ep_Code == Ep_Code).FirstOrDefault();
        }

        public bool StatusData()
        {
            return _StatusSaveData;
        }

        public string Update(ViewEmployee Ep)
        {
            if (Ep.Status == false)
            {
                var index = _lstViewEps.FindIndex(x => x.Employee.Ep_Id == Ep.Employee.Ep_Id);
                _lstViewEps[index].Employee = Ep.Employee;
            }
            _StatusSaveData = false;
            return _iEmployeeService.Update(Ep.Employee);
        }
        #endregion
    }
}
