using BUS;
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
    public partial class frm_XemHoaDon : Form
    {
        BUS_CT_HoaDon chitiets = new BUS_CT_HoaDon();
        BUS_HoaDon hoadons = new BUS_HoaDon();
        frm_CTPhieuHen frm = new frm_CTPhieuHen();

        public frm_XemHoaDon()
        {
            InitializeComponent();
            dvw_DSHD.AutoGenerateColumns = false;
            dvw_CTHoaDon.AutoGenerateColumns = false;

            lbl_MaHD.Text = string.Empty;
            dvw_DSHD.DataSource = hoadons.DSHoaDonNgay(cld_NgayLapHD.SelectedDate.Value);

        }

        private void dvw_DSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dvw_CTHoaDon.Rows.Clear();

            lbl_MaHD.Text = dvw_DSHD.SelectedRows[0].Cells[0].Value.ToString();

            foreach (var ct in chitiets.DSCT_TheoHD(lbl_MaHD.Text))
            {
                Object[] row = new Object[]
                {
                    ct.MaSP,
                    ct.TenSP,
                    ct.SoLuong,
                    ct.DonGia,
                    ct.GiamGia,
                };
               
                dvw_CTHoaDon.Rows.Add(row);
            }
            if (bool.Parse(dvw_DSHD.SelectedRows[0].Cells[2].Value.ToString()))
                pic_PhieuHen.Visible = true;
            else
                pic_PhieuHen.Visible = false;
        }

        private void pic_PhieuHen_Click(object sender, EventArgs e)
        {
            frm.TopMost = true;

            DTO_PhieuHen phieuhen = new BUS_PhieuHen().PhieuHenHD(int.Parse(lbl_MaHD.Text));
            frm.lbl_MaPH.Text = phieuhen.MaPH.ToString();
            frm.lbl_DCGiaoHang.Text = phieuhen.DiaChiGiao;
            frm.lbl_NgayGiao.Text = phieuhen.NgayHen.ToString("dd/MM/yyyy");
            frm.lbl_TrangThai.Text = phieuhen.TrangThai ? "Đã giao hàng" : "Chưa giao hàng";
            frm.ShowDialog();
        }

        private void cld_NgayLapHD_SelectionChanged(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            dvw_CTHoaDon.Rows.Clear();
            lbl_MaHD.Text = string.Empty;

            dvw_DSHD.DataSource = null;
            dvw_DSHD.DataSource = hoadons.DSHoaDonNgay(cld_NgayLapHD.SelectedDate.Value);
        }
    }
}
