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
    public partial class frm_XemSuKien : Form
    {
        BUS_SuKien suKiens = new BUS_SuKien();
        List<DTO_SuKien> lst_SK = new List<DTO_SuKien>();
        public frm_XemSuKien()
        {
            InitializeComponent();
            dtp_Begin.Value =  dtp_End.Value = DateTime.Now;

            lst_SK = suKiens.DSSuKien();
            lvw_DSSK.Items.Clear();
            foreach (var sk in lst_SK)
            {
                ils_DSSK.Images.Add(sk.MaSK.ToString(), Image.FromFile(sk.HinhAnh));
                ListViewItem item = new ListViewItem("Mã sự kiện: " + sk.MaSK.ToString(), sk.MaSK.ToString());
                item.SubItems.Add(sk.MoTa);
                item.SubItems.Add("Từ " + sk.NgayBD.ToString("dd/MM/yyyy"));
                item.SubItems.Add("đến " + sk.NgayKT.ToString("dd/MM/yyyy"));
                lvw_DSSK.Items.Add(item);
            }

            dvw_DSSP.AutoGenerateColumns = false;  
        }
        private void Load()
        {
            lvw_DSSK.Items.Clear();
            
            foreach (var sk in lst_SK)
            {
                ListViewItem item = new ListViewItem("Mã sự kiện: " + sk.MaSK.ToString(), sk.MaSK.ToString());
                item.SubItems.Add(sk.MoTa);
                item.SubItems.Add("Từ " + sk.NgayBD.ToString("dd/MM/yyyy"));
                item.SubItems.Add("đến " + sk.NgayKT.ToString("dd/MM/yyyy"));
                lvw_DSSK.Items.Add(item);
            }
        }

        private void tgg_TatCa_CheckedChanged(object sender, EventArgs e)
        {
            dvw_DSSP.DataSource = null;
            if (tgg_TatCa.Checked)
            {
                dtp_Begin.Enabled = dtp_End.Enabled = false;
                
                lst_SK = suKiens.DSSuKien();
            }
            else
            {
                dtp_Begin.Enabled = dtp_End.Enabled = true;
                lst_SK = suKiens.DSSuKien_Filler(dtp_Begin.Value, dtp_End.Value);
            }
            Load();
        }

        private void cld_Lich_SelectionChanged(object sender, EventArgs e)
        {
            dtp_Begin.Value = cld_Lich.SelectionStart;
            dtp_End.Value = cld_Lich.SelectionEnd;
        }

        private void lvw_DSSK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_DSSK.SelectedItems.Count != 0)
            {
                dvw_DSSP.DataSource = null;
                dvw_DSSP.DataSource = suKiens.CT_SuKien(lvw_DSSK.SelectedItems[0].SubItems[0].Text.Substring(11)) ;
                Load();
            }
            
        }

        private void dtp_Begin_ValueChanged(object sender, EventArgs e)
        {
            dtp_End.MinDate = dtp_Begin.Value;
            dvw_DSSP.DataSource = null;
            lst_SK = suKiens.DSSuKien_Filler(dtp_Begin.Value, dtp_End.Value);
            Load();
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            dvw_DSSP.DataSource = null;
            lst_SK = suKiens.DSSuKien_Filler(dtp_Begin.Value, dtp_End.Value);
            Load();
        }
    }
}
