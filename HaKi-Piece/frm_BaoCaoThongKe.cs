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
    public partial class frm_BaoCaoThongKe : Form
    {

        public frm_BaoCaoThongKe()
        {
            InitializeComponent();

            dtp_Den.MinDate = dtp_Tu.Value;
        }

        private void tgg_DTBanHang_CheckedChanged(object sender, EventArgs e)
        {
            if (tgg_DTBanHang.Checked)
            {
                dtp_Ngay.Enabled = true;
                tbl_SuKien.Enabled = false;
                tgg_DTSuKien.Checked = tgg_ChamCong.Checked = false;
                dtp_Tu.Enabled = dtp_Den.Enabled = false;
            }   
            else
                dtp_Ngay.Enabled = false;
        }

        private void tgg_DTSuKien_CheckedChanged(object sender, EventArgs e)
        {
            if(tgg_DTSuKien.Checked)
            {
                tbl_SuKien.Enabled = true;
                tgg_DTBanHang.Checked = tgg_ChamCong.Checked = false;
            }
            else
            {
                tbl_SuKien.Enabled = false;
            }

        }

        private void tgg_ChamCong_CheckedChanged(object sender, EventArgs e)
        {
            if (tgg_ChamCong.Checked)
            {
                dtp_Ngay.Enabled = false;
                tgg_DTSuKien.Checked = tgg_DTBanHang.Checked = false;
                dtp_Tu.Enabled = dtp_Den.Enabled = false;
            }

        }

        private void rad_TatCaSuKien_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_TatCaSuKien.Checked)
            {
                dtp_Tu.Enabled = dtp_Den.Enabled = false;
            }
        }

        private void rad_Khoang_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Tu.Enabled = dtp_Den.Enabled = true;
        }


        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        { 
            if (tgg_DTBanHang.Checked)
            {
                BanHangNgay(dtp_Ngay.Value);
            }
            else if (tgg_DTSuKien.Checked)
            {

            }
            else if (tgg_ChamCong.Checked)
            {
                ChamCong();
            }
            else
                MessageBox.Show("Chưa chọn loại báo cáo");
        }

        public void BanHangNgay(DateTime ngay)
        {
            List<DTO_HoaDon> hoaDons = new BUS_HoaDon().DSHoaDonNgay(ngay);
            string sum = new BUS_CT_HoaDon().TongDT(ngay).ToString();
            rpv_XemBaoCao.LocalReport.DataSources.Clear();

            rpv_XemBaoCao.LocalReport.ReportEmbeddedResource = "HaKi_Piece.rpt_BanHangNgay.rdlc";
            rpv_XemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("HoaDon", hoaDons));
            rpv_XemBaoCao.LocalReport.SetParameters(new ReportParameter("pa_Ngay", ngay.ToString("dd/MM/yyyy")));
            rpv_XemBaoCao.LocalReport.SetParameters(new ReportParameter("pa_Tong", sum));
            rpv_XemBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing_DoanhThu);
            rpv_XemBaoCao.RefreshReport();
        }
        void LocalReport_SubreportProcessing_DoanhThu(object sender, SubreportProcessingEventArgs e)
        {
            int mahd = int.Parse(e.Parameters["pa_MaHD"].Values[0]);
            List<DTO_CT_HoaDon> cT_HoaDons = new BUS_CT_HoaDon().DSCT_TheoHD(mahd.ToString());

            e.DataSources.Add(new ReportDataSource("CT_HoaDon", cT_HoaDons));
        }


        public void ChamCong()
        {
            List<DTO_NhanVien> nhanViens = new BUS_NhanVien().DSNhanVien().Where(u => u.TrangThai == true).ToList();
            rpv_XemBaoCao.LocalReport.DataSources.Clear();

            rpv_XemBaoCao.LocalReport.ReportEmbeddedResource = "HaKi_Piece.rpt_ChamCong.rdlc";
            rpv_XemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("NhanVien", nhanViens));
            rpv_XemBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing_ChamCong);
            rpv_XemBaoCao.RefreshReport();

        }

        void LocalReport_SubreportProcessing_ChamCong(object sender, SubreportProcessingEventArgs e)
        {
            string manv= e.Parameters["pa_TenTK"].Values[0];
            List<DTO_CaLam> caLams = new BUS_CaLam().CaLam(manv);

            e.DataSources.Add(new ReportDataSource("CaLam", caLams));
        }
    }

}
