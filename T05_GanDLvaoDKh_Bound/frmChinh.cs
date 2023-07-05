using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T05_GanDLvaoDKh_Bound
{
    public partial class frmChinh : Form
    {
        public static bool dangMo = false;

        public frmChinh()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mKhoa_Click(object sender, EventArgs e)
        {
            if (!dangMo)
            {
                frmKhoa frKhoa = new frmKhoa();
                frKhoa.MdiParent = this;
                frKhoa.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đóng form đang mở...");
            }
        }

        private void mLop_Click(object sender, EventArgs e)
        {
            if (!dangMo)
            {
                frmLop frLop = new frmLop();
                frLop.MdiParent = this;
                frLop.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đóng form đang mở...");
            }
        }

        private void mSinhvien_Click(object sender, EventArgs e)
        {
            if (!dangMo)
            {
                frmSinhVien frSV = new frmSinhVien();
                frSV.MdiParent = this;
                frSV.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đóng form đang mở...");
            }
        }

        private void mMonhoc_Click(object sender, EventArgs e)
        {
            if (!dangMo)
            {
                frmMonHoc frMH = new frmMonHoc();
                frMH.MdiParent = this;
                frMH.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đóng form đang mở...");
            }
        }
    }
}
