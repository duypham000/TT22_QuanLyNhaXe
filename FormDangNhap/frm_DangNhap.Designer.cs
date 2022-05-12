namespace TT22_QuanLyNhaXe.FormDangNhap
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpt_matkhau = new System.Windows.Forms.TextBox();
            this.inpt_mnv = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.cbx_hienthimatkhau = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_luumk = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.err_loidangnhap = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(223, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(223, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // inpt_matkhau
            // 
            this.inpt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_matkhau.Location = new System.Drawing.Point(223, 209);
            this.inpt_matkhau.Name = "inpt_matkhau";
            this.inpt_matkhau.PasswordChar = '*';
            this.inpt_matkhau.Size = new System.Drawing.Size(260, 29);
            this.inpt_matkhau.TabIndex = 2;
            // 
            // inpt_mnv
            // 
            this.inpt_mnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_mnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_mnv.Location = new System.Drawing.Point(223, 126);
            this.inpt_mnv.Name = "inpt_mnv";
            this.inpt_mnv.Size = new System.Drawing.Size(260, 29);
            this.inpt_mnv.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_login.Location = new System.Drawing.Point(223, 288);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(260, 35);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cbx_hienthimatkhau
            // 
            this.cbx_hienthimatkhau.AutoSize = true;
            this.cbx_hienthimatkhau.BackColor = System.Drawing.Color.Transparent;
            this.cbx_hienthimatkhau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_hienthimatkhau.Location = new System.Drawing.Point(388, 189);
            this.cbx_hienthimatkhau.Name = "cbx_hienthimatkhau";
            this.cbx_hienthimatkhau.Size = new System.Drawing.Size(95, 17);
            this.cbx_hienthimatkhau.TabIndex = 4;
            this.cbx_hienthimatkhau.Text = "Hiện mật khẩu";
            this.cbx_hienthimatkhau.UseVisualStyleBackColor = false;
            this.cbx_hienthimatkhau.CheckedChanged += new System.EventHandler(this.cbx_hienthimatkhau_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_luumk
            // 
            this.cbx_luumk.AutoSize = true;
            this.cbx_luumk.BackColor = System.Drawing.Color.Transparent;
            this.cbx_luumk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_luumk.Location = new System.Drawing.Point(223, 256);
            this.cbx_luumk.Name = "cbx_luumk";
            this.cbx_luumk.Size = new System.Drawing.Size(91, 17);
            this.cbx_luumk.TabIndex = 5;
            this.cbx_luumk.Text = "Lưu mật khẩu";
            this.cbx_luumk.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.cbx_luumk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_hienthimatkhau);
            this.panel1.Controls.Add(this.err_loidangnhap);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.inpt_mnv);
            this.panel1.Controls.Add(this.inpt_matkhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 441);
            this.panel1.TabIndex = 8;
            // 
            // err_loidangnhap
            // 
            this.err_loidangnhap.AutoSize = true;
            this.err_loidangnhap.BackColor = System.Drawing.Color.Transparent;
            this.err_loidangnhap.LinkColor = System.Drawing.Color.White;
            this.err_loidangnhap.Location = new System.Drawing.Point(223, 350);
            this.err_loidangnhap.Name = "err_loidangnhap";
            this.err_loidangnhap.Size = new System.Drawing.Size(128, 13);
            this.err_loidangnhap.TabIndex = 6;
            this.err_loidangnhap.TabStop = true;
            this.err_loidangnhap.Text = "Gặp sự cố khi đăng nhập";
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập vào hệ thống";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpt_matkhau;
        private System.Windows.Forms.TextBox inpt_mnv;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox cbx_hienthimatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_luumk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel err_loidangnhap;
    }
}