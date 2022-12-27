
namespace HaKi_Piece
{
    partial class frm_Main
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.elp_Form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_DangXuat = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_XemSuKien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_XemSanPham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_XemPhieuHen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_XemHoaDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_LapHoaDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_ThongTin = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_ThayDoi = new Bunifu.Framework.UI.BunifuImageButton();
            this.pic_Image = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_HoTen = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV = new Guna.UI.WinForms.GunaLabel();
            this.pnl_QuanLy = new System.Windows.Forms.Panel();
            this.btn_QLKhoHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_QLSuKien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_HTPhieuHen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_BaoCaoThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_QLNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Quyen = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_BanHang = new System.Windows.Forms.Panel();
            this.anm_Menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_Tittle = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_Switch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_Desktop = new Guna.UI.WinForms.GunaGradientPanel();
            this.pnl_Break = new System.Windows.Forms.Panel();
            this.pnl_Break2 = new System.Windows.Forms.Panel();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.drc_NVBH = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tm_SystemTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_DangXuat)).BeginInit();
            this.pnl_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ThayDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.pnl_QuanLy.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quyen)).BeginInit();
            this.pnl_BanHang.SuspendLayout();
            this.pnl_Tittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Switch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // elp_Form
            // 
            this.elp_Form.Radius = 5;
            this.elp_Form.TargetControl = this;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.anm_Menu.SetDecoration(this.btn_DangXuat, BunifuAnimatorNS.DecorationType.None);
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageActive")));
            this.btn_DangXuat.Location = new System.Drawing.Point(298, 870);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(50, 50);
            this.btn_DangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_DangXuat.TabIndex = 0;
            this.btn_DangXuat.TabStop = false;
            this.btn_DangXuat.Zoom = 10;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_XemSuKien
            // 
            this.btn_XemSuKien.Activecolor = System.Drawing.Color.Transparent;
            this.btn_XemSuKien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemSuKien.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemSuKien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemSuKien.BorderRadius = 5;
            this.btn_XemSuKien.ButtonText = "                     Xem sự kiện";
            this.btn_XemSuKien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_XemSuKien, BunifuAnimatorNS.DecorationType.None);
            this.btn_XemSuKien.DisabledColor = System.Drawing.Color.Gray;
            this.btn_XemSuKien.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_XemSuKien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_XemSuKien.Iconimage")));
            this.btn_XemSuKien.Iconimage_right = null;
            this.btn_XemSuKien.Iconimage_right_Selected = null;
            this.btn_XemSuKien.Iconimage_Selected = null;
            this.btn_XemSuKien.IconMarginLeft = 5;
            this.btn_XemSuKien.IconMarginRight = 0;
            this.btn_XemSuKien.IconRightVisible = true;
            this.btn_XemSuKien.IconRightZoom = 0D;
            this.btn_XemSuKien.IconVisible = true;
            this.btn_XemSuKien.IconZoom = 80D;
            this.btn_XemSuKien.IsTab = false;
            this.btn_XemSuKien.Location = new System.Drawing.Point(2, 340);
            this.btn_XemSuKien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XemSuKien.Name = "btn_XemSuKien";
            this.btn_XemSuKien.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_XemSuKien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_XemSuKien.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_XemSuKien.selected = false;
            this.btn_XemSuKien.Size = new System.Drawing.Size(353, 81);
            this.btn_XemSuKien.TabIndex = 1;
            this.btn_XemSuKien.Text = "                     Xem sự kiện";
            this.btn_XemSuKien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemSuKien.Textcolor = System.Drawing.Color.White;
            this.btn_XemSuKien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemSuKien.Click += new System.EventHandler(this.btn_XemSuKien_Click);
            // 
            // btn_XemSanPham
            // 
            this.btn_XemSanPham.Activecolor = System.Drawing.Color.Transparent;
            this.btn_XemSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemSanPham.BorderRadius = 5;
            this.btn_XemSanPham.ButtonText = "                     Xem sản phẩm";
            this.btn_XemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_XemSanPham, BunifuAnimatorNS.DecorationType.None);
            this.btn_XemSanPham.DisabledColor = System.Drawing.Color.Gray;
            this.btn_XemSanPham.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_XemSanPham.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_XemSanPham.Iconimage")));
            this.btn_XemSanPham.Iconimage_right = null;
            this.btn_XemSanPham.Iconimage_right_Selected = null;
            this.btn_XemSanPham.Iconimage_Selected = null;
            this.btn_XemSanPham.IconMarginLeft = 5;
            this.btn_XemSanPham.IconMarginRight = 0;
            this.btn_XemSanPham.IconRightVisible = true;
            this.btn_XemSanPham.IconRightZoom = 0D;
            this.btn_XemSanPham.IconVisible = true;
            this.btn_XemSanPham.IconZoom = 80D;
            this.btn_XemSanPham.IsTab = false;
            this.btn_XemSanPham.Location = new System.Drawing.Point(0, 259);
            this.btn_XemSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XemSanPham.Name = "btn_XemSanPham";
            this.btn_XemSanPham.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_XemSanPham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_XemSanPham.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_XemSanPham.selected = false;
            this.btn_XemSanPham.Size = new System.Drawing.Size(353, 81);
            this.btn_XemSanPham.TabIndex = 1;
            this.btn_XemSanPham.Text = "                     Xem sản phẩm";
            this.btn_XemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemSanPham.Textcolor = System.Drawing.Color.White;
            this.btn_XemSanPham.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemSanPham.Click += new System.EventHandler(this.btn_XemSanPham_Click);
            // 
            // btn_XemPhieuHen
            // 
            this.btn_XemPhieuHen.Activecolor = System.Drawing.Color.Transparent;
            this.btn_XemPhieuHen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemPhieuHen.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemPhieuHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemPhieuHen.BorderRadius = 5;
            this.btn_XemPhieuHen.ButtonText = "                     Xem phiếu hẹn";
            this.btn_XemPhieuHen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_XemPhieuHen, BunifuAnimatorNS.DecorationType.None);
            this.btn_XemPhieuHen.DisabledColor = System.Drawing.Color.Gray;
            this.btn_XemPhieuHen.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_XemPhieuHen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_XemPhieuHen.Iconimage")));
            this.btn_XemPhieuHen.Iconimage_right = null;
            this.btn_XemPhieuHen.Iconimage_right_Selected = null;
            this.btn_XemPhieuHen.Iconimage_Selected = null;
            this.btn_XemPhieuHen.IconMarginLeft = 5;
            this.btn_XemPhieuHen.IconMarginRight = 0;
            this.btn_XemPhieuHen.IconRightVisible = true;
            this.btn_XemPhieuHen.IconRightZoom = 0D;
            this.btn_XemPhieuHen.IconVisible = true;
            this.btn_XemPhieuHen.IconZoom = 80D;
            this.btn_XemPhieuHen.IsTab = false;
            this.btn_XemPhieuHen.Location = new System.Drawing.Point(1, 178);
            this.btn_XemPhieuHen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XemPhieuHen.Name = "btn_XemPhieuHen";
            this.btn_XemPhieuHen.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_XemPhieuHen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_XemPhieuHen.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_XemPhieuHen.selected = false;
            this.btn_XemPhieuHen.Size = new System.Drawing.Size(353, 81);
            this.btn_XemPhieuHen.TabIndex = 1;
            this.btn_XemPhieuHen.Text = "                     Xem phiếu hẹn";
            this.btn_XemPhieuHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemPhieuHen.Textcolor = System.Drawing.Color.White;
            this.btn_XemPhieuHen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemPhieuHen.Click += new System.EventHandler(this.btn_XemPhieuHen_Click);
            // 
            // btn_XemHoaDon
            // 
            this.btn_XemHoaDon.Activecolor = System.Drawing.Color.Transparent;
            this.btn_XemHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemHoaDon.BorderRadius = 5;
            this.btn_XemHoaDon.ButtonText = "                     Xem hóa đơn";
            this.btn_XemHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_XemHoaDon, BunifuAnimatorNS.DecorationType.None);
            this.btn_XemHoaDon.DisabledColor = System.Drawing.Color.Gray;
            this.btn_XemHoaDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_XemHoaDon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_XemHoaDon.Iconimage")));
            this.btn_XemHoaDon.Iconimage_right = null;
            this.btn_XemHoaDon.Iconimage_right_Selected = null;
            this.btn_XemHoaDon.Iconimage_Selected = null;
            this.btn_XemHoaDon.IconMarginLeft = 5;
            this.btn_XemHoaDon.IconMarginRight = 0;
            this.btn_XemHoaDon.IconRightVisible = true;
            this.btn_XemHoaDon.IconRightZoom = 0D;
            this.btn_XemHoaDon.IconVisible = true;
            this.btn_XemHoaDon.IconZoom = 80D;
            this.btn_XemHoaDon.IsTab = false;
            this.btn_XemHoaDon.Location = new System.Drawing.Point(1, 89);
            this.btn_XemHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XemHoaDon.Name = "btn_XemHoaDon";
            this.btn_XemHoaDon.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_XemHoaDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_XemHoaDon.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_XemHoaDon.selected = false;
            this.btn_XemHoaDon.Size = new System.Drawing.Size(353, 81);
            this.btn_XemHoaDon.TabIndex = 1;
            this.btn_XemHoaDon.Text = "                     Xem hóa đơn";
            this.btn_XemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemHoaDon.Textcolor = System.Drawing.Color.White;
            this.btn_XemHoaDon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemHoaDon.Click += new System.EventHandler(this.btn_XemHoaDon_Click);
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.Activecolor = System.Drawing.Color.Transparent;
            this.btn_LapHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LapHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_LapHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LapHoaDon.BorderRadius = 5;
            this.btn_LapHoaDon.ButtonText = "                     Lập hóa đơn";
            this.btn_LapHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_LapHoaDon, BunifuAnimatorNS.DecorationType.None);
            this.btn_LapHoaDon.DisabledColor = System.Drawing.Color.Gray;
            this.btn_LapHoaDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_LapHoaDon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_LapHoaDon.Iconimage")));
            this.btn_LapHoaDon.Iconimage_right = null;
            this.btn_LapHoaDon.Iconimage_right_Selected = null;
            this.btn_LapHoaDon.Iconimage_Selected = null;
            this.btn_LapHoaDon.IconMarginLeft = 5;
            this.btn_LapHoaDon.IconMarginRight = 0;
            this.btn_LapHoaDon.IconRightVisible = true;
            this.btn_LapHoaDon.IconRightZoom = 0D;
            this.btn_LapHoaDon.IconVisible = true;
            this.btn_LapHoaDon.IconZoom = 80D;
            this.btn_LapHoaDon.IsTab = false;
            this.btn_LapHoaDon.Location = new System.Drawing.Point(2, 0);
            this.btn_LapHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_LapHoaDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_LapHoaDon.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_LapHoaDon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_LapHoaDon.selected = true;
            this.btn_LapHoaDon.Size = new System.Drawing.Size(352, 81);
            this.btn_LapHoaDon.TabIndex = 1;
            this.btn_LapHoaDon.Text = "                     Lập hóa đơn";
            this.btn_LapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapHoaDon.Textcolor = System.Drawing.Color.White;
            this.btn_LapHoaDon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapHoaDon.Click += new System.EventHandler(this.btn_LapHoaDon_Click);
            // 
            // pnl_ThongTin
            // 
            this.pnl_ThongTin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ThongTin.BaseColor = System.Drawing.Color.Transparent;
            this.pnl_ThongTin.Controls.Add(this.btn_ThayDoi);
            this.pnl_ThongTin.Controls.Add(this.pic_Image);
            this.pnl_ThongTin.Controls.Add(this.lbl_HoTen);
            this.pnl_ThongTin.Controls.Add(this.lbl_MaNV);
            this.anm_Menu.SetDecoration(this.pnl_ThongTin, BunifuAnimatorNS.DecorationType.None);
            this.pnl_ThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnl_ThongTin.Name = "pnl_ThongTin";
            this.pnl_ThongTin.Size = new System.Drawing.Size(357, 342);
            this.pnl_ThongTin.TabIndex = 0;
            // 
            // btn_ThayDoi
            // 
            this.btn_ThayDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThayDoi.BackColor = System.Drawing.Color.Transparent;
            this.anm_Menu.SetDecoration(this.btn_ThayDoi, BunifuAnimatorNS.DecorationType.None);
            this.btn_ThayDoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThayDoi.Image")));
            this.btn_ThayDoi.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_ThayDoi.ImageActive")));
            this.btn_ThayDoi.Location = new System.Drawing.Point(313, 227);
            this.btn_ThayDoi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThayDoi.Name = "btn_ThayDoi";
            this.btn_ThayDoi.Size = new System.Drawing.Size(40, 40);
            this.btn_ThayDoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ThayDoi.TabIndex = 0;
            this.btn_ThayDoi.TabStop = false;
            this.btn_ThayDoi.Zoom = 5;
            this.btn_ThayDoi.Click += new System.EventHandler(this.btn_ThayDoi_Click);
            // 
            // pic_Image
            // 
            this.pic_Image.BaseColor = System.Drawing.Color.White;
            this.anm_Menu.SetDecoration(this.pic_Image, BunifuAnimatorNS.DecorationType.None);
            this.pic_Image.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_Image.Image = ((System.Drawing.Image)(resources.GetObject("pic_Image.Image")));
            this.pic_Image.Location = new System.Drawing.Point(0, 27);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(357, 200);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 0;
            this.pic_Image.TabStop = false;
            // 
            // lbl_HoTen
            // 
            this.anm_Menu.SetDecoration(this.lbl_HoTen, BunifuAnimatorNS.DecorationType.None);
            this.lbl_HoTen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_HoTen.Location = new System.Drawing.Point(0, 227);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(357, 52);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "NGUYỄN VĂN A";
            this.lbl_HoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MaNV
            // 
            this.anm_Menu.SetDecoration(this.lbl_MaNV, BunifuAnimatorNS.DecorationType.None);
            this.lbl_MaNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_MaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_MaNV.Location = new System.Drawing.Point(0, 279);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(357, 63);
            this.lbl_MaNV.TabIndex = 1;
            this.lbl_MaNV.Text = "00000";
            this.lbl_MaNV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_QuanLy
            // 
            this.pnl_QuanLy.BackColor = System.Drawing.Color.Transparent;
            this.pnl_QuanLy.Controls.Add(this.btn_QLKhoHang);
            this.pnl_QuanLy.Controls.Add(this.btn_QLSuKien);
            this.pnl_QuanLy.Controls.Add(this.btn_HTPhieuHen);
            this.pnl_QuanLy.Controls.Add(this.btn_BaoCaoThongKe);
            this.pnl_QuanLy.Controls.Add(this.btn_QLNhanVien);
            this.anm_Menu.SetDecoration(this.pnl_QuanLy, BunifuAnimatorNS.DecorationType.None);
            this.pnl_QuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_QuanLy.Location = new System.Drawing.Point(0, 803);
            this.pnl_QuanLy.Name = "pnl_QuanLy";
            this.pnl_QuanLy.Size = new System.Drawing.Size(357, 461);
            this.pnl_QuanLy.TabIndex = 0;
            // 
            // btn_QLKhoHang
            // 
            this.btn_QLKhoHang.Activecolor = System.Drawing.Color.Transparent;
            this.btn_QLKhoHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QLKhoHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLKhoHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QLKhoHang.BorderRadius = 5;
            this.btn_QLKhoHang.ButtonText = "                Quản lý kho hàng";
            this.btn_QLKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_QLKhoHang, BunifuAnimatorNS.DecorationType.None);
            this.btn_QLKhoHang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_QLKhoHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_QLKhoHang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_QLKhoHang.Iconimage")));
            this.btn_QLKhoHang.Iconimage_right = null;
            this.btn_QLKhoHang.Iconimage_right_Selected = null;
            this.btn_QLKhoHang.Iconimage_Selected = null;
            this.btn_QLKhoHang.IconMarginLeft = 5;
            this.btn_QLKhoHang.IconMarginRight = -10;
            this.btn_QLKhoHang.IconRightVisible = true;
            this.btn_QLKhoHang.IconRightZoom = 0D;
            this.btn_QLKhoHang.IconVisible = true;
            this.btn_QLKhoHang.IconZoom = 80D;
            this.btn_QLKhoHang.IsTab = false;
            this.btn_QLKhoHang.Location = new System.Drawing.Point(2, 89);
            this.btn_QLKhoHang.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QLKhoHang.Name = "btn_QLKhoHang";
            this.btn_QLKhoHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_QLKhoHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_QLKhoHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_QLKhoHang.selected = false;
            this.btn_QLKhoHang.Size = new System.Drawing.Size(353, 81);
            this.btn_QLKhoHang.TabIndex = 1;
            this.btn_QLKhoHang.Text = "                Quản lý kho hàng";
            this.btn_QLKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLKhoHang.Textcolor = System.Drawing.Color.White;
            this.btn_QLKhoHang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLKhoHang.Click += new System.EventHandler(this.btn_QLKhoHang_Click);
            // 
            // btn_QLSuKien
            // 
            this.btn_QLSuKien.Activecolor = System.Drawing.Color.Transparent;
            this.btn_QLSuKien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QLSuKien.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLSuKien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QLSuKien.BorderRadius = 5;
            this.btn_QLSuKien.ButtonText = "                Quản lý sự kiện";
            this.btn_QLSuKien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_QLSuKien, BunifuAnimatorNS.DecorationType.None);
            this.btn_QLSuKien.DisabledColor = System.Drawing.Color.Gray;
            this.btn_QLSuKien.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_QLSuKien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_QLSuKien.Iconimage")));
            this.btn_QLSuKien.Iconimage_right = null;
            this.btn_QLSuKien.Iconimage_right_Selected = null;
            this.btn_QLSuKien.Iconimage_Selected = null;
            this.btn_QLSuKien.IconMarginLeft = 5;
            this.btn_QLSuKien.IconMarginRight = -10;
            this.btn_QLSuKien.IconRightVisible = true;
            this.btn_QLSuKien.IconRightZoom = 0D;
            this.btn_QLSuKien.IconVisible = true;
            this.btn_QLSuKien.IconZoom = 80D;
            this.btn_QLSuKien.IsTab = false;
            this.btn_QLSuKien.Location = new System.Drawing.Point(2, 178);
            this.btn_QLSuKien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QLSuKien.Name = "btn_QLSuKien";
            this.btn_QLSuKien.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_QLSuKien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_QLSuKien.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_QLSuKien.selected = false;
            this.btn_QLSuKien.Size = new System.Drawing.Size(353, 81);
            this.btn_QLSuKien.TabIndex = 1;
            this.btn_QLSuKien.Text = "                Quản lý sự kiện";
            this.btn_QLSuKien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLSuKien.Textcolor = System.Drawing.Color.White;
            this.btn_QLSuKien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSuKien.Click += new System.EventHandler(this.btn_QLSuKien_Click);
            // 
            // btn_HTPhieuHen
            // 
            this.btn_HTPhieuHen.Activecolor = System.Drawing.Color.Transparent;
            this.btn_HTPhieuHen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HTPhieuHen.BackColor = System.Drawing.Color.Transparent;
            this.btn_HTPhieuHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HTPhieuHen.BorderRadius = 5;
            this.btn_HTPhieuHen.ButtonText = "                Hoàn tất phiếu hẹn";
            this.btn_HTPhieuHen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_HTPhieuHen, BunifuAnimatorNS.DecorationType.None);
            this.btn_HTPhieuHen.DisabledColor = System.Drawing.Color.Gray;
            this.btn_HTPhieuHen.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_HTPhieuHen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_HTPhieuHen.Iconimage")));
            this.btn_HTPhieuHen.Iconimage_right = null;
            this.btn_HTPhieuHen.Iconimage_right_Selected = null;
            this.btn_HTPhieuHen.Iconimage_Selected = null;
            this.btn_HTPhieuHen.IconMarginLeft = 5;
            this.btn_HTPhieuHen.IconMarginRight = -10;
            this.btn_HTPhieuHen.IconRightVisible = true;
            this.btn_HTPhieuHen.IconRightZoom = 0D;
            this.btn_HTPhieuHen.IconVisible = true;
            this.btn_HTPhieuHen.IconZoom = 80D;
            this.btn_HTPhieuHen.IsTab = false;
            this.btn_HTPhieuHen.Location = new System.Drawing.Point(2, 348);
            this.btn_HTPhieuHen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HTPhieuHen.Name = "btn_HTPhieuHen";
            this.btn_HTPhieuHen.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_HTPhieuHen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_HTPhieuHen.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_HTPhieuHen.selected = false;
            this.btn_HTPhieuHen.Size = new System.Drawing.Size(353, 81);
            this.btn_HTPhieuHen.TabIndex = 1;
            this.btn_HTPhieuHen.Text = "                Hoàn tất phiếu hẹn";
            this.btn_HTPhieuHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HTPhieuHen.Textcolor = System.Drawing.Color.White;
            this.btn_HTPhieuHen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HTPhieuHen.Click += new System.EventHandler(this.btn_HTPhieuHen_Click);
            // 
            // btn_BaoCaoThongKe
            // 
            this.btn_BaoCaoThongKe.Activecolor = System.Drawing.Color.Transparent;
            this.btn_BaoCaoThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BaoCaoThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_BaoCaoThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BaoCaoThongKe.BorderRadius = 5;
            this.btn_BaoCaoThongKe.ButtonText = "                Báo cáo thống kê";
            this.btn_BaoCaoThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_BaoCaoThongKe, BunifuAnimatorNS.DecorationType.None);
            this.btn_BaoCaoThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BaoCaoThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BaoCaoThongKe.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_BaoCaoThongKe.Iconimage")));
            this.btn_BaoCaoThongKe.Iconimage_right = null;
            this.btn_BaoCaoThongKe.Iconimage_right_Selected = null;
            this.btn_BaoCaoThongKe.Iconimage_Selected = null;
            this.btn_BaoCaoThongKe.IconMarginLeft = 5;
            this.btn_BaoCaoThongKe.IconMarginRight = -10;
            this.btn_BaoCaoThongKe.IconRightVisible = true;
            this.btn_BaoCaoThongKe.IconRightZoom = 0D;
            this.btn_BaoCaoThongKe.IconVisible = true;
            this.btn_BaoCaoThongKe.IconZoom = 80D;
            this.btn_BaoCaoThongKe.IsTab = false;
            this.btn_BaoCaoThongKe.Location = new System.Drawing.Point(2, 267);
            this.btn_BaoCaoThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BaoCaoThongKe.Name = "btn_BaoCaoThongKe";
            this.btn_BaoCaoThongKe.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_BaoCaoThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_BaoCaoThongKe.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BaoCaoThongKe.selected = false;
            this.btn_BaoCaoThongKe.Size = new System.Drawing.Size(353, 81);
            this.btn_BaoCaoThongKe.TabIndex = 1;
            this.btn_BaoCaoThongKe.Text = "                Báo cáo thống kê";
            this.btn_BaoCaoThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BaoCaoThongKe.Textcolor = System.Drawing.Color.White;
            this.btn_BaoCaoThongKe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaoCaoThongKe.Click += new System.EventHandler(this.btn_BaoCaoThongKe_Click);
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.Activecolor = System.Drawing.Color.Transparent;
            this.btn_QLNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QLNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QLNhanVien.BorderRadius = 5;
            this.btn_QLNhanVien.ButtonText = "                Quản lý nhân viên";
            this.btn_QLNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anm_Menu.SetDecoration(this.btn_QLNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.btn_QLNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.btn_QLNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_QLNhanVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_QLNhanVien.Iconimage")));
            this.btn_QLNhanVien.Iconimage_right = null;
            this.btn_QLNhanVien.Iconimage_right_Selected = null;
            this.btn_QLNhanVien.Iconimage_Selected = null;
            this.btn_QLNhanVien.IconMarginLeft = 5;
            this.btn_QLNhanVien.IconMarginRight = 0;
            this.btn_QLNhanVien.IconRightVisible = true;
            this.btn_QLNhanVien.IconRightZoom = 0D;
            this.btn_QLNhanVien.IconVisible = true;
            this.btn_QLNhanVien.IconZoom = 80D;
            this.btn_QLNhanVien.IsTab = false;
            this.btn_QLNhanVien.Location = new System.Drawing.Point(2, 0);
            this.btn_QLNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_QLNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.btn_QLNhanVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_QLNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_QLNhanVien.selected = true;
            this.btn_QLNhanVien.Size = new System.Drawing.Size(353, 81);
            this.btn_QLNhanVien.TabIndex = 1;
            this.btn_QLNhanVien.Text = "                Quản lý nhân viên";
            this.btn_QLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNhanVien.Textcolor = System.Drawing.Color.White;
            this.btn_QLNhanVien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNhanVien.Click += new System.EventHandler(this.btn_QLNhanVien_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_Menu.Controls.Add(this.pnl_QuanLy);
            this.pnl_Menu.Controls.Add(this.btn_DangXuat);
            this.pnl_Menu.Controls.Add(this.btn_Quyen);
            this.pnl_Menu.Controls.Add(this.pnl_BanHang);
            this.pnl_Menu.Controls.Add(this.pnl_ThongTin);
            this.anm_Menu.SetDecoration(this.pnl_Menu, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 77);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(357, 926);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_Quyen
            // 
            this.btn_Quyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Quyen.BackColor = System.Drawing.Color.Transparent;
            this.anm_Menu.SetDecoration(this.btn_Quyen, BunifuAnimatorNS.DecorationType.None);
            this.btn_Quyen.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quyen.Image")));
            this.btn_Quyen.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_Quyen.ImageActive")));
            this.btn_Quyen.Location = new System.Drawing.Point(232, 870);
            this.btn_Quyen.Name = "btn_Quyen";
            this.btn_Quyen.Size = new System.Drawing.Size(50, 50);
            this.btn_Quyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Quyen.TabIndex = 0;
            this.btn_Quyen.TabStop = false;
            this.btn_Quyen.Zoom = 10;
            this.btn_Quyen.Click += new System.EventHandler(this.btn_Quyen_Click);
            // 
            // pnl_BanHang
            // 
            this.pnl_BanHang.BackColor = System.Drawing.Color.Transparent;
            this.pnl_BanHang.Controls.Add(this.btn_XemSuKien);
            this.pnl_BanHang.Controls.Add(this.btn_XemSanPham);
            this.pnl_BanHang.Controls.Add(this.btn_XemPhieuHen);
            this.pnl_BanHang.Controls.Add(this.btn_XemHoaDon);
            this.pnl_BanHang.Controls.Add(this.btn_LapHoaDon);
            this.anm_Menu.SetDecoration(this.pnl_BanHang, BunifuAnimatorNS.DecorationType.None);
            this.pnl_BanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BanHang.Location = new System.Drawing.Point(0, 342);
            this.pnl_BanHang.Name = "pnl_BanHang";
            this.pnl_BanHang.Size = new System.Drawing.Size(357, 461);
            this.pnl_BanHang.TabIndex = 0;
            // 
            // anm_Menu
            // 
            this.anm_Menu.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.anm_Menu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.anm_Menu.DefaultAnimation = animation1;
            this.anm_Menu.TimeStep = 0.03F;
            // 
            // pnl_Tittle
            // 
            this.pnl_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Tittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Tittle.BaseColor = System.Drawing.Color.Transparent;
            this.pnl_Tittle.Controls.Add(this.btn_Switch);
            this.pnl_Tittle.Controls.Add(this.btn_Minimize);
            this.pnl_Tittle.Controls.Add(this.btn_Close);
            this.anm_Menu.SetDecoration(this.pnl_Tittle, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tittle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tittle.Name = "pnl_Tittle";
            this.pnl_Tittle.Radius = 1;
            this.pnl_Tittle.Size = new System.Drawing.Size(1353, 67);
            this.pnl_Tittle.TabIndex = 1;
            // 
            // btn_Switch
            // 
            this.btn_Switch.BackColor = System.Drawing.Color.Transparent;
            this.anm_Menu.SetDecoration(this.btn_Switch, BunifuAnimatorNS.DecorationType.None);
            this.btn_Switch.Image = ((System.Drawing.Image)(resources.GetObject("btn_Switch.Image")));
            this.btn_Switch.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_Switch.ImageActive")));
            this.btn_Switch.Location = new System.Drawing.Point(12, 11);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(50, 50);
            this.btn_Switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Switch.TabIndex = 0;
            this.btn_Switch.TabStop = false;
            this.btn_Switch.Zoom = 10;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.anm_Menu.SetDecoration(this.btn_Minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.ImageActive = null;
            this.btn_Minimize.Location = new System.Drawing.Point(1255, 11);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Zoom = 10;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.anm_Menu.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(1301, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Desktop
            // 
            this.pnl_Desktop.BackColor = System.Drawing.Color.Black;
            this.pnl_Desktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Desktop.BackgroundImage")));
            this.pnl_Desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anm_Menu.SetDecoration(this.pnl_Desktop, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Desktop.GradientColor1 = System.Drawing.Color.White;
            this.pnl_Desktop.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Desktop.GradientColor3 = System.Drawing.Color.White;
            this.pnl_Desktop.GradientColor4 = System.Drawing.Color.White;
            this.pnl_Desktop.Location = new System.Drawing.Point(357, 77);
            this.pnl_Desktop.Name = "pnl_Desktop";
            this.pnl_Desktop.Quality = 20;
            this.pnl_Desktop.Size = new System.Drawing.Size(996, 926);
            this.pnl_Desktop.TabIndex = 2;
            // 
            // pnl_Break
            // 
            this.pnl_Break.BackColor = System.Drawing.Color.White;
            this.anm_Menu.SetDecoration(this.pnl_Break, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Break.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Break.Location = new System.Drawing.Point(0, 67);
            this.pnl_Break.Name = "pnl_Break";
            this.pnl_Break.Size = new System.Drawing.Size(1353, 10);
            this.pnl_Break.TabIndex = 1;
            // 
            // pnl_Break2
            // 
            this.pnl_Break2.BackColor = System.Drawing.Color.White;
            this.anm_Menu.SetDecoration(this.pnl_Break2, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Break2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Break2.Location = new System.Drawing.Point(0, 1003);
            this.pnl_Break2.Name = "pnl_Break2";
            this.pnl_Break2.Size = new System.Drawing.Size(1353, 10);
            this.pnl_Break2.TabIndex = 4;
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_Footer.Controls.Add(this.lbl_Date);
            this.pnl_Footer.Controls.Add(this.lbl_Time);
            this.anm_Menu.SetDecoration(this.pnl_Footer, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(0, 1013);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1353, 42);
            this.pnl_Footer.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.anm_Menu.SetDecoration(this.lbl_Date, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(1214, 13);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(101, 20);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "01/01/2000";
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.anm_Menu.SetDecoration(this.lbl_Time, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(1069, 13);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(88, 20);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "00:00 AM";
            // 
            // drc_NVBH
            // 
            this.drc_NVBH.Fixed = true;
            this.drc_NVBH.Horizontal = true;
            this.drc_NVBH.TargetControl = this.pnl_Tittle;
            this.drc_NVBH.Vertical = true;
            // 
            // tm_SystemTime
            // 
            this.tm_SystemTime.Enabled = true;
            this.tm_SystemTime.Tick += new System.EventHandler(this.tm_SystemTime_Tick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Desktop);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Break2);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_Break);
            this.Controls.Add(this.pnl_Tittle);
            this.anm_Menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_DangXuat)).EndInit();
            this.pnl_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ThayDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.pnl_QuanLy.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quyen)).EndInit();
            this.pnl_BanHang.ResumeLayout(false);
            this.pnl_Tittle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Switch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elp_Form;
        private Guna.UI.WinForms.GunaElipsePanel pnl_Tittle;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_Switch;
        private Guna.UI.WinForms.GunaElipsePanel pnl_ThongTin;
        private Bunifu.Framework.UI.BunifuImageButton btn_ThayDoi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_LapHoaDon;
        private Bunifu.Framework.UI.BunifuFlatButton btn_XemSuKien;
        private Bunifu.Framework.UI.BunifuFlatButton btn_XemSanPham;
        private Bunifu.Framework.UI.BunifuFlatButton btn_XemPhieuHen;
        private Bunifu.Framework.UI.BunifuFlatButton btn_XemHoaDon;
        private Bunifu.Framework.UI.BunifuImageButton btn_DangXuat;
        private BunifuAnimatorNS.BunifuTransition anm_Menu;
        private System.Windows.Forms.Panel pnl_Menu;
        private Guna.UI.WinForms.GunaGradientPanel pnl_Desktop;
        private System.Windows.Forms.Panel pnl_Break;
        private Bunifu.Framework.UI.BunifuDragControl drc_NVBH;
        private Bunifu.Framework.UI.BunifuFlatButton btn_QLKhoHang;
        private Bunifu.Framework.UI.BunifuFlatButton btn_QLNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btn_QLSuKien;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BaoCaoThongKe;
        public Guna.UI.WinForms.GunaLabel lbl_MaNV;
        public Guna.UI.WinForms.GunaLabel lbl_HoTen;
        private Bunifu.Framework.UI.BunifuFlatButton btn_HTPhieuHen;
        private System.Windows.Forms.Panel pnl_Break2;
        private System.Windows.Forms.Panel pnl_Footer;
        public System.Windows.Forms.Panel pnl_QuanLy;
        public System.Windows.Forms.Panel pnl_BanHang;
        public Bunifu.Framework.UI.BunifuImageButton btn_Quyen;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer tm_SystemTime;
        public Guna.UI.WinForms.GunaPictureBox pic_Image;
    }
}

