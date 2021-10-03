using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _1_DAL_Layer.Entitys;
using _2_BUS_Layer;

namespace _3_GUI_Layer
{
    public partial class FrmDoiMatKhau : Form
    {
        private _2_BUS_Layer.IBUSServices.ILoginService _iloginService;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
            _iloginService = new _2_BUS_Layer.BUSServices.LoginService();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var mail = txtMail.Text;
            var pass = txtPass.Text;
            var passnew = txtPassNew.Text;
            var passnew2 = txtPassNew2.Text;
            NhanVien nhanvien = new NhanVien();
            nhanvien = _iloginService.SenderNhanVien(mail);
            if(nhanvien == null)
            {
                MessageBox.Show("Tài khoản không tồn tại !");
                txtMail.Focus();
                return;
            }
            if(passnew != passnew2)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txtPassNew.Focus();
                return;
            }
            if(txtMail.Text.Length == 0 && txtPass.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            var checklogin = _iloginService.CheckLogin(mail, pass);
            if(checklogin == false)
            {
                MessageBox.Show("Tài khoản mật khẩu cũ không đúng ");
                txtMail.Focus();
                return;
            }
            nhanvien.MatKhau = passnew2;
            nhanvien.TrangThaiMatKhau = true;
            MessageBox.Show(_iloginService.DoiMatKhau(nhanvien));
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
