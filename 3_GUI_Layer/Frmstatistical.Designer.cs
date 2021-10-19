
namespace _3_GUI_Layer
{
    partial class Frmstatistical
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AllProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MaxPrd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MinPrd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmBánÍtNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Statistical = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistical)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Product,
            this.TSMI_Inventory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1383, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Product
            // 
            this.TSMI_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_AllProduct,
            this.TSMI_MaxPrd,
            this.TSMI_MinPrd});
            this.TSMI_Product.Name = "TSMI_Product";
            this.TSMI_Product.Size = new System.Drawing.Size(89, 24);
            this.TSMI_Product.Text = "Sản phẩm";
            // 
            // TSMI_AllProduct
            // 
            this.TSMI_AllProduct.Name = "TSMI_AllProduct";
            this.TSMI_AllProduct.Size = new System.Drawing.Size(231, 26);
            this.TSMI_AllProduct.Text = "Sản phẩm trong kho";
            this.TSMI_AllProduct.Click += new System.EventHandler(this.TSMI_AllProduct_Click);
            // 
            // TSMI_MaxPrd
            // 
            this.TSMI_MaxPrd.Name = "TSMI_MaxPrd";
            this.TSMI_MaxPrd.Size = new System.Drawing.Size(231, 26);
            this.TSMI_MaxPrd.Text = "Sản phẩm nhiều nhất";
            this.TSMI_MaxPrd.Click += new System.EventHandler(this.TSMI_MaxPrd_Click);
            // 
            // TSMI_MinPrd
            // 
            this.TSMI_MinPrd.Name = "TSMI_MinPrd";
            this.TSMI_MinPrd.Size = new System.Drawing.Size(231, 26);
            this.TSMI_MinPrd.Text = "Sản phẩm ít nhất";
            this.TSMI_MinPrd.Click += new System.EventHandler(this.TSMI_MinPrd_Click);
            // 
            // TSMI_Inventory
            // 
            this.TSMI_Inventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmBánÍtNhấtToolStripMenuItem});
            this.TSMI_Inventory.Name = "TSMI_Inventory";
            this.TSMI_Inventory.Size = new System.Drawing.Size(76, 24);
            this.TSMI_Inventory.Text = "Tồn kho";
            // 
            // sảnPhẩmBánÍtNhấtToolStripMenuItem
            // 
            this.sảnPhẩmBánÍtNhấtToolStripMenuItem.Name = "sảnPhẩmBánÍtNhấtToolStripMenuItem";
            this.sảnPhẩmBánÍtNhấtToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.sảnPhẩmBánÍtNhấtToolStripMenuItem.Text = "Sản phẩm bán ít nhất";
            // 
            // dgv_Statistical
            // 
            this.dgv_Statistical.AllowDrop = true;
            this.dgv_Statistical.AllowUserToAddRows = false;
            this.dgv_Statistical.AllowUserToDeleteRows = false;
            this.dgv_Statistical.AllowUserToOrderColumns = true;
            this.dgv_Statistical.AllowUserToResizeColumns = false;
            this.dgv_Statistical.AllowUserToResizeRows = false;
            this.dgv_Statistical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Statistical.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Statistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Statistical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Statistical.Location = new System.Drawing.Point(0, 271);
            this.dgv_Statistical.Name = "dgv_Statistical";
            this.dgv_Statistical.RowHeadersWidth = 51;
            this.dgv_Statistical.RowTemplate.Height = 29;
            this.dgv_Statistical.Size = new System.Drawing.Size(1383, 414);
            this.dgv_Statistical.TabIndex = 1;
            // 
            // Frmstatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1383, 685);
            this.Controls.Add(this.dgv_Statistical);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmstatistical";
            this.Text = "FrmThongKe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Product;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Inventory;
        private System.Windows.Forms.DataGridView dgv_Statistical;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AllProduct;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MaxPrd;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MinPrd;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmBánÍtNhấtToolStripMenuItem;
    }
}