using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaKi_Piece
{
    public delegate void ThemSP(bool check);

    public partial class frm_ThemSP : Form
    {
        static int step = 1;
        BUS_SanPham sanPham = new BUS_SanPham();

        public event ThemSP Check;

        public frm_ThemSP()
        {
            InitializeComponent();
            pnl_HoanThanh.Width = pnl_Step2.Width = pnl_Step3.Width = pnl_Step3.Width = pnl_Step4.Width = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 2:
                    {
                        step = 1;
                        btn_Step1.ImageIndex = 1;
                        pnl_HoanThanh.Width = 0;

                        btn_Back.Visible = false;
                        btn_Next.Visible = true;

                        pnl_Step2.Width = 0;
                        pnl_Step2.Dock = DockStyle.Right;
                        pnl_Step1.Dock = DockStyle.Fill;

                        btn_Step2.ImageIndex = btn_Step3.ImageIndex = btn_Step4.ImageIndex = 0;

                    }
                    break;

                case 3:
                    {
                        step = 2;
                        btn_Step2.ImageIndex = 1;
                        pnl_HoanThanh.Width = 200;

                        btn_Back.Visible = btn_Next.Visible = true;

                        pnl_Step3.Width = 0;
                        pnl_Step3.Dock = DockStyle.Right;
                        pnl_Step2.Dock = DockStyle.Fill;

                        btn_Step3.ImageIndex = btn_Step4.ImageIndex = 0;

                    }
                    break;
                case 4:
                    {
                        step = 3;
                        btn_Step3.ImageIndex = 1;
                        pnl_HoanThanh.Width = 350;

                        btn_Back.Visible = btn_Next.Visible = true;

                        pnl_Step4.Width = 0;
                        pnl_Step4.Dock = DockStyle.Right;
                        pnl_Step3.Dock = DockStyle.Fill;

                        btn_Step4.ImageIndex = 0;

                    }
                    break;
            }

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 1:
                    {
                        if (string.IsNullOrEmpty(txt_MaSP.Text) || string.IsNullOrEmpty(txt_TenSP.Text) || string.IsNullOrEmpty(txt_HinhAnh.Text))
                        {
                            btn_Step1.ImageIndex = 3;
                            lbl_KiemTra.Visible = true;

                            if (string.IsNullOrEmpty(txt_MaSP.Text))
                                txt_MaSP.BorderColor = Color.Red;
                            if (string.IsNullOrEmpty(txt_TenSP.Text))
                                txt_TenSP.BorderColor = Color.Red;
                            if (string.IsNullOrEmpty(txt_HinhAnh.Text))
                                txt_HinhAnh.BorderColor = Color.Red;

                        }

                        else
                        {
                            btn_Step1.ImageIndex = 2;

                            step = 2;
                            btn_Step2.ImageIndex = 1;
                            pnl_HoanThanh.Width = 200;

                            pnl_Step1.Width = 0;
                            pnl_Step1.Dock = DockStyle.Right;
                            pnl_Step2.Dock = DockStyle.Fill;

                            btn_Back.Visible = btn_Next.Visible = true;

                        }
                    }
                    break;

                case 2:
                    {
                        btn_Step2.ImageIndex = 2;

                        step = 3;
                        btn_Step3.ImageIndex = 1;
                        pnl_HoanThanh.Width = 350;

                        pnl_Step2.Width = 0;
                        pnl_Step2.Dock = DockStyle.Right;
                        pnl_Step3.Dock = DockStyle.Fill;

                        btn_Back.Visible = btn_Next.Visible = true;
                    }
                    break;

                case 3:
                    {
                        btn_Step3.ImageIndex = 2;

                        step = 4;
                        btn_Step4.ImageIndex = 1;

                        pnl_HoanThanh.Width = 500;

                        pnl_Step3.Width = 0;
                        pnl_Step3.Dock = DockStyle.Right;
                        pnl_Step4.Dock = DockStyle.Fill;

                        
                        btn_Next.Visible = false;
                    }
                    break;

            }

        }

        private void btn_QpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            //vi tri open mac dinh
            ofdFile.InitialDirectory = @"D:\HK4\Do an\Winform\";
            //loc hinh anh
            ofdFile.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            ofdFile.FilterIndex = 2;
            ofdFile.RestoreDirectory = true;

            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ofdFile.OpenFile() != null)
                        txt_HinhAnh.Text = ofdFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }

                ofdFile.Dispose();
                System.GC.Collect();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            btn_Step4.ImageIndex = 2;

            DTO_SanPham sp = new DTO_SanPham
            {
                MaSP = txt_MaSP.Text,
                TenSP = txt_TenSP.Text,
                HinhAnh = @"D:\HK4\Do an\Winform\SanPham\" + txt_MaSP.Text + ".jpg",
                HSD = dtp_HSD.Value,
                DonGiaBan = num_DonGiaBan.Value,
                HangSX = string.IsNullOrEmpty(txt_HSX.Text) ? "none" : txt_HSX.Text,
                MoTa = string.IsNullOrEmpty(txt_MoTa.Text) ? "none" : txt_MoTa.Text,
            };

            using (MemoryStream memory = new MemoryStream())
            {
                using (var file = new FileStream(@"D:\HK4\Do an\Winform\SanPham\" + txt_MaSP.Text.ToUpper() + ".jpg", FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] image = ConvertToByteArray(Image.FromFile(txt_HinhAnh.Text));
                    file.Write(image, 0, image.Length);

                    file.Close();
                    file.Dispose();
                    System.GC.Collect();
                }
                memory.Close();
                memory.Dispose();
                System.GC.Collect();
            }

            if (sanPham.Them(sp))
            {
                MessageBox.Show("Sản phẩm đã được thêm vào danh sách");
                this.Check(true);
            }

            this.Close();
        }

        public byte[] ConvertToByteArray(Image img)
        {
            using (var ms = new MemoryStream())
            {
                //chuyen hinh anh thanh bitmap
                Bitmap bmp = new Bitmap(img);
                //luu bitmap thanh memory
                bmp.Save(ms, ImageFormat.Jpeg);

                ms.Close();
                ms.Dispose();
                System.GC.Collect();

                return ms.ToArray();
            }
        }
    }
}
