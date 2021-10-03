using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2_BUS_Layer.Utility;
using _1_DAL_Layer.Entitys;

namespace _3_GUI_Layer
{
    public partial class FrmBackPass : Form
    {
        private utility utility = new utility();
        private _2_BUS_Layer.IBUSServices.ILoginService _ILoginService = new _2_BUS_Layer.BUSServices.LoginService();
        int _TimeNow , _Time;
        string _passRandom;
        string _code;
        string _Mail;
        NhanVien _NhanVien;
        public FrmBackPass()
        {
            InitializeComponent();
        }

        private void btnsenMail_Click(object sender, EventArgs e)
        {

            try
            {
                /*
                +  nhân mã code từ textbox kiểm tra code 
                +  nếu code nhập vào khớp vối code trên thì đổi mật khẩu và trạng thái mật khẩu của tài khoản vào database 
                +  thông báo đã đổi mật khẩu thành công và chuyển sang form đổi mật khẩu cho người dùng đổi mật khẩu luôn
                */
                if (btnsenMail.Text == "Xác nhận code")
                {
                    _TimeNow = DateTime.Now.Minute;
                    if (txtMail.Text != _code)
                    {
                        MessageBox.Show("Mã code không khớp");
                        txtMail.Focus();
                        return;
                    }
                    // kiểm tra thời gian nếu thời gian lớn hơn 1 phút thì sẽ không cho xác nhạn nữa
                    if (_TimeNow - _Time > 1)
                    {
                        btnsenMail.Text = "Nhận Mật Khẩu Mới";
                        lblMail.Text = "Nhập Mail :";
                        MessageBox.Show("vui lòng nhận mã xác nhận khác !");
                    }
                    // thay đổi mật trạng thái của tài khoản 
                    if (_TimeNow - _Time <= 1 && txtMail.Text == _code)
                    {
                        var Nhanvien = _ILoginService.SenderNhanVien(_Mail);
                        Nhanvien.MatKhau = _passRandom;
                        Nhanvien.TrangThaiMatKhau = false;
                        _ILoginService.DoiMatKhau(Nhanvien);
                        this.Close();
                    }
                }
                // gửi mail và thay đổi text trong button
                if (btnsenMail.Text == "Nhận Mật Khẩu Mới")
                {
                    _Mail = txtMail.Text;
                    _NhanVien = _ILoginService.SenderNhanVien(_Mail);
                    if (_NhanVien == null)
                    {
                        MessageBox.Show("Email không tồn tại trong hệ thống ");
                        return;
                    }
                    _Time = DateTime.Now.Minute;
                    _code = utility.PassRandom(5);
                    _passRandom = utility.PassRandom(8);
                    MessageBox.Show(utility.SenderMail(txtMail.Text, _passRandom, _code));
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
