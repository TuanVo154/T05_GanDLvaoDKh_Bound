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
    public partial class frmSinhVien : Form
    {
        clsDuLieu dl = new clsDuLieu();
        DataTable tblSV = new DataTable();
        string DuongDanHinh = Application.StartupPath, TenHinh = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        public void BuocDuLieu()
        {
            txtMaSV.DataBindings.Add("Text", tblSV, "MaSV", true);
            txtHoTenSV.DataBindings.Add("Text", tblSV, "HoTenSV", true);
            radNam.DataBindings.Add("Checked", tblSV, "Nam", true);
            dpkNgaySinh.DataBindings.Add("Value", tblSV, "NgaySinh", true);
            txtDiaChi.DataBindings.Add("Text", tblSV, "DiaChi", true);
            txtDienThoai.DataBindings.Add("Text", tblSV, "DienThoai", true);
            cboLop.DataBindings.Add("SelectedValue", tblSV, "MaLop", true);
            txtHinh.DataBindings.Add("Text", tblSV, "Hinh", true);
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChinh.dangMo = false;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (!dl.KetNoi())
            {
                Close();
                return;
            }
            frmChinh.dangMo = true;
            DuongDanHinh = DuongDanHinh.Substring(0, DuongDanHinh.LastIndexOf("Bin", StringComparison.OrdinalIgnoreCase)) + @"HinhSV\";
            cboLop.DataSource = dl.LayDLcoDK("Lop", "", "MaLop");
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            tblSV = dl.LayDLcoDK("SinhVien", "", "MaSV");
            dgrSinhVien.DataSource = tblSV;
            BuocDuLieu();
            HienThiThem();
        }

        private void dgrSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (sender != null) HienThiThem();
        }

        private void HienThiThem()
        {
            radNu.Checked = !radNam.Checked;
            TenHinh = txtHinh.Text;
            if(TenHinh != "")
            {
                picHinh.Image = Image.FromFile(DuongDanHinh + TenHinh);
            }
            else
            {
                picHinh.Image = null;
            }
        }
    }
}
