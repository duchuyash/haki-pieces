using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaKi_Piece
{
    public partial class frm_ThemSuKien : Form
    {

        frm_XemSanPham form = new frm_XemSanPham();
        public frm_ThemSuKien()
        {
            form.MdiParent = frm_ThemSuKien.ActiveForm;

            InitializeComponent();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_SanPham.Controls.Add(form);
            //form.Them += ThemPSuKien;
            form.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void ThemPSuKien(SanPham select)
        //{
        //    Object[] row = new Object[]
        //    {
        //        select.MaSP,
        //        select.Ten,
        //        select.GiaBan,
        //        Image.FromFile(@"D:\HK4\Do an\Winform\icon\them.png"),
        //        1,
        //        Image.FromFile(@"D:\HK4\Do an\Winform\icon\bot.png"),
        //        0,
        //        //false,
        //    };

        //    dvw_CTHoaDon.Rows.Add(row);
        //}
    }
}
