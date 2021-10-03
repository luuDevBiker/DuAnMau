using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_Layer.Entitys;
using _2_BUS_Layer;

namespace _3_GUI_Layer
{
    public partial class FrmSanPham : Form
    {
        private _2_BUS_Layer.IBUSServices.IHangServices _IHangServices = new _2_BUS_Layer.BUSServices.HangServices(); 
        private string _MaNhanVien;
        private Hang _Hang;
        public FrmSanPham()
        {
            InitializeComponent();
            _IHangServices.GetlstSanPham();
        }
        private Hang resultHang()
        {
            _Hang = new Hang();
            _Hang.MaHang = txtMaHang.Text;
            _Hang.TenHang = txtTenHang.Text;
            _Hang.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            _Hang.DonGiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            _Hang.DonGiaBan = Convert.ToInt32(txtGiaBan.Text);
            _Hang.Ma_NhanVien = _MaNhanVien;
            _Hang.GhiChu = rtbGhiChu.Text;
            return _Hang;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
