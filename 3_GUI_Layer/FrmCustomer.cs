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
        private IManageCustomer _iManageCustomer ;
        private string _Ep_Code = "NV1001";
        public FrmCustomer()
        {
            InitializeComponent();
            _iManageCustomer = new ManageCustomer();
            LoadData(_iManageCustomer.GetlstView_Ct());
        }
        private void LoadData(List<ViewCustomer> lstView)
        {
            dgvCustomer.ColumnCount = 5;
            dgvCustomer.Columns[0].Name = "Họ tên khách hàng";
            dgvCustomer.Columns[1].Name = "Giới tính";
            dgvCustomer.Columns[2].Name = "Số điện thoại";
            dgvCustomer.Columns[3].Name = "Địa chỉ";
            dgvCustomer.Columns[4].Name = "Người thêm";
            dgvCustomer.Rows.Clear();
            lstView.ForEach(x =>
            {
                var ct = x.Customer;
                var ep = x.Employee;
                dgvCustomer.Rows.Add(
                    ct.Ct_Name,
                    ct.Ct_Sex == 0 ? "Nam" : "Nữ",
                    ct.Ct_PhoneNumber,
                    ct.Ct_Address,
                    ep.Ep_Name);
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
            view.Status = true;
            return view;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

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

        }
    }
}
