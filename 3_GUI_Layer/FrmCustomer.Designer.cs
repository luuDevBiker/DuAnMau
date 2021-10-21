
namespace _3_GUI_Layer
{
    partial class FrmCustomer
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
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.grDGV = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.grButton = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbInfor.SuspendLayout();
            this.grDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFrmKhachHang
            // 
            this.lbFrmKhachHang.AutoSize = true;
            this.lbFrmKhachHang.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmKhachHang.Location = new System.Drawing.Point(435, 23);
            this.lbFrmKhachHang.Name = "lbFrmKhachHang";
            this.lbFrmKhachHang.Size = new System.Drawing.Size(207, 45);
            this.lbFrmKhachHang.TabIndex = 0;
            this.lbFrmKhachHang.Text = "Khách Hàng";
            // 
            // grbInfor
            // 
            this.grbInfor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbInfor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbInfor.Controls.Add(this.rdFemale);
            this.grbInfor.Controls.Add(this.lblDienThoai);
            this.grbInfor.Controls.Add(this.lbFrmKhachHang);
            this.grbInfor.Controls.Add(this.txtName);
            this.grbInfor.Controls.Add(this.lblHoTen);
            this.grbInfor.Controls.Add(this.txtAddress);
            this.grbInfor.Controls.Add(this.lblDiaChi);
            this.grbInfor.Controls.Add(this.txtPhoneNumber);
            this.grbInfor.Controls.Add(this.lblGioiTinh);
            this.grbInfor.Controls.Add(this.rdMale);
            this.grbInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbInfor.Location = new System.Drawing.Point(0, 0);
            this.grbInfor.Name = "grbInfor";
            this.grbInfor.Size = new System.Drawing.Size(1317, 172);
            this.grbInfor.TabIndex = 5;
            this.grbInfor.TabStop = false;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(750, 135);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(52, 24);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDienThoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDienThoai.Location = new System.Drawing.Point(74, 87);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(89, 20);
            this.lblDienThoai.TabIndex = 1;
            this.lblDienThoai.Text = "Điện thoại :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHoTen.Location = new System.Drawing.Point(74, 137);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(750, 84);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(419, 27);
            this.txtAddress.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(640, 86);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(64, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(189, 84);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(407, 27);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGioiTinh.Location = new System.Drawing.Point(644, 134);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(77, 20);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(1008, 133);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(64, 24);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // grDGV
            // 
            this.grDGV.Controls.Add(this.dgvCustomer);
            this.grDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDGV.Location = new System.Drawing.Point(0, 172);
            this.grDGV.Name = "grDGV";
            this.grDGV.Size = new System.Drawing.Size(1317, 403);
            this.grDGV.TabIndex = 6;
            this.grDGV.TabStop = false;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomer.Location = new System.Drawing.Point(3, 23);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1311, 377);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // grButton
            // 
            this.grButton.Controls.Add(this.txtFind);
            this.grButton.Controls.Add(this.btnFind);
            this.grButton.Controls.Add(this.btnClose);
            this.grButton.Controls.Add(this.btnList);
            this.grButton.Controls.Add(this.btnSkip);
            this.grButton.Controls.Add(this.btnSave);
            this.grButton.Controls.Add(this.btnUpdate);
            this.grButton.Controls.Add(this.btnRemove);
            this.grButton.Controls.Add(this.btnAdd);
            this.grButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grButton.Location = new System.Drawing.Point(0, 412);
            this.grButton.Name = "grButton";
            this.grButton.Size = new System.Drawing.Size(1317, 163);
            this.grButton.TabIndex = 7;
            this.grButton.TabStop = false;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFind.Location = new System.Drawing.Point(308, 50);
            this.txtFind.Name = "txtFind";
            this.txtFind.PlaceholderText = "nhập số điện thoại khách hàng";
            this.txtFind.Size = new System.Drawing.Size(288, 27);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(603, 38);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(141, 50);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1163, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(980, 101);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(141, 50);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Danh sách";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(786, 101);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(141, 50);
            this.btnSkip.TabIndex = 0;
            this.btnSkip.Text = "Bỏ qua";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(603, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(407, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(207, 101);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 50);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 575);
            this.ControlBox = false;
            this.Controls.Add(this.grButton);
            this.Controls.Add(this.grDGV);
            this.Controls.Add(this.grbInfor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmKhachHang";
            this.grbInfor.ResumeLayout(false);
            this.grbInfor.PerformLayout();
            this.grDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grButton.ResumeLayout(false);
            this.grButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFrmKhachHang;
        private System.Windows.Forms.GroupBox grbInfor;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.GroupBox grDGV;
        private System.Windows.Forms.GroupBox grButton;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
    }
}