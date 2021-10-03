using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        private byte[] _arrImg;
        public FrmSanPham()
        {
            InitializeComponent();
            _IHangServices.GetlstSanPham();
        }
        private bool checkForm()
        {
            if(txtGiaBan.Text.Length == 0 || txtGiaNhap.Text.Length == 0 || txtSoLuong.Text.Length == 0 || txtTenHang.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
                return true;
            }
            if (_IHangServices.checkHangExits(txtTenHang.Text))
            {
                MessageBox.Show("Tên Hàng đã tồn tại");
                return true;
            }
            return false;
        }
        public string GetPathImage()
        {
            string path = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                return path = dlg.FileName;
            }
            return path;
        }
        public byte[] CopyImageToByteArray(string pathIMG)
        {
            Image theImage = Image.FromFile(pathIMG);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
        private Hang resultHang()
        {
            _Hang = new Hang();
            _Hang.ID_Hang = _IHangServices.getMaxIDHang() + 1;
            _Hang.MaHang = "MH" + _IHangServices.getMaxIDHang();
            _Hang.TenHang = txtTenHang.Text;
            _Hang.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            _Hang.DonGiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            _Hang.DonGiaBan = Convert.ToInt32(txtGiaBan.Text);
            _Hang.AnhHang = _arrImg;
            _Hang.GhiChu = rtbGhiChu.Text;
            _Hang.Ma_NhanVien = _MaNhanVien;
            return _Hang;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkForm()) return;
            var sp = resultHang();
            MessageBox.Show(_IHangServices.AddSanPham(sp));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IHangServices.SaveSanPham());
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            string path = GetPathImage();
            _arrImg = CopyImageToByteArray(path);
            pcbAnhHang.Image = Image.FromFile(path);
        }
    }
}
