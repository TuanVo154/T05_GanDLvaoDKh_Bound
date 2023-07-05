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
    public partial class frmKhoa : Form
    {
        clsDuLieu dl = new clsDuLieu();
        DataTable tblKhoa = new DataTable();
        public frmKhoa()
        {
            InitializeComponent();
        }

        public void BuocDuLieu()
        {
            txtMaKhoa.DataBindings.Add("Text", tblKhoa, "MaKhoa", true);
            txtTenKhoa.DataBindings.Add("Text", tblKhoa, "TenKhoa", true);
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {

            if (!dl.KetNoi())
            {
                Close();
                return;
            }
            frmChinh.dangMo = true;
            tblKhoa = dl.LayDLcoDK("Khoa", "", "MaKhoa");
            dl.TinhSiSo(tblKhoa, lblViTri);
            BuocDuLieu();
        }
        private void btnDau_Click(object sender, EventArgs e)
        {
            dl.Dau(this, tblKhoa, lblViTri);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            dl.Truoc(this, tblKhoa, lblViTri);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            dl.Sau(this, tblKhoa, lblViTri);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dl.Cuoi(this, tblKhoa, lblViTri);
        }
        private void frmKhoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChinh.dangMo = false;
        }
    }
}
