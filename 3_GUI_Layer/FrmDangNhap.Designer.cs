
namespace _3_GUI_Layer
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblTk = new System.Windows.Forms.Label();
            this.lblMk = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llbQMK = new System.Windows.Forms.LinkLabel();
            this.cbNhoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.pcbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLogin.Location = new System.Drawing.Point(131, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(287, 57);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Đăng Nhập";
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTk.Location = new System.Drawing.Point(22, 132);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(103, 28);
            this.lblTk.TabIndex = 1;
            this.lblTk.Text = "Tài khoản :";
            // 
            // lblMk
            // 
            this.lblMk.AutoSize = true;
            this.lblMk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMk.Location = new System.Drawing.Point(22, 182);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(103, 28);
            this.lblMk.TabIndex = 2;
            this.lblMk.Text = "Mật khẩu :";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(154, 136);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(264, 27);
            this.txtTK.TabIndex = 1;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(154, 186);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = 'x';
            this.txtMk.Size = new System.Drawing.Size(264, 27);
            this.txtMk.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(324, 264);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llbQMK
            // 
            this.llbQMK.AutoSize = true;
            this.llbQMK.Location = new System.Drawing.Point(154, 268);
            this.llbQMK.Name = "llbQMK";
            this.llbQMK.Size = new System.Drawing.Size(109, 20);
            this.llbQMK.TabIndex = 5;
            this.llbQMK.TabStop = true;
            this.llbQMK.Text = "Quên mật khẩu";
            this.llbQMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQMK_LinkClicked);
            // 
            // cbNhoTaiKhoan
            // 
            this.cbNhoTaiKhoan.AutoSize = true;
            this.cbNhoTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbNhoTaiKhoan.Location = new System.Drawing.Point(154, 232);
            this.cbNhoTaiKhoan.Name = "cbNhoTaiKhoan";
            this.cbNhoTaiKhoan.Size = new System.Drawing.Size(127, 24);
            this.cbNhoTaiKhoan.TabIndex = 3;
            this.cbNhoTaiKhoan.Text = "Nhớ Tài Khoản";
            this.cbNhoTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // pcbLogin
            // 
            this.pcbLogin.Location = new System.Drawing.Point(22, 12);
            this.pcbLogin.Name = "pcbLogin";
            this.pcbLogin.Size = new System.Drawing.Size(76, 73);
            this.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogin.TabIndex = 6;
            this.pcbLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 320);
            this.Controls.Add(this.pcbLogin);
            this.Controls.Add(this.cbNhoTaiKhoan);
            this.Controls.Add(this.llbQMK);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lblMk);
            this.Controls.Add(this.lblTk);
            this.Controls.Add(this.lblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Label lblMk;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llbQMK;
        private System.Windows.Forms.CheckBox cbNhoTaiKhoan;
        private System.Windows.Forms.PictureBox pcbLogin;
    }
}

