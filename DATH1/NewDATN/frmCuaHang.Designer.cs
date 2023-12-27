namespace NewDATN
{
    partial class frmCuaHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoLuongConLai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTenNhanVienLogin = new System.Windows.Forms.Label();
            this.btnLichSu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản phẩm";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvHangHoa.Location = new System.Drawing.Point(1, 193);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(1255, 239);
            this.dgvHangHoa.TabIndex = 2;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            this.dgvHangHoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Size";
            this.Column3.HeaderText = "Size";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DonGia";
            this.Column9.HeaderText = "Đơn Giá";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaTien";
            this.Column6.HeaderText = "Giá Tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayThanhToan";
            this.Column7.HeaderText = "Ngày Tạo Đơn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenNV";
            this.Column8.HeaderText = "Tên Nhân Viên";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // cboMa
            // 
            this.cboMa.DisplayMember = "txtMaKho";
            this.cboMa.FormattingEnabled = true;
            this.cboMa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboMa.Location = new System.Drawing.Point(144, 35);
            this.cboMa.Name = "cboMa";
            this.cboMa.Size = new System.Drawing.Size(109, 24);
            this.cboMa.TabIndex = 3;
            this.cboMa.ValueMember = "txtMaKho";
            this.cboMa.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(461, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(564, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(144, 77);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(109, 22);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = " Số lượng còn lại";
            // 
            // lblSoLuongConLai
            // 
            this.lblSoLuongConLai.AutoSize = true;
            this.lblSoLuongConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongConLai.Location = new System.Drawing.Point(332, 61);
            this.lblSoLuongConLai.Name = "lblSoLuongConLai";
            this.lblSoLuongConLai.Size = new System.Drawing.Size(19, 20);
            this.lblSoLuongConLai.TabIndex = 9;
            this.lblSoLuongConLai.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = " Tên Nhân Viên:";
            // 
            // lblTenNhanVienLogin
            // 
            this.lblTenNhanVienLogin.AutoSize = true;
            this.lblTenNhanVienLogin.Location = new System.Drawing.Point(810, 35);
            this.lblTenNhanVienLogin.Name = "lblTenNhanVienLogin";
            this.lblTenNhanVienLogin.Size = new System.Drawing.Size(43, 16);
            this.lblTenNhanVienLogin.TabIndex = 8;
            this.lblTenNhanVienLogin.Text = "Trống";
            this.lblTenNhanVienLogin.Click += new System.EventHandler(this.lblTenNhanVienLogin_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(968, 49);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(130, 43);
            this.btnLichSu.TabIndex = 10;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // frmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1350, 590);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.lblSoLuongConLai);
            this.Controls.Add(this.lblTenNhanVienLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboMa);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.label1);
            this.Name = "frmCuaHang";
            this.Text = "frmCuaHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCuaHang_FormClosing);
            this.Load += new System.EventHandler(this.frmCuaHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.ComboBox cboMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoLuongConLai;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblTenNhanVienLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnLichSu;
    }
}