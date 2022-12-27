using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaKi_Piece
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_LoadApp());
            //Application.Run(new frm_Main());
            //Application.Run(new frm_LapHoaDon());
            //Application.Run(new frm_XemSanPham());
            //Application.Run(new frm_LapPhieuHen());
            //Application.Run(new frm_ThanhToan());
            //Application.Run(new frm_XemThanhVien());
            //Application.Run(new frm_CTThanhVien());
            //Application.Run(new frm_XemPhieuHen());
            //Application.Run(new frm_XemHoaDon());
            //Application.Run(new frm_XemSuKien());
            //Application.Run(new frm_QLSuKien());
            //Application.Run(new frm_QLKhoHang());
            //Application.Run(new frm_ThemSP());

        }
    }
}
