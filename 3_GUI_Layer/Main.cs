using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace _3_GUI_Layer
{
    public partial class FrmMain : Form
    {
        bool _status_form_show = false;
        bool _status_login = false;
        string _Ma_NhanVien;
        public FrmMain()
        {
            InitializeComponent();
        }
        public void changeStatus(bool status_login, string Ma_NhanVien)
        {
            _status_login = status_login;
            _Ma_NhanVien = Ma_NhanVien;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _status_login = false;
            _Ma_NhanVien = "";
            MessageBox.Show("Bạn đã đăng xuất ");
        }

        private void TPSM_DangNhap_Click(object sender, EventArgs e)
        {
            if (_status_login == true) return;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TPSM_SanPham_Click(object sender, EventArgs e)
        {
            try
            {
                if (_status_form_show == true) return;
                _status_form_show = true;
                FrmSanPham frmSanPham = new FrmSanPham();
                frmSanPham.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TPSM_NhanVien_Click(object sender, EventArgs e)
        {
            if (_status_form_show == true) return;
            _status_form_show = true;
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.Show();
        }
    }
}
