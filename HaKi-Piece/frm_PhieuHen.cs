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
    public delegate void HoanThanhPH(bool check);

    public partial class frm_PhieuHen : Form
    {
        public event HoanThanhPH Check;
        public int maph;

        public frm_PhieuHen()
        {
            InitializeComponent();
            dvw_CTHoaDon.AutoGenerateColumns = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            if (new BUS_PhieuHen().HoanThanh(maph))
            {
                MessageBox.Show("Phiếu hẹn đã hoàn thành");
                this.Check(true);
                this.Close();     
            }
                

        }
    }
}
