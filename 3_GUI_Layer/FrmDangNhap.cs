using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Utility;

namespace _3_GUI_Layer
{
    public partial class FrmLogin : Form
    {
        private ILoginService _iLogingservice = new _2_BUS_Layer.BUSServices.LoginService();

        public delegate void sendData(bool StatusLogin, string MaNhanVien, int VaiTroNhanVien);
        public event sendData SetStatus;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void llbQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmBackPass frmBackPass = new FrmBackPass();
                frmBackPass.MdiParent = this.MdiParent;
                frmBackPass.Show();
                this.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var mail = txtTK.Text;
            var password = txtMk.Text;
            var result = _iLogingservice.CheckLogin(mail, password);
            if (result == true)
            {
                if (_iLogingservice.SenderNhanVien(mail).TrangThaiMatKhau == false)
                {
                    MessageBox.Show("Hãy đổi mật khẩu để sử dụng");
                    FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
                    frmDoiMatKhau.MdiParent = this.MdiParent;
                    frmDoiMatKhau.Show();
                    this.Close();
                    return;
                }
                else
                {
                    this.SetStatus(true, _iLogingservice.SenderNhanVien(mail).Ma_NhanVien, _iLogingservice.SenderNhanVien(mail).VaiTro);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập lại .");
            }

        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtMk.PasswordChar = '\0';
            }
            else
            {
                txtMk.PasswordChar = 'x';
            }
        }
    }
}
