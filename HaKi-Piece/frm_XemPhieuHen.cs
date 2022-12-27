using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Input;
using DTO;

namespace HaKi_Piece
{
    public partial class frm_XemPhieuHen : Form
    {
        BUS_PhieuHen phs = new BUS_PhieuHen();
       
        public frm_XemPhieuHen()
        {
            InitializeComponent();
            dvw_DSPH.AutoGenerateColumns = false;
            dvw_DSPH.DataSource = phs.PhieuHenNgay(cld_NgayHen.SelectedDate.Value);
            NgayHen();
        }

        public void NgayHen()
        {
            List<SpecialDate> lichhen = new List<SpecialDate>();

            foreach (var hen in phs.DSPhieuHen().Where(u=>u.TrangThai==false).Select(u=>u.NgayHen.ToString("dd/MM/yyyy")).Distinct())
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

        private void cld_NgayHen_SelectionChanged(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            dvw_DSPH.DataSource = null;
            dvw_DSPH.DataSource = phs.PhieuHenNgay(cld_NgayHen.SelectedDate.Value);
        }

    }
}
