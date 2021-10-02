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
            if(passnew != passnew2)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txtPassNew.Focus();
                return;
            }
            var checklogin = _iloginService.CheckLogin(mail, pass);
            if(checklogin == false)
            {
                MessageBox.Show("Tài khoản mật khẩu cũ không đúng ");
                txtMail.Focus();
                return;
            }
            var nhanvien = _iloginService.SenderNhanVien(mail);
            nhanvien.MatKhau = passnew2;
            nhanvien.TrangThaiMatKhau = true;
            MessageBox.Show(_iloginService.DoiMatKhau(nhanvien));
        }
    }
}
