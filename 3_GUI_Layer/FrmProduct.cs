﻿using System;
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
using _2_BUS_Layer.Models;
using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.IBUSServices;
using System.Text.RegularExpressions;
using System.Collections;

namespace _3_GUI_Layer
{
    public partial class FrmProduct : Form
    {
        private IManageProduct _iManageProduct;
        private string _MaNhanVien;
        private string _Pr_Code;
        private int _Pr_Id;
        private byte[] _arrImg;
        public FrmProduct()
        {
            InitializeComponent();
            _iManageProduct = new ManageProduct();
        }
        #region Tiện ích form
        public void getEpCode(string Ep_code)
        {
            _MaNhanVien = Ep_code;
            MessageBox.Show(Ep_code + " " + _MaNhanVien);
        }
        private void LoadData(List<ViewProduct> lstHang)
        {
            dgvProduct.ColumnCount = 8;
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            
            dgvCmb.HeaderText = "Name";
            dgvCmb.Items.Add("Ghanashyam");
            dgvCmb.Items.Add("Jignesh");
            dgvCmb.Items.Add("Ishver");
            dgvCmb.Items.Add("Anand");
            dgvCmb.Name = "cmbName";
            dgvCmb.DropDownWidth = 
            dgvProduct.Columns.Add(dgvCmb);

            dgvProduct.Columns[0].Name = "Tên Sản Phẩm";
            dgvProduct.Columns[1].Name = "Số Lượng";
            dgvProduct.Columns[2].Name = "Giá Nhập";
            dgvProduct.Columns[3].Name = "Giá Bán";
            dgvProduct.Columns[4].Name = "Ghi Chú";
            dgvProduct.Columns[5].Name = "Mã sản Phẩm";
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[6].Name = "Người nhập";
            dgvProduct.Columns[7].Name = "Ảnh";
            dgvProduct.Columns[7].Visible = false;



            dgvProduct.Rows.Clear();
            foreach (var x in lstHang)
            {
                var item = x.Products;
                dgvProduct.Rows.Add(
                    item.Prd_Name,
                    item.Prd_Quantity,
                    item.Prd_ImportPrice,
                    item.Prd_ExportPrice,
                    item.Prd_Note,
                    item.Ep_Code,
                    x.Employee.Ep_Name,
                    item.Prd_Image);
            }
        }
        private bool checkForm()
        {
            return false;
        }
        public string GetPathImage()
        {
            string path = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.jfif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                return path = dlg.FileName;
            }
            return path;
        }
        public byte[] CopyImageToByteArray(string pathIMG)
        {
            try
            {
                Image theImage = Image.FromFile(pathIMG);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    theImage.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private ViewProduct View_Pr()
        {
            ViewProduct View = new ViewProduct();
            var product = View.Products;
            product.Prd_Id = _iManageProduct.GetMaxID() + 1;
            product.Prd_Code = "MH" + product.Prd_Id;
            product.Prd_Name = txtPrName.Text;
            product.Prd_Quantity = Convert.ToInt32(txtPrQuanlity.Text);
            product.Prd_ImportPrice = Convert.ToInt32(txtImportPrice.Text);
            product.Prd_ExportPrice = Convert.ToInt32(txtExportPeice.Text);
            product.Prd_Image = _arrImg;
            product.Img_Barcode = _arrImg;
            product.Prd_Note = rtbAddress.Text;
            product.Ep_Code = _MaNhanVien;
            View.Employee = _iManageProduct.GetEmployee(_MaNhanVien);
            View.Status = true;
            return View;
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
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            if (indexRow >= _iManageProduct.GetlstView_Prd().Count || indexRow < 0) return;
            var row = dgvProduct.Rows[indexRow];
            txtPrName.Text = row.Cells[0].Value + "";
            txtPrQuanlity.Text = row.Cells[1].Value + "";
            txtImportPrice.Text = row.Cells[2].Value + "";
            txtExportPeice.Text = row.Cells[3].Value + "";
            rtbAddress.Text = row.Cells[4].Value + "";
            txtPrCode.Text = row.Cells[5].Value + "";
            _Pr_Code = row.Cells[5].Value + "";
            pcbAnhHang.Image = byteArrayToImage((byte[])row.Cells[7].Value);

            // Enabled button
            btnAdd.Enabled = false;
        }
        private void ClearForm()
        {
            txtPrName.Text = "";
            txtPrQuanlity.Text = "";
            txtImportPrice.Text = "";
            txtExportPeice.Text = "";
            rtbAddress.Text = "";
            txtPrCode.Text = "";
            _Pr_Code = "";
            _arrImg = null;
            btnAdd.Enabled = true;
        }

        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkForm()) return;
            if (_iManageProduct.CheckNamePrd(txtPrName.Text))
            {
                MessageBox.Show("Tên Hàng đã tồn tại");
                return;
            }
            var sp = View_Pr();
            _iManageProduct.Add(sp);
            LoadData(_iManageProduct.GetlstView_Prd());
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iManageProduct.Save());
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            string path = GetPathImage();
            _arrImg = CopyImageToByteArray(path);
            pcbAnhHang.Image = Image.FromFile(path);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkForm()) return;
            var View_Pr_Update = View_Pr();
            View_Pr_Update.Products.Prd_Code = _Pr_Code;
            View_Pr_Update.Products.Prd_Id = _Pr_Id;
            _iManageProduct.Update(View_Pr_Update);
            LoadData(_iManageProduct.GetlstView_Prd());
            ClearForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var View_Pr_Delete = View_Pr();
            View_Pr_Delete.Products.Ep_Code = _Pr_Code;
            View_Pr_Delete.Products.Prd_Id = _Pr_Id;
            _iManageProduct.Delete(View_Pr_Delete);
            ClearForm();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var lstHang = _iManageProduct.GetlstView_Prd()
                .Where(x => x.Products.Prd_Name
                .StartsWith(txtFind.Text) || x.Products.Prd_Code.StartsWith(txtFind.Text)).ToList();
            LoadData(lstHang);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadData(_iManageProduct.GetlstView_Prd());
        }
    }
}