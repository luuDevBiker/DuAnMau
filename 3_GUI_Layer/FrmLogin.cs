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
using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.Utility;

namespace _3_GUI_Layer
{
    public partial class FrmLogin : Form
    {
        private IManageEmployee _iManageEmployee = new ManageEmployee();

        public delegate void sendData(bool StatusLogin, string MaNhanVien, int VaiTroNhanVien);
        public delegate void loadForms();
        public event loadForms loadForm;
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
            var result = _iManageEmployee.SelectViewEp(mail);
            if (result != null)
            {
                if (result.Employee.Ep_Status == false)
                {
                    MessageBox.Show("Hãy đổi mật khẩu để sử dụng");
                    FrmChangePassword frmChangePassword = new FrmChangePassword();
                    frmChangePassword.MdiParent = this.MdiParent;
                    frmChangePassword.Show();
                    this.Close();
                    return;
                }
                else
                {
                    this.SetStatus(true, result.Employee.Ep_Code, result.Employee.Ep_Role);
                    this.loadForm();
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

        private void lblChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.Show();
            frmChangePassword.MdiParent = this.MdiParent;
            this.Close();
        }
    }
}
