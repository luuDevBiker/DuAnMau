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
        private string _MaNhanVien = "NV1000";
        private string _MaHang;
        private Hang _Hang;
        private byte[] _arrImg;
        public FrmSanPham()
        {
            InitializeComponent();
        }
        #region Tiện ích form
        private void LoadData(List<Hang> lstHang)
        {
            dgvNhanVien.ColumnCount = 7;
            dgvNhanVien.Columns[0].Name = "Tên Sản Phẩm";
            dgvNhanVien.Columns[1].Name = "Số Lượng";
            dgvNhanVien.Columns[2].Name = "Giá Nhập";
            dgvNhanVien.Columns[3].Name = "Giá Bán";
            dgvNhanVien.Columns[4].Name = "Ghi Chú";
            dgvNhanVien.Columns[5].Name = "Mã sản Phẩm";
            dgvNhanVien.Columns[5].Visible = false;
            dgvNhanVien.Columns[6].Name = "Ảnh";
            dgvNhanVien.Columns[6].Visible = false;
            dgvNhanVien.Rows.Clear();
            foreach (var x in lstHang)
            {
                dgvNhanVien.Rows.Add(x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu, x.MaHang, x.AnhHang);
            }
        }
        private bool checkForm()
        {
            if (txtGiaBan.Text.Length == 0 || txtGiaNhap.Text.Length == 0 || txtSoLuong.Text.Length == 0 || txtTenHang.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
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
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                return Image.FromStream(ms, true);//Exception occurs here
            }
            catch 
            {
                throw;
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0) return;
            var row = dgvNhanVien.Rows[indexRow];
            txtTenHang.Text = row.Cells[0].Value + "";
            txtSoLuong.Text = row.Cells[1].Value + "";
            txtGiaNhap.Text = row.Cells[2].Value + "";
            txtGiaBan.Text = row.Cells[3].Value + "";
            rtbGhiChu.Text = row.Cells[4].Value + "";
            txtMaHang.Text = row.Cells[5].Value + "";
            pcbAnhHang.Image = byteArrayToImage( (byte[])row.Cells[6].Value);
            _MaHang = row.Cells[5].Value + "";
            _arrImg = (byte[])row.Cells[6].Value;
            // Enabled button
            btnThem.Enabled = false;
        }
        private void ClearForm()
        {
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            rtbGhiChu.Text = "";
            txtMaHang.Text = "";
            _MaHang = "";
            _arrImg = null;
            btnThem.Enabled = true;
        }

        #endregion
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkForm()) return;
            if (_IHangServices.checkHangExits(txtTenHang.Text))
            {
                MessageBox.Show("Tên Hàng đã tồn tại");
                return;
            }
            var sp = resultHang();
            MessageBox.Show(_IHangServices.AddSanPham(sp));
            LoadData(_IHangServices.SendlstSanPham());
            ClearForm();
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



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkForm()) return;
            var sprs = _IHangServices.SelectHang(_MaHang);
            sprs.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            sprs.DonGiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            sprs.DonGiaBan = Convert.ToInt32(txtGiaBan.Text);
            sprs.GhiChu = rtbGhiChu.Text;
            sprs.AnhHang = _arrImg;
            MessageBox.Show(_IHangServices.UpdateSanPham(sprs));
            LoadData(_IHangServices.SendlstSanPham());
            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IHangServices.DeleteSanPham(_MaHang));
            ClearForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var lstHang = _IHangServices.SendlstSanPham().Where(x => x.TenHang.StartsWith(txtTimKiem.Text) || x.MaHang.StartsWith(txtTimKiem.Text)).ToList();
            LoadData(lstHang);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            _IHangServices.GetlstSanPham();
            LoadData(_IHangServices.SendlstSanPham());
        }
    }
}
