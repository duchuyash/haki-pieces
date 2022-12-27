
namespace HaKi_Piece
{
    partial class frm_XemSuKien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XemSuKien));
            this.pnl_Frame1 = new System.Windows.Forms.Panel();
            this.dvw_DSSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Frame3 = new System.Windows.Forms.Panel();
            this.pnl_Frame2 = new System.Windows.Forms.Panel();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.lvw_DSSK = new System.Windows.Forms.ListView();
            this.col_MaSK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayBD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayKT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ils_DSSK = new System.Windows.Forms.ImageList(this.components);
            this.pnl_break = new System.Windows.Forms.Panel();
            this.pnl_Loc = new Guna.UI.WinForms.GunaElipsePanel();
            this.dtp_End = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtp_Begin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_Den = new System.Windows.Forms.Label();
            this.lbl_Tu = new System.Windows.Forms.Label();
            this.lbl_TatCa = new System.Windows.Forms.Label();
            this.tgg_TatCa = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.pic_Filler = new System.Windows.Forms.PictureBox();
            this.cld_Lich = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.col_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SLToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Giam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phantram = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSSP)).BeginInit();
            this.pnl_Left.SuspendLayout();
            this.pnl_Loc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Filler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cld_Lich.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Frame1
            // 
            this.pnl_Frame1.BackColor = System.Drawing.Color.White;
            this.pnl_Frame1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Frame1.Location = new System.Drawing.Point(0, 0);
            this.pnl_Frame1.Name = "pnl_Frame1";
            this.pnl_Frame1.Size = new System.Drawing.Size(10, 768);
            this.pnl_Frame1.TabIndex = 4;
            // 
            // dvw_DSSP
            // 
            this.dvw_DSSP.AllowUserToAddRows = false;
            this.dvw_DSSP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvw_DSSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvw_DSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_DSSP.BackgroundColor = System.Drawing.Color.White;
            this.dvw_DSSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvw_DSSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_DSSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvw_DSSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvw_DSSP.ColumnHeadersHeight = 50;
            this.dvw_DSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSP,
            this.col_TenSP,
            this.col_GiaBan,
            this.col_SLToiThieu,
            this.col_Giam,
            this.col_Phantram});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvw_DSSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvw_DSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvw_DSSP.EnableHeadersVisualStyles = false;
            this.dvw_DSSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_DSSP.Location = new System.Drawing.Point(871, 0);
            this.dvw_DSSP.Name = "dvw_DSSP";
            this.dvw_DSSP.ReadOnly = true;
            this.dvw_DSSP.RowHeadersVisible = false;
            this.dvw_DSSP.RowHeadersWidth = 80;
            this.dvw_DSSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvw_DSSP.RowTemplate.Height = 24;
            this.dvw_DSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvw_DSSP.Size = new System.Drawing.Size(426, 768);
            this.dvw_DSSP.TabIndex = 5;
            this.dvw_DSSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_DSSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvw_DSSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvw_DSSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvw_DSSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvw_DSSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvw_DSSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_DSSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.dvw_DSSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvw_DSSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvw_DSSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvw_DSSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvw_DSSP.ThemeStyle.HeaderStyle.Height = 50;
            this.dvw_DSSP.ThemeStyle.ReadOnly = true;
            this.dvw_DSSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_DSSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_DSSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvw_DSSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvw_DSSP.ThemeStyle.RowsStyle.Height = 24;
            this.dvw_DSSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvw_DSSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_Frame3
            // 
            this.pnl_Frame3.BackColor = System.Drawing.Color.White;
            this.pnl_Frame3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame3.Location = new System.Drawing.Point(1297, 0);
            this.pnl_Frame3.Name = "pnl_Frame3";
            this.pnl_Frame3.Size = new System.Drawing.Size(10, 768);
            this.pnl_Frame3.TabIndex = 7;
            // 
            // pnl_Frame2
            // 
            this.pnl_Frame2.BackColor = System.Drawing.Color.White;
            this.pnl_Frame2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Frame2.Location = new System.Drawing.Point(861, 0);
            this.pnl_Frame2.Name = "pnl_Frame2";
            this.pnl_Frame2.Size = new System.Drawing.Size(10, 768);
            this.pnl_Frame2.TabIndex = 8;
            // 
            // pnl_Left
            // 
            this.pnl_Left.Controls.Add(this.lvw_DSSK);
            this.pnl_Left.Controls.Add(this.pnl_break);
            this.pnl_Left.Controls.Add(this.pnl_Loc);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Location = new System.Drawing.Point(10, 0);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(851, 768);
            this.pnl_Left.TabIndex = 10;
            // 
            // lvw_DSSK
            // 
            this.lvw_DSSK.BackColor = System.Drawing.Color.White;
            this.lvw_DSSK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_MaSK,
            this.col_MoTa,
            this.col_NgayBD,
            this.col_NgayKT});
            this.lvw_DSSK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_DSSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_DSSK.FullRowSelect = true;
            this.lvw_DSSK.HideSelection = false;
            this.lvw_DSSK.LargeImageList = this.ils_DSSK;
            this.lvw_DSSK.Location = new System.Drawing.Point(0, 303);
            this.lvw_DSSK.Name = "lvw_DSSK";
            this.lvw_DSSK.Size = new System.Drawing.Size(851, 465);
            this.lvw_DSSK.SmallImageList = this.ils_DSSK;
            this.lvw_DSSK.TabIndex = 7;
            this.lvw_DSSK.UseCompatibleStateImageBehavior = false;
            this.lvw_DSSK.View = System.Windows.Forms.View.Tile;
            this.lvw_DSSK.SelectedIndexChanged += new System.EventHandler(this.lvw_DSSK_SelectedIndexChanged);
            // 
            // col_MaSK
            // 
            this.col_MaSK.Text = "Sự kiện";
            // 
            // col_MoTa
            // 
            this.col_MoTa.Text = "Mô tả";
            // 
            // col_NgayBD
            // 
            this.col_NgayBD.Text = "Ngày BĐ";
            // 
            // col_NgayKT
            // 
            this.col_NgayKT.Text = "Ngày KT";
            // 
            // ils_DSSK
            // 
            this.ils_DSSK.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ils_DSSK.ImageSize = new System.Drawing.Size(256, 100);
            this.ils_DSSK.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnl_break
            // 
            this.pnl_break.BackColor = System.Drawing.Color.White;
            this.pnl_break.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_break.Location = new System.Drawing.Point(0, 293);
            this.pnl_break.Name = "pnl_break";
            this.pnl_break.Size = new System.Drawing.Size(851, 10);
            this.pnl_break.TabIndex = 6;
            // 
            // pnl_Loc
            // 
            this.pnl_Loc.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Loc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Loc.Controls.Add(this.dtp_End);
            this.pnl_Loc.Controls.Add(this.dtp_Begin);
            this.pnl_Loc.Controls.Add(this.lbl_Den);
            this.pnl_Loc.Controls.Add(this.lbl_Tu);
            this.pnl_Loc.Controls.Add(this.lbl_TatCa);
            this.pnl_Loc.Controls.Add(this.tgg_TatCa);
            this.pnl_Loc.Controls.Add(this.pic_Filler);
            this.pnl_Loc.Controls.Add(this.cld_Lich);
            this.pnl_Loc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Loc.Location = new System.Drawing.Point(0, 0);
            this.pnl_Loc.Name = "pnl_Loc";
            this.pnl_Loc.Radius = 15;
            this.pnl_Loc.Size = new System.Drawing.Size(851, 293);
            this.pnl_Loc.TabIndex = 2;
            // 
            // dtp_End
            // 
            this.dtp_End.BackColor = System.Drawing.Color.Transparent;
            this.dtp_End.BaseColor = System.Drawing.Color.White;
            this.dtp_End.BorderColor = System.Drawing.Color.White;
            this.dtp_End.CustomFormat = "dd/MM/yyyy";
            this.dtp_End.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_End.Enabled = false;
            this.dtp_End.FocusedColor = System.Drawing.Color.White;
            this.dtp_End.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_End.ForeColor = System.Drawing.Color.Black;
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(255, 197);
            this.dtp_End.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_End.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_End.OnHoverBorderColor = System.Drawing.Color.White;
            this.dtp_End.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.dtp_End.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_End.Radius = 10;
            this.dtp_End.Size = new System.Drawing.Size(269, 48);
            this.dtp_End.TabIndex = 13;
            this.dtp_End.Text = "03/07/2022";
            this.dtp_End.Value = new System.DateTime(2022, 7, 3, 18, 12, 5, 790);
            this.dtp_End.ValueChanged += new System.EventHandler(this.dtp_End_ValueChanged);
            // 
            // dtp_Begin
            // 
            this.dtp_Begin.BackColor = System.Drawing.Color.Transparent;
            this.dtp_Begin.BaseColor = System.Drawing.Color.White;
            this.dtp_Begin.BorderColor = System.Drawing.Color.White;
            this.dtp_Begin.CustomFormat = "dd/MM/yyyy";
            this.dtp_Begin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Begin.Enabled = false;
            this.dtp_Begin.FocusedColor = System.Drawing.Color.White;
            this.dtp_Begin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Begin.ForeColor = System.Drawing.Color.Black;
            this.dtp_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin.Location = new System.Drawing.Point(255, 111);
            this.dtp_Begin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Begin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Begin.Name = "dtp_Begin";
            this.dtp_Begin.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_Begin.OnHoverBorderColor = System.Drawing.Color.White;
            this.dtp_Begin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.dtp_Begin.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_Begin.Radius = 10;
            this.dtp_Begin.Size = new System.Drawing.Size(269, 48);
            this.dtp_Begin.TabIndex = 13;
            this.dtp_Begin.Text = "03/07/2022";
            this.dtp_Begin.Value = new System.DateTime(2022, 7, 3, 18, 13, 8, 331);
            this.dtp_Begin.ValueChanged += new System.EventHandler(this.dtp_Begin_ValueChanged);
            // 
            // lbl_Den
            // 
            this.lbl_Den.AutoSize = true;
            this.lbl_Den.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Den.ForeColor = System.Drawing.Color.White;
            this.lbl_Den.Location = new System.Drawing.Point(205, 213);
            this.lbl_Den.Name = "lbl_Den";
            this.lbl_Den.Size = new System.Drawing.Size(39, 20);
            this.lbl_Den.TabIndex = 12;
            this.lbl_Den.Text = "đến";
            // 
            // lbl_Tu
            // 
            this.lbl_Tu.AutoSize = true;
            this.lbl_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tu.ForeColor = System.Drawing.Color.White;
            this.lbl_Tu.Location = new System.Drawing.Point(205, 126);
            this.lbl_Tu.Name = "lbl_Tu";
            this.lbl_Tu.Size = new System.Drawing.Size(30, 20);
            this.lbl_Tu.TabIndex = 12;
            this.lbl_Tu.Text = "Từ";
            // 
            // lbl_TatCa
            // 
            this.lbl_TatCa.AutoSize = true;
            this.lbl_TatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TatCa.ForeColor = System.Drawing.Color.White;
            this.lbl_TatCa.Location = new System.Drawing.Point(371, 46);
            this.lbl_TatCa.Name = "lbl_TatCa";
            this.lbl_TatCa.Size = new System.Drawing.Size(74, 20);
            this.lbl_TatCa.TabIndex = 12;
            this.lbl_TatCa.Text = "TẤT CẢ";
            // 
            // tgg_TatCa
            // 
            this.tgg_TatCa.Checked = true;
            this.tgg_TatCa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.tgg_TatCa.CheckedState.BorderRadius = 10;
            this.tgg_TatCa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.tgg_TatCa.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgg_TatCa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgg_TatCa.Location = new System.Drawing.Point(473, 43);
            this.tgg_TatCa.Name = "tgg_TatCa";
            this.tgg_TatCa.Size = new System.Drawing.Size(51, 25);
            this.tgg_TatCa.TabIndex = 9;
            this.tgg_TatCa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgg_TatCa.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgg_TatCa.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgg_TatCa.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgg_TatCa.CheckedChanged += new System.EventHandler(this.tgg_TatCa_CheckedChanged);
            // 
            // pic_Filler
            // 
            this.pic_Filler.Image = ((System.Drawing.Image)(resources.GetObject("pic_Filler.Image")));
            this.pic_Filler.Location = new System.Drawing.Point(14, 46);
            this.pic_Filler.Name = "pic_Filler";
            this.pic_Filler.Size = new System.Drawing.Size(185, 178);
            this.pic_Filler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Filler.TabIndex = 11;
            this.pic_Filler.TabStop = false;
            // 
            // cld_Lich
            // 
            this.cld_Lich.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cld_Lich.Dock = System.Windows.Forms.DockStyle.Right;
            this.cld_Lich.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.True;
            this.cld_Lich.Location = new System.Drawing.Point(566, 0);
            this.cld_Lich.Margin = new System.Windows.Forms.Padding(4);
            this.cld_Lich.Name = "cld_Lich";
            this.cld_Lich.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple;
            this.cld_Lich.Size = new System.Drawing.Size(285, 293);
            this.cld_Lich.TabIndex = 0;
            this.cld_Lich.SelectionChanged += new System.EventHandler(this.cld_Lich_SelectionChanged);
            // 
            // col_MaSP
            // 
            this.col_MaSP.DataPropertyName = "MaSP";
            this.col_MaSP.FillWeight = 50F;
            this.col_MaSP.HeaderText = "Mã SP";
            this.col_MaSP.MinimumWidth = 6;
            this.col_MaSP.Name = "col_MaSP";
            this.col_MaSP.ReadOnly = true;
            // 
            // col_TenSP
            // 
            this.col_TenSP.DataPropertyName = "TenSP";
            this.col_TenSP.FillWeight = 150F;
            this.col_TenSP.HeaderText = "Tên SP";
            this.col_TenSP.MinimumWidth = 6;
            this.col_TenSP.Name = "col_TenSP";
            this.col_TenSP.ReadOnly = true;
            // 
            // col_GiaBan
            // 
            this.col_GiaBan.DataPropertyName = "GiaBan";
            this.col_GiaBan.HeaderText = "Giá bán";
            this.col_GiaBan.MinimumWidth = 6;
            this.col_GiaBan.Name = "col_GiaBan";
            this.col_GiaBan.ReadOnly = true;
            // 
            // col_SLToiThieu
            // 
            this.col_SLToiThieu.DataPropertyName = "SLToiThieu";
            this.col_SLToiThieu.FillWeight = 60F;
            this.col_SLToiThieu.HeaderText = "SL tối thiểu";
            this.col_SLToiThieu.MinimumWidth = 6;
            this.col_SLToiThieu.Name = "col_SLToiThieu";
            this.col_SLToiThieu.ReadOnly = true;
            // 
            // col_Giam
            // 
            this.col_Giam.DataPropertyName = "Giam";
            this.col_Giam.FillWeight = 80F;
            this.col_Giam.HeaderText = "Giảm";
            this.col_Giam.MinimumWidth = 6;
            this.col_Giam.Name = "col_Giam";
            this.col_Giam.ReadOnly = true;
            // 
            // col_Phantram
            // 
            this.col_Phantram.DataPropertyName = "PhanTram";
            this.col_Phantram.FillWeight = 20F;
            this.col_Phantram.HeaderText = "%";
            this.col_Phantram.MinimumWidth = 6;
            this.col_Phantram.Name = "col_Phantram";
            this.col_Phantram.ReadOnly = true;
            // 
            // frm_XemSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 768);
            this.Controls.Add(this.dvw_DSSP);
            this.Controls.Add(this.pnl_Frame2);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_Frame1);
            this.Controls.Add(this.pnl_Frame3);
            this.Name = "frm_XemSuKien";
            this.Text = "frm_XemSuKien";
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSSP)).EndInit();
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Loc.ResumeLayout(false);
            this.pnl_Loc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Filler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cld_Lich.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Frame1;
        private Guna.UI2.WinForms.Guna2DataGridView dvw_DSSP;
        private System.Windows.Forms.Panel pnl_Frame3;
        private System.Windows.Forms.Panel pnl_Frame2;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_break;
        private Guna.UI.WinForms.GunaElipsePanel pnl_Loc;
        private DevExpress.XtraEditors.Controls.CalendarControl cld_Lich;
        private System.Windows.Forms.PictureBox pic_Filler;
        private System.Windows.Forms.Label lbl_TatCa;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgg_TatCa;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_End;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_Begin;
        private System.Windows.Forms.ListView lvw_DSSK;
        private System.Windows.Forms.ColumnHeader col_MaSK;
        private System.Windows.Forms.ColumnHeader col_MoTa;
        private System.Windows.Forms.ColumnHeader col_NgayBD;
        private System.Windows.Forms.ColumnHeader col_NgayKT;
        private System.Windows.Forms.ImageList ils_DSSK;
        private System.Windows.Forms.Label lbl_Den;
        private System.Windows.Forms.Label lbl_Tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SLToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Giam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Phantram;
    }
}