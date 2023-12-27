namespace NewDATN
{
    partial class frmKho
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.radS = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.radL = new System.Windows.Forms.RadioButton();
            this.radXL = new System.Windows.Forms.RadioButton();
            this.radXXL = new System.Windows.Forms.RadioButton();
            this.lblTest = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(645, 66);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(739, 66);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(739, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(645, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKho
            // 
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.Column4,
            this.DonGia});
            this.dgvKho.Location = new System.Drawing.Point(-3, 150);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(875, 258);
            this.dgvKho.TabIndex = 18;
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            this.dgvKho.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaSP";
            this.MaNV.HeaderText = "Mã sản phẩm";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenSP";
            this.TenNV.HeaderText = "Tên sản phẩm";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "Size";
            this.NgaySinh.HeaderText = "Size";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // txtKho
            // 
            this.txtKho.Location = new System.Drawing.Point(129, 34);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(117, 22);
            this.txtKho.TabIndex = 16;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(129, 8);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(117, 22);
            this.txtMaKho.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Sản phẩm";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(301, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 133);
            this.label3.TabIndex = 12;
            this.label3.Text = "Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số Lượng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(129, 70);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(117, 22);
            this.txtSL.TabIndex = 16;
            // 
            // radS
            // 
            this.radS.AutoSize = true;
            this.radS.Location = new System.Drawing.Point(349, 14);
            this.radS.Name = "radS";
            this.radS.Size = new System.Drawing.Size(37, 20);
            this.radS.TabIndex = 25;
            this.radS.TabStop = true;
            this.radS.Text = "S";
            this.radS.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(349, 40);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(39, 20);
            this.radM.TabIndex = 25;
            this.radM.TabStop = true;
            this.radM.Text = "M";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // radL
            // 
            this.radL.AutoSize = true;
            this.radL.Location = new System.Drawing.Point(349, 64);
            this.radL.Name = "radL";
            this.radL.Size = new System.Drawing.Size(35, 20);
            this.radL.TabIndex = 25;
            this.radL.TabStop = true;
            this.radL.Text = "L";
            this.radL.UseVisualStyleBackColor = true;
            // 
            // radXL
            // 
            this.radXL.AutoSize = true;
            this.radXL.Location = new System.Drawing.Point(349, 90);
            this.radXL.Name = "radXL";
            this.radXL.Size = new System.Drawing.Size(43, 20);
            this.radXL.TabIndex = 25;
            this.radXL.TabStop = true;
            this.radXL.Text = "XL";
            this.radXL.UseVisualStyleBackColor = true;
            // 
            // radXXL
            // 
            this.radXXL.AutoSize = true;
            this.radXXL.Location = new System.Drawing.Point(349, 111);
            this.radXXL.Name = "radXXL";
            this.radXXL.Size = new System.Drawing.Size(51, 20);
            this.radXXL.TabIndex = 25;
            this.radXXL.TabStop = true;
            this.radXXL.Text = "XXL";
            this.radXXL.UseVisualStyleBackColor = true;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(488, 44);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(34, 16);
            this.lblTest.TabIndex = 26;
            this.lblTest.Text = "Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nhân Viên";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(129, 98);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(117, 22);
            this.txtDonGia.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đơn Giá";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.radXXL);
            this.Controls.Add(this.radXL);
            this.Controls.Add(this.radL);
            this.Controls.Add(this.radM);
            this.Controls.Add(this.radS);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtKho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKho";
            this.Text = "X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKho_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKho_FormClosed);
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKho;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL;
        public System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.RadioButton radS;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.RadioButton radL;
        private System.Windows.Forms.RadioButton radXL;
        private System.Windows.Forms.RadioButton radXXL;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}