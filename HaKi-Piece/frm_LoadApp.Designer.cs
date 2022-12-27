
namespace HaKi_Piece
{
    partial class frm_LoadApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoadApp));
            this.epl_LoadApp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Time = new System.Windows.Forms.Panel();
            this.pic_LoadApp = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_Step = new System.Windows.Forms.Panel();
            this.tmr_Load = new System.Windows.Forms.Timer(this.components);
            this.pnl_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoadApp)).BeginInit();
            this.SuspendLayout();
            // 
            // epl_LoadApp
            // 
            this.epl_LoadApp.ElipseRadius = 10;
            this.epl_LoadApp.TargetControl = this;
            // 
            // pnl_Time
            // 
            this.pnl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.pnl_Time.Controls.Add(this.pnl_Step);
            this.pnl_Time.Location = new System.Drawing.Point(0, 503);
            this.pnl_Time.Name = "pnl_Time";
            this.pnl_Time.Size = new System.Drawing.Size(815, 20);
            this.pnl_Time.TabIndex = 1;
            // 
            // pic_LoadApp
            // 
            this.pic_LoadApp.BaseColor = System.Drawing.Color.White;
            this.pic_LoadApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_LoadApp.Image = ((System.Drawing.Image)(resources.GetObject("pic_LoadApp.Image")));
            this.pic_LoadApp.Location = new System.Drawing.Point(0, 0);
            this.pic_LoadApp.Name = "pic_LoadApp";
            this.pic_LoadApp.Size = new System.Drawing.Size(815, 544);
            this.pic_LoadApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_LoadApp.TabIndex = 0;
            this.pic_LoadApp.TabStop = false;
            // 
            // pnl_Step
            // 
            this.pnl_Step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(109)))), ((int)(((byte)(137)))));
            this.pnl_Step.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Step.Location = new System.Drawing.Point(0, 0);
            this.pnl_Step.Name = "pnl_Step";
            this.pnl_Step.Size = new System.Drawing.Size(100, 20);
            this.pnl_Step.TabIndex = 1;
            // 
            // tmr_Load
            // 
            this.tmr_Load.Enabled = true;
            this.tmr_Load.Interval = 15;
            this.tmr_Load.Tick += new System.EventHandler(this.tmr_Load_Tick);
            // 
            // frm_LoadApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 544);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Time);
            this.Controls.Add(this.pic_LoadApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LoadApp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Time.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoadApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse epl_LoadApp;
        private System.Windows.Forms.Panel pnl_Time;
        private System.Windows.Forms.Panel pnl_Step;
        private Guna.UI.WinForms.GunaPictureBox pic_LoadApp;
        private System.Windows.Forms.Timer tmr_Load;
    }
}