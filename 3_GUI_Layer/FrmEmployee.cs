using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_Layer.Models;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.Utility;

namespace _3_GUI_Layer
{
    public partial class FrmEmployee : Form
    {
        private Utility _Utility = new Utility();
        private IManageEmployee _iManageEmployee;
        ViewEmployee _viewEp;
        private string _EpCode_Click;
        private string _Ep_Code_Login;
        public FrmEmployee()
        {
            InitializeComponent();
            _iManageEmployee = new ManageEmployee();
            
        }
        #region Form method
        public void GetEpCode(string Ep_Code)
        {
            _Ep_Code_Login = Ep_Code;
        }
        private void LoadData(List<ViewEmployee> lstView)
        {
            dgvEmployee.ColumnCount = 7;
            dgvEmployee.Columns[0].Name = "Mã nhân viên";
            dgvEmployee.Columns[1].Name = "Họ Và Tên";
            dgvEmployee.Columns[2].Name = "Email";
            dgvEmployee.Columns[3].Name = "Chức vụ";
            dgvEmployee.Columns[4].Name = "Trạng thái hoạt động";
            dgvEmployee.Columns[5].Name = "Địa Chỉ";
            dgvEmployee.Columns[6].Name = "Status";
            dgvEmployee.Columns[6].Visible = false;

            dgvEmployee.Rows.Clear();
            lstView.ForEach(x =>
            {
                var item = x.Employee;
                dgvEmployee.Rows.Add(
                    item.Ep_Code,
                    item.Ep_Name,
                    item.Ep_Email,
                    item.Ep_Role == 0 ? "Quản trị" : "Nhân viên",
                    item.Ep_Status == true ? "Hoạt động" : "Ngưng hoạt động",
                    item.Ep_Address
                    );
            });
        }
        private void ClearForm()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtMail.Text = "";
            rdAdmin.Checked = false;
            rdOn.Checked = false;
            rdEmployee.Checked = false;
            btnAdd.Enabled = true;
        }
        private bool CheckForm()
        {

            if (txtName.Text.Length == 0)
            {
                txtName.Focus();
                MessageBox.Show("không được để trống thông tin");
                return true;
            }
            if (txtMail.Text.Length == 0)
            {
                txtMail.Focus();
                MessageBox.Show("không được để trống thông tin");
                return true;
            }
            if (_iManageEmployee.CheckMail(txtMail.Text))
            {
                MessageBox.Show("Mail đã tồn tại .");
                txtMail.Focus();
                return true;
            }
            if (_Utility.CheckMailExits(txtMail.Text) == false)
            {
                txtMail.Focus();
                MessageBox.Show("Địa chỉ mail không tồn tại");
                return true;
            }
            if (txtAddress.Text.Length == 0)
            {
                txtAddress.Focus();
                MessageBox.Show("không được để trống thông tin");
                return true;
            }
            return false;
        }
        private ViewEmployee ViewEpUpdate(ViewEmployee viewEp)
        {
            var Ep = viewEp.Employee;
            Ep.Ep_Name = txtName.Text;

            Ep.Ep_Email = txtMail.Text.ToLower();
            Ep.Ep_Address = txtAddress.Text;
            Ep.Ep_Status = rdOn.Checked == true ? true : false;
            Ep.Ep_Role = rdAdmin.Checked == true ? 1 : 0;
            viewEp.Status = false;
            return viewEp;
        }
        private ViewEmployee ViewEpAdd()
        {
            _viewEp = new ViewEmployee();
            var Ep = _viewEp.Employee;
            Ep.Ep_Id = _iManageEmployee.GetMaxID()+1;
            Ep.Ep_Code = "NV" + Ep.Ep_Id;
            Ep.Ep_Password = _Utility.PassRandom(8);
            Ep.Ep_Name = txtName.Text;
            Ep.Ep_Email = txtMail.Text.ToLower();
            Ep.Ep_Address = txtAddress.Text;
            Ep.Ep_Status = rdOn.Checked == true ? true : false;
            Ep.Ep_Role = rdAdmin.Checked == true ? 1 : 0;
            Ep.Ep_StatusPassword = false;
            _viewEp.Status = true;
            return _viewEp;
        }
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckForm()) return;
            _iManageEmployee.Add(ViewEpAdd());
            LoadData(_iManageEmployee.GetlstView_Ep());
            ClearForm(); 
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            var Ep = _iManageEmployee.SelectViewEp(_EpCode_Click);
            MessageBox.Show(_iManageEmployee.Delete(Ep));
            LoadData(_iManageEmployee.GetlstView_Ep());
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForm()) return;
            var Ep = _iManageEmployee.SelectViewEp(_EpCode_Click);
            var EpUpdate = ViewEpUpdate(Ep);
            MessageBox.Show(_iManageEmployee.Update(EpUpdate));
            LoadData(_iManageEmployee.GetlstView_Ep());
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iManageEmployee.Save());
            _iManageEmployee.LoadlstView_Ep();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadData(_iManageEmployee.GetlstView_Ep());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm;
            if (_iManageEmployee.StatusData() == false)
            {
                confirm = MessageBox.Show("Dữ liệu chưa được lưu vào database \n bạn có muốn lưu trước khi thoát ?",
                    "Thông báo",
                    MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)_iManageEmployee.Save();
            }
            this.Close();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0) return;
            var row = dgvEmployee.Rows[index].Cells;
            _EpCode_Click = row[0].Value + "";
            txtName.Text = row[1].Value + "";
            txtMail.Text = row[2].Value + "";
            if (row[3].Value.ToString() == "Quản trị")
            {
                rdAdmin.Checked = true;
            }
            else
            {
                rdEmployee.Checked = true;
            }
            if (row[4].Value.ToString() == "Hoạt động")
            {
                rdOn.Checked = true;
            }
            else
            {
                rdOff.Checked = true;
            }
            txtAddress.Text = row[5].Value + "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var lstView = _iManageEmployee.GetlstView_Ep()
                .Where(x => x.Employee.Ep_Code.StartsWith(txtFind.Text) ||
                x.Employee.Ep_Email.StartsWith(txtFind.Text)).ToList();
            LoadData(lstView);
        }
    }
}
