
namespace _3_GUI_Layer
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
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
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.pcbAnhHang = new System.Windows.Forms.PictureBox();
            this.txtPrCode = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txtExportPeice = new System.Windows.Forms.TextBox();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtPrQuanlity = new System.Windows.Forms.TextBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtPrName = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lbFrmNhanVien = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.grButton.SuspendLayout();
            this.grbNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnhHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grButton
            // 
            this.grButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grButton.Controls.Add(this.txtFind);
            this.grButton.Controls.Add(this.btnFind);
            this.grButton.Controls.Add(this.btnClose);
            this.grButton.Controls.Add(this.btnList);
            this.grButton.Controls.Add(this.btnSkip);
            this.grButton.Controls.Add(this.btnSave);
            this.grButton.Controls.Add(this.btnUpdate);
            this.grButton.Controls.Add(this.btnRemove);
            this.grButton.Controls.Add(this.btnAdd);
            resources.ApplyResources(this.grButton, "grButton");
            this.grButton.Name = "grButton";
            this.grButton.TabStop = false;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtFind, "txtFind");
            this.txtFind.Name = "txtFind";
            // 
            // btnFind
            // 
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.Name = "btnFind";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            resources.ApplyResources(this.btnList, "btnList");
            this.btnList.Name = "btnList";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSkip
            // 
            resources.ApplyResources(this.btnSkip, "btnSkip");
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbNhanVien.Controls.Add(this.rtbAddress);
            this.grbNhanVien.Controls.Add(this.btnOpenImg);
            this.grbNhanVien.Controls.Add(this.pcbAnhHang);
            this.grbNhanVien.Controls.Add(this.txtPrCode);
            this.grbNhanVien.Controls.Add(this.lblMaHang);
            this.grbNhanVien.Controls.Add(this.txtExportPeice);
            this.grbNhanVien.Controls.Add(this.txtImportPrice);
            this.grbNhanVien.Controls.Add(this.lblGiaBan);
            this.grbNhanVien.Controls.Add(this.txtPrQuanlity);
            this.grbNhanVien.Controls.Add(this.lblGiaNhap);
            this.grbNhanVien.Controls.Add(this.txtPrName);
            this.grbNhanVien.Controls.Add(this.lblSoLuong);
            this.grbNhanVien.Controls.Add(this.lblDiaChi);
            this.grbNhanVien.Controls.Add(this.lblTenHang);
            this.grbNhanVien.Controls.Add(this.lbFrmNhanVien);
            resources.ApplyResources(this.grbNhanVien, "grbNhanVien");
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.TabStop = false;
            // 
            // rtbAddress
            // 
            resources.ApplyResources(this.rtbAddress, "rtbAddress");
            this.rtbAddress.Name = "rtbAddress";
            // 
            // btnOpenImg
            // 
            resources.ApplyResources(this.btnOpenImg, "btnOpenImg");
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // pcbAnhHang
            // 
            resources.ApplyResources(this.pcbAnhHang, "pcbAnhHang");
            this.pcbAnhHang.Name = "pcbAnhHang";
            this.pcbAnhHang.TabStop = false;
            // 
            // txtPrCode
            // 
            resources.ApplyResources(this.txtPrCode, "txtPrCode");
            this.txtPrCode.Name = "txtPrCode";
            this.txtPrCode.ReadOnly = true;
            // 
            // lblMaHang
            // 
            resources.ApplyResources(this.lblMaHang, "lblMaHang");
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaHang.Name = "lblMaHang";
            // 
            // txtExportPeice
            // 
            resources.ApplyResources(this.txtExportPeice, "txtExportPeice");
            this.txtExportPeice.Name = "txtExportPeice";
            // 
            // txtImportPrice
            // 
            resources.ApplyResources(this.txtImportPrice, "txtImportPrice");
            this.txtImportPrice.Name = "txtImportPrice";
            // 
            // lblGiaBan
            // 
            resources.ApplyResources(this.lblGiaBan, "lblGiaBan");
            this.lblGiaBan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGiaBan.Name = "lblGiaBan";
            // 
            // txtPrQuanlity
            // 
            resources.ApplyResources(this.txtPrQuanlity, "txtPrQuanlity");
            this.txtPrQuanlity.Name = "txtPrQuanlity";
            // 
            // lblGiaNhap
            // 
            resources.ApplyResources(this.lblGiaNhap, "lblGiaNhap");
            this.lblGiaNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGiaNhap.Name = "lblGiaNhap";
            // 
            // txtPrName
            // 
            this.txtPrName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtPrName, "txtPrName");
            this.txtPrName.Name = "txtPrName";
            // 
            // lblSoLuong
            // 
            resources.ApplyResources(this.lblSoLuong, "lblSoLuong");
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSoLuong.Name = "lblSoLuong";
            // 
            // lblDiaChi
            // 
            resources.ApplyResources(this.lblDiaChi, "lblDiaChi");
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Name = "lblDiaChi";
            // 
            // lblTenHang
            // 
            resources.ApplyResources(this.lblTenHang, "lblTenHang");
            this.lblTenHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTenHang.Name = "lblTenHang";
            // 
            // lbFrmNhanVien
            // 
            resources.ApplyResources(this.lbFrmNhanVien, "lbFrmNhanVien");
            this.lbFrmNhanVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmNhanVien.Name = "lbFrmNhanVien";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvProduct, "dgvProduct");
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.ShowCellToolTips = false;
            this.dgvProduct.ShowEditingIcon = false;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // FrmProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.grButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.grButton.ResumeLayout(false);
            this.grButton.PerformLayout();
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnhHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
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
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.TextBox txtPrCode;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtPrName;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lbFrmNhanVien;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.PictureBox pcbAnhHang;
        private System.Windows.Forms.TextBox txtExportPeice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtPrQuanlity;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.DataGridView dgvProduct;
    }
}