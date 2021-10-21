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
        public string _Ep_Code;
        public bool _StatusLogin;
        private int _RoleEmployee;

        public FrmMain()
        {
            InitializeComponent();
            loadForm();
        }
        private void loadForm()
        {
            if(_RoleEmployee == 1)
            {
                TPSM_Employee.Visible = false ;
            }
            if(_StatusLogin == true)
            {
                TPSM_Login.Visible = false;
                TSMI_Logout.Visible = true;
            }
            else
            {
                TSMI_Logout.Visible = false;
                TPSM_Login.Visible = true;
            }
        }
        private void SetStatus(bool statusLogin, string Ep_Code, int Role_Ep)
        {
            _StatusLogin = statusLogin;
            _Ep_Code = Ep_Code;
            _RoleEmployee = Role_Ep;
            lblNameEp.Text = Ep_Code+"";
            TPSM_Login.Visible = true;
        }
        private bool checkForm(string nameForm)
        {
            bool formExits = false;
            if (this.MdiChildren.Length > 0) return true;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == Name) formExits = true;
                return formExits;
            }
            return formExits;
        }
        private void TPSM_Login_Click(object sender, EventArgs e)
        {
            if (checkForm("frmLogin") == true) return;
            if (_StatusLogin == true) return;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.SetStatus += SetStatus;
            frmLogin.loadForm += loadForm;
            frmLogin.Show();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TPSM_Product_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkForm("frmProduct") == true) return;
                if (_StatusLogin == false)
                {
                    MessageBox.Show("hãy đăng nhập để sử dụng");
                    return;
                }
                FrmProduct frmProduct = new FrmProduct();
                frmProduct.MdiParent = this;
                frmProduct.getEpCode(_Ep_Code);
                frmProduct.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TPSM_Employee_Click(object sender, EventArgs e)
        {
            if (checkForm("frmEmployee") == true) return;
            if (_StatusLogin == false)
            {
                MessageBox.Show("hãy đăng nhập để sử dụng");
                return;
            }
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.MdiParent = this;
            frmEmployee.GetEpCode(_Ep_Code);
            frmEmployee.Show();
        }

        private void TSMI_Logout_Click(object sender, EventArgs e)
        {
            _StatusLogin = false;
            _Ep_Code = "";
            TPSM_Login.Visible = true;
            TPSM_Employee.Visible = true;
            lblNameEp.Text = "";
            MessageBox.Show("Đã đăng xuất ");
            loadForm();
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_InforEp_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false)
            {
                MessageBox.Show("hãy đăng nhập để sử dụng");
                return;
            }

        }

        private void TPSM_Customer_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false)
            {
                MessageBox.Show("hãy đăng nhập để sử dụng");
                return;
            }
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.MdiParent = this;
            frmCustomer.GetEpCode(_Ep_Code);
            frmCustomer.Show();
        }

        private void TPSM_Statistical_Click(object sender, EventArgs e)
        {
            if (checkForm("frmstatistical") == true) return;
            if (_StatusLogin == false)
            {
                MessageBox.Show("hãy đăng nhập để sử dụng");
                return;
            }
            Frmstatistical frmstatistical = new Frmstatistical();
            frmstatistical.MdiParent = this;
            frmstatistical.Show();
        }

        private void TPSM_Instructions_Click(object sender, EventArgs e)
        {

        }

        private void TPSM_Introduce_Click(object sender, EventArgs e)
        {

        }

        private void TSML_SellPr_Click(object sender, EventArgs e)
        {
            if (checkForm("frmNhanVien") == true) return;
            if (_StatusLogin == false)
            {
                MessageBox.Show("hãy đăng nhập để sử dụng");
                return;
            }
            FrmSellProduct frmSellProduct = new FrmSellProduct();
            frmSellProduct.getpCode(_Ep_Code);
            frmSellProduct.MdiParent = this;
            frmSellProduct.Show();
        }
    }
}
