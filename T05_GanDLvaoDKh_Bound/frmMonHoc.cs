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
    public partial class frmMonHoc : Form
    {
        clsDuLieu dl = new clsDuLieu();
        DataTable tblMonHoc = new DataTable();

        public frmMonHoc()
        {
            InitializeComponent();
        }
        public void BuocDuLieu()
        {
            txtMaMH.DataBindings.Add("Text", tblMonHoc, "MaMH", true);
            txtTenMH.DataBindings.Add("Text", tblMonHoc, "TenMH", true);
            txtSoTC.DataBindings.Add("Text", tblMonHoc, "SoTC", true);
        }

        private void frmMonHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChinh.dangMo = false;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (!dl.KetNoi())
            {
                Close();
                return;
            }
            frmChinh.dangMo = true;
            tblMonHoc = dl.LayDLcoDK("MonHoc", "", "MaMH");
            dl.TinhSiSo(tblMonHoc, lblViTri);
            BuocDuLieu();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dl.Dau(this, tblMonHoc, lblViTri);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            dl.Truoc(this, tblMonHoc, lblViTri);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            dl.Sau(this, tblMonHoc, lblViTri);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dl.Cuoi(this, tblMonHoc, lblViTri);
        }
    }
}
