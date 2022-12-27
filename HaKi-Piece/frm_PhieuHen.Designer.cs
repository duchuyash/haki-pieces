
namespace HaKi_Piece
{
    partial class frm_PhieuHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhieuHen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_NgayGiao = new System.Windows.Forms.Label();
            this.lbl_DCGiao = new System.Windows.Forms.Label();
            this.txt_TenKH = new Guna.UI.WinForms.GunaTextBox();
            this.btn_HoanThanh = new Guna.UI2.WinForms.Guna2Button();
            this.txt_MaTV = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.elp_NgayGiao = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.dvw_CTHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Frame3 = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.grp_ThongTinPH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtp_NgayGiao = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_DCGiaoHang = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_MaTV = new System.Windows.Forms.Label();
            this.pnl_Border = new System.Windows.Forms.Panel();
            this.pnl_Form.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_CTHoaDon)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_Left.SuspendLayout();
            this.grp_ThongTinPH.SuspendLayout();
            this.pnl_Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NgayGiao
            // 
            this.lbl_NgayGiao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NgayGiao.AutoSize = true;
            this.lbl_NgayGiao.BackColor = System.Drawing.Color.White;
            this.lbl_NgayGiao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayGiao.Location = new System.Drawing.Point(26, 496);
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
            this.lbl_DCGiao.Location = new System.Drawing.Point(26, 227);
            this.lbl_DCGiao.Name = "lbl_DCGiao";
            this.lbl_DCGiao.Size = new System.Drawing.Size(144, 23);
            this.lbl_DCGiao.TabIndex = 0;
            this.lbl_DCGiao.Text = "Địa chỉ giao hàng";
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
            this.txt_TenKH.Location = new System.Drawing.Point(175, 149);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.PasswordChar = '\0';
            this.txt_TenKH.Radius = 10;
            this.txt_TenKH.ReadOnly = true;
            this.txt_TenKH.SelectedText = "";
            this.txt_TenKH.Size = new System.Drawing.Size(260, 40);
            this.txt_TenKH.TabIndex = 7;
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_HoanThanh.Location = new System.Drawing.Point(254, 561);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(251, 59);
            this.btn_HoanThanh.TabIndex = 10;
            this.btn_HoanThanh.Text = "HOÀN THÀNH";
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
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
            this.txt_MaTV.Location = new System.Drawing.Point(175, 86);
            this.txt_MaTV.Name = "txt_MaTV";
            this.txt_MaTV.PasswordChar = '\0';
            this.txt_MaTV.Radius = 10;
            this.txt_MaTV.ReadOnly = true;
            this.txt_MaTV.SelectedText = "";
            this.txt_MaTV.Size = new System.Drawing.Size(260, 40);
            this.txt_MaTV.TabIndex = 7;
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.BackColor = System.Drawing.Color.White;
            this.lbl_TenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKH.Location = new System.Drawing.Point(25, 159);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(130, 23);
            this.lbl_TenKH.TabIndex = 2;
            this.lbl_TenKH.Text = "Tên khách hàng";
            // 
            // elp_NgayGiao
            // 
            this.elp_NgayGiao.BorderRadius = 15;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.White;
            this.pnl_Form.Controls.Add(this.pnl_Right);
            this.pnl_Form.Controls.Add(this.pnl_Left);
            this.pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Form.Location = new System.Drawing.Point(5, 5);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1091, 640);
            this.pnl_Form.TabIndex = 0;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Controls.Add(this.dvw_CTHoaDon);
            this.pnl_Right.Controls.Add(this.pnl_Frame3);
            this.pnl_Right.Controls.Add(this.btn_HoanThanh);
            this.pnl_Right.Controls.Add(this.pnl_Top);
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Right.Location = new System.Drawing.Point(561, 0);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(530, 640);
            this.pnl_Right.TabIndex = 12;
            // 
            // dvw_CTHoaDon
            // 
            this.dvw_CTHoaDon.AllowUserToAddRows = false;
            this.dvw_CTHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dvw_CTHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvw_CTHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_CTHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvw_CTHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_CTHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvw_CTHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvw_CTHoaDon.ColumnHeadersHeight = 40;
            this.dvw_CTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSP,
            this.col_TenSP,
            this.col_SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvw_CTHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvw_CTHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvw_CTHoaDon.EnableHeadersVisualStyles = false;
            this.dvw_CTHoaDon.GridColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.Location = new System.Drawing.Point(0, 40);
            this.dvw_CTHoaDon.Name = "dvw_CTHoaDon";
            this.dvw_CTHoaDon.ReadOnly = true;
            this.dvw_CTHoaDon.RowHeadersVisible = false;
            this.dvw_CTHoaDon.RowHeadersWidth = 51;
            this.dvw_CTHoaDon.RowTemplate.Height = 24;
            this.dvw_CTHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvw_CTHoaDon.Size = new System.Drawing.Size(505, 467);
            this.dvw_CTHoaDon.TabIndex = 0;
            this.dvw_CTHoaDon.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvw_CTHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvw_CTHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvw_CTHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            this.dvw_CTHoaDon.ThemeStyle.ReadOnly = true;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dvw_CTHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // col_MaSP
            // 
            this.col_MaSP.DataPropertyName = "MaSP";
            this.col_MaSP.FillWeight = 80F;
            this.col_MaSP.HeaderText = "Mã SP";
            this.col_MaSP.MinimumWidth = 6;
            this.col_MaSP.Name = "col_MaSP";
            this.col_MaSP.ReadOnly = true;
            // 
            // col_TenSP
            // 
            this.col_TenSP.DataPropertyName = "TenSP";
            this.col_TenSP.FillWeight = 200F;
            this.col_TenSP.HeaderText = "Tên sản phẩm";
            this.col_TenSP.MinimumWidth = 6;
            this.col_TenSP.Name = "col_TenSP";
            this.col_TenSP.ReadOnly = true;
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.DataPropertyName = "SoLuong";
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            this.col_SoLuong.ReadOnly = true;
            // 
            // pnl_Frame3
            // 
            this.pnl_Frame3.BackColor = System.Drawing.Color.White;
            this.pnl_Frame3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame3.Location = new System.Drawing.Point(505, 40);
            this.pnl_Frame3.Name = "pnl_Frame3";
            this.pnl_Frame3.Size = new System.Drawing.Size(25, 600);
            this.pnl_Frame3.TabIndex = 12;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.btn_Close);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(530, 40);
            this.pnl_Top.TabIndex = 11;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(490, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 10;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Left
            // 
            this.pnl_Left.Controls.Add(this.grp_ThongTinPH);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(561, 640);
            this.pnl_Left.TabIndex = 11;
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
            this.grp_ThongTinPH.Controls.Add(this.txt_TenKH);
            this.grp_ThongTinPH.Controls.Add(this.lbl_DCGiao);
            this.grp_ThongTinPH.Controls.Add(this.lbl_TenKH);
            this.grp_ThongTinPH.Controls.Add(this.txt_MaTV);
            this.grp_ThongTinPH.Controls.Add(this.lbl_MaTV);
            this.grp_ThongTinPH.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.grp_ThongTinPH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinPH.ForeColor = System.Drawing.Color.Black;
            this.grp_ThongTinPH.Location = new System.Drawing.Point(25, 40);
            this.grp_ThongTinPH.Name = "grp_ThongTinPH";
            this.grp_ThongTinPH.Size = new System.Drawing.Size(472, 559);
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
            this.dtp_NgayGiao.Enabled = false;
            this.dtp_NgayGiao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayGiao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayGiao.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGiao.Location = new System.Drawing.Point(163, 482);
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
            this.txt_DCGiaoHang.Location = new System.Drawing.Point(40, 263);
            this.txt_DCGiaoHang.Multiline = true;
            this.txt_DCGiaoHang.Name = "txt_DCGiaoHang";
            this.txt_DCGiaoHang.PasswordChar = '\0';
            this.txt_DCGiaoHang.Radius = 10;
            this.txt_DCGiaoHang.ReadOnly = true;
            this.txt_DCGiaoHang.SelectedText = "";
            this.txt_DCGiaoHang.Size = new System.Drawing.Size(383, 153);
            this.txt_DCGiaoHang.TabIndex = 7;
            // 
            // lbl_MaTV
            // 
            this.lbl_MaTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MaTV.AutoSize = true;
            this.lbl_MaTV.BackColor = System.Drawing.Color.White;
            this.lbl_MaTV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTV.Location = new System.Drawing.Point(25, 92);
            this.lbl_MaTV.Name = "lbl_MaTV";
            this.lbl_MaTV.Size = new System.Drawing.Size(120, 23);
            this.lbl_MaTV.TabIndex = 0;
            this.lbl_MaTV.Text = "Mã thành viên";
            // 
            // pnl_Border
            // 
            this.pnl_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_Border.Controls.Add(this.pnl_Form);
            this.pnl_Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border.Location = new System.Drawing.Point(0, 0);
            this.pnl_Border.Name = "pnl_Border";
            this.pnl_Border.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Border.Size = new System.Drawing.Size(1101, 650);
            this.pnl_Border.TabIndex = 12;
            // 
            // frm_PhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PhieuHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PhieuHen";
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvw_CTHoaDon)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_Left.ResumeLayout(false);
            this.grp_ThongTinPH.ResumeLayout(false);
            this.grp_ThongTinPH.PerformLayout();
            this.pnl_Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_NgayGiao;
        private System.Windows.Forms.Label lbl_DCGiao;
        public Guna.UI.WinForms.GunaTextBox txt_TenKH;
        private Guna.UI2.WinForms.Guna2Button btn_HoanThanh;
        public Guna.UI.WinForms.GunaTextBox txt_MaTV;
        private System.Windows.Forms.Label lbl_TenKH;
        private Guna.UI2.WinForms.Guna2Elipse elp_NgayGiao;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Label lbl_MaTV;
        private Guna.UI2.WinForms.Guna2GroupBox grp_ThongTinPH;
        public Guna.UI.WinForms.GunaDateTimePicker dtp_NgayGiao;
        public Guna.UI.WinForms.GunaTextBox txt_DCGiaoHang;
        private System.Windows.Forms.Panel pnl_Border;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.Panel pnl_Top;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.Panel pnl_Frame3;
        public Guna.UI2.WinForms.Guna2DataGridView dvw_CTHoaDon;
    }
}