
namespace HaKi_Piece
{
    partial class frm_ThemSuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemSuKien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Frame1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.dvw_CTHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_ThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Them = new System.Windows.Forms.Label();
            this.lbl_Tra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_TTHoaDon = new System.Windows.Forms.Panel();
            this.pnl_Frame2 = new System.Windows.Forms.Panel();
            this.pnl_HoaDon = new System.Windows.Forms.Panel();
            this.ils_Nuoc = new System.Windows.Forms.ImageList(this.components);
            this.pnl_SanPham = new System.Windows.Forms.Panel();
            this.pnl_Frame3 = new System.Windows.Forms.Panel();
            this.col_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Bot = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Giam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HinhThuc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_CTHoaDon)).BeginInit();
            this.pnl_TTHoaDon.SuspendLayout();
            this.pnl_HoaDon.SuspendLayout();
            this.pnl_SanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Frame1
            // 
            this.pnl_Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Frame1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Frame1.Location = new System.Drawing.Point(0, 0);
            this.pnl_Frame1.Name = "pnl_Frame1";
            this.pnl_Frame1.Size = new System.Drawing.Size(10, 828);
            this.pnl_Frame1.TabIndex = 2;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageActive = null;
            this.btn_Delete.Location = new System.Drawing.Point(550, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(50, 50);
            this.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Zoom = 10;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dvw_CTHoaDon
            // 
            this.dvw_CTHoaDon.AllowUserToAddRows = false;
            this.dvw_CTHoaDon.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvw_CTHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvw_CTHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_CTHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvw_CTHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_CTHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvw_CTHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvw_CTHoaDon.ColumnHeadersHeight = 27;
            this.dvw_CTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSP,
            this.col_TenSP,
            this.col_GiaBan,
            this.btn_Them,
            this.col_SoLuong,
            this.btn_Bot,
            this.col_Giam,
            this.col_HinhThuc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvw_CTHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvw_CTHoaDon.EnableHeadersVisualStyles = false;
            this.dvw_CTHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_CTHoaDon.Location = new System.Drawing.Point(0, 111);
            this.dvw_CTHoaDon.Name = "dvw_CTHoaDon";
            this.dvw_CTHoaDon.RowHeadersVisible = false;
            this.dvw_CTHoaDon.RowHeadersWidth = 51;
            this.dvw_CTHoaDon.RowTemplate.Height = 24;
            this.dvw_CTHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvw_CTHoaDon.Size = new System.Drawing.Size(600, 570);
            this.dvw_CTHoaDon.TabIndex = 2;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvw_CTHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.Height = 27;
            this.dvw_CTHoaDon.ThemeStyle.ReadOnly = false;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.BorderRadius = 15;
            this.btn_ThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(105, 766);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(353, 50);
            this.btn_ThanhToan.TabIndex = 1;
            this.btn_ThanhToan.Text = "ÁP DỤNG";
            // 
            // lbl_Them
            // 
            this.lbl_Them.AutoSize = true;
            this.lbl_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Them.ForeColor = System.Drawing.Color.White;
            this.lbl_Them.Location = new System.Drawing.Point(21, 35);
            this.lbl_Them.Name = "lbl_Them";
            this.lbl_Them.Size = new System.Drawing.Size(224, 32);
            this.lbl_Them.TabIndex = 0;
            this.lbl_Them.Text = "THÊM SỰ KIỆN";
            // 
            // lbl_Tra
            // 
            this.lbl_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Tra.Location = new System.Drawing.Point(298, 703);
            this.lbl_Tra.Name = "lbl_Tra";
            this.lbl_Tra.Size = new System.Drawing.Size(300, 20);
            this.lbl_Tra.TabIndex = 4;
            this.lbl_Tra.Text = "0";
            this.lbl_Tra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TỔNG DOANH THU GIẢM";
            // 
            // pnl_TTHoaDon
            // 
            this.pnl_TTHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_TTHoaDon.Controls.Add(this.lbl_Them);
            this.pnl_TTHoaDon.Controls.Add(this.btn_Delete);
            this.pnl_TTHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TTHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnl_TTHoaDon.Name = "pnl_TTHoaDon";
            this.pnl_TTHoaDon.Size = new System.Drawing.Size(600, 100);
            this.pnl_TTHoaDon.TabIndex = 3;
            // 
            // pnl_Frame2
            // 
            this.pnl_Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Frame2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame2.Location = new System.Drawing.Point(1041, 0);
            this.pnl_Frame2.Name = "pnl_Frame2";
            this.pnl_Frame2.Size = new System.Drawing.Size(10, 828);
            this.pnl_Frame2.TabIndex = 3;
            // 
            // pnl_HoaDon
            // 
            this.pnl_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_HoaDon.Controls.Add(this.lbl_Tra);
            this.pnl_HoaDon.Controls.Add(this.label1);
            this.pnl_HoaDon.Controls.Add(this.pnl_TTHoaDon);
            this.pnl_HoaDon.Controls.Add(this.btn_ThanhToan);
            this.pnl_HoaDon.Controls.Add(this.dvw_CTHoaDon);
            this.pnl_HoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_HoaDon.Location = new System.Drawing.Point(1051, 0);
            this.pnl_HoaDon.Name = "pnl_HoaDon";
            this.pnl_HoaDon.Size = new System.Drawing.Size(600, 828);
            this.pnl_HoaDon.TabIndex = 6;
            // 
            // ils_Nuoc
            // 
            this.ils_Nuoc.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ils_Nuoc.ImageSize = new System.Drawing.Size(100, 100);
            this.ils_Nuoc.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnl_SanPham
            // 
            this.pnl_SanPham.BackColor = System.Drawing.Color.White;
            this.pnl_SanPham.Controls.Add(this.panel1);
            this.pnl_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SanPham.Location = new System.Drawing.Point(10, 0);
            this.pnl_SanPham.Name = "pnl_SanPham";
            this.pnl_SanPham.Size = new System.Drawing.Size(1031, 828);
            this.pnl_SanPham.TabIndex = 4;
            // 
            // pnl_Frame3
            // 
            this.pnl_Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Frame3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame3.Location = new System.Drawing.Point(1651, 0);
            this.pnl_Frame3.Name = "pnl_Frame3";
            this.pnl_Frame3.Size = new System.Drawing.Size(10, 828);
            this.pnl_Frame3.TabIndex = 5;
            // 
            // col_MaSP
            // 
            this.col_MaSP.FillWeight = 50F;
            this.col_MaSP.HeaderText = "MaSP";
            this.col_MaSP.MinimumWidth = 6;
            this.col_MaSP.Name = "col_MaSP";
            this.col_MaSP.ReadOnly = true;
            // 
            // col_TenSP
            // 
            this.col_TenSP.HeaderText = "Tên SP";
            this.col_TenSP.MinimumWidth = 6;
            this.col_TenSP.Name = "col_TenSP";
            this.col_TenSP.ReadOnly = true;
            this.col_TenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_GiaBan
            // 
            this.col_GiaBan.FillWeight = 65.94291F;
            this.col_GiaBan.HeaderText = "Giá bán";
            this.col_GiaBan.MinimumWidth = 6;
            this.col_GiaBan.Name = "col_GiaBan";
            this.col_GiaBan.ReadOnly = true;
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_Them.FillWeight = 10F;
            this.btn_Them.HeaderText = "";
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_Them.MinimumWidth = 6;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Them.Width = 6;
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.FillWeight = 20F;
            this.col_SoLuong.HeaderText = "SL Tối thiểu";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // btn_Bot
            // 
            this.btn_Bot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_Bot.FillWeight = 10F;
            this.btn_Bot.HeaderText = "";
            this.btn_Bot.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bot.Image")));
            this.btn_Bot.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_Bot.MinimumWidth = 6;
            this.btn_Bot.Name = "btn_Bot";
            this.btn_Bot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Bot.Width = 6;
            // 
            // col_Giam
            // 
            this.col_Giam.FillWeight = 76.82108F;
            this.col_Giam.HeaderText = "Giảm giá";
            this.col_Giam.MinimumWidth = 6;
            this.col_Giam.Name = "col_Giam";
            this.col_Giam.ReadOnly = true;
            // 
            // col_HinhThuc
            // 
            this.col_HinhThuc.HeaderText = "Hình thức";
            this.col_HinhThuc.MinimumWidth = 6;
            this.col_HinhThuc.Name = "col_HinhThuc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 818);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 10);
            this.panel1.TabIndex = 4;
            // 
            // frm_ThemSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 828);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_SanPham);
            this.Controls.Add(this.pnl_Frame1);
            this.Controls.Add(this.pnl_Frame2);
            this.Controls.Add(this.pnl_HoaDon);
            this.Controls.Add(this.pnl_Frame3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_ThemSuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_CTHoaDon)).EndInit();
            this.pnl_TTHoaDon.ResumeLayout(false);
            this.pnl_TTHoaDon.PerformLayout();
            this.pnl_HoaDon.ResumeLayout(false);
            this.pnl_HoaDon.PerformLayout();
            this.pnl_SanPham.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Frame1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Delete;
        public Guna.UI2.WinForms.Guna2DataGridView dvw_CTHoaDon;
        private Guna.UI2.WinForms.Guna2Button btn_ThanhToan;
        private System.Windows.Forms.Label lbl_Them;
        private System.Windows.Forms.Label lbl_Tra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_TTHoaDon;
        private System.Windows.Forms.Panel pnl_Frame2;
        private System.Windows.Forms.Panel pnl_HoaDon;
        private System.Windows.Forms.ImageList ils_Nuoc;
        private System.Windows.Forms.Panel pnl_SanPham;
        private System.Windows.Forms.Panel pnl_Frame3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaBan;
        private System.Windows.Forms.DataGridViewImageColumn btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewImageColumn btn_Bot;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Giam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_HinhThuc;
        private System.Windows.Forms.Panel panel1;
    }
}