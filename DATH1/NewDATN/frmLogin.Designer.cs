namespace NewDATN
{
    partial class frmLogin
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
            this.Login = new System.Windows.Forms.GroupBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoginKho = new System.Windows.Forms.Button();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login.Controls.Add(this.btnLoginKho);
            this.Login.Controls.Add(this.button1);
            this.Login.Controls.Add(this.txtLogin);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(46, 42);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(678, 349);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(212, 87);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(248, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng nhập Cửa Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoginKho
            // 
            this.btnLoginKho.Location = new System.Drawing.Point(344, 166);
            this.btnLoginKho.Name = "btnLoginKho";
            this.btnLoginKho.Size = new System.Drawing.Size(99, 51);
            this.btnLoginKho.TabIndex = 3;
            this.btnLoginKho.Text = "Đăng nhập Kho";
            this.btnLoginKho.UseVisualStyleBackColor = true;
            this.btnLoginKho.Click += new System.EventHandler(this.btnLoginKho_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginKho;
        private System.Windows.Forms.Button button1;
    }
}