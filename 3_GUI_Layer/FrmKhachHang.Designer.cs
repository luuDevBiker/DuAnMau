
namespace _3_GUI_Layer
{
    partial class FrmKhachHang
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
            this.lbFrmKhachHang = new System.Windows.Forms.Label();
            this.grbInfor = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.grDGV = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.grButton = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbInfor.SuspendLayout();
            this.grDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFrmKhachHang
            // 
            this.lbFrmKhachHang.AutoSize = true;
            this.lbFrmKhachHang.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmKhachHang.Location = new System.Drawing.Point(387, 23);
            this.lbFrmKhachHang.Name = "lbFrmKhachHang";
            this.lbFrmKhachHang.Size = new System.Drawing.Size(207, 45);
            this.lbFrmKhachHang.TabIndex = 0;
            this.lbFrmKhachHang.Text = "Khách Hàng";
            // 
            // grbInfor
            // 
            this.grbInfor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbInfor.Controls.Add(this.rdNu);
            this.grbInfor.Controls.Add(this.lblDienThoai);
            this.grbInfor.Controls.Add(this.lbFrmKhachHang);
            this.grbInfor.Controls.Add(this.txtHoTen);
            this.grbInfor.Controls.Add(this.lblHoTen);
            this.grbInfor.Controls.Add(this.txtDiaChi);
            this.grbInfor.Controls.Add(this.lblDiaChi);
            this.grbInfor.Controls.Add(this.txtSoDienThoai);
            this.grbInfor.Controls.Add(this.lblGioiTinh);
            this.grbInfor.Controls.Add(this.rdNam);
            this.grbInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbInfor.Location = new System.Drawing.Point(0, 0);
            this.grbInfor.Name = "grbInfor";
            this.grbInfor.Size = new System.Drawing.Size(1171, 172);
            this.grbInfor.TabIndex = 5;
            this.grbInfor.TabStop = false;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(667, 135);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(50, 24);
            this.rdNu.TabIndex = 4;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDienThoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDienThoai.Location = new System.Drawing.Point(66, 87);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(89, 20);
            this.lblDienThoai.TabIndex = 1;
            this.lblDienThoai.Text = "Điện thoại :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(168, 134);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(362, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHoTen.Location = new System.Drawing.Point(66, 137);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(667, 84);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(373, 27);
            this.txtDiaChi.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(585, 87);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(64, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(168, 84);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(362, 27);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGioiTinh.Location = new System.Drawing.Point(588, 135);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(64, 20);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Địa chỉ :";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(896, 133);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(62, 24);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // grDGV
            // 
            this.grDGV.Controls.Add(this.dgvKhachHang);
            this.grDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDGV.Location = new System.Drawing.Point(0, 172);
            this.grDGV.Name = "grDGV";
            this.grDGV.Size = new System.Drawing.Size(1171, 403);
            this.grDGV.TabIndex = 6;
            this.grDGV.TabStop = false;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 23);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 29;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1165, 377);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // grButton
            // 
            this.grButton.Controls.Add(this.textBox4);
            this.grButton.Controls.Add(this.btnTimKiem);
            this.grButton.Controls.Add(this.btnDong);
            this.grButton.Controls.Add(this.btnDanhSach);
            this.grButton.Controls.Add(this.btnBoQua);
            this.grButton.Controls.Add(this.btnLuu);
            this.grButton.Controls.Add(this.btnSua);
            this.grButton.Controls.Add(this.btnXoa);
            this.grButton.Controls.Add(this.btnThem);
            this.grButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grButton.Location = new System.Drawing.Point(0, 412);
            this.grButton.Name = "grButton";
            this.grButton.Size = new System.Drawing.Size(1171, 163);
            this.grButton.TabIndex = 7;
            this.grButton.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(274, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "nhập số điện thoại khách hàng";
            this.textBox4.Size = new System.Drawing.Size(256, 27);
            this.textBox4.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(536, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 50);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1034, 101);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(125, 50);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(871, 101);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(125, 50);
            this.btnDanhSach.TabIndex = 0;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(699, 101);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(125, 50);
            this.btnBoQua.TabIndex = 0;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(536, 101);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 50);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(362, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 50);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(184, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 50);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 575);
            this.Controls.Add(this.grButton);
            this.Controls.Add(this.grDGV);
            this.Controls.Add(this.grbInfor);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.grbInfor.ResumeLayout(false);
            this.grbInfor.PerformLayout();
            this.grDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grButton.ResumeLayout(false);
            this.grButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFrmKhachHang;
        private System.Windows.Forms.GroupBox grbInfor;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox grDGV;
        private System.Windows.Forms.GroupBox grButton;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnTimKiem;
    }
}