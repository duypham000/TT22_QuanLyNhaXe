using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_QLKhach : Form
    {
        private QLNXDataSet.KhachHangDataTable khachs = null;
        private QLNXDataSet.XeDataTable xes = null;

        private QLNXDataSetTableAdapters.KhachHangTableAdapter khachAdapter = null;
        private QLNXDataSetTableAdapters.XeTableAdapter xeAdapter = null;
        public frm_QLKhach()
        {
            InitializeComponent();
            khachAdapter = new QLNXDataSetTableAdapters.KhachHangTableAdapter();
            xeAdapter = new QLNXDataSetTableAdapters.XeTableAdapter();

            xes = new QLNXDataSet.XeDataTable();
            khachs = new QLNXDataSet.KhachHangDataTable();

            xeAdapter.Fill(xes);
            khachAdapter.Fill(khachs);
        }


        private void layout_ManHinhChinh_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();

            this.cb_timTheo.SelectedIndex = 0;
        }

        private void hienThiDuLieu()
        {
            this.dtgv_hienThi.Rows.Clear();
            string tt;
            foreach (var khach in khachs)
            {
                this.dtgv_hienThi.Rows.Add(khach.ID, khach.TenKH, khach.DiaChi, khach.SDT);
            }
        }

        private void dtgv_hienThi_Click(object sender, EventArgs e)
        {
            if (this.dtgv_hienThi.Rows.Count > 0)
            {
                int id = int.Parse(this.dtgv_hienThi.SelectedRows[0].Cells[0].Value.ToString());
                this.idHienTai = id;

                var khach = khachs.FindByID(id);

                this.inp_ten.Text = khach.TenKH;
                this.inp_diachi.Text = khach.DiaChi;
                this.inp_sdt.Text = khach.SDT;
            }
        }

        private void locDL(object sender, EventArgs e)
        {
            khachAdapter.Fill(khachs);

            string timKiem = this.inpt_timKiem.Text;
            switch (this.cb_timTheo.SelectedIndex)
            {
                case 0:
                    foreach (var khach in khachs.ToList())
                    {
                        if (!khach.TenKH.Contains(timKiem))
                        {
                            this.khachs.Rows.Remove(khach);
                        }
                    }
                    break;

                case 1:
                    foreach (var khach in khachs.ToList())
                    {
                        if (!khach.DiaChi.Contains(timKiem))
                        {
                            this.khachs.Rows.Remove(khach);
                        }
                    }
                    break;

                case 2:
                    foreach (var khach in khachs.ToList())
                    {
                        if (!khach.SDT.Contains(timKiem))
                        {
                            this.khachs.Rows.Remove(khach);
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
            string tenKhach = this.inp_ten.Text;
            string diaChi = this.inp_diachi.Text;
            string sdt = this.inp_sdt.Text;

            khachAdapter.Insert(tenKhach, sdt, diaChi);

        }

        private int idHienTai = -1;

        private void btn_sua_Click(object sender, EventArgs e)
        {
            khachAdapter.Fill(khachs);

            string tenKhach = this.inp_ten.Text;
            string diaChi = this.inp_diachi.Text;
            string sdt = this.inp_sdt.Text;


            khachs.FindByID(idHienTai).TenKH = tenKhach;
            khachs.FindByID(idHienTai).DiaChi = diaChi;
            khachs.FindByID(idHienTai).SDT = sdt;

            khachAdapter.Update(khachs);

            locDL(null, null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (idHienTai != -1)
            {
                khachAdapter.Fill(khachs);
                var khach = khachs.FindByID(idHienTai);

                foreach (var xe in xes)
                {
                    if (xe.IDChuXe == khach.ID)
                    {
                        MessageBox.Show("Vui lòng xóa các xe của chủ xe này trước!");
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa khách", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    khachAdapter.Delete(khach.ID, khach.TenKH, khach.SDT, khach.DiaChi);
                    khachAdapter.Fill(khachs);
                    locDL(null, null);
                }
            }
        }
    }
}