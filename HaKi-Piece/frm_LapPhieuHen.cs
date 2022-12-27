using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace HaKi_Piece
{
    public delegate void Sent_ThanhVien(DTO_ThanhVien tv);
    public delegate void Sent_PhieuHen(DTO_PhieuHen ph);

    public partial class frm_LapPhieuHen : Form
    {
        public event Sent_ThanhVien ThanhVien;
        public event Sent_PhieuHen PhieuHen;

        BUS_ThanhVien list = new BUS_ThanhVien();
        BUS_HoaDon hd = new BUS_HoaDon();

        public frm_LapPhieuHen()
        {
            InitializeComponent();
            dvw_DSTV.AutoGenerateColumns = false;
            dvw_DSTV.DataSource = list.DSThanhVien();
            dtp_NgayGiao.MinDate = DateTime.Now;
        }

        private void dvw_DSTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvw_DSTV.SelectedRows.Count != 0)
            {
                txt_MaTV.Text = dvw_DSTV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenKH.Text = dvw_DSTV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_DiaChi.Text = dvw_DSTV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_SDT.Text = dvw_DSTV.Rows[e.RowIndex].Cells[3].Value.ToString();

                txt_MaTV.Enabled = txt_TenKH.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = false;
            }
        }

        private void btn_ThenTV_Click(object sender, EventArgs e)
        {
            txt_MaTV.Text = (list.DSThanhVien().Count+1).ToString();

            txt_TenKH.Text = txt_DiaChi.Text = txt_SDT.Text = string.Empty;
            txt_TenKH.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = true;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dvw_DSTV.DataSource = null;
            dvw_DSTV.DataSource = list.TimKiem(txt_TimKiem.Text);
        }

        private void txt_TenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            pic_TimKiem.Enabled = true;
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            pic_TimKiem.Enabled = false;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = string.Empty;
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_TenKH.Text) || string.IsNullOrEmpty(txt_MaTV.Text) ||
                string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_DCGiaoHang.Text))

                MessageBox.Show("Vui lòng nhập đủ thông tin");
            else
            {
                DTO_ThanhVien thanhvien;
                DTO_PhieuHen phieuhen;

                thanhvien = new DTO_ThanhVien
                {
                    MaTV = int.Parse(txt_MaTV.Text),
                    TenKH = txt_TenKH.Text,
                    SDT = txt_SDT.Text,
                    DiaChi = txt_DiaChi.Text
                };

                if (!list.KT_TonTai(txt_MaTV.Text))
                {
                    this.ThanhVien(thanhvien);
                }
                phieuhen = new DTO_PhieuHen
                {
                    MaTV = int.Parse(txt_MaTV.Text),
                    DiaChiGiao = txt_DCGiaoHang.Text,
                    NgayHen = dtp_NgayGiao.Value
                };

                this.PhieuHen(phieuhen);
                
                this.Hide();
            }
        }

        private void btn_HuyPhieuHen_Click(object sender, EventArgs e)
        {
            this.ThanhVien(null);
            this.PhieuHen(null);
            this.Hide();
        }
    }
}
