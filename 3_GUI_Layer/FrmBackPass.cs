using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2_BUS_Layer.Utility;
using _2_BUS_Layer.BUSServices;
using _2_BUS_Layer.IBUSServices;
using _2_BUS_Layer.Models;

namespace _3_GUI_Layer
{
    public partial class FrmBackPass : Form
    {
        private IManageEmployee _iManageEmployee = new ManageEmployee();
        private Utility Utility = new Utility();
        int _TimeNow, _Time;
        string _passRandom;
        string _code;
        string _Mail;
        public FrmBackPass()
        {
            InitializeComponent();
        }

        private void btnsenMail_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnsenMail.Text == "Xác nhận code")
                {
                    _TimeNow = DateTime.Now.Minute;
                    if (txtMail.Text != _code)
                    {
                        MessageBox.Show("Mã code không khớp");
                        txtMail.Focus();
                        return;
                    }

                    if (_TimeNow - _Time > 1)
                    {
                        btnsenMail.Text = "Nhận Mật Khẩu Mới";
                        lblMail.Text = "Nhập Mail :";
                        MessageBox.Show("vui lòng nhận mã xác nhận khác !");
                    }

                    if (_TimeNow - _Time <= 1 && txtMail.Text == _code)
                    {
                        var view = _iManageEmployee.SelectViewEp(_Mail);
                        FrmChangePassword frmChangePassword = new FrmChangePassword();
                        frmChangePassword.getInforView(_passRandom, view);
                        frmChangePassword.Show();
                        this.Close();
                    }
                }

                if (btnsenMail.Text == "Nhận Mật Khẩu Mới")
                {
                    _Mail = txtMail.Text;
                    var status = _iManageEmployee.CheckMail(txtMail.Text);
                    if (status==false)
                    {
                        MessageBox.Show("Email không tồn tại trong hệ thống ");
                        return;
                    }
                    _Time = DateTime.Now.Minute;
                    _code = Utility.PassRandom(5);
                    _passRandom = Utility.PassRandom(8);
                    string mess = "Mã xác nhận của bạn là : " + _code + " mã xác nhận sẽ vô hiệu hóa sau 1 phút !";
                    MessageBox.Show(Utility.SenderMail(txtMail.Text, _passRandom, mess));
                    txtMail.Text = default;
                    btnsenMail.Text = "Xác nhận code";
                    lblMail.Text = "nhập code :";
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
