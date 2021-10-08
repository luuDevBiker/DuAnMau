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
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.BUSServices;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
namespace _3_GUI_Layer
{
    public partial class Form1 : Form
    {
        private IManageEmployee _iManageEmployee = new ManageEmployee();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            textBox2.Text = _iManageEmployee.GetMaxID()+"";
            textBox1.Text = _iManageEmployee.GetlstView_Ep().Count+"";
        }

        private void btntest2_Click(object sender, EventArgs e)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("abc");
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            textBox2.Text = sb+"";
        }
    }
}
