using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_Layer
{
    public partial class FrmSellProduct : Form
    {
        private IManageCtOdDetail _iManageCtOdDetail;
        private IManageCtOrder _iManageCtOrder;
        private IManageProduct _iManageProduct;
        private IManageCustomer _iManageCustomer;
        private List<ViewProduct> _lstPrdBuy;
        private List<ViewProduct> _lstPrd;
        private int _indexRow;
        private string _Ep_Code;
        public FrmSellProduct()
        {
            InitializeComponent();
            _iManageCtOdDetail = new ManageCtOdDetail();
            _iManageCtOrder = new ManageCtOrder();
            _iManageProduct = new ManageProduct();
            _iManageCustomer = new ManageCustomer();
            _lstPrdBuy = new List<ViewProduct>();
            _lstPrd = new List<ViewProduct>();
            _lstPrd = _iManageProduct.GetlstView_Prd();
            LoadDataProduct();
            LoadDataCtBuy(_lstPrdBuy);
        }
        public void getpCode(string ep_Code)
        {
            _Ep_Code = ep_Code;
        }
        private void LoadDataCtBuy(List<ViewProduct> lst)
        {
            var sumMonney = 0;
            var saleMonney = 0;
            dgvCtBuy.AutoGenerateColumns = false;
            dgvCtBuy.ColumnCount = 6;
            dgvCtBuy.Columns[0].Name = "Mã sp";
            dgvCtBuy.Columns[0].Visible = false;
            dgvCtBuy.Columns[1].Name = "Tên sản phẩm";
            dgvCtBuy.Columns[1].ReadOnly = true;
            dgvCtBuy.Columns[2].Name = "Giá bán";
            dgvCtBuy.Columns[2].ReadOnly = true;
            dgvCtBuy.Columns[3].Name = "Tổng tiền";
            dgvCtBuy.Columns[3].ReadOnly = true;
            dgvCtBuy.Columns[4].Name = "Khuyến mãi";
            dgvCtBuy.Columns[4].ReadOnly = true;
            dgvCtBuy.Columns[5].Name = "Thanh toán";
            dgvCtBuy.Columns[5].ReadOnly = true;
            DataGridViewButtonColumn BtnclRemove = new DataGridViewButtonColumn();
            dgvCtBuy.Columns.Add(BtnclRemove);
            BtnclRemove.HeaderText = "Bớt";
            BtnclRemove.Text = "-";
            BtnclRemove.Name = "btnRemove";
            BtnclRemove.UseColumnTextForButtonValue = true;
            DataGridViewTextBoxColumn tbclQuantity = new DataGridViewTextBoxColumn();
            dgvCtBuy.Columns.Add(tbclQuantity);
            tbclQuantity.HeaderText = "Số lượng";

            tbclQuantity.Name = "Quantity";
            DataGridViewButtonColumn BtnclPluss = new DataGridViewButtonColumn();
            dgvCtBuy.Columns.Add(BtnclPluss);
            BtnclPluss.HeaderText = "Thêm";
            BtnclPluss.Text = "+";
            BtnclPluss.Name = "btnRemove";
            BtnclPluss.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn BtnclMinus = new DataGridViewButtonColumn();
            dgvCtBuy.Columns.Add(BtnclMinus);
            BtnclMinus.HeaderText = "Xóa khỏi giỏ";
            BtnclMinus.Text = "Xóa";
            BtnclMinus.Name = "btnRemove";
            BtnclMinus.UseColumnTextForButtonValue = true;
            dgvCtBuy.Rows.Clear();
            lst.ForEach(x =>
            {
                var money = x.Products.Prd_Quantity * x.Products.Prd_ExportPrice;
                var sale = (money * x.Products.Prd_Sale / 100);
                var Pay = money - sale;
                sumMonney += Pay;
                saleMonney += sale;
                dgvCtBuy.Rows.Add(
                    x.Products.Prd_Code,
                    x.Products.Prd_Name,
                    x.Products.Prd_ExportPrice,
                    money,
                    x.Products.Prd_Sale + " %",
                    Pay, null,
                    x.Products.Prd_Quantity
                    );
            });
            txtPay.Text = sumMonney + "";
            txtSale.Text = saleMonney + "";
        }

        private void LoadDataProduct()
        {
            dgvLstPtd.ColumnCount = 5;
            dgvLstPtd.Columns[0].Name = "Tên sản phẩm";
            dgvLstPtd.Columns[1].Name = "Số lượng còn";
            dgvLstPtd.Columns[2].Name = "Giá bán";
            dgvLstPtd.Columns[3].Name = "Khuyến mãi";
            dgvLstPtd.Columns[4].Name = "Mã sp";
            dgvLstPtd.Columns[4].Name = "Mã sp";
            dgvLstPtd.Columns[4].Visible = false;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Name = "Img";
            dgvLstPtd.Columns.Add(imageCol);
            DataGridViewButtonColumn BtnclAdd = new DataGridViewButtonColumn();
            dgvLstPtd.Columns.Add(BtnclAdd);
            BtnclAdd.HeaderText = "Thêm vào giỏ";
            BtnclAdd.Text = "Thêm";
            BtnclAdd.Name = "btnAdd";
            BtnclAdd.UseColumnTextForButtonValue = true;
            dgvLstPtd.Rows.Clear();
            _lstPrd.ForEach(x =>
            {
                dgvLstPtd.Rows.Add(
                    x.Products.Prd_Name,
                    x.Products.Prd_Quantity,
                    x.Products.Prd_ExportPrice,
                    x.Products.Prd_Sale,
                    x.Products.Prd_Code,
                    byteArrayToImage(x.Products.Prd_Image)
                    );
            });
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
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_lstPrdBuy.Count == 0) return;
            var CtOd = _iManageCtOrder.Add(txtPhoneCt.Text, Convert.ToInt32(txtPay.Text));
            _lstPrdBuy.ForEach(x =>
            {
                var money = x.Products.Prd_Quantity * x.Products.Prd_ExportPrice;
                var sale = (money * x.Products.Prd_Sale / 100);
                var CtOdDt = new ViewCustomerOrderDetail();
                var item = CtOdDt.Customer_Order_Details;
                item.CO_Code = CtOd.CO_Code;
                item.ExportPrice = x.Products.Prd_ExportPrice;
                item.Quantity = x.Products.Prd_Quantity;
                item.Sale = x.Products.Prd_Sale;
                item.Prd_Code = x.Products.Prd_Code;
                item.Total = money - sale;
                _iManageCtOdDetail.Add(item);
                var prd = _iManageProduct.SelectViewProduct(x.Products.Prd_Code);
                prd.Products.Prd_Quantity -= x.Products.Prd_Quantity;
                _iManageProduct.Update(prd);
            });
            _iManageProduct.Save();
            MessageBox.Show(_iManageCtOdDetail.Save());
            _lstPrdBuy.Clear();
            _lstPrd = _iManageProduct.GetlstView_Prd();
            LoadDataProduct();
            LoadDataCtBuy(_lstPrdBuy);
            txtPay.Text = "0";
            txtPhoneCt.Text = "0";
            txtSale.Text = "0";
        }
        private void dgvCtBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _indexRow = e.RowIndex;
            var row = dgvCtBuy.Rows[_indexRow];
            var Code = row.Cells[0].Value.ToString();
            if (e.ColumnIndex == 8)
            {
                var i = _lstPrdBuy.FindIndex(x => x.Products.Prd_Code == Code);
                if (i >= 0)
                {
                    if (checkValueQuantity()) return;
                    _lstPrdBuy[i].Products.Prd_Quantity += 1;
                    LoadDataCtBuy(_lstPrdBuy);
                    return;
                }
            }
            if (e.ColumnIndex == 6)
            {
                var i = _lstPrdBuy.FindIndex(x => x.Products.Prd_Code == Code);
                if (i >= 0)
                {
                    if (_lstPrdBuy[i].Products.Prd_Quantity == 0)
                    {
                        _lstPrdBuy.RemoveAt(i);
                        return;
                    };
                    if (checkValueQuantity()) return;
                    _lstPrdBuy[i].Products.Prd_Quantity -= 1;
                    LoadDataCtBuy(_lstPrdBuy);
                    return;
                }
            }
            if (e.ColumnIndex == 9)
            {
                var i = _lstPrdBuy.FindIndex(x => x.Products.Prd_Code == Code);
                _lstPrdBuy.RemoveAt(i);
                LoadDataCtBuy(_lstPrdBuy);
            }
        }

        private void dgvLstPtd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var lst = _lstPrd;
            var ind = e.ColumnIndex;
            var row = dgvLstPtd.Rows[e.RowIndex];
            var Code = row.Cells[4].Value.ToString();
            if (ind == 5)
            {
                var i = _lstPrdBuy.FindIndex(x => x.Products.Prd_Code == Code);
                if (i >= 0)
                    return;
                var itempdt = _lstPrd.Where(x => x.Products.Prd_Code == Code).FirstOrDefault().Products;
                var item = new ViewProduct();
                item.Products.Prd_Code = itempdt.Prd_Code;
                item.Products.Prd_Quantity = 0;
                item.Products.Prd_Name = itempdt.Prd_Name;
                item.Products.Prd_ExportPrice = itempdt.Prd_ExportPrice;
                _lstPrdBuy.Add(item);
                LoadDataCtBuy(_lstPrdBuy);
            }
        }
        private void dgvCtBuy_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var row = dgvCtBuy.Rows[_indexRow];
                var Code = row.Cells[0].Value.ToString();
                var i = _lstPrdBuy.FindIndex(x => x.Products.Prd_Code == Code);
                var quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                var quantityprd = _lstPrd.Where(x => x.Products.Prd_Code == Code).Select(x => x.Products.Prd_Quantity).FirstOrDefault();
                if (quantity >= quantityprd)
                {
                    _lstPrdBuy[i].Products.Prd_Quantity = quantityprd-1;
                    MessageBox.Show("Quá số lượng trong kho");
                    return;
                }
                _lstPrdBuy[i].Products.Prd_Quantity = quantity;
            }
            catch
            {
            }
        }
        private bool checkValueQuantity()
        {
            var row = dgvCtBuy.Rows[_indexRow];
            var Code = row.Cells[0].Value.ToString();
            var i = _lstPrdBuy.FindIndex(x => x.Products.Prd_Code == Code);
            var quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
            var quantityprd = _lstPrd.Where(x => x.Products.Prd_Code == Code).Select(x => x.Products.Prd_Quantity).FirstOrDefault();
            if (quantity > quantityprd)
            {
                return true;
            }
            return false;
        }

        private void txtPhoneCt_Leave(object sender, EventArgs e)
        {
            var ct = _iManageCustomer.GetViewCustomer(txtPhoneCt.Text).Customer;
            if(ct == null)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                return;
            }
            txtNameCt.Text = ct.Ct_Name;
        }
    }
}
