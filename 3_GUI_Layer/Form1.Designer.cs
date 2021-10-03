
namespace _3_GUI_Layer
{
    partial class Form1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btntest2 = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(534, 138);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 29);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(454, 27);
            this.textBox2.TabIndex = 1;
            // 
            // btntest2
            // 
            this.btntest2.Location = new System.Drawing.Point(414, 138);
            this.btntest2.Name = "btntest2";
            this.btntest2.Size = new System.Drawing.Size(94, 29);
            this.btntest2.TabIndex = 2;
            this.btntest2.Text = "test";
            this.btntest2.UseVisualStyleBackColor = true;
            this.btntest2.Click += new System.EventHandler(this.btntest2_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(12, 147);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(0, 20);
            this.lblLink.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 179);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btntest2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btntest2;
        private System.Windows.Forms.Label lblLink;
    }
}

