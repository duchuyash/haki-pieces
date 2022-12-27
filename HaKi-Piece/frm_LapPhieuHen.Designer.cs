
namespace HaKi_Piece
{
    partial class frm_LapPhieuHen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LapPhieuHen));
            this.dvw_DSTV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ThongTinTV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.txt_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.txt_TenKH = new Guna.UI.WinForms.GunaTextBox();
            this.txt_MaTV = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.lbl_MaTV = new System.Windows.Forms.Label();
            this.grp_ThongTinPH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtp_NgayGiao = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_DCGiaoHang = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_NgayGiao = new System.Windows.Forms.Label();
            this.lbl_DCGiao = new System.Windows.Forms.Label();
            this.btn_Huy = new Bunifu.Framework.UI.BunifuImageButton();
            this.pic_TimKiem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ThenTV = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_HoanThanh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_HuyPhieuHen = new Guna.UI2.WinForms.Guna2Button();
            this.elp_NgayGiao = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_Border = new System.Windows.Forms.Panel();
            this.pnl_Form = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSTV)).BeginInit();
            this.grp_ThongTinTV.SuspendLayout();
            this.grp_ThongTinPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Huy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ThenTV)).BeginInit();
            this.pnl_Border.SuspendLayout();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvw_DSTV
            // 
            this.dvw_DSTV.AllowUserToAddRows = false;
            this.dvw_DSTV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dvw_DSTV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvw_DSTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvw_DSTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_DSTV.BackgroundColor = System.Drawing.Color.White;
            this.dvw_DSTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvw_DSTV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_DSTV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvw_DSTV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvw_DSTV.ColumnHeadersHeight = 27;
            this.dvw_DSTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaTV,
            this.col_TenKH,
            this.col_DiaChi,
            this.col_SDT});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvw_DSTV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvw_DSTV.EnableHeadersVisualStyles = false;
            this.dvw_DSTV.GridColor = System.Drawing.Color.White;
            this.dvw_DSTV.Location = new System.Drawing.Point(7, 545);
            this.dvw_DSTV.Name = "dvw_DSTV";
            this.dvw_DSTV.ReadOnly = true;
            this.dvw_DSTV.RowHeadersVisible = false;
            this.dvw_DSTV.RowHeadersWidth = 51;
            this.dvw_DSTV.RowTemplate.Height = 24;
            this.dvw_DSTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvw_DSTV.Size = new System.Drawing.Size(1044, 299);
            this.dvw_DSTV.TabIndex = 0;
            this.dvw_DSTV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dvw_DSTV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dvw_DSTV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvw_DSTV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvw_DSTV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvw_DSTV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvw_DSTV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvw_DSTV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dvw_DSTV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dvw_DSTV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvw_DSTV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_DSTV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvw_DSTV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvw_DSTV.ThemeStyle.HeaderStyle.Height = 27;
            this.dvw_DSTV.ThemeStyle.ReadOnly = true;
            this.dvw_DSTV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dvw_DSTV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_DSTV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_DSTV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dvw_DSTV.ThemeStyle.RowsStyle.Height = 24;
            this.dvw_DSTV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dvw_DSTV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dvw_DSTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvw_DSTV_CellClick);
            // 
            // col_MaTV
            // 
            this.col_MaTV.DataPropertyName = "MaTV";
            this.col_MaTV.FillWeight = 50F;
            this.col_MaTV.HeaderText = "Mã TV";
            this.col_MaTV.MinimumWidth = 6;
            this.col_MaTV.Name = "col_MaTV";
            this.col_MaTV.ReadOnly = true;
            // 
            // col_TenKH
            // 
            this.col_TenKH.DataPropertyName = "TenKH";
            this.col_TenKH.HeaderText = "Tên KH";
            this.col_TenKH.MinimumWidth = 6;
            this.col_TenKH.Name = "col_TenKH";
            this.col_TenKH.ReadOnly = true;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.FillWeight = 200F;
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            // 
            // col_SDT
            // 
            this.col_SDT.DataPropertyName = "SDT";
            this.col_SDT.HeaderText = "SĐT";
            this.col_SDT.MinimumWidth = 6;
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.ReadOnly = true;
            // 
            // grp_ThongTinTV
            // 
            this.grp_ThongTinTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_ThongTinTV.BackColor = System.Drawing.Color.White;
            this.grp_ThongTinTV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.grp_ThongTinTV.BorderRadius = 15;
            this.grp_ThongTinTV.Controls.Add(this.txt_SDT);
            this.grp_ThongTinTV.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTinTV.Controls.Add(this.txt_TenKH);
            this.grp_ThongTinTV.Controls.Add(this.txt_MaTV);
            this.grp_ThongTinTV.Controls.Add(this.lbl_SDT);
            this.grp_ThongTinTV.Controls.Add(this.lbl_DiaChi);
            this.grp_ThongTinTV.Controls.Add(this.lbl_TenKH);
            this.grp_ThongTinTV.Controls.Add(this.lbl_MaTV);
            this.grp_ThongTinTV.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.grp_ThongTinTV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinTV.ForeColor = System.Drawing.Color.Black;
            this.grp_ThongTinTV.Location = new System.Drawing.Point(12, 57);
            this.grp_ThongTinTV.Name = "grp_ThongTinTV";
            this.grp_ThongTinTV.Size = new System.Drawing.Size(510, 382);
            this.grp_ThongTinTV.TabIndex = 1;
            this.grp_ThongTinTV.Text = "Thông tin thành viên";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SDT.BackColor = System.Drawing.Color.Transparent;
            this.txt_SDT.BaseColor = System.Drawing.Color.White;
            this.txt_SDT.BorderColor = System.Drawing.Color.Silver;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.Location = new System.Drawing.Point(171, 319);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.Radius = 10;
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(306, 40);
            this.txt_SDT.TabIndex = 7;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txt_DiaChi.BaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.Location = new System.Drawing.Point(171, 176);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.Radius = 10;
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(306, 100);
            this.txt_DiaChi.TabIndex = 7;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenKH.BaseColor = System.Drawing.Color.White;
            this.txt_TenKH.BorderColor = System.Drawing.Color.Silver;
            this.txt_TenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenKH.Enabled = false;
            this.txt_TenKH.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TenKH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TenKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenKH.Location = new System.Drawing.Point(171, 116);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.PasswordChar = '\0';
            this.txt_TenKH.Radius = 10;
            this.txt_TenKH.SelectedText = "";
            this.txt_TenKH.Size = new System.Drawing.Size(306, 40);
            this.txt_TenKH.TabIndex = 7;
            this.txt_TenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenKH_KeyPress);
            // 
            // txt_MaTV
            // 
            this.txt_MaTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaTV.BackColor = System.Drawing.Color.Transparent;
            this.txt_MaTV.BaseColor = System.Drawing.Color.White;
            this.txt_MaTV.BorderColor = System.Drawing.Color.Silver;
            this.txt_MaTV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaTV.Enabled = false;
            this.txt_MaTV.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaTV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaTV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaTV.Location = new System.Drawing.Point(171, 60);
            this.txt_MaTV.Name = "txt_MaTV";
            this.txt_MaTV.PasswordChar = '\0';
            this.txt_MaTV.Radius = 10;
            this.txt_MaTV.SelectedText = "";
            this.txt_MaTV.Size = new System.Drawing.Size(306, 40);
            this.txt_MaTV.TabIndex = 7;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.BackColor = System.Drawing.Color.White;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(21, 326);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(111, 23);
            this.lbl_SDT.TabIndex = 6;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.BackColor = System.Drawing.Color.White;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(21, 192);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(62, 23);
            this.lbl_DiaChi.TabIndex = 4;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.BackColor = System.Drawing.Color.White;
            this.lbl_TenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKH.Location = new System.Drawing.Point(21, 128);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(130, 23);
            this.lbl_TenKH.TabIndex = 2;
            this.lbl_TenKH.Text = "Tên khách hàng";
            // 
            // lbl_MaTV
            // 
            this.lbl_MaTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MaTV.AutoSize = true;
            this.lbl_MaTV.BackColor = System.Drawing.Color.White;
            this.lbl_MaTV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTV.Location = new System.Drawing.Point(21, 66);
            this.lbl_MaTV.Name = "lbl_MaTV";
            this.lbl_MaTV.Size = new System.Drawing.Size(120, 23);
            this.lbl_MaTV.TabIndex = 0;
            this.lbl_MaTV.Text = "Mã thành viên";
            // 
            // grp_ThongTinPH
            // 
            this.grp_ThongTinPH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_ThongTinPH.BackColor = System.Drawing.Color.White;
            this.grp_ThongTinPH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.grp_ThongTinPH.BorderRadius = 15;
            this.grp_ThongTinPH.Controls.Add(this.dtp_NgayGiao);
            this.grp_ThongTinPH.Controls.Add(this.txt_DCGiaoHang);
            this.grp_ThongTinPH.Controls.Add(this.lbl_NgayGiao);
            this.grp_ThongTinPH.Controls.Add(this.lbl_DCGiao);
            this.grp_ThongTinPH.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.grp_ThongTinPH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinPH.ForeColor = System.Drawing.Color.Black;
            this.grp_ThongTinPH.Location = new System.Drawing.Point(565, 58);
            this.grp_ThongTinPH.Name = "grp_ThongTinPH";
            this.grp_ThongTinPH.Size = new System.Drawing.Size(486, 382);
            this.grp_ThongTinPH.TabIndex = 1;
            this.grp_ThongTinPH.Text = "Thông tin phiếu hẹn";
            // 
            // dtp_NgayGiao
            // 
            this.dtp_NgayGiao.BackColor = System.Drawing.Color.Transparent;
            this.dtp_NgayGiao.BaseColor = System.Drawing.Color.White;
            this.dtp_NgayGiao.BorderColor = System.Drawing.Color.Silver;
            this.dtp_NgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayGiao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_NgayGiao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayGiao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayGiao.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGiao.Location = new System.Drawing.Point(171, 313);
            this.dtp_NgayGiao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayGiao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayGiao.Name = "dtp_NgayGiao";
            this.dtp_NgayGiao.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgayGiao.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayGiao.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayGiao.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgayGiao.Radius = 10;
            this.dtp_NgayGiao.Size = new System.Drawing.Size(260, 46);
            this.dtp_NgayGiao.TabIndex = 8;
            this.dtp_NgayGiao.Text = "18/06/2022";
            this.dtp_NgayGiao.Value = new System.DateTime(2022, 6, 18, 13, 31, 7, 997);
            // 
            // txt_DCGiaoHang
            // 
            this.txt_DCGiaoHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_DCGiaoHang.BackColor = System.Drawing.Color.Transparent;
            this.txt_DCGiaoHang.BaseColor = System.Drawing.Color.White;
            this.txt_DCGiaoHang.BorderColor = System.Drawing.Color.Silver;
            this.txt_DCGiaoHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DCGiaoHang.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DCGiaoHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DCGiaoHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DCGiaoHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DCGiaoHang.Location = new System.Drawing.Point(52, 96);
            this.txt_DCGiaoHang.Multiline = true;
            this.txt_DCGiaoHang.Name = "txt_DCGiaoHang";
            this.txt_DCGiaoHang.PasswordChar = '\0';
            this.txt_DCGiaoHang.Radius = 10;
            this.txt_DCGiaoHang.SelectedText = "";
            this.txt_DCGiaoHang.Size = new System.Drawing.Size(379, 170);
            this.txt_DCGiaoHang.TabIndex = 7;
            // 
            // lbl_NgayGiao
            // 
            this.lbl_NgayGiao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NgayGiao.AutoSize = true;
            this.lbl_NgayGiao.BackColor = System.Drawing.Color.White;
            this.lbl_NgayGiao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayGiao.Location = new System.Drawing.Point(48, 326);
            this.lbl_NgayGiao.Name = "lbl_NgayGiao";
            this.lbl_NgayGiao.Size = new System.Drawing.Size(88, 23);
            this.lbl_NgayGiao.TabIndex = 2;
            this.lbl_NgayGiao.Text = "Ngày giao";
            // 
            // lbl_DCGiao
            // 
            this.lbl_DCGiao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DCGiao.AutoSize = true;
            this.lbl_DCGiao.BackColor = System.Drawing.Color.White;
            this.lbl_DCGiao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DCGiao.Location = new System.Drawing.Point(34, 60);
            this.lbl_DCGiao.Name = "lbl_DCGiao";
            this.lbl_DCGiao.Size = new System.Drawing.Size(144, 23);
            this.lbl_DCGiao.TabIndex = 0;
            this.lbl_DCGiao.Text = "Địa chỉ giao hàng";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageActive = null;
            this.btn_Huy.Location = new System.Drawing.Point(106, 471);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(30, 30);
            this.btn_Huy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Huy.TabIndex = 8;
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
            this.pic_TimKiem.Location = new System.Drawing.Point(471, 467);
            this.pic_TimKiem.Name = "pic_TimKiem";
            this.pic_TimKiem.Size = new System.Drawing.Size(35, 35);
            this.pic_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_TimKiem.TabIndex = 7;
            this.pic_TimKiem.TabStop = false;
            this.pic_TimKiem.UseTransparentBackground = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TimKiem.BackColor = System.Drawing.Color.White;
            this.txt_TimKiem.BorderRadius = 15;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.IconLeftSize = new System.Drawing.Size(0, 0);
            this.txt_TimKiem.IconRightSize = new System.Drawing.Size(0, 0);
            this.txt_TimKiem.Location = new System.Drawing.Point(96, 462);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.PlaceholderText = "Nhập từ khóa tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(421, 46);
            this.txt_TimKiem.TabIndex = 6;
            this.txt_TimKiem.TextOffset = new System.Drawing.Point(30, 0);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // btn_ThenTV
            // 
            this.btn_ThenTV.BackColor = System.Drawing.Color.White;
            this.btn_ThenTV.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThenTV.Image")));
            this.btn_ThenTV.ImageActive = null;
            this.btn_ThenTV.Location = new System.Drawing.Point(12, 445);
            this.btn_ThenTV.Name = "btn_ThenTV";
            this.btn_ThenTV.Size = new System.Drawing.Size(71, 71);
            this.btn_ThenTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ThenTV.TabIndex = 9;
            this.btn_ThenTV.TabStop = false;
            this.btn_ThenTV.Zoom = 10;
            this.btn_ThenTV.Click += new System.EventHandler(this.btn_ThenTV_Click);
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_HoanThanh.BackColor = System.Drawing.Color.White;
            this.btn_HoanThanh.BorderRadius = 15;
            this.btn_HoanThanh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_HoanThanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HoanThanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HoanThanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HoanThanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HoanThanh.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.ForeColor = System.Drawing.Color.White;
            this.btn_HoanThanh.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoanThanh.Image")));
            this.btn_HoanThanh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_HoanThanh.Location = new System.Drawing.Point(800, 456);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(251, 59);
            this.btn_HoanThanh.TabIndex = 10;
            this.btn_HoanThanh.Text = "HOÀN THÀNH";
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // btn_HuyPhieuHen
            // 
            this.btn_HuyPhieuHen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_HuyPhieuHen.BackColor = System.Drawing.Color.White;
            this.btn_HuyPhieuHen.BorderRadius = 15;
            this.btn_HuyPhieuHen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_HuyPhieuHen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HuyPhieuHen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HuyPhieuHen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HuyPhieuHen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HuyPhieuHen.FillColor = System.Drawing.Color.LightCoral;
            this.btn_HuyPhieuHen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyPhieuHen.ForeColor = System.Drawing.Color.White;
            this.btn_HuyPhieuHen.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyPhieuHen.Image")));
            this.btn_HuyPhieuHen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_HuyPhieuHen.Location = new System.Drawing.Point(544, 456);
            this.btn_HuyPhieuHen.Name = "btn_HuyPhieuHen";
            this.btn_HuyPhieuHen.Size = new System.Drawing.Size(250, 59);
            this.btn_HuyPhieuHen.TabIndex = 10;
            this.btn_HuyPhieuHen.Text = "HỦY PHIẾU HẸN";
            this.btn_HuyPhieuHen.Click += new System.EventHandler(this.btn_HuyPhieuHen_Click);
            // 
            // elp_NgayGiao
            // 
            this.elp_NgayGiao.BorderRadius = 15;
            // 
            // pnl_Border
            // 
            this.pnl_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_Border.Controls.Add(this.pnl_Form);
            this.pnl_Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border.Location = new System.Drawing.Point(0, 0);
            this.pnl_Border.Name = "pnl_Border";
            this.pnl_Border.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Border.Size = new System.Drawing.Size(1068, 855);
            this.pnl_Border.TabIndex = 11;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.White;
            this.pnl_Form.Controls.Add(this.btn_HuyPhieuHen);
            this.pnl_Form.Controls.Add(this.grp_ThongTinPH);
            this.pnl_Form.Controls.Add(this.btn_HoanThanh);
            this.pnl_Form.Controls.Add(this.dvw_DSTV);
            this.pnl_Form.Controls.Add(this.btn_ThenTV);
            this.pnl_Form.Controls.Add(this.grp_ThongTinTV);
            this.pnl_Form.Controls.Add(this.btn_Huy);
            this.pnl_Form.Controls.Add(this.txt_TimKiem);
            this.pnl_Form.Controls.Add(this.pic_TimKiem);
            this.pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Form.Location = new System.Drawing.Point(5, 5);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1058, 845);
            this.pnl_Form.TabIndex = 0;
            // 
            // frm_LapPhieuHen
            // 
            this.AcceptButton = this.btn_HoanThanh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1068, 855);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LapPhieuHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSTV)).EndInit();
            this.grp_ThongTinTV.ResumeLayout(false);
            this.grp_ThongTinTV.PerformLayout();
            this.grp_ThongTinPH.ResumeLayout(false);
            this.grp_ThongTinPH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Huy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ThenTV)).EndInit();
            this.pnl_Border.ResumeLayout(false);
            this.pnl_Form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dvw_DSTV;
        private Guna.UI2.WinForms.Guna2GroupBox grp_ThongTinTV;
        private Guna.UI2.WinForms.Guna2GroupBox grp_ThongTinPH;
        private Bunifu.Framework.UI.BunifuImageButton btn_Huy;
        private Guna.UI2.WinForms.Guna2PictureBox pic_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Bunifu.Framework.UI.BunifuImageButton btn_ThenTV;
        private Guna.UI2.WinForms.Guna2Button btn_HoanThanh;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.Label lbl_MaTV;
        private System.Windows.Forms.Label lbl_NgayGiao;
        private System.Windows.Forms.Label lbl_DCGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private Guna.UI2.WinForms.Guna2Elipse elp_NgayGiao;
        private System.Windows.Forms.Panel pnl_Border;
        private System.Windows.Forms.Panel pnl_Form;
        public Guna.UI.WinForms.GunaTextBox txt_SDT;
        public Guna.UI.WinForms.GunaTextBox txt_DiaChi;
        public Guna.UI.WinForms.GunaTextBox txt_TenKH;
        public Guna.UI.WinForms.GunaTextBox txt_MaTV;
        public Guna.UI.WinForms.GunaTextBox txt_DCGiaoHang;
        public Guna.UI.WinForms.GunaDateTimePicker dtp_NgayGiao;
        public Guna.UI2.WinForms.Guna2Button btn_HuyPhieuHen;
    }
}