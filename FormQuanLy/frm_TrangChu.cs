using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_TrangChu : Form
    {
        private QLNXDataSet.VeXeDataTable veXes = null;
        private QLNXDataSet.XeDataTable xes = null;
        private QLNXDataSet.KhachHangDataTable khachHangs = null;

        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeAdapter = null;
        private QLNXDataSetTableAdapters.XeTableAdapter xeAdapter = null;
        private QLNXDataSetTableAdapters.KhachHangTableAdapter khachHangAdapter = null;

        public frm_TrangChu()
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

        private void dienChuXe()
        {
            this.cb_ChuXe.Items.Clear();
            this.cb_ChuXe.Items.Add("-trống-");

            foreach (var khach in khachHangs)
            {
                this.cb_ChuXe.Items.Add(new ListItem(khach.TenKH, khach.ID.ToString()));
            }
        }

        private void tinhTien(object sender, EventArgs e)
        {
            string loaiXe = this.cb_LoaiXe.Text;
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
                this.lbl_TienVe.Text = tienVe.ToString();
            }
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            string loaiVe = this.cb_LoaiVe.Text;
            string bienXe = this.inp_BienXe.Text;
            string loaiXe = this.cb_LoaiXe.Text;
            string chuXe = this.cb_ChuXe.Text;
            int tienVe = int.Parse(this.lbl_TienVe.Text);
            string mota = this.inpt_mota.Text;
            int idChuXe = -1;
            int idXe = -1;

            if (loaiVe != "" && loaiXe != "" && chuXe != "" && tienVe != 0)
            {
                foreach (var khach in khachHangs)
                {
                    if (khach.TenKH.Equals(chuXe))
                    {
                        idChuXe = khach.ID;
                    }
                }

                if (bienXe != "")
                {
                    foreach (var xe in xes)
                    {
                        if (xe.BienXe.Equals(bienXe) && idChuXe == xe.IDChuXe)
                        {
                            idXe = xe.ID;
                        }
                    }
                }

                if (idChuXe == -1)
                {
                    string tenKH = this.inpt_TenChuXe.Text;
                    string sdt = this.inpt_sdt.Text;
                    string diaChi = this.inpt_DiaChi.Text;

                    if (tenKH != "" && sdt != "" && diaChi != "")
                    {
                        this.khachHangAdapter.Insert(tenKH, sdt, diaChi);
                        this.khachHangAdapter.Fill(khachHangs);
                        dienChuXe();
                    }
                    else
                    {
                        MessageBox.Show("Nhập đầy đủ thông tin chủ xe!");
                    }

                    idChuXe = khachHangs[khachHangs.Count - 1].ID;
                }
                if (idXe == -1)
                {
                    this.xeAdapter.Insert(bienXe, idChuXe, loaiXe, mota, true);
                }
                this.xeAdapter.Fill(xes);
                idXe = this.xes[xes.Count - 1].ID;
                this.veXeAdapter.Insert(idXe, DateTime.Now, null, loaiVe, false, false, tienVe);
                hienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin chủ xe!");
            }
        }

        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            dienChuXe();
            lbl_err.Hide();
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

        private void cb_ChuXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_ChuXe.SelectedItem != null)
            {
                string chuXe = this.cb_ChuXe.SelectedItem.ToString();
                if (chuXe.Equals("-trống-"))
                {
                    this.lbl_err.Show();

                    this.inpt_TenChuXe.Enabled = true;
                    this.inpt_sdt.Enabled = true;
                    this.inpt_DiaChi.Enabled = true;

                    this.inpt_TenChuXe.Text = "";
                    this.inpt_sdt.Text = "";
                    this.inpt_DiaChi.Text = "";
                }
                else
                {
                    this.lbl_err.Hide();
                    foreach (var khach in khachHangs)
                    {
                        if (khach.TenKH.Equals(chuXe))
                        {
                            this.inpt_TenChuXe.Enabled = false;
                            this.inpt_sdt.Enabled = false;
                            this.inpt_DiaChi.Enabled = false;

                            this.inpt_TenChuXe.Text = khach.TenKH;
                            this.inpt_sdt.Text = khach.SDT;
                            this.inpt_DiaChi.Text = khach.DiaChi;
                        }
                    }
                }
            }
        }

        private void btn_xeVao_Click(object sender, EventArgs e)
        {
            this.inpt_TenChuXe.Text = "";
            this.inpt_sdt.Text = "";
            this.inpt_DiaChi.Text = "";
            this.cb_LoaiVe.Text = "";
            this.inp_BienXe.Text = "";
            this.cb_LoaiXe.Text = "";
            this.cb_ChuXe.Text = "";
            this.lbl_TienVe.Text = "0";
            this.inpt_mota.Text = "";

            this.inpt_TenChuXe.Enabled = true;
            this.inpt_sdt.Enabled = true;
            this.inpt_DiaChi.Enabled = true;
            this.cb_LoaiVe.Enabled = true;
            this.inp_BienXe.Enabled = true;
            this.cb_LoaiXe.Enabled = true;
            this.cb_ChuXe.Enabled = true;
            this.inpt_mota.Enabled = true;

            this.btn_gui.Enabled = true;
            this.btn_lay.Enabled = false;
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
                this.btn_gui.Enabled = false;
                this.btn_lay.Enabled = true;

                int idVe = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());

                var veXe = veXes.FindByID(idVe);
                var xe = xes.FindByID(veXe.IDXe);
                var khach = khachHangs.FindByID(xe.IDChuXe);

                if (veXe.DaLay)
                {
                    this.btn_lay.Enabled = false;
                }

                this.cb_LoaiVe.Text = veXe.LoaiVe;
                this.inp_BienXe.Text = xe.BienXe;
                this.cb_LoaiXe.Text = xe.LoaiXe;
                this.cb_ChuXe.Text = khach.TenKH;
                this.inpt_mota.Text = xe.MoTaXe;
                this.inpt_TenChuXe.Text = khach.TenKH;
                this.inpt_sdt.Text = khach.SDT;
                this.inpt_DiaChi.Text = khach.DiaChi;
                tinhTien(null, null);

                this.inpt_TenChuXe.Enabled = false;
                this.inpt_sdt.Enabled = false;
                this.inpt_DiaChi.Enabled = false;
                this.cb_LoaiVe.Enabled = false;
                this.inp_BienXe.Enabled = false;
                this.cb_LoaiXe.Enabled = false;
                this.cb_ChuXe.Enabled = false;
                this.inpt_mota.Enabled = false;
            }
        }

        private void btn_lay_Click(object sender, EventArgs e)
        {
            int idVe = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());
            var veXe = veXes.FindByID(idVe);
            veXes.FindByID(idVe).DaLay = true;
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

            DateTime nGui = this.dt_ngayGui.Value;
            foreach (var ve in veXes.ToList())
            {
                if (!ve.NgayGui.Date.Equals(nGui.Date))
                {
                    veXes.Rows.Remove(ve);
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
    }
}