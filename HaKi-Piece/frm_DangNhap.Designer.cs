
namespace HaKi_Piece
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.elp_DangNhap = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.elp_Textbox = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_DangNhap = new Guna.UI.WinForms.GunaGradientPanel();
            this.btn_DangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_ThongBao = new Guna.UI.WinForms.GunaLabel();
            this.btn_Hide = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_Image = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.drc_DangNhap = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // elp_DangNhap
            // 
            this.elp_DangNhap.Radius = 10;
            this.elp_DangNhap.TargetControl = this;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageActive")));
            this.btn_Close.Location = new System.Drawing.Point(449, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // elp_Textbox
            // 
            this.elp_Textbox.Radius = 20;
            this.elp_Textbox.TargetControl = this;
            // 
            // pnl_DangNhap
            // 
            this.pnl_DangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_DangNhap.BackgroundImage")));
            this.pnl_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_DangNhap.Controls.Add(this.btn_DangNhap);
            this.pnl_DangNhap.Controls.Add(this.lbl_ThongBao);
            this.pnl_DangNhap.Controls.Add(this.btn_Hide);
            this.pnl_DangNhap.Controls.Add(this.txt_MatKhau);
            this.pnl_DangNhap.Controls.Add(this.txt_TenDangNhap);
            this.pnl_DangNhap.Controls.Add(this.pic_Image);
            this.pnl_DangNhap.Controls.Add(this.btn_Close);
            this.pnl_DangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_DangNhap.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_DangNhap.GradientColor2 = System.Drawing.Color.White;
            this.pnl_DangNhap.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_DangNhap.GradientColor4 = System.Drawing.Color.White;
            this.pnl_DangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnl_DangNhap.Name = "pnl_DangNhap";
            this.pnl_DangNhap.Size = new System.Drawing.Size(501, 713);
            this.pnl_DangNhap.TabIndex = 4;
            this.pnl_DangNhap.Text = "pnl_DangNhap";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.Animated = true;
            this.btn_DangNhap.AutoRoundedCorners = true;
            this.btn_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangNhap.BorderRadius = 26;
            this.btn_DangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.IndicateFocus = true;
            this.btn_DangNhap.Location = new System.Drawing.Point(85, 553);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(335, 55);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "ĐĂNG NHẬP";
            this.btn_DangNhap.UseTransparentBackground = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbl_ThongBao.Location = new System.Drawing.Point(98, 404);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(159, 20);
            this.lbl_ThongBao.TabIndex = 10;
            this.lbl_ThongBao.Text = "Chưa nhập đủ dữ liệu";
            // 
            // btn_Hide
            // 
            this.btn_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Hide.BackColor = System.Drawing.Color.White;
            this.btn_Hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hide.Image")));
            this.btn_Hide.ImageActive = null;
            this.btn_Hide.Location = new System.Drawing.Point(374, 461);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(30, 30);
            this.btn_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Hide.TabIndex = 9;
            this.btn_Hide.TabStop = false;
            this.btn_Hide.Zoom = 10;
            this.btn_Hide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Hide_MouseDown);
            this.btn_Hide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Hide_MouseUp);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.Animated = true;
            this.txt_MatKhau.AutoRoundedCorners = true;
            this.txt_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txt_MatKhau.BorderColor = System.Drawing.Color.Green;
            this.txt_MatKhau.BorderRadius = 26;
            this.txt_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MatKhau.DefaultText = "";
            this.txt_MatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.txt_MatKhau.HideSelection = false;
            this.txt_MatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_MatKhau.IconLeft")));
            this.txt_MatKhau.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_MatKhau.Location = new System.Drawing.Point(85, 449);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '\0';
            this.txt_MatKhau.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_MatKhau.PlaceholderText = "Mật khẩu";
            this.txt_MatKhau.SelectedText = "";
            this.txt_MatKhau.Size = new System.Drawing.Size(335, 55);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDangNhap.Animated = true;
            this.txt_TenDangNhap.AutoRoundedCorners = true;
            this.txt_TenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenDangNhap.BorderColor = System.Drawing.Color.Green;
            this.txt_TenDangNhap.BorderRadius = 26;
            this.txt_TenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenDangNhap.DefaultText = "";
            this.txt_TenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_TenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txt_TenDangNhap.HideSelection = false;
            this.txt_TenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenDangNhap.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_TenDangNhap.IconLeft")));
            this.txt_TenDangNhap.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_TenDangNhap.Location = new System.Drawing.Point(85, 336);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.PasswordChar = '\0';
            this.txt_TenDangNhap.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_TenDangNhap.PlaceholderText = "Tên đăng nhập";
            this.txt_TenDangNhap.SelectedText = "";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(335, 55);
            this.txt_TenDangNhap.TabIndex = 0;
            this.txt_TenDangNhap.TextOffset = new System.Drawing.Point(10, 0);
            this.txt_TenDangNhap.TextChanged += new System.EventHandler(this.txt_TenDangNhap_TextChanged);
            // 
            // pic_Image
            // 
            this.pic_Image.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_Image.BackColor = System.Drawing.Color.Transparent;
            this.pic_Image.BaseColor = System.Drawing.Color.Transparent;
            this.pic_Image.Image = ((System.Drawing.Image)(resources.GetObject("pic_Image.Image")));
            this.pic_Image.Location = new System.Drawing.Point(132, 50);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(233, 207);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 6;
            this.pic_Image.TabStop = false;
            this.pic_Image.UseTransfarantBackground = false;
            // 
            // drc_DangNhap
            // 
            this.drc_DangNhap.Fixed = true;
            this.drc_DangNhap.Horizontal = true;
            this.drc_DangNhap.TargetControl = this.pnl_DangNhap;
            this.drc_DangNhap.Vertical = true;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 713);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_DangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_DangNhap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_DangNhap.ResumeLayout(false);
            this.pnl_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elp_DangNhap;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Guna.UI.WinForms.GunaElipse elp_Textbox;
        private Guna.UI.WinForms.GunaGradientPanel pnl_DangNhap;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_Image;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txt_MatKhau;
        private Bunifu.Framework.UI.BunifuImageButton btn_Hide;
        private Guna.UI2.WinForms.Guna2Button btn_DangNhap;
        private Guna.UI.WinForms.GunaLabel lbl_ThongBao;
        private Bunifu.Framework.UI.BunifuDragControl drc_DangNhap;
    }
}