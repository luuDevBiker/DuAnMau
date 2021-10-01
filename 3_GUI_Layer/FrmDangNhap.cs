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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var mail = txtTK.Text;
            var password = txtMk.Text;
            var result = _iLogingservice.CheckLogin(mail, password);
            if (result == true)
            {
                 
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập lại .");
            }
        }
    }
}
