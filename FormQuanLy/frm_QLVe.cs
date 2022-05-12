using System;
using System.Linq;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_QLVe : Form
    {
        private QLNXDataSet.VeXeDataTable veXes = null;
        private QLNXDataSet.XeDataTable xes = null;
        private QLNXDataSet.KhachHangDataTable khachHangs = null;

        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeAdapter = null;
        private QLNXDataSetTableAdapters.XeTableAdapter xeAdapter = null;
        private QLNXDataSetTableAdapters.KhachHangTableAdapter khachHangAdapter = null;

        public frm_QLVe()
        {
            veXeAdapter = new QLNXDataSetTableAdapters.VeXeTableAdapter();
            xeAdapter = new QLNXDataSetTableAdapters.XeTableAdapter();
            khachHangAdapter = new QLNXDataSetTableAdapters.KhachHangTableAdapter();

            veXes = new QLNXDataSet.VeXeDataTable();
            xes = new QLNXDataSet.XeDataTable();
            khachHangs = new QLNXDataSet.KhachHangDataTable();

            veXeAdapter.Fill(veXes);
            xeAdapter.Fill(xes);
            khachHangAdapter.Fill(khachHangs);

            InitializeComponent();
        }

        private void hienThiXe()
        {
            this.cb_BienXe.Items.Add("-Trống-");
            foreach (var xe in xes)
            {
                this.cb_BienXe.Items.Add(xe.BienXe);
            }
        }

        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            hienThiXe();
            hienThiDuLieu();

            this.cb_timTheo.SelectedIndex = 0;
            this.filter_loaiVe.SelectedIndex = 0;
            this.filter_tt.SelectedIndex = 0;

            veXeAdapter.Update(veXes);
        }

        private void tinhTien(object sender, EventArgs e)
        {
            string loaiXe = this.s_loai.Text;
            string loaiVe = this.cb_LoaiVe.Text;
            if (loaiVe != "" && loaiXe != "")
            {
                int tienVe = 0;
                if (loaiVe.Equals("Vé ngày"))
                {
                    switch (loaiXe)
                    {
                        case "Xe đạp":
                            tienVe = 3000;
                            break;

                        case "Xe máy":
                            tienVe = 5000;
                            break;

                        case "Ô tô":
                            tienVe = 10000;
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (loaiXe)
                    {
                        case "Xe đạp":
                            tienVe = 20000;
                            break;

                        case "Xe máy":
                            tienVe = 30000;
                            break;

                        case "Ô tô":
                            tienVe = 50000;
                            break;

                        default:
                            break;
                    }
                }
                this.lbl_gia.Text = tienVe.ToString();
            }
        }

        private void hienThiDuLieu()
        {
            this.dtgv_hienThi.Rows.Clear();
            string idVe, bienXe, loaiXe, chuXe, loaiVe, gGui, nGui, gLay, nLay, trangThai;
            foreach (var ve in veXes)
            {
                idVe = ve.ID.ToString();
                loaiVe = ve.LoaiVe;
                gGui = ve.NgayGui.ToString("HH:mm");
                nGui = ve.NgayGui.ToString("dd/MM/yyyy");

                if (ve.DaLay)
                {
                    gLay = ve.NgayLay.ToString("HH:mm");
                    nLay = ve.NgayLay.ToString("dd/MM/yyyy");
                    trangThai = "Đã lấy";
                }
                else
                {
                    if (ve.QuaHan)
                        trangThai = "Quá hạn";
                    else
                        trangThai = "Chưa lấy";
                    gLay = "";
                    nLay = "";
                }

                var xe = xes.FindByID(ve.IDXe);

                bienXe = xe.BienXe;
                loaiXe = xe.LoaiXe;

                var khach = khachHangs.FindByID(xe.IDChuXe);
                chuXe = khach.TenKH;

                this.dtgv_hienThi.Rows.Add(idVe, bienXe, loaiXe, chuXe, loaiVe, gGui, nGui, gLay, nLay, trangThai);
            }
        }

        private void dtgv_hienThi_Click(object sender, EventArgs e)
        {
            if (this.dtgv_hienThi.Rows.Count > 0)
            {
                int idVe = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());
                this.idHienTai = idVe;
                var veXe = veXes.FindByID(idVe);
                var xe = xes.FindByID(veXe.IDXe);
                var khach = khachHangs.FindByID(xe.IDChuXe);

                this.cb_LoaiVe.Text = veXe.LoaiVe;
                this.s_bien.Text = xe.BienXe;
                this.cb_BienXe.Text = xe.BienXe;
                this.dt_nGui.Value = veXe.NgayGui;

                if (veXe.DaLay)
                {
                    this.dt_nLay.Value = veXe.NgayLay;
                    this.cb_tt.SelectedIndex = 1;
                }
                else if (veXe.QuaHan)
                {
                    this.cb_tt.SelectedIndex = 2;
                }
                else
                {
                    this.cb_tt.SelectedIndex = 0;
                }

                tinhTien(null, null);
            }
        }

        private void locDL(object sender, EventArgs e)
        {
            veXeAdapter.Fill(veXes);
            switch (this.filter_tt.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    foreach (var ve in veXes.ToList())
                    {
                        if (ve.DaLay)
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                case 2:
                    foreach (var ve in veXes.ToList())
                    {
                        if (!ve.DaLay)
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                case 3:
                    foreach (var ve in veXes.ToList())
                    {
                        if (!ve.QuaHan)
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                default:
                    break;
            }

            switch (this.filter_loaiVe.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    foreach (var ve in veXes.ToList())
                    {
                        if (!ve.LoaiVe.Equals("Vé ngày"))
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                case 2:
                    foreach (var ve in veXes.ToList())
                    {
                        if (!ve.LoaiVe.Equals("Vé qua đêm"))
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                default:
                    break;
            }

            if (!this.chx_huy.Checked)
            {
                DateTime nGui = this.dt_ngayGui.Value;
                foreach (var ve in veXes.ToList())
                {
                    if (!ve.NgayGui.Date.Equals(nGui.Date))
                    {
                        veXes.Rows.Remove(ve);
                    }
                }
            }

            string timKiem = this.inpt_timKiem.Text;
            switch (this.cb_timTheo.SelectedIndex)
            {
                case 0:
                    foreach (var ve in veXes.ToList())
                    {
                        var xe = xes.FindByID(ve.IDXe);
                        if (!xe.BienXe.Contains(timKiem))
                        {
                            this.veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                case 1:
                    foreach (var ve in veXes.ToList())
                    {
                        var xe = xes.FindByID(ve.IDXe);
                        var khach = khachHangs.FindByID(xe.IDChuXe);

                        if (!khach.TenKH.Contains(timKiem))
                        {
                            this.veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                default:
                    break;
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
            var xe = xes[this.cb_BienXe.SelectedIndex];
            DateTime nGui = this.dt_nGui.Value;

            String loaiVe = this.cb_LoaiVe.Text;
            DateTime nLay = nLay = this.dt_nLay.Value;
            bool daLay = false;
            bool quaHan = false;
            switch (this.cb_tt.SelectedIndex)
            {
                case 1:
                    daLay = true;
                    break;

                case 2:
                    quaHan = true;
                    break;

                default:
                    break;
            }

            veXeAdapter.Insert(xe.ID, nGui, nLay, loaiVe, quaHan, daLay, decimal.Parse(this.lbl_gia.Text));

            veXeAdapter.Fill(veXes);
            MessageBox.Show("Đã thêm!");
            hienThiDuLieu();
        }

        private void cb_BienXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vitri = this.cb_BienXe.SelectedIndex - 1;
            if (this.cb_BienXe.SelectedIndex != -1)
            {
                var xe = xes[vitri];
                this.s_bien.Text = xe.BienXe;
                this.s_loai.Text = xe.LoaiXe;
                this.s_chu.Text = khachHangs.FindByID(xe.IDChuXe).TenKH;
                this.s_mta.Text = xe.MoTaXe;
            }
        }

        private void cb_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cb_tt.SelectedIndex)
            {
                case 1:
                    this.dt_nLay.Enabled = true;
                    break;

                default:
                    this.dt_nLay.Enabled = false;
                    break;
            }
        }

        private int idHienTai = -1;

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (idHienTai != -1)
            {
                var xe = xes[this.cb_BienXe.SelectedIndex];
                veXes.FindByID(idHienTai).IDXe = xe.ID;

                DateTime nGui = this.dt_nGui.Value;
                veXes.FindByID(idHienTai).NgayGui = nGui;

                String loaiVe = this.cb_LoaiVe.Text;
                veXes.FindByID(idHienTai).LoaiVe = loaiVe;

                DateTime nLay = this.dt_nLay.Value;
                veXes.FindByID(idHienTai).NgayLay = nLay;

                switch (this.cb_tt.SelectedIndex)
                {
                    case 0:
                        veXes.FindByID(idHienTai).QuaHan = false;
                        veXes.FindByID(idHienTai).DaLay = false;
                        break;

                    case 1:
                        veXes.FindByID(idHienTai).DaLay = true;
                        veXes.FindByID(idHienTai).QuaHan = false;
                        break;

                    case 2:
                        veXes.FindByID(idHienTai).DaLay = false;
                        veXes.FindByID(idHienTai).QuaHan = true;
                        break;

                    default:
                        break;
                }

                veXes.FindByID(idHienTai).GiaVe = decimal.Parse(this.lbl_gia.Text);

                veXeAdapter.Update(veXes);
                MessageBox.Show("Đã sửa!");
                hienThiDuLieu();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (idHienTai != -1)
            {
                veXeAdapter.Fill(veXes);
                var ve = veXes.FindByID(idHienTai);
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa vé", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    veXeAdapter.Delete(ve.ID, ve.IDXe, ve.NgayGui, ve.NgayLay, ve.LoaiVe, ve.QuaHan, ve.DaLay, ve.GiaVe);
                    veXeAdapter.Fill(veXes);
                    locDL(null, null);
                }
            }
        }

        private void chx_huy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chx_huy.Checked)
            {
                this.dt_ngayGui.Enabled = false;
            }
            else
            {
                this.dt_ngayGui.Enabled = true;
            }

            locDL(null, null);
        }
    }
}