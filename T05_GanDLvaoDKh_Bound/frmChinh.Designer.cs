namespace T05_GanDLvaoDKh_Bound
{
    partial class frmChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mSinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mMonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKhoa,
            this.mLop,
            this.mSinhvien,
            this.mMonhoc});
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xemToolStripMenuItem.Text = "&Xem";
            // 
            // mKhoa
            // 
            this.mKhoa.Name = "mKhoa";
            this.mKhoa.Size = new System.Drawing.Size(180, 22);
            this.mKhoa.Text = "&Khoa";
            this.mKhoa.Click += new System.EventHandler(this.mKhoa_Click);
            // 
            // mLop
            // 
            this.mLop.Name = "mLop";
            this.mLop.Size = new System.Drawing.Size(180, 22);
            this.mLop.Text = "&Lớp";
            this.mLop.Click += new System.EventHandler(this.mLop_Click);
            // 
            // mSinhvien
            // 
            this.mSinhvien.Name = "mSinhvien";
            this.mSinhvien.Size = new System.Drawing.Size(180, 22);
            this.mSinhvien.Text = "&Sinh viên";
            this.mSinhvien.Click += new System.EventHandler(this.mSinhvien_Click);
            // 
            // mMonhoc
            // 
            this.mMonhoc.Name = "mMonhoc";
            this.mMonhoc.Size = new System.Drawing.Size(180, 22);
            this.mMonhoc.Text = "Môn Học";
            this.mMonhoc.Click += new System.EventHandler(this.mMonhoc_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "&Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mKhoa;
        private System.Windows.Forms.ToolStripMenuItem mLop;
        private System.Windows.Forms.ToolStripMenuItem mSinhvien;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mMonhoc;
    }
}


