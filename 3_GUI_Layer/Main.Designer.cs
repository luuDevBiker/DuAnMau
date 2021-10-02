
namespace _3_GUI_Layer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_HoSoNV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_HuóngDan = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_GioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.hướngToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1309, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_DangNhap,
            this.TSMI_DangXuat,
            this.TSMI_HoSoNV,
            this.TSMI_Thoat});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.fileToolStripMenuItem.Text = "Hệ Thống";
            // 
            // TPSM_DangNhap
            // 
            this.TPSM_DangNhap.Name = "TPSM_DangNhap";
            this.TPSM_DangNhap.Size = new System.Drawing.Size(198, 26);
            this.TPSM_DangNhap.Text = "Đăng nhập";
            this.TPSM_DangNhap.Click += new System.EventHandler(this.TPSM_DangNhap_Click);
            // 
            // TSMI_DangXuat
            // 
            this.TSMI_DangXuat.Name = "TSMI_DangXuat";
            this.TSMI_DangXuat.Size = new System.Drawing.Size(198, 26);
            this.TSMI_DangXuat.Text = "Đăng xuất";
            this.TSMI_DangXuat.Click += new System.EventHandler(this.TSMI_DangXuat_Click);
            // 
            // TSMI_HoSoNV
            // 
            this.TSMI_HoSoNV.Name = "TSMI_HoSoNV";
            this.TSMI_HoSoNV.Size = new System.Drawing.Size(198, 26);
            this.TSMI_HoSoNV.Text = "Hồ sơ nhân viên";
            this.TSMI_HoSoNV.Click += new System.EventHandler(this.TSMI_HoSoNV_Click);
            // 
            // TSMI_Thoat
            // 
            this.TSMI_Thoat.Name = "TSMI_Thoat";
            this.TSMI_Thoat.Size = new System.Drawing.Size(198, 26);
            this.TSMI_Thoat.Text = "Thoát";
            this.TSMI_Thoat.Click += new System.EventHandler(this.TSMI_Thoat_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_SanPham,
            this.TPSM_NhanVien,
            this.TPSM_KhachHang});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // TPSM_SanPham
            // 
            this.TPSM_SanPham.Name = "TPSM_SanPham";
            this.TPSM_SanPham.Size = new System.Drawing.Size(172, 26);
            this.TPSM_SanPham.Text = "Sản Phẩm";
            this.TPSM_SanPham.Click += new System.EventHandler(this.TPSM_SanPham_Click);
            // 
            // TPSM_NhanVien
            // 
            this.TPSM_NhanVien.Name = "TPSM_NhanVien";
            this.TPSM_NhanVien.Size = new System.Drawing.Size(172, 26);
            this.TPSM_NhanVien.Text = "Nhân Viên";
            this.TPSM_NhanVien.Click += new System.EventHandler(this.TPSM_NhanVien_Click);
            // 
            // TPSM_KhachHang
            // 
            this.TPSM_KhachHang.Name = "TPSM_KhachHang";
            this.TPSM_KhachHang.Size = new System.Drawing.Size(172, 26);
            this.TPSM_KhachHang.Text = "Khách Hàng";
            this.TPSM_KhachHang.Click += new System.EventHandler(this.TPSM_KhachHang_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_ThongKe});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // TPSM_ThongKe
            // 
            this.TPSM_ThongKe.Name = "TPSM_ThongKe";
            this.TPSM_ThongKe.Size = new System.Drawing.Size(224, 26);
            this.TPSM_ThongKe.Text = "Thống Kê Sản Phẩm";
            this.TPSM_ThongKe.Click += new System.EventHandler(this.TPSM_ThongKe_Click);
            // 
            // hướngToolStripMenuItem
            // 
            this.hướngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hướngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_HuóngDan,
            this.TPSM_GioiThieu});
            this.hướngToolStripMenuItem.Name = "hướngToolStripMenuItem";
            this.hướngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.hướngToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // TPSM_HuóngDan
            // 
            this.TPSM_HuóngDan.Name = "TPSM_HuóngDan";
            this.TPSM_HuóngDan.Size = new System.Drawing.Size(224, 26);
            this.TPSM_HuóngDan.Text = "Hướng dẫn sử dụng";
            this.TPSM_HuóngDan.Click += new System.EventHandler(this.TPSM_HuóngDan_Click);
            // 
            // TPSM_GioiThieu
            // 
            this.TPSM_GioiThieu.Name = "TPSM_GioiThieu";
            this.TPSM_GioiThieu.Size = new System.Drawing.Size(224, 26);
            this.TPSM_GioiThieu.Text = "Giới thiệu sản phẩm";
            this.TPSM_GioiThieu.Click += new System.EventHandler(this.TPSM_GioiThieu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1309, 753);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_HoSoNV;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Thoat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_SanPham;
        private System.Windows.Forms.ToolStripMenuItem TPSM_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem TPSM_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem hướngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_HuóngDan;
        private System.Windows.Forms.ToolStripMenuItem TPSM_GioiThieu;
    }
}