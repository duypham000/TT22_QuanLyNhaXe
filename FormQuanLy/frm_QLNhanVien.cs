using System;
using System.Linq;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_QLNhanVien : Form
    {
        private QLNXDataSet.NhanVienDataTable nhanViens = null;

        private QLNXDataSetTableAdapters.NhanVienTableAdapter nhanVienAdapter = null;

        public frm_QLNhanVien()
        {
            InitializeComponent();

            nhanVienAdapter = new QLNXDataSetTableAdapters.NhanVienTableAdapter();
            nhanViens = new QLNXDataSet.NhanVienDataTable();
            nhanVienAdapter.Fill(nhanViens);
        }

        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();

            this.cb_timTheo.SelectedIndex = 0;
            this.filter_tt.SelectedIndex = 0;
        }

        private void hienThiDuLieu()
        {
            this.dtgv_hienThi.Rows.Clear();
            string tt, chuXe;
            foreach (var nv in nhanViens)
            {
                this.dtgv_hienThi.Rows.Add(nv.ID, nv.MaNV, nv.TenNV, nv.SDT, nv.DiaChi, nv.NgayVaoLam.ToString("dd/MM/yyyy"), nv.TrangThai);
            }
        }

        private void dtgv_hienThi_Click(object sender, EventArgs e)
        {
            if (this.dtgv_hienThi.Rows.Count > 0)
            {
                int idNv = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());
                this.idNvHienTai = idNv;

                var nv = nhanViens.FindByID(idNv);

                this.inp_mnv.Text = nv.MaNV;
                this.inp_tennv.Text = nv.TenNV;
                this.inp_diachi.Text = nv.DiaChi;
                this.dt_ngayVao.Value = nv.NgayVaoLam;
                this.inp_sdt.Text = nv.SDT;
                this.cb_tt.Text = nv.TrangThai;
                this.inp_mk.Text = nv.MatKhau;
            }
        }

        private void locDL(object sender, EventArgs e)
        {
            nhanVienAdapter.Fill(nhanViens);
            switch (this.filter_tt.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.TrangThai.Equals("Đang làm"))
                        {
                            nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                case 2:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.TrangThai.Equals("Nghỉ phép"))
                        {
                            nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                case 3:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.TrangThai.Equals("Nghỉ việc"))
                        {
                            nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                default:
                    break;
            }

            string timKiem = this.inpt_timKiem.Text;
            switch (this.cb_timTheo.SelectedIndex)
            {
                case 0:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.MaNV.Contains(timKiem))
                        {
                            this.nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                case 1:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.TenNV.Contains(timKiem))
                        {
                            this.nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                case 2:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.DiaChi.Contains(timKiem))
                        {
                            this.nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                case 3:
                    foreach (var nv in nhanViens.ToList())
                    {
                        if (!nv.SDT.Contains(timKiem))
                        {
                            this.nhanViens.Rows.Remove(nv);
                        }
                    }
                    break;

                default:
                    break;
            }

            if (!this.chx_huy.Checked)
            {
                DateTime nGui = this.filter_nVao.Value;
                foreach (var nv in nhanViens.ToList())
                {
                    if (!nv.NgayVaoLam.Date.Equals(nGui.Date))
                    {
                        nhanViens.Rows.Remove(nv);
                    }
                }
            }

            hienThiDuLieu();
        }

        private void inpt_timKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                locDL(null, null);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string mnv = this.inp_mnv.Text;
            string tenNv = this.inp_tennv.Text;
            string diaChi = this.inp_diachi.Text;
            string sdt = this.inp_sdt.Text;
            string mk = this.inp_mk.Text;
            DateTime ngayVao = this.dt_ngayVao.Value;
            string tt = this.cb_tt.Text;

            foreach (var nv in nhanViens)
            {
                if (nv.MaNV.Equals(mnv))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                    return;
                }
            }

            nhanVienAdapter.Insert(mnv, mk, tenNv, diaChi, sdt, ngayVao, tt);
        }

        private int idNvHienTai = -1;

        private void btn_sua_Click(object sender, EventArgs e)
        {
            nhanVienAdapter.Fill(nhanViens);

            string mnv = this.inp_mnv.Text;
            string tenNv = this.inp_tennv.Text;
            string diaChi = this.inp_diachi.Text;
            string sdt = this.inp_sdt.Text;
            string mk = this.inp_mk.Text;
            DateTime ngayVao = this.dt_ngayVao.Value;
            string tt = this.cb_tt.Text;

            nhanViens.FindByID(idNvHienTai).MaNV = mnv;
            nhanViens.FindByID(idNvHienTai).TenNV = tenNv;
            nhanViens.FindByID(idNvHienTai).TrangThai = tt;
            nhanViens.FindByID(idNvHienTai).DiaChi = diaChi;
            nhanViens.FindByID(idNvHienTai).SDT = sdt;
            nhanViens.FindByID(idNvHienTai).MatKhau = mk;
            nhanViens.FindByID(idNvHienTai).NgayVaoLam = ngayVao;

            nhanVienAdapter.Update(nhanViens);

            locDL(null, null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (idNvHienTai != -1)
            {
                nhanVienAdapter.Fill(nhanViens);
                var nv = nhanViens.FindByID(idNvHienTai);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    nhanVienAdapter.Delete(nv.ID, nv.MaNV, nv.MatKhau, nv.TenNV, nv.DiaChi, nv.SDT, nv.NgayVaoLam, nv.TrangThai);
                    nhanVienAdapter.Fill(nhanViens);
                    locDL(null, null);
                }
            }
        }

        private void chx_huy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chx_huy.Checked)
            {
                this.filter_nVao.Enabled = false;
            }
            else
            {
                this.filter_nVao.Enabled = true;
            }
            locDL(null, null);
        }
    }
}