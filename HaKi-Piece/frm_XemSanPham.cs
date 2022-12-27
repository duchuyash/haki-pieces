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
using System.IO;

namespace HaKi_Piece
{
    public delegate void ChonSanPham(DTO_SanPham sp);

    public partial class frm_XemSanPham : Form
    {
        frm_CTSanPham frm;

        BUS_SanPham list = new BUS_SanPham();

        List<DTO_SanPham> lst_SP = new List<DTO_SanPham>();

        public event ChonSanPham Select;

        public frm_XemSanPham()
        {
            InitializeComponent();
            lst_SP = list.DSSanPham();

            foreach (var sp in lst_SP)
            {
                ils_Nuoc.Images.Add(sp.MaSP, Image.FromFile(sp.HinhAnh));
                ListViewItem item = new ListViewItem(sp.TenSP, sp.MaSP);
                item.SubItems.Add(sp.MaSP);
                item.SubItems.Add(sp.HangSX);
                item.SubItems.Add(sp.MoTa);
                item.SubItems.Add(sp.HSD.ToString());
                item.SubItems.Add(sp.DonGiaBan.ToString());
                item.SubItems.Add(sp.SoLuongTon.ToString());
                lvw_DSSP.Items.Add(item);
            }

        }
       
        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            pic_TimKiem.Enabled = true;
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            pic_TimKiem.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = string.Empty;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            lvw_DSSP.Items.Clear();
            lst_SP = list.TimKiem(txt_TimKiem.Text);

            foreach (var sp in lst_SP)
            {
                ListViewItem item = new ListViewItem(sp.TenSP, sp.MaSP);
                item.SubItems.Add(sp.MaSP);
                item.SubItems.Add(sp.HangSX);
                item.SubItems.Add(sp.MoTa);
                item.SubItems.Add(sp.HSD.ToString());
                item.SubItems.Add(sp.DonGiaBan.ToString());
                item.SubItems.Add(sp.SoLuongTon.ToString());
                lvw_DSSP.Items.Add(item);
            }
        }

        private void lvw_DSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_DSSP.SelectedItems.Count != 0)
            {
                DTO_SanPham sp = new DTO_SanPham()
                {
                    MaSP = lvw_DSSP.SelectedItems[0].SubItems[1].Text,
                    TenSP = lvw_DSSP.SelectedItems[0].Text,
                    HangSX = lvw_DSSP.SelectedItems[0].SubItems[2].Text,
                    MoTa = lvw_DSSP.SelectedItems[0].SubItems[3].Text,
                    HSD = DateTime.Parse(lvw_DSSP.SelectedItems[0].SubItems[4].Text),
                    DonGiaBan = decimal.Parse(lvw_DSSP.SelectedItems[0].SubItems[5].Text),
                    SoLuongTon= int.Parse(lvw_DSSP.SelectedItems[0].SubItems[6].Text)
                };

                lvw_DSSP.SelectedItems.Clear();

                if (this.ParentForm.Name == "frm_LapHoaDon")
                {
                    this.Select(sp);
                }

                else
                {
                    frm = new frm_CTSanPham();

                    this.ParentForm.TopMost = false;
                    frm.TopMost = true;
                    
                    frm.lbl_MaSP.Text = sp.MaSP;
                    frm.lbl_TenSP.Text = sp.TenSP;
                    frm.lbl_HSX.Text = sp.HangSX;
                    frm.lbl_MoTa.Text = sp.MoTa;
                    frm.lbl_HSD.Text = sp.HSD.ToString("dd/MM/yyyy");
                    frm.lbl_DonGiaBan.Text = sp.DonGiaBan.ToString();
                    frm.lbl_SLTon.Text = sp.SoLuongTon.ToString();

                    if (File.Exists(@"D:\HK4\Do an\Winform\SanPham\" + frm.lbl_MaSP.Text + ".jpg"))
                    {
                        //chuyen hinh thanh mang byte
                        byte[] image = File.ReadAllBytes(@"D:\HK4\Do an\Winform\SanPham\" + frm.lbl_MaSP.Text + ".jpg");
                        //chuyen byte[] thanh MemoryStream
                        MemoryStream data = new MemoryStream(image);
                        //tao Image tu MemoryStream
                        frm.pic_Image.Image = Image.FromStream(data);

                        data.Close();
                        data.Dispose();
                        System.GC.Collect();
                    }
                    else
                        frm.pic_Image.Image = null;
                    
                    frm.Show();
                }
            }

        }

        private void btn_YeuCau_Click(object sender, EventArgs e)
        {
            List<string> DSSP = list.DSSanPham().Where(u => u.SoLuongTon < 50).Select(u => u.MaSP).ToList();
            if (new BUS_YeuCau().YeuCau(DSSP))
                MessageBox.Show("Yêu cầu sẽ được lưu lại để xử lý");
            else
                MessageBox.Show("Sản phẩm tồn vẫn còn đủ");
        }
    }
}
