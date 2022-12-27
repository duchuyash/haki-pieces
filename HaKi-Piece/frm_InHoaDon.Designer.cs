
namespace HaKi_Piece
{
    partial class frm_InHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InHoaDon));
            this.rpv_HoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.elp_NgayGiao = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_Border = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpv_HoaDon
            // 
            this.rpv_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_HoaDon.DocumentMapWidth = 59;
            this.rpv_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpv_HoaDon.Name = "rpv_HoaDon";
            this.rpv_HoaDon.ServerReport.BearerToken = null;
            this.rpv_HoaDon.Size = new System.Drawing.Size(606, 663);
            this.rpv_HoaDon.TabIndex = 0;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.btn_Close);
            this.pnl_Main.Controls.Add(this.rpv_HoaDon);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Main.Location = new System.Drawing.Point(5, 5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(606, 663);
            this.pnl_Main.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(563, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // elp_NgayGiao
            // 
            this.elp_NgayGiao.BorderRadius = 15;
            // 
            // pnl_Border
            // 
            this.pnl_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_Border.Controls.Add(this.pnl_Main);
            this.pnl_Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border.Location = new System.Drawing.Point(0, 0);
            this.pnl_Border.Name = "pnl_Border";
            this.pnl_Border.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Border.Size = new System.Drawing.Size(616, 673);
            this.pnl_Border.TabIndex = 14;
            // 
            // frm_InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 673);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_XemBaoCao";
            this.Load += new System.EventHandler(this.frm_XemBaoCao_Load);
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_HoaDon;
        private System.Windows.Forms.Panel pnl_Main;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Guna.UI2.WinForms.Guna2Elipse elp_NgayGiao;
        private System.Windows.Forms.Panel pnl_Border;
    }
}