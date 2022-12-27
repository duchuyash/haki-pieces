using BUS;
using DTO;
using Syncfusion.WinForms.Input;
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
    public partial class frm_HTPhieuHen : Form
    {
        BUS_PhieuHen phs = new BUS_PhieuHen();
        frm_PhieuHen form2;

        public frm_HTPhieuHen()
        {
            InitializeComponent();
            dvw_DSPH.AutoGenerateColumns = false;
            dvw_DSPH.DataSource = phs.PhieuHenNgay(cld_NgayHen.SelectedDate.Value);
            NgayHen();
        }

        public void NgayHen()
        {
            List<SpecialDate> lichhen = new List<SpecialDate>();

            foreach (var hen in phs.DSPhieuHen().Where(u => u.TrangThai == false).Select(u => u.NgayHen.ToString("dd/MM/yyyy")).Distinct())
            {
                SpecialDate day = new SpecialDate();
                day.Value = DateTime.Parse(hen);
                day.BackColor = Color.White;
                day.Image = Image.FromFile(@"D:\HK4\Do an\Winform\icon\hen.png");
                day.ImageAlign = ContentAlignment.MiddleCenter;
                day.IsDateVisible = false;
                day.TextImageRelation = TextImageRelation.TextBeforeImage;
                lichhen.Add(day);
            }

            cld_NgayHen.SpecialDates = lichhen;
        }
       
        private void HoanThanhPH(bool check)
        {
            NgayHen();
            dvw_DSPH.DataSource = new BUS_PhieuHen().PhieuHenNgay(cld_NgayHen.SelectedDate.Value);
        }

        private void cld_NgayHen_SelectionChanged(SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            dvw_DSPH.DataSource = null;
            dvw_DSPH.DataSource = phs.PhieuHenNgay(cld_NgayHen.SelectedDate.Value);
        }

        private void dvw_DSPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvw_DSPH.SelectedRows.Count != 0)
            {
                form2 = new frm_PhieuHen();

                form2.maph = int.Parse(dvw_DSPH.SelectedRows[0].Cells[0].Value.ToString());
                form2.txt_MaTV.Text = dvw_DSPH.SelectedRows[0].Cells[4].Value.ToString();
                form2.txt_TenKH.Text = dvw_DSPH.SelectedRows[0].Cells[2].Value.ToString();
                form2.txt_DCGiaoHang.Text = dvw_DSPH.SelectedRows[0].Cells[3].Value.ToString();
                form2.dtp_NgayGiao.Value = cld_NgayHen.SelectedDate.Value;
                form2.dvw_CTHoaDon.DataSource = new BUS_CT_HoaDon().DSCT_TheoHD(dvw_DSPH.SelectedRows[0].Cells[1].Value.ToString());

                form2.TopMost = true;
                form2.Check += HoanThanhPH;
                form2.Show();
            }
        }
    }
}
