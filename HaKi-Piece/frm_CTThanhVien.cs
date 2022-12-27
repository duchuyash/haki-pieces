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
    

    public partial class frm_CTThanhVien : Form
    {
        BUS_PhieuHen phs = new BUS_PhieuHen();
        public frm_CTThanhVien()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CTThanhVien_Load(object sender, EventArgs e)
        {
            //dvw_PHcuaTV.DataSource = phs.Load_DSPH(txt_MaTV.Text);
        }
    }
}
