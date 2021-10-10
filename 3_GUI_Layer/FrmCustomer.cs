using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.BUSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2_BUS_Layer.Models;

namespace _3_GUI_Layer
{
    public partial class FrmCustomer : Form
    {
        private IManageCustomer _iManageCustomer;
        private string _Ep_Code;
        private string _Ct_Phone_Click;
        public FrmCustomer()
        {
            InitializeComponent();
            _iManageCustomer = new ManageCustomer();
            LoadData(_iManageCustomer.GetlstView_Ct());
        }
        public void GetEpCode(string Ep_Code)
        {
            _Ep_Code = Ep_Code;
        }
        private void LoadData(List<ViewCustomer> lstView)
        {
            dgvCustomer.ColumnCount = 6;
            dgvCustomer.Columns[0].Name = "Họ tên khách hàng";
            dgvCustomer.Columns[1].Name = "Giới tính";
            dgvCustomer.Columns[2].Name = "Số điện thoại";
            dgvCustomer.Columns[3].Name = "Địa chỉ";
            dgvCustomer.Columns[4].Name = "Mã người thêm";
            dgvCustomer.Columns[4].Visible = true;
            dgvCustomer.Columns[5].Name = "Người thêm";
            dgvCustomer.Rows.Clear();
            lstView.ForEach(x =>
            {
                dgvCustomer.Rows.Add(
                    x.Customer.Ct_Name,
                    x.Customer.Ct_Sex == 0 ? "Nam" : "Nữ",
                    x.Customer.Ct_PhoneNumber,
                    x.Customer.Ct_Address,
                    x.Customer.Ep_Code,
                    x.Employee.Ep_Name);
            });
        }
        private ViewCustomer ViewAdd()
        {
            ViewCustomer view = new ViewCustomer();
            var ct = view.Customer;
            ct.Ct_PhoneNumber = txtPhoneNumber.Text;
            ct.Ct_Name = txtName.Text;
            ct.Ct_Address = txtAddress.Text;
            ct.Ct_Sex = rdMale.Checked == true ? 1 : 0;
            ct.Ep_Code = _Ep_Code;
            view.Employee = _iManageCustomer.GetEmployee(_Ep_Code);
            view.Status = true;
            return view;
        }
        private bool CheckForm()
        {
            bool checktextbox(TextBox txt)
            {
                if (txt.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                    txt.Focus();
                    return false;
                }
                return true;
            }
            if (
            checktextbox(txtAddress) &&
                checktextbox(txtPhoneNumber) &&
                checktextbox(txtName))
                return true;
            return false;
        }
        private void ClearForm()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckForm() == false) return;
            _iManageCustomer.Add(ViewAdd());
            LoadData(_iManageCustomer.GetlstView_Ct());
            ClearForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var Pr = ViewAdd();
            Pr.Customer.Ct_PhoneNumber = _Ct_Phone_Click;
            _iManageCustomer.Delete(Pr);
            LoadData(_iManageCustomer.GetlstView_Ct());
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForm() == false) return;
            var view = _iManageCustomer.GetViewCustomer(_Ct_Phone_Click);
            var customer = view.Customer;
            customer.Ct_PhoneNumber = txtPhoneNumber.Text;
            customer.Ct_Name = txtName.Text;
            customer.Ct_Address = txtAddress.Text;
            customer.Ct_Sex = rdMale.Checked == true ? 0 : 1;
            _iManageCustomer.Update(view);
            LoadData(_iManageCustomer.GetlstView_Ct());
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iManageCustomer.Save());
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadData(_iManageCustomer.GetlstView_Ct());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm;
            if (_iManageCustomer.StatusData() == false)
            {
                confirm = MessageBox.Show("Dữ liệu chưa được lưu vào database \n bạn có muốn lưu trước khi thoát ?",
                    "Thông báo",
                    MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes) _iManageCustomer.Save();
            }
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var listView = _iManageCustomer.GetlstView_Ct()
                .FindAll(x => x.Customer.Ct_Name.StartsWith(txtFind.Text) || x.Customer.Ct_PhoneNumber.StartsWith(txtFind.Text));
            LoadData(listView); 
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0) return;
            var row = dgvCustomer.Rows[index].Cells;
            txtName.Text = row[0].Value + "";
            if(row[1].Value == "Nam")
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            txtPhoneNumber.Text = row[2].Value + "";
            _Ct_Phone_Click = row[2].Value + "";
            txtAddress.Text = row[3].Value + "";
        }
    }
}
