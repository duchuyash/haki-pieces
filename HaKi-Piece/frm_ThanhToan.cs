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
    public delegate void HoanThanh(bool check);

    public partial class frm_ThanhToan : Form
    {
        static int step = 1;

        public List<DTO_CT_HoaDon> list = new List<DTO_CT_HoaDon>();
        public DTO_ThanhVien thanhvien = new DTO_ThanhVien();
        public DTO_PhieuHen phieuhen = new DTO_PhieuHen();

        public event HoanThanh Check;

        public frm_ThanhToan()
        {
            InitializeComponent();
            pnl_Step2.Width = pnl_Step3.Width = 0;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_TrucTiep_Click(object sender, EventArgs e)
        {
            btn_PhuongThuc.ImageIndex = 2;
            btn_TuongTac.ImageIndex = 1;
            pnl_HoanThanh.Width = 200;

            btn_Back.Visible = true;

            pnl_Step1.Width = 0;
            pnl_Step1.Dock = DockStyle.Right;
            pnl_Step2.Dock = DockStyle.Fill;

            num_KhachDua.Minimum = decimal.Parse(lbl_TongTienPhaiTra.Text);

            step = 2;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        { 
            btn_PhuongThuc.ImageIndex = 1;
            pnl_HoanThanh.Width = 80;

            btn_Back.Visible = false;

            pnl_Step2.Width = 0;
            pnl_Step2.Dock = DockStyle.Right;
            pnl_Step1.Dock = DockStyle.Fill;

            btn_TuongTac.ImageIndex = btn_HoanThanh.ImageIndex = 0;

            step = 1;
        }

        private void pic_MoMo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phương thức đang bảo trì");
        }

        private void pic_Bank_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phương thức đang bảo trì");
        }

        private void frm_ThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (step == 2)
                {
                    btn_TuongTac.ImageIndex = 2;
                    btn_HoanThanh.ImageIndex = 1;
                    pnl_HoanThanh.Width = 600;

                    pnl_Step2.Width = 0;
                    pnl_Step2.Dock = DockStyle.Right;
                    pnl_Step3.Dock = DockStyle.Fill;
                    tm_HoanThanh.Start();
                    step = 3;

                }
                else
                {
                    DTO_HoaDon hoaDon = new DTO_HoaDon
                    {
                        TenTK = frm_Main.tentk,
                        CT_HoaDons = list,
                        NgayLapHD = DateTime.Now,
                        TrangThai = true,
                        Hen = phieuhen != null ? true : false
                    };
                    
                    BUS_HoaDon hd = new BUS_HoaDon();

                    hd.Them(hoaDon);

                    if (thanhvien != null)
                    {
                        BUS_ThanhVien tv = new BUS_ThanhVien();
                        tv.Them(thanhvien);
                    }

                    if (phieuhen != null)
                    {
                        BUS_PhieuHen ph = new BUS_PhieuHen();
                        ph.Them(phieuhen);

                    }

                    DialogResult x = MessageBox.Show("In hóa đơn ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (x == DialogResult.Yes)
                    {
                        frm_InHoaDon frm = new frm_InHoaDon();
                        int mahd = new BUS_HoaDon().DSHoaDon().Select(u => u.MaHD).Max();
                        frm.HoaDon(mahd.ToString());
                        frm.TopMost = true;
                        frm.ShowDialog();
                    }
                       

                    this.Check(true);
                    this.Close();
                }
            }    
        }

        private void tm_HoanThanh_Tick(object sender, EventArgs e)
        {
            pic_HoanThanh.Enabled = false;
            tm_HoanThanh.Stop();

            lbl_HoanThanh.Visible = true;
            btn_HoanThanh.ImageIndex = 2;

        }
    }
}
