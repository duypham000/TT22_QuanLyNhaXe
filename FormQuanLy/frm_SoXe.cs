using System;
using System.Linq;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_SoXe : Form
    {
        private QLNXDataSet.VeXeDataTable veXes = null;
        private QLNXDataSet.XeDataTable xes = null;
        private QLNXDataSet.KhachHangDataTable khachHangs = null;

        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeAdapter = null;
        private QLNXDataSetTableAdapters.XeTableAdapter xeAdapter = null;
        private QLNXDataSetTableAdapters.KhachHangTableAdapter khachHangAdapter = null;

        public frm_SoXe()
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

        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();

            this.cb_timTheo.SelectedIndex = 0;
            this.filter_loaiXe.SelectedIndex = 0;
            this.filter_loaiVe.SelectedIndex = 0;
            this.filter_tt.SelectedIndex = 0;

            for (int i = 0; i < veXes.Count; i++)
            {
                int cp = DateTime.Compare(DateTime.Now.Date, veXes[i].NgayGui.Date);
                if (cp > 0 && veXes[i].LoaiVe.Equals("Vé ngày"))
                {
                    veXes[i].QuaHan = true;
                }
                else if (cp > 1 && veXes[i].LoaiVe.Equals("Vé qua đêm"))
                {
                    veXes[i].QuaHan = true;
                }
                else
                {
                    veXes[i].QuaHan = false;
                }
            }
            veXeAdapter.Update(veXes);
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
                    {
                        trangThai = "Quá hạn";
                    }
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

            this.lbl_demXe.Text = this.dtgv_hienThi.Rows.Count + " xe";
        }

        private void btn_lay_Click(object sender, EventArgs e)
        {
            int idVe = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());
            var veXe = veXes.FindByID(idVe);
            veXes.FindByID(idVe).QuaHan = false;
            xes.FindByID(veXe.IDXe).DangDeXe = false;
            xeAdapter.Update(xes);
            veXes.FindByID(idVe).NgayLay = DateTime.Now;
            veXeAdapter.Update(veXes);
            hienThiDuLieu();
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

            switch (this.filter_loaiXe.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    foreach (var ve in veXes.ToList())
                    {
                        var xe = xes.FindByID(ve.IDXe);
                        if (!xe.LoaiXe.Equals("Xe đạp"))
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                case 2:
                    foreach (var ve in veXes.ToList())
                    {
                        var xe = xes.FindByID(ve.IDXe);
                        if (!xe.LoaiXe.Equals("Xe máy"))
                        {
                            veXes.Rows.Remove(ve);
                        }
                    }
                    break;

                case 3:
                    foreach (var ve in veXes.ToList())
                    {
                        var xe = xes.FindByID(ve.IDXe);
                        if (!xe.LoaiXe.Equals("Ô tô"))
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

            if (!this.chx_gui.Checked)
            {
                DateTime nGui = this.dt_nGui.Value.Date;
                DateTime nGui1 = this.dt_nGui1.Value.Date;
                TimeSpan gGui = this.dt_gGui.Value.TimeOfDay;
                TimeSpan gGui1 = this.dt_gGui1.Value.TimeOfDay;

                foreach (var ve in veXes.ToList())
                {
                    if (!((ve.NgayGui.Date.CompareTo(nGui.Date) >= 0) && (ve.NgayGui.Date.CompareTo(nGui1.Date) <= 0) && (ve.NgayGui.TimeOfDay.CompareTo(gGui) >= 0) && (ve.NgayGui.TimeOfDay.CompareTo(gGui1) <= 0)))
                    {
                        veXes.Rows.Remove(ve);
                    }
                }
            }
            if (!this.chx_lay.Checked)
            {
                DateTime nLay = this.dt_nLay.Value.Date;
                DateTime nLay1 = this.dt_nLay1.Value.Date;
                TimeSpan gLay = this.dt_gLay.Value.TimeOfDay;
                TimeSpan gLay1 = this.dt_gLay1.Value.TimeOfDay;

                foreach (var ve in veXes.ToList())
                {
                    if (ve.DaLay && !((ve.NgayLay.Date.CompareTo(nLay.Date) >= 0) && (ve.NgayLay.Date.CompareTo(nLay1.Date) <= 0) && (ve.NgayLay.TimeOfDay.CompareTo(gLay) >= 0) && (ve.NgayLay.TimeOfDay.CompareTo(gLay1) <= 0)))
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

        private void chx_lay_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_lay.Checked)
            {
                this.dt_gLay.Enabled = false;
                this.dt_gLay1.Enabled = false;
                this.dt_nLay.Enabled = false;
                this.dt_nLay1.Enabled = false;
            }
            else
            {
                this.dt_gLay.Enabled = true;
                this.dt_gLay1.Enabled = true;
                this.dt_nLay.Enabled = true;
                this.dt_nLay1.Enabled = true;
            }

            locDL(null, null);
        }

        private void chx_gui_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_gui.Checked)
            {
                this.dt_gGui.Enabled = false;
                this.dt_gGui1.Enabled = false;
                this.dt_nGui.Enabled = false;
                this.dt_nGui1.Enabled = false;
            }
            else
            {
                this.dt_gGui.Enabled = true;
                this.dt_gGui1.Enabled = true;
                this.dt_nGui.Enabled = true;
                this.dt_nGui1.Enabled = true;
            }
            locDL(null, null);
        }
    }
}