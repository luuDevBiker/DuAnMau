using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_Layer.DataBaseContext;
using _1_DAL_Layer.DALService;
using _1_DAL_Layer.IDALService;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.BUSServices;
using _1_DAL_Layer.Entitys;
using System.Security.Cryptography;

namespace _3_GUI_Layer
{
    public partial class Form1 : Form
    {
        private ILoginService _iLoginServices = new LoginService();
        private IAccountServices _iAccountServices = new AccountServices();
        private DBcontext context = new DBcontext(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var mail = "luubiker@gmail.com";
                var password = "123abc";
                var nhanVien = _iAccountServices.getNhanVien(mail, _iLoginServices.MaHoaPass(password));
                MessageBox.Show(nhanVien.Email);
                bool result = nhanVien.MatKhau == _iLoginServices.MaHoaPass(password) ? true : false;
                MessageBox.Show(result + "");
            }
            catch
            {
                MessageBox.Show("");
            }
        }
    }
}
