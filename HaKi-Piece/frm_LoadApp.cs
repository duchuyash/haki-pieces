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
    public partial class frm_LoadApp : Form
    {
        public frm_LoadApp()
        {
            InitializeComponent();
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            pnl_Step.Width += 5;
            if(pnl_Step.Width > pnl_Time.Width)
            {
                tmr_Load.Stop();
                Form frm = new frm_DangNhap();
                frm.Show();
                this.Hide();
            }

        }
    }
}
