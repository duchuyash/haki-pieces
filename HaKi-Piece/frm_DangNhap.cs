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

    public partial class frm_DangNhap : Form
    {
        BUS_TaiKhoan list = new BUS_TaiKhoan();
        BUS_NhanVien listnv = new BUS_NhanVien();

        frm_Main frm = new frm_Main();

        public frm_DangNhap()
        {
            InitializeComponent();
            txt_MatKhau.UseSystemPasswordChar = true;
            lbl_ThongBao.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Hide_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Hide.Image = Image.FromFile(@"D:\HK4\Do an\Winform\icon\show.png");
            txt_MatKhau.UseSystemPasswordChar = false;
        }

        private void btn_Hide_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Hide.Image = Image.FromFile(@"D:\HK4\Do an\Winform\icon\hide.png");
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDangNhap.Text))
            {
                txt_TenDangNhap.BorderColor = Color.Red;
                lbl_ThongBao.Show();
            }
                
            else
            {
                DTO_TaiKhoan tk = new DTO_TaiKhoan { TenTK = txt_TenDangNhap.Text, MatKhau = txt_MatKhau.Text };

                if (list.KT_HopLe(tk))
                {

                    frm.TopMost = false;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();

                    frm.lbl_HoTen.Text = listnv.NhanVien(txt_TenDangNhap.Text).HoTen.ToUpper();
                    frm.pic_Image.Image = Image.FromFile(listnv.NhanVien(txt_TenDangNhap.Text).HinhAnh);
                    frm.lbl_MaNV.Text = txt_TenDangNhap.Text;
                    frm_Main.tentk = frm.lbl_MaNV.Text;
                    frm.start = DateTime.Now;

                    if (frm.lbl_MaNV.Text.Contains("BH"))
                    {
                        frm.pnl_BanHang.Visible = true;
                        frm.pnl_QuanLy.Visible = frm.btn_Quyen.Visible = false;
                    }
                    else
                    {
                        frm.pnl_BanHang.Visible = false;
                        frm.pnl_QuanLy.Visible = frm.btn_Quyen.Visible = true;
                    }

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                }
                
            }

        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_TenDangNhap.Text))
            {
                txt_TenDangNhap.BorderColor = Color.Green;
                lbl_ThongBao.Hide();
                
            }
            else
            {
                txt_TenDangNhap.BorderColor = Color.Red;
            }
        }

        private void frm_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_DangNhap_Click(sender, e);
        }
    }
}
