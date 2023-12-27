namespace NewDATN
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.btnQlyNvien = new System.Windows.Forms.Button();
            this.btnQlyHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQlyNvien
            // 
            this.btnQlyNvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQlyNvien.Image = ((System.Drawing.Image)(resources.GetObject("btnQlyNvien.Image")));
            this.btnQlyNvien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQlyNvien.Location = new System.Drawing.Point(339, 126);
            this.btnQlyNvien.Name = "btnQlyNvien";
            this.btnQlyNvien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQlyNvien.Size = new System.Drawing.Size(141, 98);
            this.btnQlyNvien.TabIndex = 0;
            this.btnQlyNvien.Text = "Quản lý Nhân viên";
            this.btnQlyNvien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQlyNvien.UseVisualStyleBackColor = false;
            this.btnQlyNvien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQlyHang
            // 
            this.btnQlyHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQlyHang.Image = ((System.Drawing.Image)(resources.GetObject("btnQlyHang.Image")));
            this.btnQlyHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQlyHang.Location = new System.Drawing.Point(153, 126);
            this.btnQlyHang.Name = "btnQlyHang";
            this.btnQlyHang.Size = new System.Drawing.Size(141, 98);
            this.btnQlyHang.TabIndex = 1;
            this.btnQlyHang.Text = "Quản lý Hàng";
            this.btnQlyHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQlyHang.UseVisualStyleBackColor = false;
            this.btnQlyHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.btnQlyHang);
            this.Controls.Add(this.btnQlyNvien);
            this.Name = "frmChinh";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQlyNvien;
        private System.Windows.Forms.Button btnQlyHang;
    }
}

