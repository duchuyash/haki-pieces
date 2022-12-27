using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DTO;
using BUS;

namespace HaKi_Piece
{
    public partial class frm_Main : Form
    {
        public Form form = new Form();
        public static string tentk;
        public bool Status = true;

        public DateTime start;

        public frm_Main()
        {
            InitializeComponent();
            pnl_Menu.Width = 300;
            pnl_Tittle.BackColor = Color.FromArgb(4, 67, 127);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            tm_SystemTime.Start();
        }

        private void tm_SystemTime_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_Date.Text = DateTime.Now.ToShortDateString(); 
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            btn_DangXuat_Click(sender, e);
            if(!Status)
                Application.Exit();
        }    

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Switch_Click(object sender, EventArgs e)
        {
            if (pnl_Menu.Width == 60)
            {
                pnl_ThongTin.Show();
                pnl_Menu.Visible = false;
                pnl_Menu.Width = 300;
                anm_Menu.ShowSync(pnl_Menu);
                anm_Menu.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            }
            else
            {
                pnl_Menu.Hide();
                pnl_ThongTin.Visible = false;
                pnl_Menu.Width = 60;
                anm_Menu.ShowSync(pnl_Menu);
                anm_Menu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            }
        }

        private void ChucNang(Form form)
        {
            btn_LapHoaDon.Normalcolor = btn_XemHoaDon.Normalcolor = btn_XemPhieuHen.Normalcolor
               = btn_XemSanPham.Normalcolor = btn_XemSuKien.Normalcolor = btn_QLNhanVien.Normalcolor = btn_QLKhoHang.Normalcolor = btn_QLSuKien.Normalcolor = btn_HTPhieuHen.Normalcolor = btn_BaoCaoThongKe.Normalcolor = Color.Transparent;
            if (form != null)
            {
                pnl_Desktop.Controls.Clear();
            }

            form.MdiParent = this;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_Desktop.Controls.Add(form);
            form.Show();

        }

        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_LapHoaDon());
            btn_LapHoaDon.Normalcolor = Color.FromArgb(0, 148, 221);
           
        }

        private void btn_XemHoaDon_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_XemHoaDon());
            btn_XemHoaDon.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_XemPhieuHen_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_XemPhieuHen());
            btn_XemPhieuHen.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_XemSanPham_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_XemSanPham());
            btn_XemSanPham.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_XemSuKien_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_XemSuKien());
            btn_XemSuKien.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_QLNhanVien());
            btn_QLNhanVien.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_QLKhoHang_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_QLKhoHang());
            btn_QLKhoHang.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_QLSuKien_Click(object sender, EventArgs e)
        {
            //ChucNang(new frm_QLSuKien());
            btn_QLSuKien.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_BaoCaoThongKe_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_BaoCaoThongKe());
            btn_BaoCaoThongKe.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_HTPhieuHen_Click(object sender, EventArgs e)
        {
            ChucNang(new frm_HTPhieuHen());
            btn_HTPhieuHen.Normalcolor = Color.FromArgb(0, 148, 221);

        }

        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            //ChucNang(frm_ThongTin);

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Đăng xuất để hết phiên làm việc ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (x == DialogResult.OK)
            {
                DTO_CaLam calam = new DTO_CaLam
                {
                    TenTK = lbl_MaNV.Text,
                    ThoiGianBD = start,
                    ThoiGianKT = DateTime.Now
                };

                new BUS_CaLam().Them(calam);

                Form frm = new frm_DangNhap();
                frm.Show();
                Status = false;
                this.Close();
            }
        }

        private void btn_Quyen_Click(object sender, EventArgs e)
        {
            pnl_BanHang.Visible = !pnl_BanHang.Visible;

            pnl_QuanLy.Visible = !pnl_QuanLy.Visible;


        }

        private void frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    {
                        btn_ThayDoi_Click(sender, e);
                    } break;

                case Keys.F2:
                    {
                        if(pnl_BanHang.Visible)
                            btn_LapHoaDon_Click(sender, e);
                        else
                            btn_QLNhanVien_Click(sender, e);
                    }
                    break;

                case Keys.F3:
                    {
                        if (pnl_BanHang.Visible)
                            btn_XemHoaDon_Click(sender, e);
                        else
                            btn_QLKhoHang_Click(sender, e);
                        
                    }
                    break;

                case Keys.F4:
                    {
                        if (pnl_BanHang.Visible)
                            btn_XemPhieuHen_Click(sender, e);
                        else
                           btn_QLSuKien_Click(sender, e);
                    }
                    break;
                case Keys.F5:
                    {
                        if (pnl_BanHang.Visible)
                             btn_XemSanPham_Click(sender, e);
                        else
                           btn_BaoCaoThongKe_Click(sender, e);
                       
                    }
                    break;
                case Keys.F6:
                    {
                        if (pnl_BanHang.Visible)
                            btn_XemSuKien_Click(sender, e);
                        else
                            btn_HTPhieuHen_Click(sender, e);
                        
                    }
                    break;
                case Keys.Escape:
                    {
                        btn_DangXuat_Click(sender, e);
                    }
                    break;

            }

            if (e.Alt == true && e.KeyCode == Keys.F4)
            {
                btn_Close_Click(sender, e);
            }

            if (e.Control == true && e.KeyCode == Keys.Tab)
            {
                btn_Switch_Click(sender, e);
            }

            if (e.Control == true && e.KeyCode == Keys.Space)
            {
                if (lbl_MaNV.Text.Contains("QL"))
                    btn_Quyen_Click(sender, e);
            }

           
        }

       
    }
}
