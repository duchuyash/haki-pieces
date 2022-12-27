using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace HaKi_Piece
{
    public partial class frm_LapHoaDon : Form
    {
        frm_XemSanPham form1 = new frm_XemSanPham();
        frm_LapPhieuHen form2;
        frm_ThanhToan form3;

        DTO_ThanhVien thanhvien;
        DTO_PhieuHen phieuhen;

        public frm_LapHoaDon()
        {
            form1.MdiParent = frm_LapHoaDon.ActiveForm;

            InitializeComponent();
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            pnl_SanPham.Controls.Add(form1);
            form1.btn_YeuCau.Visible = false;

            form1.Select += ChonSanPham;

            form1.Show();
        }

        private void ChonSanPham(DTO_SanPham select)
        {
            foreach (DataGridViewRow r in dvw_CTHoaDon.Rows)
            {
                if (r.Cells[0].Value == select.MaSP)
                {
                    int count = int.Parse(dvw_CTHoaDon.Rows[r.Index].Cells[2].Value.ToString());
                    dvw_CTHoaDon.Rows[r.Index].Cells[2].Value = count + 1;
                    return;
                }

            }

            Object[] row = new Object[]
            {
                select.MaSP,
                select.TenSP,
                1,
                Image.FromFile(@"D:\HK4\Do an\Winform\icon\them.png"),
                Image.FromFile(@"D:\HK4\Do an\Winform\icon\bot.png"),
                select.DonGiaBan,
                0,
                select.DonGiaBan
            };

            dvw_CTHoaDon.Rows.Add(row);

          
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dvw_CTHoaDon.Rows.Clear();
            lbl_Sum.Text = lbl_Tra.Text = "0";

            pic_PhieuHen.Visible = false;
            btn_ThemPhieuHen.Visible = true;
            phieuhen = null;
        }


        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (dvw_CTHoaDon.Rows.Count != 0)
            {
                form3 = new frm_ThanhToan();
                foreach (DataGridViewRow r in dvw_CTHoaDon.Rows)
                {
                    DTO_CT_HoaDon ct = new DTO_CT_HoaDon
                    {
                        MaSP = dvw_CTHoaDon.Rows[r.Index].Cells[0].Value.ToString(),
                        SoLuong = int.Parse(dvw_CTHoaDon.Rows[r.Index].Cells[2].Value.ToString()),
                        DonGia = decimal.Parse(dvw_CTHoaDon.Rows[r.Index].Cells[5].Value.ToString()),
                        GiamGia = decimal.Parse(dvw_CTHoaDon.Rows[r.Index].Cells[6].Value.ToString())
                    };

                    if (!new BUS_SanPham().KiemTraSL(ct.MaSP, ct.SoLuong))
                    {
                        if (phieuhen == null)
                        {
                            DialogResult x = MessageBox.Show("Số lượng không đủ, phải lập phiếu hẹn", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (x == DialogResult.Yes)
                            {
                                btn_ThemPhieuHen_Click(sender, e);
                            }
                            else
                            {
                                dvw_CTHoaDon.Rows.Remove(r);
                                continue;
                            }
                        }
                    }
                    form3.list.Add(ct);
                }
                form3.thanhvien = thanhvien;
                form3.phieuhen = phieuhen;
                form3.lbl_TongTienPhaiTra.Text = lbl_Tra.Text;
                form3.Check += HoanThanh;
                form3.TopMost = true;
                form3.Show();
            }
            else
            {
                MessageBox.Show("Chưa có phiên thêm hóa đơn nào");
            }

        }
        private void HoanThanh(bool check)
        {
            dvw_CTHoaDon.Rows.Clear();
            lbl_Sum.Text = lbl_Tra.Text = lbl_Giam.Text = "0";
            pic_PhieuHen.Visible = false;
            btn_ThemPhieuHen.Visible = true;
        }

        private void btn_ThemPhieuHen_Click(object sender, EventArgs e)
        {
            if (dvw_CTHoaDon.Rows.Count != 0)
            {
                form2 = new frm_LapPhieuHen();
                form2.TopMost = true;
                form2.PhieuHen += ThemPhieuHen;
                form2.ThanhVien += ThemThanhVien;
                form2.Show();
                btn_ThemPhieuHen.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng lập hóa đơn trước");
            }
        }

        private void ThemThanhVien(DTO_ThanhVien tv)
        {
            thanhvien = tv;
        }

        private void ThemPhieuHen(DTO_PhieuHen ph)
        {
            phieuhen = ph;
            if (phieuhen != null)
            {
                pic_PhieuHen.Visible = true;
                btn_ThemPhieuHen.Visible = false;
            }
            else
            {
                pic_PhieuHen.Visible = false;
                btn_ThemPhieuHen.Visible = true;
            }

        }

        private void dvw_CTHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvw_CTHoaDon.SelectedRows.Count != 0)
            {
                int count = int.Parse(dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (e.ColumnIndex == 3)
                {
                    dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value = count + 1;
                    return;
                }
                if (e.ColumnIndex == 4)
                {
                    if (count == 1)
                    {
                        dvw_CTHoaDon.Rows.RemoveAt(e.RowIndex);
                        if (dvw_CTHoaDon.Rows.Count == 0)
                            lbl_Sum.Text = lbl_Tra.Text = "0";

                        return;
                    }

                    dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value = int.Parse(dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString()) - 1;
                    return;
                }

            }
           
        }

        private void dvw_CTHoaDon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value == null
                || int.Parse(dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString()) < 1)
                dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value = 1;

            foreach (DataGridViewRow r in dvw_CTHoaDon.Rows)
            {
                DTO_KhuyenMai khuyenMai = new BUS_KhuyenMai().SPKhuyenMai(r.Cells[0].Value.ToString());

                if (khuyenMai != null && khuyenMai.SLToiThieu <= int.Parse(r.Cells[2].Value.ToString()))
                    r.Cells[6].Value = 
                        (int.Parse(r.Cells[2].Value.ToString()) / khuyenMai.SLToiThieu) *
                        (khuyenMai.PhanTram ? khuyenMai.GiaBan * khuyenMai.Giam / 100 : khuyenMai.Giam);
            }

            dvw_CTHoaDon.Rows[e.RowIndex].Cells[7].Value =
                  double.Parse(dvw_CTHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString())
                  * int.Parse(dvw_CTHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());

            double sum = 0;

            foreach (DataGridViewRow r in dvw_CTHoaDon.Rows)
                sum += double.Parse(dvw_CTHoaDon.Rows[r.Index].Cells[7].Value.ToString());
         
            lbl_Sum.Text = sum.ToString();
            sum = 0;

            foreach (DataGridViewRow r in dvw_CTHoaDon.Rows)
                sum += double.Parse(dvw_CTHoaDon.Rows[r.Index].Cells[6].Value.ToString());

            lbl_Giam.Text = sum.ToString();

            lbl_Tra.Text = (double.Parse(lbl_Sum.Text) - double.Parse(lbl_Giam.Text)).ToString();
        }

        private void pic_PhieuHen_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void frm_LapHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ThanhToan_Click(sender, e);
        }

        private void dvw_CTHoaDon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(KeyPress);
            if (dvw_CTHoaDon.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(KeyPress);
                }
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
