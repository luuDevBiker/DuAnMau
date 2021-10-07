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
        private DBcontext context = new DBcontext(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(textBox2.Text);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            textBox1.Text = sb.ToString();
        }

        private void btntest2_Click(object sender, EventArgs e)
        {
            var mail = "luubiker@gmail.com";
            using (WebClient webclient = new WebClient())
            {
                string url = "http://verify-email.org/";
                NameValueCollection formData = new NameValueCollection();
                formData["check"] = mail;
                MessageBox.Show(formData+"");
                byte[] responseBytes = webclient.UploadValues(url, "POST", formData);
                string response = Encoding.ASCII.GetString(responseBytes);
                if (response.Contains("Result: Ok"))
                {
                    MessageBox.Show("true");
                }
                MessageBox.Show("false");
            }

        }
    }
}
