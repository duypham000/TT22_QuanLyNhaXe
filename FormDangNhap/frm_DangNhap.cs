using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormDangNhap
{
    public partial class frm_DangNhap : Form
    {
        QLNXDataSet.NhanVienDataTable nhanViens = null;
        QLNXDataSetTableAdapters.NhanVienTableAdapter nhanVienAdapter = null;
        public frm_DangNhap()
        {
            InitializeComponent();
            nhanVienAdapter = new QLNXDataSetTableAdapters.NhanVienTableAdapter();
            nhanViens = new QLNXDataSet.NhanVienDataTable();

            nhanVienAdapter.Fill(nhanViens);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string mnv = this.inpt_mnv.Text;
            string mk = this.inpt_matkhau.Text;
            if (!string.IsNullOrEmpty(mnv) || !string.IsNullOrEmpty(mk))
            {
                foreach (var nv in nhanViens)
                {
                    if(nv.MaNV.Equals(mnv) && nv.MatKhau.Equals(mk))
                    {
                        Properties.Settings.Default.DangNhap = true;
                        Properties.Settings.Default.MNV = mnv;
                        if (this.cbx_luumk.Checked)
                        {
                            Properties.Settings.Default.MK = mk;
                        }
                        Properties.Settings.Default.Save();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ tài khoản và mật khẩu!");
            }
        }

        private void cbx_hienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbx_hienthimatkhau.Checked)
            {
                this.inpt_matkhau.PasswordChar = '\0';
            }
            else
            {
                this.inpt_matkhau.PasswordChar = '*';
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.inpt_matkhau.Text = Properties.Settings.Default.MK;
            this.inpt_mnv.Text = Properties.Settings.Default.MNV;
            if (Properties.Settings.Default.MK != "")
            {
                this.cbx_luumk.Checked = true;
            }
        }
    }
}
