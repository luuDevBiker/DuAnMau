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

namespace _3_GUI_Layer
{
    public partial class FrmLogin : Form
    {
        private ILoginService _iLogingservice = new _2_BUS_Layer.BUSServices.LoginService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void llbQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmBackPass frmBackPass = new FrmBackPass();
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
            if (_iLogingservice.SenderTrangThaiMatKhau() == false)
            {
                MessageBox.Show("Hãy đổi mật khẩu để sử dụng");
                FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
                frmDoiMatKhau.Show();
                this.Close();
                return;
            }
            if (result == true)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.changeStatus(result, _iLogingservice.SenderMaNV());
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập lại .");
            }

        }
    }
}
