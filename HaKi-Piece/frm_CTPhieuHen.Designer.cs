
namespace HaKi_Piece
{
    partial class frm_CTPhieuHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTPhieuHen));
            this.elp_NgayGiao = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_Border = new System.Windows.Forms.Panel();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl_MaPH = new System.Windows.Forms.Label();
            this.lbl_DCGiaoHang = new System.Windows.Forms.Label();
            this.lbl_NgayGiao = new System.Windows.Forms.Label();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pnl_Border.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // elp_NgayGiao
            // 
            this.elp_NgayGiao.BorderRadius = 15;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(413, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Border
            // 
            this.pnl_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.pnl_Border.Controls.Add(this.pnl_Main);
            this.pnl_Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border.Location = new System.Drawing.Point(0, 0);
            this.pnl_Border.Name = "pnl_Border";
            this.pnl_Border.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Border.Size = new System.Drawing.Size(466, 339);
            this.pnl_Border.TabIndex = 12;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.lbl_TrangThai);
            this.pnl_Main.Controls.Add(this.lbl_NgayGiao);
            this.pnl_Main.Controls.Add(this.lbl_DCGiaoHang);
            this.pnl_Main.Controls.Add(this.lbl_MaPH);
            this.pnl_Main.Controls.Add(this.lbl1);
            this.pnl_Main.Controls.Add(this.lbl4);
            this.pnl_Main.Controls.Add(this.lbl3);
            this.pnl_Main.Controls.Add(this.lbl2);
            this.pnl_Main.Controls.Add(this.btn_Close);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Main.Location = new System.Drawing.Point(5, 5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(456, 329);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(28, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(127, 20);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Mã phiếu hẹn:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(28, 200);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(98, 20);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Ngày giao:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(28, 80);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 20);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Địa chỉ giao hàng:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(28, 249);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 20);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "Tình trạng:";
            // 
            // lbl_MaPH
            // 
            this.lbl_MaPH.AutoSize = true;
            this.lbl_MaPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPH.Location = new System.Drawing.Point(196, 43);
            this.lbl_MaPH.Name = "lbl_MaPH";
            this.lbl_MaPH.Size = new System.Drawing.Size(18, 20);
            this.lbl_MaPH.TabIndex = 16;
            this.lbl_MaPH.Text = "0";
            // 
            // lbl_DCGiaoHang
            // 
            this.lbl_DCGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DCGiaoHang.Location = new System.Drawing.Point(28, 111);
            this.lbl_DCGiaoHang.Name = "lbl_DCGiaoHang";
            this.lbl_DCGiaoHang.Size = new System.Drawing.Size(363, 79);
            this.lbl_DCGiaoHang.TabIndex = 16;
            this.lbl_DCGiaoHang.Text = "abc";
            // 
            // lbl_NgayGiao
            // 
            this.lbl_NgayGiao.AutoSize = true;
            this.lbl_NgayGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayGiao.Location = new System.Drawing.Point(145, 200);
            this.lbl_NgayGiao.Name = "lbl_NgayGiao";
            this.lbl_NgayGiao.Size = new System.Drawing.Size(97, 20);
            this.lbl_NgayGiao.TabIndex = 16;
            this.lbl_NgayGiao.Text = "dd/MM/yyyy";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(145, 249);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(19, 20);
            this.lbl_TrangThai.TabIndex = 16;
            this.lbl_TrangThai.Text = "#";
            // 
            // frm_CTPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 339);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 250);
            this.Name = "frm_CTPhieuHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pnl_Border.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse elp_NgayGiao;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.Panel pnl_Border;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.Label lbl_TrangThai;
        public System.Windows.Forms.Label lbl_NgayGiao;
        public System.Windows.Forms.Label lbl_DCGiaoHang;
        public System.Windows.Forms.Label lbl_MaPH;
    }
}