
namespace HaKi_Piece
{
    partial class frm_CTHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTHoaDon));
            this.elp_NgayGiao = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_Border = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
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
            this.pnl_Border.Size = new System.Drawing.Size(588, 669);
            this.pnl_Border.TabIndex = 13;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(535, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.btn_Close);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Main.Location = new System.Drawing.Point(5, 5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(578, 659);
            this.pnl_Main.TabIndex = 0;
            // 
            // frm_CTHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 669);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CTHoaDon";
            this.pnl_Border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse elp_NgayGiao;
        private System.Windows.Forms.Panel pnl_Border;
        private System.Windows.Forms.Panel pnl_Main;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
    }
}