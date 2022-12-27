
namespace HaKi_Piece
{
    partial class frm_CTThanhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTThanhVien));
            this.lbl_MaTV = new System.Windows.Forms.Label();
            this.txt_MaTV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.dvw_PHcuaTV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoanTat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_TTThanhVien = new System.Windows.Forms.Label();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_PHcuaTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaTV
            // 
            this.lbl_MaTV.AutoSize = true;
            this.lbl_MaTV.Location = new System.Drawing.Point(27, 71);
            this.lbl_MaTV.Name = "lbl_MaTV";
            this.lbl_MaTV.Size = new System.Drawing.Size(49, 17);
            this.lbl_MaTV.TabIndex = 0;
            this.lbl_MaTV.Text = "Mã TV";
            // 
            // txt_MaTV
            // 
            this.txt_MaTV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaTV.DefaultText = "";
            this.txt_MaTV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaTV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaTV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaTV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaTV.Enabled = false;
            this.txt_MaTV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaTV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaTV.Location = new System.Drawing.Point(118, 62);
            this.txt_MaTV.Name = "txt_MaTV";
            this.txt_MaTV.PasswordChar = '\0';
            this.txt_MaTV.PlaceholderText = "";
            this.txt_MaTV.SelectedText = "";
            this.txt_MaTV.Size = new System.Drawing.Size(200, 36);
            this.txt_MaTV.TabIndex = 1;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenKH.DefaultText = "";
            this.txt_TenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenKH.Location = new System.Drawing.Point(118, 145);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.PasswordChar = '\0';
            this.txt_TenKH.PlaceholderText = "";
            this.txt_TenKH.SelectedText = "";
            this.txt_TenKH.Size = new System.Drawing.Size(200, 36);
            this.txt_TenKH.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.DefaultText = "";
            this.txt_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(118, 203);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(209, 89);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.DefaultText = "";
            this.txt_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SDT.Location = new System.Drawing.Point(118, 311);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.PlaceholderText = "";
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(209, 41);
            this.txt_SDT.TabIndex = 4;
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Location = new System.Drawing.Point(27, 145);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(56, 17);
            this.lbl_TenKH.TabIndex = 5;
            this.lbl_TenKH.Text = "Tên KH";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(32, 217);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(51, 17);
            this.lbl_DiaChi.TabIndex = 5;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Location = new System.Drawing.Point(32, 321);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(36, 17);
            this.lbl_SDT.TabIndex = 5;
            this.lbl_SDT.Text = "SĐT";
            // 
            // dvw_PHcuaTV
            // 
            this.dvw_PHcuaTV.AllowUserToAddRows = false;
            this.dvw_PHcuaTV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvw_PHcuaTV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvw_PHcuaTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_PHcuaTV.BackgroundColor = System.Drawing.Color.White;
            this.dvw_PHcuaTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvw_PHcuaTV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_PHcuaTV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvw_PHcuaTV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvw_PHcuaTV.ColumnHeadersHeight = 27;
            this.dvw_PHcuaTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaPH,
            this.col_MaHD,
            this.col_ThanhVien,
            this.col_DiaChi,
            this.col_NgayHen,
            this.col_HoanTat});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvw_PHcuaTV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvw_PHcuaTV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvw_PHcuaTV.EnableHeadersVisualStyles = false;
            this.dvw_PHcuaTV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_PHcuaTV.Location = new System.Drawing.Point(374, 0);
            this.dvw_PHcuaTV.Name = "dvw_PHcuaTV";
            this.dvw_PHcuaTV.RowHeadersVisible = false;
            this.dvw_PHcuaTV.RowHeadersWidth = 51;
            this.dvw_PHcuaTV.RowTemplate.Height = 24;
            this.dvw_PHcuaTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvw_PHcuaTV.Size = new System.Drawing.Size(846, 454);
            this.dvw_PHcuaTV.TabIndex = 6;
            this.dvw_PHcuaTV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_PHcuaTV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvw_PHcuaTV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvw_PHcuaTV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvw_PHcuaTV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvw_PHcuaTV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvw_PHcuaTV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_PHcuaTV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dvw_PHcuaTV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvw_PHcuaTV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_PHcuaTV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvw_PHcuaTV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvw_PHcuaTV.ThemeStyle.HeaderStyle.Height = 27;
            this.dvw_PHcuaTV.ThemeStyle.ReadOnly = false;
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.Height = 24;
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_PHcuaTV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // col_MaPH
            // 
            this.col_MaPH.DataPropertyName = "MaPH";
            this.col_MaPH.FillWeight = 71.52406F;
            this.col_MaPH.HeaderText = "Mã PH";
            this.col_MaPH.MinimumWidth = 6;
            this.col_MaPH.Name = "col_MaPH";
            this.col_MaPH.ReadOnly = true;
            // 
            // col_MaHD
            // 
            this.col_MaHD.DataPropertyName = "MaHD";
            this.col_MaHD.FillWeight = 71.52406F;
            this.col_MaHD.HeaderText = "Mã HD";
            this.col_MaHD.MinimumWidth = 6;
            this.col_MaHD.Name = "col_MaHD";
            this.col_MaHD.ReadOnly = true;
            // 
            // col_ThanhVien
            // 
            this.col_ThanhVien.DataPropertyName = "ThanhVien";
            this.col_ThanhVien.HeaderText = "Thành viên";
            this.col_ThanhVien.MinimumWidth = 6;
            this.col_ThanhVien.Name = "col_ThanhVien";
            this.col_ThanhVien.Visible = false;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DiaChiGiao";
            this.col_DiaChi.FillWeight = 213.9037F;
            this.col_DiaChi.HeaderText = "Địa chỉ giao hàng";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_NgayHen
            // 
            this.col_NgayHen.DataPropertyName = "NgayHen";
            this.col_NgayHen.FillWeight = 71.52406F;
            this.col_NgayHen.HeaderText = "Ngày hẹn";
            this.col_NgayHen.MinimumWidth = 6;
            this.col_NgayHen.Name = "col_NgayHen";
            // 
            // col_HoanTat
            // 
            this.col_HoanTat.DataPropertyName = "TrangThai";
            this.col_HoanTat.FillWeight = 71.52406F;
            this.col_HoanTat.HeaderText = "Hoàn tất";
            this.col_HoanTat.MinimumWidth = 6;
            this.col_HoanTat.Name = "col_HoanTat";
            this.col_HoanTat.ReadOnly = true;
            // 
            // lbl_TTThanhVien
            // 
            this.lbl_TTThanhVien.AutoSize = true;
            this.lbl_TTThanhVien.Location = new System.Drawing.Point(106, 24);
            this.lbl_TTThanhVien.Name = "lbl_TTThanhVien";
            this.lbl_TTThanhVien.Size = new System.Drawing.Size(172, 17);
            this.lbl_TTThanhVien.TabIndex = 0;
            this.lbl_TTThanhVien.Text = "THÔNG TIN THÀNH VIÊN";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(2, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 41);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 7;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(262, 393);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(88, 45);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            // 
            // frm_CTThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 454);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dvw_PHcuaTV);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_TenKH);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.txt_MaTV);
            this.Controls.Add(this.lbl_TTThanhVien);
            this.Controls.Add(this.lbl_MaTV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_CTThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_CTThanhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvw_PHcuaTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaTV;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_SDT;
        private Guna.UI2.WinForms.Guna2DataGridView dvw_PHcuaTV;
        private System.Windows.Forms.Label lbl_TTThanhVien;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        public Guna.UI2.WinForms.Guna2TextBox txt_MaTV;
        public Guna.UI2.WinForms.Guna2TextBox txt_TenKH;
        public Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        public Guna.UI2.WinForms.Guna2TextBox txt_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayHen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_HoanTat;
    }
}