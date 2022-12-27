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
    public partial class frm_QLNhanVien : Form
    {
        List<DTO_NhanVien> list = new BUS_NhanVien().DSNhanVien();

        public frm_QLNhanVien()
        {
            InitializeComponent();

            cbo_ChucvuNV.DropDownStyle = ComboBoxStyle.Simple;
            dvw_DSNV.AutoGenerateColumns = dvw_CaLam.AutoGenerateColumns = false;

            LoadDataGridView();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemNV form = new frm_ThemNV();
            form.TopMost = true;
            form.step = 1;
            form.Show();
            
            form.Check += ThemNV;
        }
        private void ThemNV(bool check)
        {
            list = new BUS_NhanVien().DSNhanVien();
            LoadDataGridView();
        }

        private void dvw_DSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                pic_HinhAnh.Image = (Image)dvw_DSNV.Rows[e.RowIndex].Cells[0].Value;
                txt_MaNV.Text = dvw_DSNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_HoTen.Text = dvw_DSNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbo_ChucvuNV.Text = dvw_DSNV.Rows[e.RowIndex].Cells[3].Value.ToString();

                if ((bool)dvw_DSNV.Rows[e.RowIndex].Cells[4].Value)
                {
                    lbl_Status.Text = "Hoạt động";
                    lbl_Status.ForeColor = Color.Green;
                    btn_Khoa.Image = Image.FromFile(@"D:\HK4\Do an\Winform\icon\lock.png");
                }
                else
                {
                    lbl_Status.Text = "Thôi việc";
                    lbl_Status.ForeColor = Color.Red;
                    btn_Khoa.Image = Image.FromFile(@"D:\HK4\Do an\Winform\icon\unlock.png");
                }

                txt_DiaChi.Text = dvw_DSNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_SDT.Text = dvw_DSNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_CMND.Text = dvw_DSNV.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_Luong.Text = dvw_DSNV.Rows[e.RowIndex].Cells[9].Value.ToString();

                txt_TenDangNhap.Text = dvw_DSNV.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_MatKhau.Text = dvw_DSNV.Rows[e.RowIndex].Cells[11].Value.ToString();
                txt_Email.Text = dvw_DSNV.Rows[e.RowIndex].Cells[12].Value.ToString();

                dvw_CaLam.DataSource = new BUS_CaLam().CaLam(dvw_DSNV.Rows[e.RowIndex].Cells[10].Value.ToString());

                if (e.ColumnIndex == 5)
                {
                    txt_HoTen.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled
                        = txt_CMND.Enabled = txt_Luong.Enabled = txt_Email.Enabled = true;
                    return;
                }
            }

        }

        private void cbo_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ChucVu.SelectedIndex == 1)
                list = new BUS_NhanVien().DSNhanVien().Where(u => u.MaNV.Contains("QL")).ToList();
            else if (cbo_ChucVu.SelectedIndex == 2)
                list = new BUS_NhanVien().DSNhanVien().Where(u => u.MaNV.Contains("BH")).ToList();
            else
                list = new BUS_NhanVien().DSNhanVien();

            LoadDataGridView();
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
            cbo_ChucVu.SelectedIndex = 0;

            list = new BUS_NhanVien().TimKiem(txt_TimKiem.Text);

            LoadDataGridView();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            pic_HinhAnh.Image = null;
            txt_HoTen.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled
                       = txt_CMND.Enabled = txt_Luong.Enabled = txt_Email.Enabled = false;

            txt_HoTen.Text = txt_DiaChi.Text = txt_SDT.Text
                       = txt_CMND.Text = txt_Luong.Text = txt_MatKhau.Text = txt_Email.Text = txt_MaNV.Text = txt_TenDangNhap.Text =lbl_Status.Text = string.Empty;
        }

        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            if (dvw_DSNV.SelectedRows.Count != 0)
            {
                if (dvw_DSNV.SelectedRows[0].Cells[1].Value.ToString() != frm_Main.tentk)
                {
                    if(new BUS_NhanVien().Khoa((dvw_DSNV.SelectedRows[0].Cells[1].Value.ToString())))
                        MessageBox.Show("Nhân viên được hoạt động lại");
                    else
                        MessageBox.Show("Nhân viên dược tạm thời thôi việc");
                    txt_TimKiem_TextChanged(sender, e);
                }
                    
                else
                    MessageBox.Show("Không thể khóa chính mình");

                btn_TroVe_Click(sender, e);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien
            {
                MaNV = txt_MaNV.Text,
                HoTen = txt_HoTen.Text,
                CMND = txt_CMND.Text,
                DiaChi = txt_DiaChi.Text,
                SDT = txt_SDT.Text,
                Luong = decimal.Parse(txt_Luong.Text),
                TaiKhoan = new DTO_TaiKhoan
                {
                    Email = txt_Email.Text,
                }
            };

            if (new BUS_NhanVien().CapNhat(nv))
            {
                MessageBox.Show("Cập nhật thành công");
                btn_TroVe_Click(sender, e);

                txt_TimKiem_TextChanged(sender, e);
            }

            btn_TroVe_Click(sender, e);
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            btn_TroVe_Click(sender, e);
        }

        private void LoadDataGridView()
        {
            dvw_DSNV.Rows.Clear();
            foreach (var nv in list)
            {
                DTO_TaiKhoan tk = new BUS_TaiKhoan().DSTaiKhoan().SingleOrDefault(u => u.TenTK == nv.MaNV);

                Object[] row = new Object[]
                {
                     Image.FromFile(nv.HinhAnh),
                       nv.MaNV,
                       nv.HoTen,
                       nv.ChucVu,
                       nv.TrangThai,
                       null,
                       nv.DiaChi,
                       nv.SDT,
                       nv.CMND,
                       nv.Luong,
                       tk.TenTK,
                       //tk.MatKhau,
                       DTO_Function.GiaiMaHoa(tk.MatKhau),
                       tk.Email,
                 };
                dvw_DSNV.Rows.Add(row);
            }
        }
    }
}
