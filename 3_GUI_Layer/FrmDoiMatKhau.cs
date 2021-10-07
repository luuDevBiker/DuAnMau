//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using _2_BUS_Layer;
//using _2_BUS_Layer.BUSServices;
//using _2_BUS_Layer.IBUSServices;
//using _2_BUS_Layer.Models;

//namespace _3_GUI_Layer
//{
//    public partial class FrmDoiMatKhau : Form
//    {
//        private IManageLogin _iManageLogin;
//        public FrmDoiMatKhau()
//        {
//            InitializeComponent();
//            _iManageLogin = new ManageLogin();
//        }

//        private void btnDoiMatKhau_Click(object sender, EventArgs e)
//        {
//            var mail = txtMail.Text;
//            var pass = txtPass.Text;
//            var passnew = txtPassNew.Text;
//            var passnew2 = txtPassNew2.Text;
//            var Acc = _iManageLogin.GetAccount(mail);
//            if(Acc == null)
//            {
//                MessageBox.Show("Tài khoản không tồn tại !");
//                txtMail.Focus();
//                return;
//            }
//            if(passnew != passnew2)
//            {
//                MessageBox.Show("Mật khẩu không khớp");
//                txtPassNew.Focus();
//                return;
//            }
//            if(txtMail.Text.Length == 0 && txtPass.Text.Length == 0)
//            {
//                MessageBox.Show("Không được để trống thông tin");
//            }
//            var checklogin = _iManageLogin.CheckAccount(mail, pass);
//            if(checklogin == null)
//            {
//                MessageBox.Show("Tài khoản mật khẩu cũ không đúng ");
//                txtMail.Focus();
//                return;
//            }
//            Acc.Ep_Password = passnew2;
//            Acc.Ep_StatusPassword = true;
//            MessageBox.Show(_iManageLogin.Update(mail,passnew2,true));
//        }

//        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
//        {
//            if (cbHienMK.Checked == true)
//            {
//                txtPass.PasswordChar = '\0';
//                txtPassNew.PasswordChar = '\0';
//                txtPassNew2.PasswordChar = '\0';
//            }
//            else
//            {
//                txtPass.PasswordChar = 'x';
//                txtPassNew.PasswordChar = 'x';
//                txtPassNew2.PasswordChar = 'x';
//            }
//        }

//        private void btnThoat_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}
