using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_Layer
{
    public partial class Frmstatistical : Form
    {

        private IManageProduct _iManageProduct;
        private IManageCtOdDetail _iManageCtOdDetail;
        private List<ViewProduct> _lstView = new List<ViewProduct>();
        public Frmstatistical()
        {
            InitializeComponent();
            _iManageProduct = new ManageProduct();
            _iManageCtOdDetail = new ManageCtOdDetail();
            loadLstView();
        }
        private void LoadData(List<ViewProduct> lstView)
        {
            dgv_Statistical.ColumnCount = 3;
            dgv_Statistical.Columns[0].Name = "Tên sản phẳm";
            dgv_Statistical.Columns[1].Name = "Người nhập";
            dgv_Statistical.Columns[2].Name = "Số Lượng";

            dgv_Statistical.Rows.Clear();

            lstView.ForEach(x =>
            {
                dgv_Statistical.Rows.Add(x.Products.Prd_Name, x.Employee.Ep_Name, x.Products.Prd_Quantity);
            });

        }

        private void TSMI_AllProduct_Click(object sender, EventArgs e)
        {
            var listProduct = _iManageProduct.GetlstView_Prd();
            LoadData(listProduct);
        }

        private void TSMI_MaxPrd_Click(object sender, EventArgs e)
        {
            var list = _iManageProduct.GetlstView_Prd();
            var min = list.Max(z => z.Products.Prd_Quantity);
            LoadData(list.Where(z => z.Products.Prd_Quantity == min).ToList());
        }

        private void TSMI_MinPrd_Click(object sender, EventArgs e)
        {
            var list = _iManageProduct.GetlstView_Prd();
            var min = list.Min(z => z.Products.Prd_Quantity);
            LoadData(list.Where(z=>z.Products.Prd_Quantity == min).ToList());
        }
        private void loadLstView()
        {
            var lstPr = new ManageProduct().GetlstView_Prd();
            lstPr.ForEach(z =>
            {
                ViewProduct view = new ViewProduct();
                view.Products = z.Products;
                view.Products.Prd_Quantity = _iManageCtOdDetail.Getlst_View().OrderBy(x => x.Customer_Order_Details.Prd_Code).Where(x => x.Customer_Order_Details.Prd_Code == z.Products.Prd_Code).Sum(x => x.Customer_Order_Details.Quantity);
                _lstView.Add(view);
            });
        }
        private void TSMI_PrdSellMin_Click(object sender, EventArgs e)
        {
            var a = _lstView.Min(x => x.Products.Prd_Quantity);
            LoadData(_lstView.Where(x => x.Products.Prd_Quantity == a).ToList());
            dgv_Statistical.Columns[1].Visible = true;
        }

        private void TSMI_PrSellMax_Click(object sender, EventArgs e)
        {
            var a = _lstView.Max(x => x.Products.Prd_Quantity);
            LoadData(_lstView.Where(x => x.Products.Prd_Quantity == a).ToList());
            dgv_Statistical.Columns[1].Visible = true;
        }
    }
}
