using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TT22_QuanLyNhaXe.FormQuanLy
{
    public partial class frm_DoanhThu : Form
    {
        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeAdapter = null;
        private QLNXDataSet.VeXeDataTable veXes = null;

        public frm_DoanhThu()
        {
            InitializeComponent();
            veXeAdapter = new QLNXDataSetTableAdapters.VeXeTableAdapter();
            veXes = new QLNXDataSet.VeXeDataTable();
            veXeAdapter.Fill(veXes);
        }

        private void hienThiThongKe()
        {
            DateTime tu = this.dt_tu.Value;
            DateTime den = this.dt_den.Value;

            List<DateTime> shown = new List<DateTime>();

            this.dtgv_hienThi.Rows.Clear();

            foreach (var ve in veXes)
            {
                if (ve != null)
                {
                    if (ve.NgayGui.Date.CompareTo(tu.Date) >= 0 && ve.NgayGui.Date.CompareTo(den.Date) <= 0 && !shown.Contains(ve.NgayGui.Date))
                    {
                        int count = 1;
                        decimal total = ve.GiaVe;
                        foreach (var veXe in veXes)
                        {
                            if (veXe.NgayGui.Date.CompareTo(ve.NgayGui.Date) == 0)
                            {
                                count++;
                                total += veXe.GiaVe;
                            }
                        }
                        shown.Add(ve.NgayGui.Date);
                        this.dtgv_hienThi.Rows.Add(ve.NgayGui.Date.ToString("dd/MM/yyyy"), count, total);
                    }
                }
            }

            decimal tongTien = 0;
            for (int i = 0; i < this.dtgv_hienThi.RowCount; i++)
            {
                tongTien += decimal.Parse(this.dtgv_hienThi.Rows[i].Cells[2].Value.ToString());
            }

            this.tongTien.Text = tongTien.ToString();
        }

        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {
            hienThiThongKe();
        }

        private void dt_tu_ValueChanged(object sender, EventArgs e)
        {
            hienThiThongKe();
        }

        private void dt_den_ValueChanged(object sender, EventArgs e)
        {
            hienThiThongKe();
        }
    }
}