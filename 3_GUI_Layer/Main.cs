using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Utility;

namespace _3_GUI_Layer
{
    public partial class FrmMain : Form
    {
        public string _MaNhanVien;
        public bool _StatusLogin;
        public FrmMain Self;
        public FrmMain()
        {
            InitializeComponent();
            Self = this;
        }
        private void SetStatus(bool statusLogin , string MaNhanVien)
        {
            _StatusLogin = statusLogin;
            _MaNhanVien = MaNhanVien;
        }
        private bool checkForm(string nameForm)
        {
            bool formExits = false;
            if (this.MdiChildren.Length > 0) return true;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == Name) formExits = true;
                return formExits;
            }
            return formExits;
        }
        private void TPSM_DangNhap_Click(object sender, EventArgs e)
        {
            if(checkForm("frmLogin")==true)return;
            if(_StatusLogin==true)return;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.SetStatus += SetStatus;
            frmLogin.Show();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TPSM_SanPham_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkForm("frmSanPham") == true) return;
                if (_StatusLogin == false) MessageBox.Show("hãy đăng nhập để sử dụng");
                FrmSanPham frmSanPham = new FrmSanPham();
                frmSanPham.MdiParent = this;
                frmSanPham.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TPSM_NhanVien_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false) MessageBox.Show("hãy đăng nhập để sử dụng");
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.Show();
        }

        private void TSMI_DangXuat_Click(object sender, EventArgs e)
        {
            _StatusLogin = false;
            _MaNhanVien = "";
            MessageBox.Show("Đã đăng xuất ");
        }

        private void TSMI_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_HoSoNV_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false) MessageBox.Show("hãy đăng nhập để sử dụng");
        }

        private void TPSM_KhachHang_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false) MessageBox.Show("hãy đăng nhập để sử dụng");
        }

        private void TPSM_ThongKe_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false) MessageBox.Show("hãy đăng nhập để sử dụng");
        }

        private void TPSM_HuóngDan_Click(object sender, EventArgs e)
        {

        }

        private void TPSM_GioiThieu_Click(object sender, EventArgs e)
        {

        }
    }
}
