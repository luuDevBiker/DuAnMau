
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_InforEp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Statistical = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Instructions = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSM_Introduce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.lblNameEp = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_Login,
            this.TSMI_Logout,
            this.TSMI_InforEp,
            this.TSMI_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.fileToolStripMenuItem.Text = "Hệ Thống";
            // 
            // TPSM_Login
            // 
            this.TPSM_Login.Name = "TPSM_Login";
            this.TPSM_Login.Size = new System.Drawing.Size(224, 26);
            this.TPSM_Login.Text = "Đăng nhập";
            this.TPSM_Login.Click += new System.EventHandler(this.TPSM_Login_Click);
            // 
            // TSMI_Logout
            // 
            this.TSMI_Logout.Name = "TSMI_Logout";
            this.TSMI_Logout.Size = new System.Drawing.Size(224, 26);
            this.TSMI_Logout.Text = "Đăng xuất";
            this.TSMI_Logout.Click += new System.EventHandler(this.TSMI_Logout_Click);
            // 
            // TSMI_InforEp
            // 
            this.TSMI_InforEp.Name = "TSMI_InforEp";
            this.TSMI_InforEp.Size = new System.Drawing.Size(224, 26);
            this.TSMI_InforEp.Text = "Hồ sơ nhân viên";
            this.TSMI_InforEp.Click += new System.EventHandler(this.TSMI_InforEp_Click);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(224, 26);
            this.TSMI_Exit.Text = "Thoát";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_Product,
            this.TPSM_Employee,
            this.TPSM_Customer});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // TPSM_Product
            // 
            this.TPSM_Product.Name = "TPSM_Product";
            this.TPSM_Product.Size = new System.Drawing.Size(172, 26);
            this.TPSM_Product.Text = "Sản Phẩm";
            this.TPSM_Product.Click += new System.EventHandler(this.TPSM_Product_Click);
            // 
            // TPSM_Employee
            // 
            this.TPSM_Employee.Name = "TPSM_Employee";
            this.TPSM_Employee.Size = new System.Drawing.Size(172, 26);
            this.TPSM_Employee.Text = "Nhân Viên";
            this.TPSM_Employee.Click += new System.EventHandler(this.TPSM_Employee_Click);
            // 
            // TPSM_Customer
            // 
            this.TPSM_Customer.Name = "TPSM_Customer";
            this.TPSM_Customer.Size = new System.Drawing.Size(172, 26);
            this.TPSM_Customer.Text = "Khách Hàng";
            this.TPSM_Customer.Click += new System.EventHandler(this.TPSM_Customer_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_Statistical});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // TPSM_Statistical
            // 
            this.TPSM_Statistical.Name = "TPSM_Statistical";
            this.TPSM_Statistical.Size = new System.Drawing.Size(224, 26);
            this.TPSM_Statistical.Text = "Thống Kê Sản Phẩm";
            this.TPSM_Statistical.Click += new System.EventHandler(this.TPSM_Statistical_Click);
            // 
            // hướngToolStripMenuItem
            // 
            this.hướngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hướngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPSM_Instructions,
            this.TPSM_Introduce});
            this.hướngToolStripMenuItem.Name = "hướngToolStripMenuItem";
            this.hướngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.hướngToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // TPSM_Instructions
            // 
            this.TPSM_Instructions.Name = "TPSM_Instructions";
            this.TPSM_Instructions.Size = new System.Drawing.Size(224, 26);
            this.TPSM_Instructions.Text = "Hướng dẫn sử dụng";
            this.TPSM_Instructions.Click += new System.EventHandler(this.TPSM_Instructions_Click);
            // 
            // TPSM_Introduce
            // 
            this.TPSM_Introduce.Name = "TPSM_Introduce";
            this.TPSM_Introduce.Size = new System.Drawing.Size(224, 26);
            this.TPSM_Introduce.Text = "Giới thiệu sản phẩm";
            this.TPSM_Introduce.Click += new System.EventHandler(this.TPSM_Introduce_Click);
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
            // lblNameEp
            // 
            this.lblNameEp.AutoSize = true;
            this.lblNameEp.Location = new System.Drawing.Point(1044, 0);
            this.lblNameEp.Name = "lblNameEp";
            this.lblNameEp.Size = new System.Drawing.Size(0, 20);
            this.lblNameEp.TabIndex = 111;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1309, 753);
            this.Controls.Add(this.lblNameEp);
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

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Login;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Logout;
        private System.Windows.Forms.ToolStripMenuItem TSMI_InforEp;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Product;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Employee;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Customer;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Statistical;
        private System.Windows.Forms.ToolStripMenuItem hướngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Instructions;
        private System.Windows.Forms.ToolStripMenuItem TPSM_Introduce;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label lblNameEp;
    }
}