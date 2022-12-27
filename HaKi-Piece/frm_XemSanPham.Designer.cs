
namespace HaKi_Piece
{
    partial class frm_XemSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XemSanPham));
            this.btn_Huy = new Bunifu.Framework.UI.BunifuImageButton();
            this.pic_TimKiem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.ils_Nuoc = new System.Windows.Forms.ImageList(this.components);
            this.lvw_DSSP = new System.Windows.Forms.ListView();
            this.col_MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_HSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_HSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_SLTon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Break = new System.Windows.Forms.Panel();
            this.pnl_Frame1 = new System.Windows.Forms.Panel();
            this.pnl_Frame3 = new System.Windows.Forms.Panel();
            this.pnl_Header = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_YeuCau = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Huy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimKiem)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageActive = null;
            this.btn_Huy.Location = new System.Drawing.Point(30, 35);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(30, 30);
            this.btn_Huy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Huy.TabIndex = 2;
            this.btn_Huy.TabStop = false;
            this.btn_Huy.Zoom = 10;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // pic_TimKiem
            // 
            this.pic_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.pic_TimKiem.Enabled = false;
            this.pic_TimKiem.FillColor = System.Drawing.Color.Transparent;
            this.pic_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("pic_TimKiem.Image")));
            this.pic_TimKiem.ImageRotate = 0F;
            this.pic_TimKiem.Location = new System.Drawing.Point(525, 27);
            this.pic_TimKiem.Name = "pic_TimKiem";
            this.pic_TimKiem.Size = new System.Drawing.Size(35, 35);
            this.pic_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_TimKiem.TabIndex = 1;
            this.pic_TimKiem.TabStop = false;
            this.pic_TimKiem.UseTransparentBackground = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TimKiem.BorderRadius = 15;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.IconLeftSize = new System.Drawing.Size(0, 0);
            this.txt_TimKiem.IconRightSize = new System.Drawing.Size(0, 0);
            this.txt_TimKiem.Location = new System.Drawing.Point(21, 24);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.PlaceholderText = "Nhập từ khóa tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(549, 46);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.TextOffset = new System.Drawing.Point(30, 0);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // ils_Nuoc
            // 
            this.ils_Nuoc.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ils_Nuoc.ImageSize = new System.Drawing.Size(160, 120);
            this.ils_Nuoc.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvw_DSSP
            // 
            this.lvw_DSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_MaSP,
            this.col_TenSP,
            this.col_HSX,
            this.col_MoTa,
            this.col_HSD,
            this.col_GiaBan,
            this.col_SLTon});
            this.lvw_DSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_DSSP.HideSelection = false;
            this.lvw_DSSP.LargeImageList = this.ils_Nuoc;
            this.lvw_DSSP.Location = new System.Drawing.Point(10, 110);
            this.lvw_DSSP.Name = "lvw_DSSP";
            this.lvw_DSSP.Size = new System.Drawing.Size(1237, 561);
            this.lvw_DSSP.TabIndex = 1;
            this.lvw_DSSP.UseCompatibleStateImageBehavior = false;
            this.lvw_DSSP.SelectedIndexChanged += new System.EventHandler(this.lvw_DSSP_SelectedIndexChanged);
            // 
            // col_MaSP
            // 
            this.col_MaSP.Text = "Mã SP";
            this.col_MaSP.Width = 122;
            // 
            // col_TenSP
            // 
            this.col_TenSP.Text = "Tên SP";
            this.col_TenSP.Width = 306;
            // 
            // col_HSX
            // 
            this.col_HSX.DisplayIndex = 4;
            this.col_HSX.Text = "Hãng SX";
            // 
            // col_MoTa
            // 
            this.col_MoTa.Text = "Mô tả";
            // 
            // col_HSD
            // 
            this.col_HSD.DisplayIndex = 5;
            this.col_HSD.Text = "HSD";
            // 
            // col_GiaBan
            // 
            this.col_GiaBan.DisplayIndex = 2;
            this.col_GiaBan.Text = "Giá Bán";
            this.col_GiaBan.Width = 257;
            // 
            // col_SLTon
            // 
            this.col_SLTon.Text = "SL Tồn";
            // 
            // pnl_Break
            // 
            this.pnl_Break.BackColor = System.Drawing.Color.White;
            this.pnl_Break.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Break.Location = new System.Drawing.Point(10, 100);
            this.pnl_Break.Name = "pnl_Break";
            this.pnl_Break.Size = new System.Drawing.Size(1237, 10);
            this.pnl_Break.TabIndex = 4;
            // 
            // pnl_Frame1
            // 
            this.pnl_Frame1.BackColor = System.Drawing.Color.White;
            this.pnl_Frame1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Frame1.Location = new System.Drawing.Point(0, 0);
            this.pnl_Frame1.Name = "pnl_Frame1";
            this.pnl_Frame1.Size = new System.Drawing.Size(10, 671);
            this.pnl_Frame1.TabIndex = 5;
            // 
            // pnl_Frame3
            // 
            this.pnl_Frame3.BackColor = System.Drawing.Color.White;
            this.pnl_Frame3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame3.Location = new System.Drawing.Point(1247, 0);
            this.pnl_Frame3.Name = "pnl_Frame3";
            this.pnl_Frame3.Size = new System.Drawing.Size(10, 671);
            this.pnl_Frame3.TabIndex = 6;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Header.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Header.Controls.Add(this.btn_YeuCau);
            this.pnl_Header.Controls.Add(this.pic_TimKiem);
            this.pnl_Header.Controls.Add(this.btn_Huy);
            this.pnl_Header.Controls.Add(this.txt_TimKiem);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(10, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Radius = 15;
            this.pnl_Header.Size = new System.Drawing.Size(1237, 100);
            this.pnl_Header.TabIndex = 7;
            // 
            // btn_YeuCau
            // 
            this.btn_YeuCau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_YeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.btn_YeuCau.BorderRadius = 15;
            this.btn_YeuCau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_YeuCau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_YeuCau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_YeuCau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_YeuCau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_YeuCau.ForeColor = System.Drawing.Color.White;
            this.btn_YeuCau.Image = ((System.Drawing.Image)(resources.GetObject("btn_YeuCau.Image")));
            this.btn_YeuCau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_YeuCau.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_YeuCau.Location = new System.Drawing.Point(931, 12);
            this.btn_YeuCau.Name = "btn_YeuCau";
            this.btn_YeuCau.Size = new System.Drawing.Size(280, 67);
            this.btn_YeuCau.TabIndex = 3;
            this.btn_YeuCau.Text = "YÊU CẦU NHẬP KHO";
            this.btn_YeuCau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_YeuCau.Click += new System.EventHandler(this.btn_YeuCau_Click);
            // 
            // frm_XemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 671);
            this.Controls.Add(this.lvw_DSSP);
            this.Controls.Add(this.pnl_Break);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_Frame1);
            this.Controls.Add(this.pnl_Frame3);
            this.Name = "frm_XemSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Huy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimKiem)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Bunifu.Framework.UI.BunifuImageButton btn_Huy;
        private Guna.UI2.WinForms.Guna2PictureBox pic_TimKiem;
        private System.Windows.Forms.ColumnHeader col_MaSP;
        private System.Windows.Forms.ColumnHeader col_TenSP;
        private System.Windows.Forms.ColumnHeader col_GiaBan;
        private System.Windows.Forms.ColumnHeader col_MoTa;
        private System.Windows.Forms.ColumnHeader col_HSX;
        public System.Windows.Forms.ListView lvw_DSSP;
        private System.Windows.Forms.Panel pnl_Break;
        public System.Windows.Forms.ImageList ils_Nuoc;
        private System.Windows.Forms.Panel pnl_Frame1;
        private System.Windows.Forms.Panel pnl_Frame3;
        private Guna.UI.WinForms.GunaElipsePanel pnl_Header;
        private System.Windows.Forms.ColumnHeader col_HSD;
        private System.Windows.Forms.ColumnHeader col_SLTon;
        public Guna.UI2.WinForms.Guna2Button btn_YeuCau;
    }
}