
namespace HaKi_Piece
{
    partial class frm_HTPhieuHen
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
            this.dvw_DSPH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Frame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cld_NgayHen = new Syncfusion.WinForms.Input.SfCalendar();
            this.pnl_break = new System.Windows.Forms.Panel();
            this.pnl_Title = new Guna.UI.WinForms.GunaElipsePanel();
            this.pnl_Frame1 = new System.Windows.Forms.Panel();
            this.pnl_Frame2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSPH)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvw_DSPH
            // 
            this.dvw_DSPH.AllowUserToAddRows = false;
            this.dvw_DSPH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvw_DSPH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvw_DSPH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_DSPH.BackgroundColor = System.Drawing.Color.White;
            this.dvw_DSPH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvw_DSPH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_DSPH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvw_DSPH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvw_DSPH.ColumnHeadersHeight = 40;
            this.dvw_DSPH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaPH,
            this.col_MaHD,
            this.col_ThanhVien,
            this.col_DiaChi,
            this.col_MaTV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvw_DSPH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvw_DSPH.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvw_DSPH.EnableHeadersVisualStyles = false;
            this.dvw_DSPH.GridColor = System.Drawing.Color.White;
            this.dvw_DSPH.Location = new System.Drawing.Point(524, 0);
            this.dvw_DSPH.Name = "dvw_DSPH";
            this.dvw_DSPH.RowHeadersVisible = false;
            this.dvw_DSPH.RowHeadersWidth = 51;
            this.dvw_DSPH.RowTemplate.Height = 24;
            this.dvw_DSPH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvw_DSPH.Size = new System.Drawing.Size(885, 747);
            this.dvw_DSPH.TabIndex = 23;
            this.dvw_DSPH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dvw_DSPH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvw_DSPH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvw_DSPH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvw_DSPH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvw_DSPH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvw_DSPH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvw_DSPH.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dvw_DSPH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.dvw_DSPH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvw_DSPH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvw_DSPH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvw_DSPH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvw_DSPH.ThemeStyle.HeaderStyle.Height = 40;
            this.dvw_DSPH.ThemeStyle.ReadOnly = false;
            this.dvw_DSPH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dvw_DSPH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvw_DSPH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvw_DSPH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dvw_DSPH.ThemeStyle.RowsStyle.Height = 24;
            this.dvw_DSPH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dvw_DSPH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dvw_DSPH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvw_DSPH_CellClick);
            // 
            // col_MaPH
            // 
            this.col_MaPH.DataPropertyName = "MaPH";
            this.col_MaPH.FillWeight = 70F;
            this.col_MaPH.HeaderText = "Mã PH";
            this.col_MaPH.MinimumWidth = 6;
            this.col_MaPH.Name = "col_MaPH";
            this.col_MaPH.ReadOnly = true;
            // 
            // col_MaHD
            // 
            this.col_MaHD.DataPropertyName = "MaHD";
            this.col_MaHD.FillWeight = 70F;
            this.col_MaHD.HeaderText = "Mã HD";
            this.col_MaHD.MinimumWidth = 6;
            this.col_MaHD.Name = "col_MaHD";
            this.col_MaHD.ReadOnly = true;
            // 
            // col_ThanhVien
            // 
            this.col_ThanhVien.DataPropertyName = "ThanhVien";
            this.col_ThanhVien.FillWeight = 130F;
            this.col_ThanhVien.HeaderText = "Tên khách hàng";
            this.col_ThanhVien.MinimumWidth = 6;
            this.col_ThanhVien.Name = "col_ThanhVien";
            this.col_ThanhVien.ReadOnly = true;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DiaChiGiao";
            this.col_DiaChi.FillWeight = 150F;
            this.col_DiaChi.HeaderText = "Địa chỉ giao hàng";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            // 
            // col_MaTV
            // 
            this.col_MaTV.DataPropertyName = "MaTV";
            this.col_MaTV.HeaderText = "Mã TV";
            this.col_MaTV.MinimumWidth = 6;
            this.col_MaTV.Name = "col_MaTV";
            this.col_MaTV.Visible = false;
            // 
            // pnl_Frame
            // 
            this.pnl_Frame.BackColor = System.Drawing.Color.White;
            this.pnl_Frame.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Frame.Location = new System.Drawing.Point(0, 0);
            this.pnl_Frame.Name = "pnl_Frame";
            this.pnl_Frame.Size = new System.Drawing.Size(10, 747);
            this.pnl_Frame.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "LỊCH NGÀY HẸN";
            // 
            // cld_NgayHen
            // 
            this.cld_NgayHen.Culture = new System.Globalization.CultureInfo("en-US");
            this.cld_NgayHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cld_NgayHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cld_NgayHen.ForeColor = System.Drawing.Color.Transparent;
            this.cld_NgayHen.Location = new System.Drawing.Point(10, 110);
            this.cld_NgayHen.MinimumSize = new System.Drawing.Size(399, 399);
            this.cld_NgayHen.Name = "cld_NgayHen";
            this.cld_NgayHen.Size = new System.Drawing.Size(504, 637);
            this.cld_NgayHen.Style.BorderColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.Cell.CellBackColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.Cell.CellFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cld_NgayHen.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.cld_NgayHen.Style.Cell.CellHoverBorderColor = System.Drawing.Color.LightGray;
            this.cld_NgayHen.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.cld_NgayHen.Style.Cell.SelectedCellFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cld_NgayHen.Style.Cell.SelectedCellForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.cld_NgayHen.Style.Cell.TrailingCellFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cld_NgayHen.Style.Cell.WeekNumberFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cld_NgayHen.Style.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.cld_NgayHen.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.cld_NgayHen.Style.Header.DayNamesFont = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cld_NgayHen.Style.Header.DayNamesForeColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.Header.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cld_NgayHen.Style.Header.ForeColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.HorizontalSplitterColor = System.Drawing.Color.White;
            this.cld_NgayHen.Style.VerticalSplitterColor = System.Drawing.Color.White;
            this.cld_NgayHen.TabIndex = 27;
            this.cld_NgayHen.SelectionChanged += new Syncfusion.WinForms.Input.Events.SelectionChangedEventHandler(this.cld_NgayHen_SelectionChanged);
            // 
            // pnl_break
            // 
            this.pnl_break.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_break.Location = new System.Drawing.Point(10, 100);
            this.pnl_break.Name = "pnl_break";
            this.pnl_break.Size = new System.Drawing.Size(504, 10);
            this.pnl_break.TabIndex = 29;
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Title.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(10, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Radius = 15;
            this.pnl_Title.Size = new System.Drawing.Size(504, 100);
            this.pnl_Title.TabIndex = 28;
            // 
            // pnl_Frame1
            // 
            this.pnl_Frame1.BackColor = System.Drawing.Color.White;
            this.pnl_Frame1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame1.Location = new System.Drawing.Point(1409, 0);
            this.pnl_Frame1.Name = "pnl_Frame1";
            this.pnl_Frame1.Size = new System.Drawing.Size(10, 747);
            this.pnl_Frame1.TabIndex = 25;
            // 
            // pnl_Frame2
            // 
            this.pnl_Frame2.BackColor = System.Drawing.Color.White;
            this.pnl_Frame2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Frame2.Location = new System.Drawing.Point(514, 0);
            this.pnl_Frame2.Name = "pnl_Frame2";
            this.pnl_Frame2.Size = new System.Drawing.Size(10, 747);
            this.pnl_Frame2.TabIndex = 26;
            // 
            // frm_HTPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1419, 747);
            this.ControlBox = false;
            this.Controls.Add(this.cld_NgayHen);
            this.Controls.Add(this.pnl_break);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.pnl_Frame2);
            this.Controls.Add(this.dvw_DSPH);
            this.Controls.Add(this.pnl_Frame);
            this.Controls.Add(this.pnl_Frame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HTPhieuHen";
            this.Text = "frm_HTPhieuHen";
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSPH)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dvw_DSPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaTV;
        private System.Windows.Forms.Panel pnl_Frame;
        private System.Windows.Forms.Label label1;
        public Syncfusion.WinForms.Input.SfCalendar cld_NgayHen;
        private System.Windows.Forms.Panel pnl_break;
        private Guna.UI.WinForms.GunaElipsePanel pnl_Title;
        private System.Windows.Forms.Panel pnl_Frame1;
        private System.Windows.Forms.Panel pnl_Frame2;
    }
}