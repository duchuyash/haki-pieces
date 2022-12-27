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
    public partial class frm_QLKhoHang : Form
    {
        BUS_SanPham list = new BUS_SanPham();

        List<DTO_SanPham> lst_SP = new List<DTO_SanPham>();

        public frm_QLKhoHang()
        {
            InitializeComponent();
            lst_SP = list.DSSanPham();

            foreach (var sp in lst_SP)
            {
                ils_Nuoc.Images.Add(sp.MaSP, Image.FromFile(sp.HinhAnh));
                ListViewItem item = new ListViewItem(sp.TenSP, sp.MaSP);
                item.SubItems.Add(sp.MaSP);
                item.SubItems.Add("Hãng SX: " + sp.HangSX);
                item.SubItems.Add("Mô tả: " + sp.MoTa);
                item.SubItems.Add("HSD: " + sp.HSD.ToString());
                item.SubItems.Add("Đơn giá: " + sp.DonGiaBan.ToString());
                item.SubItems.Add("SL tồn: " + sp.SoLuongTon.ToString());
                lvw_DSSP.Items.Add(item);
            }
        }
        
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dvw_CTNhapKho.Rows.Clear();
            lbl_SumMH.Text = lbl_SumGia.Text = "0";

            btn_LoadYeuCau.Visible = true;
        }

        private void btn_VaoKho_Click(object sender, EventArgs e)
        {
            if (dvw_CTNhapKho.Rows.Count != 0)
            {
                List<DTO_NhapKho> nhapkho = new List<DTO_NhapKho>();
                foreach (DataGridViewRow r in (dvw_CTNhapKho.Rows))
                {
                    DTO_NhapKho sp = new DTO_NhapKho
                    {
                        TenTK = frm_Main.tentk,
                        MaSP = dvw_CTNhapKho.Rows[r.Index].Cells[0].Value.ToString(),
                        SoLuong = int.Parse(dvw_CTNhapKho.Rows[r.Index].Cells[2].Value.ToString()),
                        DonGiaNhap = decimal.Parse(dvw_CTNhapKho.Rows[r.Index].Cells[5].Value.ToString())
                    };

                    nhapkho.Add(sp);
                }
                new BUS_NhapKho().NhapKho(nhapkho);

                MessageBox.Show("Số lượng sản phẩm được cập nhật");
                btn_Delete_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Chưa có phiên nhập kho nào");
            }
        }

        private void dvw_CTNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvw_CTNhapKho.SelectedRows.Count != 0)
            {
                int count = int.Parse(dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (e.ColumnIndex == 3)
                {
                    dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value = count + 1;
                    return;
                }
                if (e.ColumnIndex == 4)
                {
                    if (count == 1)
                    {
                        dvw_CTNhapKho.Rows.RemoveAt(e.RowIndex);
                        if (dvw_CTNhapKho.Rows.Count == 0)
                            lbl_SumGia.Text = lbl_SumMH.Text = "0";

                        return;
                    }

                    dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value = int.Parse(dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value.ToString()) - 1;
                    return;
                }

            }
        }

        private void dvw_CTNhapKho_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value == null 
                || int.Parse(dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value.ToString()) < 1 || int.Parse(dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value.ToString()) > 1000)
                dvw_CTNhapKho.Rows[e.RowIndex].Cells[2].Value = 10;

          if (dvw_CTNhapKho.Rows[e.RowIndex].Cells[5].Value == null ||
                int.Parse(dvw_CTNhapKho.Rows[e.RowIndex].Cells[5].Value.ToString()) < 1000)
                dvw_CTNhapKho.Rows[e.RowIndex].Cells[5].Value = 1000;


            int summh = dvw_CTNhapKho.Rows.Count;
            double sumgia = dvw_CTNhapKho.Rows.Count;
            foreach (DataGridViewRow r in dvw_CTNhapKho.Rows)
                sumgia += double.Parse(dvw_CTNhapKho.Rows[r.Index].Cells[5].Value.ToString());

            lbl_SumMH.Text = summh.ToString();
            lbl_SumGia.Text = sumgia.ToString();

        }

        private void frm_QLKhoHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_VaoKho_Click(sender, e);
        }

        private void dvw_CTNhapKho_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(KeyPress);
            if (dvw_CTNhapKho.CurrentCell.ColumnIndex == 2 || (dvw_CTNhapKho.CurrentCell.ColumnIndex == 5))
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

        private void btn_LoadYeuCau_Click(object sender, EventArgs e)
        {
            if (new BUS_YeuCau().DSYeuCau().Select(u => u.MaYC).Distinct().Count() == 0)
            {
                MessageBox.Show("Không có yêu cầu nào");
                return;
            }

            int mayc = new BUS_YeuCau().DSYeuCau().Select(u => u.MaYC).Distinct().First();

            List<DTO_YeuCau> yeuCaus = new BUS_YeuCau().DSYeuCau().Where(u=>u.MaYC==mayc).ToList();

            foreach (var r in yeuCaus)
            {
                Object[] row = new Object[]
                {
                    r.MaSP,
                    r.TenSP,
                    r.SLYeuCau,
                    Image.FromFile(@"D:\HK4\Do an\Winform\icon\them.png"),
                    Image.FromFile(@"D:\HK4\Do an\Winform\icon\bot.png"),
                    r.DonGia,
                };
                dvw_CTNhapKho.Rows.Add(row);
                btn_VaoKho_Click(sender, e);
                new BUS_YeuCau().Xoa(mayc);
            }
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            frm_ThemSP form = new frm_ThemSP();
            form.TopMost = true;
            form.Show();
            form.Check += ThemSP;
        }

        private void ThemSP(bool check)
        {
            lvw_DSSP.Items.Clear();
            lst_SP = new BUS_SanPham().DSSanPham();
            ils_Nuoc.Images.Clear();
            foreach (var sp in lst_SP)
            {
                ils_Nuoc.Images.Add(sp.MaSP, Image.FromFile(sp.HinhAnh));
                ListViewItem item = new ListViewItem(sp.TenSP, sp.MaSP);
                item.SubItems.Add(sp.MaSP);
                item.SubItems.Add("Hãng SX: " + sp.HangSX);
                item.SubItems.Add("Mô tả: " + sp.MoTa);
                item.SubItems.Add("HSD: " + sp.HSD.ToString());
                item.SubItems.Add("Đơn giá: " + sp.DonGiaBan.ToString());
                item.SubItems.Add("SL tồn: " + sp.SoLuongTon.ToString());
                lvw_DSSP.Items.Add(item);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            lvw_DSSP.Items.Clear();
            lst_SP = list.TimKiem(txt_TimKiem.Text);

            foreach (var sp in lst_SP)
            {
                ListViewItem item = new ListViewItem(sp.TenSP, sp.MaSP);
                item.SubItems.Add(sp.MaSP);
                item.SubItems.Add("Hãng SX: " + sp.HangSX);
                item.SubItems.Add("Mô tả: " + sp.MoTa);
                item.SubItems.Add("HSD: " + sp.HSD.ToString());
                item.SubItems.Add("Đơn giá: " + sp.DonGiaBan.ToString());
                item.SubItems.Add("SL tồn: " + sp.SoLuongTon.ToString());
                lvw_DSSP.Items.Add(item);
            }
        }

        private void lvw_DSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_DSSP.SelectedItems.Count != 0)
            {
                foreach (DataGridViewRow r in dvw_CTNhapKho.Rows)
                {
                    if (r.Cells[0].Value == lvw_DSSP.SelectedItems[0].SubItems[1].Text)
                    {
                        int count = int.Parse(dvw_CTNhapKho.Rows[r.Index].Cells[2].Value.ToString());
                        dvw_CTNhapKho.Rows[r.Index].Cells[2].Value = count + 10;
                        lvw_DSSP.SelectedItems.Clear();
                        return;
                    }

                }
                Object[] row = new Object[]
                {
                    lvw_DSSP.SelectedItems[0].SubItems[1].Text,
                    lvw_DSSP.SelectedItems[0].Text,
                    10,
                    Image.FromFile(@"D:\HK4\Do an\Winform\icon\them.png"),
                    Image.FromFile(@"D:\HK4\Do an\Winform\icon\bot.png"),
                    decimal.Parse(lvw_DSSP.SelectedItems[0].SubItems[5].Text.Substring(8)),
                };

                dvw_CTNhapKho.Rows.Add(row);
            }
            lvw_DSSP.SelectedItems.Clear();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = string.Empty;
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            pic_TimKiem.Enabled = true;
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            pic_TimKiem.Enabled = false;
        }
    }
    
}
