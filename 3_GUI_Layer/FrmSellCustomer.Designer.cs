﻿
namespace _3_GUI_Layer
{
    partial class FrmSellCustomer
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
            this.dgvLstPtd = new System.Windows.Forms.DataGridView();
            this.GrbSell = new System.Windows.Forms.GroupBox();
            this.dgvCtBuy = new System.Windows.Forms.DataGridView();
            this.lblNameCt = new System.Windows.Forms.Label();
            this.txtNameCt = new System.Windows.Forms.TextBox();
            this.lblPhoneCt = new System.Windows.Forms.Label();
            this.txtPhoneCt = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstPtd)).BeginInit();
            this.GrbSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLstPtd
            // 
            this.dgvLstPtd.AllowDrop = true;
            this.dgvLstPtd.AllowUserToAddRows = false;
            this.dgvLstPtd.AllowUserToDeleteRows = false;
            this.dgvLstPtd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLstPtd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLstPtd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLstPtd.Location = new System.Drawing.Point(0, 474);
            this.dgvLstPtd.MultiSelect = false;
            this.dgvLstPtd.Name = "dgvLstPtd";
            this.dgvLstPtd.RowHeadersWidth = 51;
            this.dgvLstPtd.RowTemplate.Height = 29;
            this.dgvLstPtd.Size = new System.Drawing.Size(1335, 273);
            this.dgvLstPtd.TabIndex = 0;
            // 
            // GrbSell
            // 
            this.GrbSell.Controls.Add(this.btnPay);
            this.GrbSell.Controls.Add(this.txtPay);
            this.GrbSell.Controls.Add(this.lblPay);
            this.GrbSell.Controls.Add(this.txtSale);
            this.GrbSell.Controls.Add(this.lblSale);
            this.GrbSell.Controls.Add(this.txtTotal);
            this.GrbSell.Controls.Add(this.lblTotal);
            this.GrbSell.Controls.Add(this.txtPhoneCt);
            this.GrbSell.Controls.Add(this.lblPhoneCt);
            this.GrbSell.Controls.Add(this.txtNameCt);
            this.GrbSell.Controls.Add(this.lblNameCt);
            this.GrbSell.Controls.Add(this.dgvCtBuy);
            this.GrbSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrbSell.Location = new System.Drawing.Point(0, 0);
            this.GrbSell.Name = "GrbSell";
            this.GrbSell.Size = new System.Drawing.Size(1335, 475);
            this.GrbSell.TabIndex = 1;
            this.GrbSell.TabStop = false;
            // 
            // dgvCtBuy
            // 
            this.dgvCtBuy.AllowDrop = true;
            this.dgvCtBuy.AllowUserToAddRows = false;
            this.dgvCtBuy.AllowUserToDeleteRows = false;
            this.dgvCtBuy.AllowUserToOrderColumns = true;
            this.dgvCtBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCtBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCtBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtBuy.Location = new System.Drawing.Point(445, 14);
            this.dgvCtBuy.MultiSelect = false;
            this.dgvCtBuy.Name = "dgvCtBuy";
            this.dgvCtBuy.RowHeadersWidth = 51;
            this.dgvCtBuy.RowTemplate.Height = 29;
            this.dgvCtBuy.Size = new System.Drawing.Size(890, 454);
            this.dgvCtBuy.TabIndex = 0;
            // 
            // lblNameCt
            // 
            this.lblNameCt.AutoSize = true;
            this.lblNameCt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameCt.Location = new System.Drawing.Point(16, 41);
            this.lblNameCt.Name = "lblNameCt";
            this.lblNameCt.Size = new System.Drawing.Size(113, 23);
            this.lblNameCt.TabIndex = 1;
            this.lblNameCt.Text = "Khách hàng :";
            // 
            // txtNameCt
            // 
            this.txtNameCt.Enabled = false;
            this.txtNameCt.Location = new System.Drawing.Point(156, 39);
            this.txtNameCt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameCt.Name = "txtNameCt";
            this.txtNameCt.Size = new System.Drawing.Size(284, 30);
            this.txtNameCt.TabIndex = 2;
            // 
            // lblPhoneCt
            // 
            this.lblPhoneCt.AutoSize = true;
            this.lblPhoneCt.Location = new System.Drawing.Point(16, 81);
            this.lblPhoneCt.Name = "lblPhoneCt";
            this.lblPhoneCt.Size = new System.Drawing.Size(126, 23);
            this.lblPhoneCt.TabIndex = 1;
            this.lblPhoneCt.Text = "Số điện thoại :";
            // 
            // txtPhoneCt
            // 
            this.txtPhoneCt.Enabled = false;
            this.txtPhoneCt.Location = new System.Drawing.Point(156, 79);
            this.txtPhoneCt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneCt.Name = "txtPhoneCt";
            this.txtPhoneCt.Size = new System.Drawing.Size(284, 30);
            this.txtPhoneCt.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 122);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 23);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Tổng tiền :";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(156, 120);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(284, 30);
            this.txtTotal.TabIndex = 2;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(16, 166);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(92, 23);
            this.lblSale.TabIndex = 1;
            this.lblSale.Text = "Giảm giá :";
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(156, 163);
            this.txtSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(284, 30);
            this.txtSale.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(275, 432);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(165, 36);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(16, 211);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(110, 23);
            this.lblPay.TabIndex = 1;
            this.lblPay.Text = "Thanh toán :";
            // 
            // txtPay
            // 
            this.txtPay.Enabled = false;
            this.txtPay.Location = new System.Drawing.Point(156, 208);
            this.txtPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(284, 30);
            this.txtPay.TabIndex = 2;
            // 
            // FrmSellCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1335, 749);
            this.ControlBox = false;
            this.Controls.Add(this.GrbSell);
            this.Controls.Add(this.dgvLstPtd);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "FrmSellCustomer";
            this.Text = "Bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstPtd)).EndInit();
            this.GrbSell.ResumeLayout(false);
            this.GrbSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLstPtd;
        private System.Windows.Forms.GroupBox GrbSell;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPhoneCt;
        private System.Windows.Forms.Label lblPhoneCt;
        private System.Windows.Forms.TextBox txtNameCt;
        private System.Windows.Forms.Label lblNameCt;
        private System.Windows.Forms.DataGridView dgvCtBuy;
    }
}