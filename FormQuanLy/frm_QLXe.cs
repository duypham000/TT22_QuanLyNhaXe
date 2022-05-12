using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_QLXe : Form
    {
        private QLNXDataSet.VeXeDataTable veXes = null;
        private QLNXDataSet.XeDataTable xes = null;
        private QLNXDataSet.KhachHangDataTable khachHangs = null;

        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeAdapter = null;
        private QLNXDataSetTableAdapters.XeTableAdapter xeAdapter = null;
        private QLNXDataSetTableAdapters.KhachHangTableAdapter khachHangAdapter = null;

        public frm_QLXe()
        {
            InitializeComponent();

            veXeAdapter = new QLNXDataSetTableAdapters.VeXeTableAdapter();
            xeAdapter = new QLNXDataSetTableAdapters.XeTableAdapter();
            khachHangAdapter = new QLNXDataSetTableAdapters.KhachHangTableAdapter();

            veXes = new QLNXDataSet.VeXeDataTable();
            xes = new QLNXDataSet.XeDataTable();
            khachHangs = new QLNXDataSet.KhachHangDataTable();

            veXeAdapter.Fill(veXes);
            xeAdapter.Fill(xes);
            khachHangAdapter.Fill(khachHangs);
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

        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNXDataSet.VeXe' table. You can move, or remove it, as needed.
            this.veXeTableAdapter.Fill(this.qLNXDataSet.VeXe);
            dienChuXe();
            hienThiDuLieu();

            this.cb_timTheo.SelectedIndex = 0;
            this.filter_loaiXe.SelectedIndex = 0;
            this.filter_tt.SelectedIndex = 0;
        }

        private void hienThiDuLieu()
        {
            this.dtgv_hienThi.Rows.Clear();
            string tt, chuXe;
            foreach (var xe in xes)
            {
                if (xe.DangDeXe)
                {
                    tt = "Đang để xe";
                }
                else
                {
                    tt = "Không trong nhà xe";
                }
                var khach = khachHangs.FindByID(xe.IDChuXe);
                chuXe = khach.TenKH;

                this.dtgv_hienThi.Rows.Add(xe.ID, xe.BienXe, xe.LoaiXe, chuXe, xe.MoTaXe, tt);
            }
        }

        private void dtgv_hienThi_Click(object sender, EventArgs e)
        {
            if (this.dtgv_hienThi.Rows.Count > 0)
            {
                int idXe = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());
                this.idXeHienTai = idXe;
                var xe = xes.FindByID(idXe);
                var khach = khachHangs.FindByID(xe.IDChuXe);

                this.inp_BienXe.Text = xe.BienXe;
                this.cb_LoaiXe.Text = xe.LoaiXe;
                this.cb_ChuXe.Text = khach.TenKH;
                this.inpt_mota.Text = xe.MoTaXe;

                if (xe.DangDeXe)
                {
                    this.cb_tt.SelectedIndex = 0;
                }
                else
                {
                    this.cb_tt.SelectedIndex = 1;
                }
            }
        }

        private void locDL(object sender, EventArgs e)
        {
            xeAdapter.Fill(xes);

            switch (this.filter_loaiXe.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    foreach (var xe in xes.ToList())
                    {
                        if (!xe.LoaiXe.Equals("Xe đạp"))
                        {
                            xes.Rows.Remove(xe);
                        }
                    }
                    break;

                case 2:
                    foreach (var xe in xes.ToList())
                    {
                        if (!xe.LoaiXe.Equals("Xe máy"))
                        {
                            xes.Rows.Remove(xe);
                        }
                    }
                    break;

                case 3:
                    foreach (var xe in xes.ToList())
                    {
                        if (!xe.LoaiXe.Equals("Ô tô"))
                        {
                            xes.Rows.Remove(xe);
                        }
                    }
                    break;

                default:
                    break;
            }

            switch (this.filter_tt.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    foreach (var xe in xes.ToList())
                    {
                        if (!xe.DangDeXe)
                        {
                            xes.Rows.Remove(xe);
                        }
                    }
                    break;

                case 2:
                    foreach (var xe in xes.ToList())
                    {
                        if (xe.DangDeXe)
                        {
                            xes.Rows.Remove(xe);
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
                    foreach (var xe in xes.ToList())
                    {
                        if (!xe.BienXe.Contains(timKiem))
                        {
                            this.xes.Rows.Remove(xe);
                        }
                    }
                    break;

                case 1:
                    foreach (var xe in xes.ToList())
                    {
                        var khach = khachHangs.FindByID(xe.IDChuXe);

                        if (!khach.TenKH.Contains(timKiem))
                        {
                            this.xes.Rows.Remove(xe);
                        }
                    }
                    break;

                case 2:
                    foreach (var xe in xes.ToList())
                    {
                        if (!xe.MoTaXe.Contains(timKiem))
                        {
                            this.xes.Rows.Remove(xe);
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
            string bien = this.inp_BienXe.Text;
            string loai = this.cb_LoaiXe.Text;
            int vt = this.cb_ChuXe.SelectedIndex - 1;
            int idChu = int.Parse(khachHangs.Rows[vt].ItemArray[0].ToString());
            string moTa = this.inpt_mota.Text;
            int tt = this.cb_tt.SelectedIndex;
            bool dangDeXe = false;

            if (tt == 0)
            {
                dangDeXe = true;
            }

            foreach (var xe in xes)
            {
                if (xe.BienXe.Equals(bien) && xe.IDChuXe == idChu)
                {
                    MessageBox.Show("Xe đã tồn tại");
                    return;
                }
            }

            xeAdapter.Insert(bien, idChu, loai, moTa, dangDeXe);
        }

        private int idXeHienTai = -1;

        private void btn_sua_Click(object sender, EventArgs e)
        {
            xeAdapter.Fill(xes);

            string bien = this.inp_BienXe.Text;
            string loai = this.cb_LoaiXe.Text;
            int vt = this.cb_ChuXe.SelectedIndex - 1;
            int idChu = int.Parse(khachHangs.Rows[vt].ItemArray[0].ToString());
            string moTa = this.inpt_mota.Text;
            int tt = this.cb_tt.SelectedIndex;
            bool dangDeXe = false;

            if (tt == 0)
            {
                dangDeXe = true;
            }

            xes.FindByID(idXeHienTai).BienXe = bien;
            xes.FindByID(idXeHienTai).LoaiXe = loai;
            xes.FindByID(idXeHienTai).IDChuXe = idChu;
            xes.FindByID(idXeHienTai).MoTaXe = moTa;
            xes.FindByID(idXeHienTai).DangDeXe = dangDeXe;

            xeAdapter.Update(xes);
            locDL(null, null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (idXeHienTai != -1)
            {
                xeAdapter.Fill(xes);
                var xe = xes.FindByID(idXeHienTai);

                foreach (var ve in veXes)
                {
                    if (ve.IDXe == idXeHienTai)
                    {
                        MessageBox.Show("Vui lòng xóa những vé xe liên quan đến xe này!");
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa xe", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    xeAdapter.Delete(xe.ID, xe.BienXe, xe.IDChuXe, xe.LoaiXe, xe.MoTaXe, xe.DangDeXe);
                    xeAdapter.Fill(xes);
                    locDL(null, null);
                }
            }
        }
    }
}