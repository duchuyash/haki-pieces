using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frm_InHoaDon : Form
    {
        public frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void frm_XemBaoCao_Load(object sender, EventArgs e)
        {
            //this.rpv_XemBaoCao.RefreshReport();
        }
        public void HoaDon(string mahd)
        {
            List<DTO_CT_HoaDon> list = new BUS_CT_HoaDon().DSCT_TheoHD(mahd);
            DTO_HoaDon hoaDon = new BUS_HoaDon().DSHoaDon().SingleOrDefault(u => u.MaHD == int.Parse(mahd));

            this.rpv_HoaDon.LocalReport.ReportEmbeddedResource = "HaKi_Piece.rpt_HoaDon.rdlc";
            this.rpv_HoaDon.LocalReport.DataSources.Add(new ReportDataSource("CT_HoaDon", list));
            this.rpv_HoaDon.LocalReport.SetParameters(new ReportParameter("pa_MaHD", hoaDon.MaHD.ToString()));
            this.rpv_HoaDon.LocalReport.SetParameters(new ReportParameter("pa_ThuNgan", hoaDon.ThuNgan));
            this.rpv_HoaDon.LocalReport.SetParameters(new ReportParameter("pa_NgayLapHD", hoaDon.NgayLapHD.ToString()));
            this.rpv_HoaDon.RefreshReport();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
