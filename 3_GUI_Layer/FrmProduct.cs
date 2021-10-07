//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using _2_BUS_Layer.Models;
//using _2_BUS_Layer.BUSServices;
//using _2_BUS_Layer.IBUSServices;

//namespace _3_GUI_Layer
//{
//    public partial class FrmProduct : Form
//    {
//        private IManageProduct _iManageProduct = new ManageProduct();
//        private string _MaNhanVien = "NV1000";
//        private string _MaHang;
//        private ViewProduct _ViewPrd;
//        private byte[] _arrImg;
//        public FrmProduct()
//        {
//            InitializeComponent();
//        }
//        #region Tiện ích form
//        private void LoadData(List<ViewProduct> lstHang)
//        {
//            dgvProduct.ColumnCount = 8;
//            dgvProduct.Columns[0].Name = "Tên Sản Phẩm";
//            dgvProduct.Columns[1].Name = "Số Lượng";
//            dgvProduct.Columns[2].Name = "Giá Nhập";
//            dgvProduct.Columns[3].Name = "Giá Bán";
//            dgvProduct.Columns[4].Name = "Ghi Chú";
//            dgvProduct.Columns[5].Name = "Mã sản Phẩm";
//            dgvProduct.Columns[5].Visible = false;
//            dgvProduct.Columns[6].Name = "Người nhập";
//            dgvProduct.Columns[7].Name = "Ảnh";
//            dgvProduct.Columns[7].Visible = false;

//            dgvProduct.Rows.Clear();
//            foreach (var x in lstHang)
//            {
//                dgvProduct.Rows.Add(x.Prd_Name, x.Prd_Quanlity, x.Prd_ImpPrice, x.Prd_ExpPrice, x.Prd_Note, x.Prd_Code, x.Prd_EpName, x.Prd_Img);
//            }
//        }
//        private bool checkForm()
//        {
//            if (txtGiaBan.Text.Length == 0 || txtGiaNhap.Text.Length == 0 || txtSoLuong.Text.Length == 0 || txtTenHang.Text.Length == 0)
//            {
//                MessageBox.Show("Không được để trống thông tin");
//                return true;
//            }
//            return false;
//        }
//        public string GetPathImage()
//        {
//            string path = "";
//            OpenFileDialog dlg = new OpenFileDialog();
//            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
//            if (dlg.ShowDialog() == DialogResult.OK)
//            {

//                return path = dlg.FileName;
//            }
//            return path;
//        }
//        public byte[] CopyImageToByteArray(string pathIMG)
//        {
//            Image theImage = Image.FromFile(pathIMG);
//            using (MemoryStream memoryStream = new MemoryStream())
//            {
//                theImage.Save(memoryStream, ImageFormat.Png);
//                return memoryStream.ToArray();
//            }
//        }
//        private ViewProduct resultHang()
//        {
//            _ViewPrd = new ViewProduct();
//            _ViewPrd.Prd_Id = _iManageProduct.GetMaxID() + 1;
//            _ViewPrd.Prd_Code = "MH" + _ViewPrd.Prd_Id;
//            _ViewPrd.Prd_EpName = txtTenHang.Text;
//            _ViewPrd.Prd_Quanlity = Convert.ToInt32(txtSoLuong.Text);
//            _ViewPrd.Prd_ImpPrice = Convert.ToInt32(txtGiaNhap.Text);
//            _ViewPrd.Prd_ExpPrice = Convert.ToInt32(txtGiaBan.Text);
//            _ViewPrd.Prd_Img = _arrImg;
//            _ViewPrd.Prd_Note = rtbGhiChu.Text;
//            _ViewPrd.Prd_EpCode = _MaNhanVien;
//            return _ViewPrd;
//        }
//        public Image byteArrayToImage(byte[] byteArrayIn)
//        {
//            try
//            {
//                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
//                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
//                return Image.FromStream(ms, true);//Exception occurs here
//            }
//            catch
//            {
//                throw;
//            }
//        }
//        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int indexRow = e.RowIndex;
//            if (indexRow < 0) return;
//            var row = dgvProduct.Rows[indexRow];
//            txtTenHang.Text = row.Cells[0].Value + "";
//            txtSoLuong.Text = row.Cells[1].Value + "";
//            txtGiaNhap.Text = row.Cells[2].Value + "";
//            txtGiaBan.Text = row.Cells[3].Value + "";
//            rtbGhiChu.Text = row.Cells[4].Value + "";
//            txtMaHang.Text = row.Cells[5].Value + "";
//            pcbAnhHang.Image = byteArrayToImage((byte[])row.Cells[6].Value);
//            _MaHang = row.Cells[5].Value + "";
//            _arrImg = (byte[])row.Cells[6].Value;
//            // Enabled button
//            btnThem.Enabled = false;
//        }
//        private void ClearForm()
//        {
//            txtTenHang.Text = "";
//            txtSoLuong.Text = "";
//            txtGiaNhap.Text = "";
//            txtGiaBan.Text = "";
//            rtbGhiChu.Text = "";
//            txtMaHang.Text = "";
//            _MaHang = "";
//            _arrImg = null;
//            btnThem.Enabled = true;
//        }

//        #endregion
//        private void btnThem_Click(object sender, EventArgs e)
//        {
//            if (checkForm()) return;
//            if (_iManageProduct.CheckNamePrd(txtTenHang.Text))
//            {
//                MessageBox.Show("Tên Hàng đã tồn tại");
//                return;
//            }
//            var sp = resultHang();
//            MessageBox.Show(_iManageProduct.Add(sp));
//            LoadData(_iManageProduct.GetlstView_Prd());
//            ClearForm();
//        }

//        private void btnLuu_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show(_iManageProduct.Save());
//        }

//        private void btnOpenImg_Click(object sender, EventArgs e)
//        {
//            string path = GetPathImage();
//            _arrImg = CopyImageToByteArray(path);
//            pcbAnhHang.Image = Image.FromFile(path);
//        }



//        private void btnSua_Click(object sender, EventArgs e)
//        {
//            if (checkForm()) return;
//            var sprs = _iManageProduct.SelectViewProduct(_MaHang);
//            sprs.Prd_Quanlity = Convert.ToInt32(txtSoLuong.Text);
//            sprs.Prd_ImpPrice = Convert.ToInt32(txtGiaNhap.Text);
//            sprs.Prd_ExpPrice = Convert.ToInt32(txtGiaBan.Text);
//            sprs.Prd_Note = rtbGhiChu.Text;
//            sprs.Prd_Img = _arrImg;
//            MessageBox.Show(_iManageProduct.Update(sprs));
//            LoadData(_iManageProduct.GetlstView_Prd());
//            ClearForm();
//        }

//        private void btnXoa_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show(_iManageProduct.Delete(resultHang()));
//            ClearForm();
//        }

//        private void btnTimKiem_Click(object sender, EventArgs e)
//        {
//            var lstHang = _iManageProduct.GetlstView_Prd().Where(x => x.Prd_Name.StartsWith(txtTimKiem.Text) || x.Prd_Code.StartsWith(txtTimKiem.Text)).ToList();
//            LoadData(lstHang);
//        }

//        private void btnBoQua_Click(object sender, EventArgs e)
//        {
//            ClearForm();
//        }

//        private void btnDong_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void btnDanhSach_Click(object sender, EventArgs e)
//        {
//            LoadData(_iManageProduct.GetlstView_Prd());
//        }
//    }
//}
