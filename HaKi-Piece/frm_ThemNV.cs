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
    public delegate void ThemNV(bool check);

    public partial class frm_ThemNV : Form
    {
        public int step = 1;
        BUS_NhanVien nhanVien = new BUS_NhanVien();
       
        public event ThemNV Check;

        public frm_ThemNV()
        {
            InitializeComponent();

            pnl_ThongTinTK.Width = pnl_Step2.Width = pnl_Step3.Width = pnl_Step4.Width = pnl_Step5.Width = pnl_Step6.Width = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 2:
                    {
                        step = 1;
                        btn_HoTen_SDT.ImageIndex = 1;
                        pnl_HoanThanh.Width = 80;

                        btn_Back.Visible = false;
                        btn_Next.Visible = true;

                        pnl_Step2.Width = 0;
                        pnl_Step2.Dock = DockStyle.Right;
                        pnl_Step1.Dock = DockStyle.Fill;

                        btn_CMND_DiaChi.ImageIndex = btn_HoanThanh1.ImageIndex = 0;

                    }
                    break;

                case 3:
                    {
                        step = 2;
                        btn_CMND_DiaChi.ImageIndex = 1;
                        pnl_HoanThanh.Width = 200;

                        btn_Back.Visible = btn_Next.Visible = true;

                        pnl_Step3.Width = 0;
                        pnl_Step3.Dock = DockStyle.Right;
                        pnl_Step2.Dock = DockStyle.Fill;

                        btn_HoanThanh1.ImageIndex = 0;

                    }
                    break;
                case 5:
                    {
                        step = 4;
                        btn_HinhAnh_ChucVu.ImageIndex = 1;
                        pnl_HoanThanh2.Width = 80;

                        btn_Back.Visible = btn_Next.Visible = true;

                        pnl_Step5.Width = 0;
                        pnl_Step5.Dock = DockStyle.Right;
                        pnl_Step4.Dock = DockStyle.Fill;

                        btn_HoanThanh2.ImageIndex = 0;

                    }
                    break;

                case 6:
                    {
                        step = 5;
                        btn_MatKhau_Email.ImageIndex = 1;
                        pnl_HoanThanh2.Width = 200;

                        btn_Back.Visible = btn_Next.Visible = true;

                        pnl_Step6.Width = 0;
                        pnl_Step6.Dock = DockStyle.Right;
                        pnl_Step5.Dock = DockStyle.Fill;

                        btn_HoanThanh2.ImageIndex = 0;

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
                        if (string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_SDT.Text) || txt_SDT.Text.Length < 10)
                        {
                            btn_HoTen_SDT.ImageIndex = 3;
                            lbl_KiemTra.Visible = true;

                            if (string.IsNullOrEmpty(txt_HoTen.Text))
                                txt_HoTen.BorderColor = Color.Red;
                            if (string.IsNullOrEmpty(txt_SDT.Text) || txt_SDT.Text.Length < 10)
                                txt_SDT.BorderColor = Color.Red;
                        }

                        else
                        {
                            btn_HoTen_SDT.ImageIndex = 2;

                            step = 2;
                            btn_CMND_DiaChi.ImageIndex = 1;
                            pnl_HoanThanh.Width = 200;

                            pnl_Step1.Width = 0;
                            pnl_Step1.Dock = DockStyle.Right;
                            pnl_Step2.Dock = DockStyle.Fill;

                            btn_Back.Visible = btn_Next.Visible = true;

                        }
                    } break;

                case 2:
                    {
                        if (string.IsNullOrEmpty(txt_CMND.Text) || string.IsNullOrEmpty(txt_DiaChi.Text))
                        {
                            btn_CMND_DiaChi.ImageIndex = 3;
                            lbl_KiemTra.Visible = true;

                            if (string.IsNullOrEmpty(txt_CMND.Text))
                                txt_CMND.BorderColor = Color.Red;
                            if (string.IsNullOrEmpty(txt_DiaChi.Text))
                                txt_DiaChi.BorderColor = Color.Red;
                        }

                        else
                        {
                            btn_CMND_DiaChi.ImageIndex = 2;

                            step = 3;
                            btn_HoanThanh1.ImageIndex = 1;
                            pnl_HoanThanh.Width = 600;

                            pnl_Step2.Width = 0;
                            pnl_Step2.Dock = DockStyle.Right;
                            pnl_Step3.Dock = DockStyle.Fill;

                            btn_Back.Visible = btn_Next.Visible = true;

                            btn_Next.Visible = false;
                        }
                    }
                    break;

                case 4:
                    {
                        if (string.IsNullOrEmpty(txt_HinhAnh.Text))
                        {
                            btn_HinhAnh_ChucVu.ImageIndex = 3;
                            lbl_KiemTra.Visible = true;

                            if (string.IsNullOrEmpty(txt_HinhAnh.Text))
                                txt_HinhAnh.BorderColor = Color.Red;
                        }

                        else
                        {
                            btn_HinhAnh_ChucVu.ImageIndex = 2;

                            step = 5;
                            pnl_HoanThanh2.Width = 200;

                            pnl_Step4.Width = 0;
                            pnl_Step4.Dock = DockStyle.Right;
                            pnl_Step5.Dock = DockStyle.Fill;
                            txt_MatKhau.Text = (rad_QuanLy.Checked ? "QL" : "BH") +(nhanVien.DSNhanVien().Count()+1).ToString("000");
                            btn_Back.Visible = btn_Next.Visible = true;

                        }
                    }
                    break;

                case 5:
                    {
                        if (string.IsNullOrEmpty(txt_Email.Text))
                        {
                            btn_MatKhau_Email.ImageIndex = 3;
                            lbl_KiemTra.Visible = true;

                            if (string.IsNullOrEmpty(txt_Email.Text))
                                txt_Email.BorderColor = Color.Red;

                        }

                        else
                        {
                            btn_MatKhau_Email.ImageIndex = 2;

                            step = 6;
                            btn_HoanThanh2.ImageIndex = 1;
                            pnl_HoanThanh2.Width = 600;

                            pnl_Step5.Width = 0;
                            pnl_Step5.Dock = DockStyle.Right;
                            pnl_Step6.Dock = DockStyle.Fill;

                            btn_Next.Visible = false;
                        }
                    }
                    break;

            } 

        }
        private void TextBox_Changed(object sender, EventArgs e)
        {
            lbl_KiemTra.Visible = false;
            txt_HoTen.BorderColor = txt_SDT.BorderColor = txt_DiaChi.BorderColor = txt_CMND.BorderColor = Color.Black;
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            btn_HoanThanh1.ImageIndex = 2;
            
            pnl_ThongTinNV.Width = 0;
            pnl_ThongTinNV.Dock = DockStyle.Right;
            pnl_ThongTinTK.Dock = DockStyle.Fill;

            step = 4;

            pnl_Step3.Width = 0;
            pnl_Step3.Dock = DockStyle.Right;
            pnl_Step4.Dock = DockStyle.Fill;

            btn_Back.Visible = false;
            btn_Next.Visible = true;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            btn_HoanThanh1.ImageIndex = 2;
            
            DTO_NhanVien nv = new DTO_NhanVien
            {
                MaNV = (rad_QuanLy.Checked ? "QL" : "BH") + (nhanVien.DSNhanVien().Count()+1).ToString("000"),
                HoTen = txt_HoTen.Text,
                //HinhAnh = @"D:\HK4\Do an\Winform\img\" + "QL001.jpg",
                HinhAnh = @"D:\HK4\Do an\Winform\img\" + (rad_QuanLy.Checked ? "QL" : "BH")
                        + (nhanVien.DSNhanVien().Count()+1).ToString("000") + ".jpg",
                CMND = txt_CMND.Text,
                DiaChi = txt_DiaChi.Text,
                SDT = txt_SDT.Text,
                Luong = num_Luong.Value,
                
                TaiKhoan = new DTO_TaiKhoan
                {
                    MatKhau = txt_MatKhau.Text,
                    Email = txt_Email.Text,
                }
            };

            using (MemoryStream memory = new MemoryStream())
            {
                //using (var file = new FileStream(@"D:\HK4\Do an\Winform\img\" + "QL001" + ".jpg", FileMode.Create, FileAccess.ReadWrite))
                using (var file = new FileStream(@"D:\HK4\Do an\Winform\img\" + (rad_QuanLy.Checked ? "QL" : "BH") + (nhanVien.DSNhanVien().Count() + 1).ToString("000") + ".jpg", FileMode.Create, FileAccess.ReadWrite))
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

            if (nhanVien.Them(nv))
            {
                MessageBox.Show("Nhân viên đã được thêm vào danh sách");
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

        private void txt_HoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
