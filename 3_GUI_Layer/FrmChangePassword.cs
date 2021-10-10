using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2_BUS_Layer;
using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using _2_BUS_Layer.Utility;

namespace _3_GUI_Layer
{
    public partial class FrmChangePassword : Form
    {
        private IManageEmployee _iManageEmployee ;
        private Utility _Utility = new Utility();
        private ViewEmployee _ViewEp;
        private string _PassRandom;
        private bool _Status; // status to changes password is viewemployee from 
        public FrmChangePassword()
        {
            InitializeComponent();
            _ViewEp = new ViewEmployee();
            _iManageEmployee = new ManageEmployee();
            _Status = true;

        }
        public void getInforView(string PassRandom,ViewEmployee View)
        {
            _PassRandom = PassRandom;
            txtPass.Text = PassRandom;
            txtPass.Enabled = true;
            txtMail.Text = View.Employee.Ep_Email;
            txtMail.Enabled = false;
            _ViewEp = View;
            _Status = false;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var mail = txtMail.Text;
            var pass = txtPass.Text;
            var passnew = txtPassNew.Text;
            var passnew2 = txtPassNew2.Text;

            if (_Status)
            {
                _ViewEp = _iManageEmployee.SelectViewEp(mail);
                if (_ViewEp == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại !");
                    txtMail.Focus();
                    return;
                }
                if (_ViewEp.Employee.Ep_Password != _Utility.EncodePass(pass))
                {
                    MessageBox.Show("mật khẩu không đúng");
                    txtPass.Focus();
                    return;
                }
            }

            if (passnew != passnew2)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txtPassNew.Focus();
                return;
            }
            if (txtMail.Text.Length == 0 && txtPass.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            _ViewEp.Employee.Ep_Password = _Utility.EncodePass(passnew2);
            _ViewEp.Employee.Ep_StatusPassword = true;
            _iManageEmployee.Update(_ViewEp);
            _iManageEmployee.Save();
            MessageBox.Show("Đổi mật khẩu thành công . đăng nhập để sử dụng.");
            this.Close();
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtPass.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
                txtPassNew2.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = 'x';
                txtPassNew.PasswordChar = 'x';
                txtPassNew2.PasswordChar = 'x';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
