
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_HoSoNV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
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
            this.TPSM_DangNhap.Size = new System.Drawing.Size(224, 26);
            this.TPSM_DangNhap.Text = "Đăng nhập";
            this.TPSM_DangNhap.Click += new System.EventHandler(this.TPSM_DangNhap_Click);
            // 
            // TSMI_DangXuat
            // 
            this.TSMI_DangXuat.Name = "TSMI_DangXuat";
            this.TSMI_DangXuat.Size = new System.Drawing.Size(224, 26);
            this.TSMI_DangXuat.Text = "Đăng xuất";
            this.TSMI_DangXuat.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TSMI_HoSoNV
            // 
            this.TSMI_HoSoNV.Name = "TSMI_HoSoNV";
            this.TSMI_HoSoNV.Size = new System.Drawing.Size(224, 26);
            this.TSMI_HoSoNV.Text = "Hồ sơ nhân viên";
            // 
            // TSMI_Thoat
            // 
            this.TSMI_Thoat.Name = "TSMI_Thoat";
            this.TSMI_Thoat.Size = new System.Drawing.Size(224, 26);
            this.TSMI_Thoat.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSảnPhẩmToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            this.thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            this.thốngKêSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thốngKêSảnPhẩmToolStripMenuItem.Text = "Thống Kê Sản Phẩm";
            // 
            // hướngToolStripMenuItem
            // 
            this.hướngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hướngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ướngDẫnSửDụngToolStripMenuItem,
            this.giớiThiệuSảnPhẩmToolStripMenuItem});
            this.hướngToolStripMenuItem.Name = "hướngToolStripMenuItem";
            this.hướngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.hướngToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // ướngDẫnSửDụngToolStripMenuItem
            // 
            this.ướngDẫnSửDụngToolStripMenuItem.Name = "ướngDẫnSửDụngToolStripMenuItem";
            this.ướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // giớiThiệuSảnPhẩmToolStripMenuItem
            // 
            this.giớiThiệuSảnPhẩmToolStripMenuItem.Name = "giớiThiệuSảnPhẩmToolStripMenuItem";
            this.giớiThiệuSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giớiThiệuSảnPhẩmToolStripMenuItem.Text = "Giới thiệu sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}