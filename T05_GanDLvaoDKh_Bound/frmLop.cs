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
    public partial class frmLop : Form
    {
        clsDuLieu dl = new clsDuLieu();
        DataTable tblLop = new DataTable();
        public frmLop()
        {
            InitializeComponent();
        }

        public void BuocDuLieu()
        {
            txtMaLop.DataBindings.Add("Text", tblLop, "MaLop", true);
            txtTenLop.DataBindings.Add("Text", tblLop, "TenLop", true);
            txtNienKhoa.DataBindings.Add("Text", tblLop, "NienKhoa", true);
            cboKhoa.DataBindings.Add("SelectedValue", tblLop, "MaKhoa", true);
            txtGVCN.DataBindings.Add("Text", tblLop, "GVCN", true);
        }

        private void frmLop_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChinh.dangMo = false;
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            if (!dl.KetNoi())
            {
                Close();
                return;
            }
            frmChinh.dangMo = true;
            cboKhoa.DataSource = dl.LayDLcoDK("Khoa", "", "MaKhoa");
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";

            tblLop = dl.LayDLcoDK("Lop", "", "MaLop");
            lstLop.DataSource = tblLop;
            lstLop.DisplayMember = "TenLop";
            lstLop.ValueMember = "MaLop";
            BuocDuLieu();
        }
    }
}
