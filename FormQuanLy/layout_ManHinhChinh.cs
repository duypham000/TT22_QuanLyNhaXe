using System;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class layout_ManHinhChinh : Form
    {
        public layout_ManHinhChinh()
        {
            InitializeComponent();
        }

        private void mi_dangXuat_Click(object sender, EventArgs e)
        {
            string message = "Bạn muốn đăng xuất?";
            string title = "Đăng xuất";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.MK = "";
                Properties.Settings.Default.DangNhap = false;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            this.noty_tenDangNhap.Text = "Xin chào " + Properties.Settings.Default.MNV;

            frm_TrangChu trangChu = new frm_TrangChu();
            openChildForm(trangChu);
        }

        private Form activeForm = null;
        public void openChildForm(Form form)
        {
            if (activeForm != null)
            {
                this.pnl_ManHinh.Controls.Clear();
            }

            this.activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnl_ManHinh.Controls.Add(form);
            this.pnl_ManHinh.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void moTrangChu(object sender, EventArgs e)
        {
            frm_TrangChu trangChu = new frm_TrangChu();
            openChildForm(trangChu);
        }

        private void moDoanhThu(object sender, EventArgs e)
        {
            frm_DoanhThu doanhThu = new frm_DoanhThu();
            openChildForm(doanhThu);
        }

        private void moThongKeXe(object sender, EventArgs e)
        {
            frm_SoXe soXe = new frm_SoXe();
            openChildForm(soXe);
        }

        private void mn_qlx_Click(object sender, EventArgs e)
        {
            frm_QLXe qLXe = new frm_QLXe();
            openChildForm(qLXe);
        }

        private void mn_qlnv_Click(object sender, EventArgs e)
        {
            frm_QLNhanVien qLNhanVien = new frm_QLNhanVien();
            openChildForm(qLNhanVien);
        }

        private void mn_qlkh_Click(object sender, EventArgs e)
        {
            frm_QLKhach qLKhach = new frm_QLKhach();
            openChildForm(qLKhach);
        }

        private void mn_qlv_Click(object sender, EventArgs e)
        {
            frm_QLVe qLVe = new frm_QLVe();
            openChildForm(qLVe);
        }
    }
}