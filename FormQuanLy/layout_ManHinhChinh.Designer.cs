namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class layout_ManHinhChinh
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
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlv = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlkh = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlx = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.noty_tenDangNhap = new System.Windows.Forms.ToolStripTextBox();
            this.pnl_hienThi = new System.Windows.Forms.Panel();
            this.pnl_ManHinh = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnl_hienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.mn_qlv,
            this.mn_qlkh,
            this.mn_qlnv,
            this.mn_qlx,
            this.thốngKêToolStripMenuItem,
            this.mi_dangXuat,
            this.noty_tenDangNhap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.moTrangChu);
            // 
            // mn_qlv
            // 
            this.mn_qlv.Name = "mn_qlv";
            this.mn_qlv.Size = new System.Drawing.Size(75, 20);
            this.mn_qlv.Text = "Quản lý vé";
            this.mn_qlv.Click += new System.EventHandler(this.mn_qlv_Click);
            // 
            // mn_qlkh
            // 
            this.mn_qlkh.Name = "mn_qlkh";
            this.mn_qlkh.Size = new System.Drawing.Size(125, 20);
            this.mn_qlkh.Text = "Quản lý khách hàng";
            this.mn_qlkh.Click += new System.EventHandler(this.mn_qlkh_Click);
            // 
            // mn_qlnv
            // 
            this.mn_qlnv.Name = "mn_qlnv";
            this.mn_qlnv.Size = new System.Drawing.Size(115, 20);
            this.mn_qlnv.Text = "Quản lý nhân viên";
            this.mn_qlnv.Click += new System.EventHandler(this.mn_qlnv_Click);
            // 
            // mn_qlx
            // 
            this.mn_qlx.Name = "mn_qlx";
            this.mn_qlx.Size = new System.Drawing.Size(75, 20);
            this.mn_qlx.Text = "Quản lý xe";
            this.mn_qlx.Click += new System.EventHandler(this.mn_qlx_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.xeToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.moDoanhThu);
            // 
            // xeToolStripMenuItem
            // 
            this.xeToolStripMenuItem.Name = "xeToolStripMenuItem";
            this.xeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.xeToolStripMenuItem.Text = "Xe";
            this.xeToolStripMenuItem.Click += new System.EventHandler(this.moThongKeXe);
            // 
            // mi_dangXuat
            // 
            this.mi_dangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mi_dangXuat.Name = "mi_dangXuat";
            this.mi_dangXuat.Size = new System.Drawing.Size(73, 20);
            this.mi_dangXuat.Text = "Đăng xuất";
            this.mi_dangXuat.Click += new System.EventHandler(this.mi_dangXuat_Click);
            // 
            // noty_tenDangNhap
            // 
            this.noty_tenDangNhap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.noty_tenDangNhap.AutoSize = false;
            this.noty_tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noty_tenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noty_tenDangNhap.Name = "noty_tenDangNhap";
            this.noty_tenDangNhap.ReadOnly = true;
            this.noty_tenDangNhap.Size = new System.Drawing.Size(100, 20);
            this.noty_tenDangNhap.Text = "Xin chào duyn";
            // 
            // pnl_hienThi
            // 
            this.pnl_hienThi.Controls.Add(this.pnl_ManHinh);
            this.pnl_hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_hienThi.Location = new System.Drawing.Point(0, 24);
            this.pnl_hienThi.Name = "pnl_hienThi";
            this.pnl_hienThi.Size = new System.Drawing.Size(1264, 657);
            this.pnl_hienThi.TabIndex = 1;
            // 
            // pnl_ManHinh
            // 
            this.pnl_ManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ManHinh.Location = new System.Drawing.Point(0, 0);
            this.pnl_ManHinh.Name = "pnl_ManHinh";
            this.pnl_ManHinh.Size = new System.Drawing.Size(1264, 657);
            this.pnl_ManHinh.TabIndex = 1;
            // 
            // layout_ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_hienThi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "layout_ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà xe";
            this.Load += new System.EventHandler(this.layout_ManHinhChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_hienThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_qlv;
        private System.Windows.Forms.ToolStripMenuItem mn_qlkh;
        private System.Windows.Forms.ToolStripMenuItem mn_qlnv;
        private System.Windows.Forms.ToolStripMenuItem mn_qlx;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_hienThi;
        private System.Windows.Forms.ToolStripMenuItem mi_dangXuat;
        private System.Windows.Forms.ToolStripTextBox noty_tenDangNhap;
        private System.Windows.Forms.Panel pnl_ManHinh;
    }
}