using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.IBUSServices;
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
    public partial class FrmSellCustomer : Form
    {
        private IManageCtOdDetail _iManageCtOdDetail;
        public FrmSellCustomer()
        {
            InitializeComponent();
            _iManageCtOdDetail = new ManageCtOdDetail();
        }
    }
}
