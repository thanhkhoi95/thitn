namespace THITN
{
    partial class frmDangNhap
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
            this.pnDangNhap = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.tbTenNguoiDung = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDangNhap
            // 
            this.pnDangNhap.Controls.Add(this.btnDangNhap);
            this.pnDangNhap.Controls.Add(this.tbTenNguoiDung);
            this.pnDangNhap.Controls.Add(this.tbMatKhau);
            this.pnDangNhap.Controls.Add(this.label2);
            this.pnDangNhap.Controls.Add(this.label1);
            this.pnDangNhap.Location = new System.Drawing.Point(12, 12);
            this.pnDangNhap.Name = "pnDangNhap";
            this.pnDangNhap.Size = new System.Drawing.Size(338, 298);
            this.pnDangNhap.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(252, 75);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tbTenNguoiDung
            // 
            this.tbTenNguoiDung.Location = new System.Drawing.Point(112, 7);
            this.tbTenNguoiDung.Name = "tbTenNguoiDung";
            this.tbTenNguoiDung.Size = new System.Drawing.Size(215, 20);
            this.tbTenNguoiDung.TabIndex = 4;
            this.tbTenNguoiDung.WordWrap = false;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(112, 40);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(215, 20);
            this.tbMatKhau.TabIndex = 5;
            //this.tbMatKhau.TextChanged += new System.EventHandler(this.tbMatKhau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 322);
            this.Controls.Add(this.pnDangNhap);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnDangNhap.ResumeLayout(false);
            this.pnDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox tbTenNguoiDung;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;


    }
}