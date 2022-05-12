using System;
using System.Windows.Forms;
using TT22_QuanLyNhaXe.FormDangNhap;
using TT22_QuanLyNhaXe.FormQuanLy;

namespace TT22_QuanLyNhaXe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dang_nhap:
            Application.Run(new frm_DangNhap());
            if (!Properties.Settings.Default.DangNhap)
                goto thoat;

            Application.Run(new layout_ManHinhChinh());
            if (!Properties.Settings.Default.DangNhap)
                goto dang_nhap;

            thoat:
            Properties.Settings.Default.DangNhap = false;
            Properties.Settings.Default.Save();
        }
    }
}