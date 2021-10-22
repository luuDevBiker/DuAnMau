
namespace _3_GUI_Layer
{
    partial class FrmEmployee
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
            this.grDGV = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdOn = new System.Windows.Forms.RadioButton();
            this.rdOff = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdEmployee = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lbFrmNhanVien = new System.Windows.Forms.Label();
            this.grButton.SuspendLayout();
            this.grDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.grbNhanVien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.grButton.Location = new System.Drawing.Point(0, 593);
            this.grButton.Name = "grButton";
            this.grButton.Size = new System.Drawing.Size(1330, 177);
            this.grButton.TabIndex = 2;
            this.grButton.TabStop = false;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFind.Location = new System.Drawing.Point(308, 50);
            this.txtFind.Name = "txtFind";
            this.txtFind.PlaceholderText = "Nhập mã Nhân viên hoặc Email";
            this.txtFind.Size = new System.Drawing.Size(288, 27);
            this.txtFind.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(603, 38);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(141, 50);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1163, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(980, 101);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(141, 50);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "Danh sách";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(786, 101);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(141, 50);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Bỏ qua";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(603, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(407, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(207, 101);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 50);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grDGV
            // 
            this.grDGV.Controls.Add(this.dgvEmployee);
            this.grDGV.Controls.Add(this.grbNhanVien);
            this.grDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDGV.Location = new System.Drawing.Point(0, 0);
            this.grDGV.Name = "grDGV";
            this.grDGV.Size = new System.Drawing.Size(1330, 593);
            this.grDGV.TabIndex = 9;
            this.grDGV.TabStop = false;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowDrop = true;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 218);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.ShowEditingIcon = false;
            this.dgvEmployee.Size = new System.Drawing.Size(1324, 372);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Controls.Add(this.panel2);
            this.grbNhanVien.Controls.Add(this.txtAddress);
            this.grbNhanVien.Controls.Add(this.panel1);
            this.grbNhanVien.Controls.Add(this.txtMail);
            this.grbNhanVien.Controls.Add(this.lblMail);
            this.grbNhanVien.Controls.Add(this.txtName);
            this.grbNhanVien.Controls.Add(this.lblTrangThai);
            this.grbNhanVien.Controls.Add(this.lblDiaChi);
            this.grbNhanVien.Controls.Add(this.lblChucVu);
            this.grbNhanVien.Controls.Add(this.lblHoTen);
            this.grbNhanVien.Controls.Add(this.lbFrmNhanVien);
            this.grbNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNhanVien.Location = new System.Drawing.Point(3, 23);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(1324, 195);
            this.grbNhanVien.TabIndex = 1;
            this.grbNhanVien.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdOn);
            this.panel2.Controls.Add(this.rdOff);
            this.panel2.Location = new System.Drawing.Point(783, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 55);
            this.panel2.TabIndex = 7;
            // 
            // rdOn
            // 
            this.rdOn.AutoSize = true;
            this.rdOn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdOn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdOn.Location = new System.Drawing.Point(3, 15);
            this.rdOn.Name = "rdOn";
            this.rdOn.Size = new System.Drawing.Size(104, 24);
            this.rdOn.TabIndex = 6;
            this.rdOn.TabStop = true;
            this.rdOn.Text = "Hoạt động";
            this.rdOn.UseVisualStyleBackColor = true;
            // 
            // rdOff
            // 
            this.rdOff.AutoSize = true;
            this.rdOff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdOff.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdOff.Location = new System.Drawing.Point(184, 15);
            this.rdOff.Name = "rdOff";
            this.rdOff.Size = new System.Drawing.Size(155, 24);
            this.rdOff.TabIndex = 7;
            this.rdOff.TabStop = true;
            this.rdOff.Text = "Ngưng hoạt động";
            this.rdOff.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(783, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(362, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdAdmin);
            this.panel1.Controls.Add(this.rdEmployee);
            this.panel1.Location = new System.Drawing.Point(159, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 50);
            this.panel1.TabIndex = 3;
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdAdmin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdAdmin.Location = new System.Drawing.Point(306, 14);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(87, 24);
            this.rdAdmin.TabIndex = 4;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Quản trị";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdEmployee
            // 
            this.rdEmployee.AutoSize = true;
            this.rdEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdEmployee.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdEmployee.Location = new System.Drawing.Point(3, 14);
            this.rdEmployee.Name = "rdEmployee";
            this.rdEmployee.Size = new System.Drawing.Size(103, 24);
            this.rdEmployee.TabIndex = 3;
            this.rdEmployee.TabStop = true;
            this.rdEmployee.Text = "Nhân Viên";
            this.rdEmployee.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(159, 60);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(407, 27);
            this.txtMail.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMail.Location = new System.Drawing.Point(44, 63);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 20);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTrangThai.Location = new System.Drawing.Point(658, 139);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(88, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng thái :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(658, 60);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChucVu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblChucVu.Location = new System.Drawing.Point(44, 153);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(73, 20);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức vụ :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHoTen.Location = new System.Drawing.Point(44, 109);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 20);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // lbFrmNhanVien
            // 
            this.lbFrmNhanVien.AutoSize = true;
            this.lbFrmNhanVien.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmNhanVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmNhanVien.Location = new System.Drawing.Point(466, 12);
            this.lbFrmNhanVien.Name = "lbFrmNhanVien";
            this.lbFrmNhanVien.Size = new System.Drawing.Size(182, 45);
            this.lbFrmNhanVien.TabIndex = 1;
            this.lbFrmNhanVien.Text = "Nhân Viên";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1330, 770);
            this.ControlBox = false;
            this.Controls.Add(this.grDGV);
            this.Controls.Add(this.grButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee";
            this.grButton.ResumeLayout(false);
            this.grButton.PerformLayout();
            this.grDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grButton;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grDGV;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.Label lbFrmNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdEmployee;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.RadioButton rdOn;
        private System.Windows.Forms.RadioButton rdOff;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}