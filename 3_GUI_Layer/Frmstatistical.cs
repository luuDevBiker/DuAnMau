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
        public Frmstatistical()
        {
            InitializeComponent();
            _iManageProduct = new ManageProduct();
            _iManageCtOdDetail = new ManageCtOdDetail();
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
            var list = _iManageProduct.GetlstView_Prd().OrderByDescending(x => x.Products.Prd_Quantity).Take(1).ToList();
            LoadData(list);
        }

        private void TSMI_MinPrd_Click(object sender, EventArgs e)
        {
            var list = _iManageProduct.GetlstView_Prd().OrderBy(x => x.Products.Prd_Quantity).Take(1).ToList();
            LoadData(list);
        }
    }
}
