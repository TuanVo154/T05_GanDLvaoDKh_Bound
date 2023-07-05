using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T05_GanDLvaoDKh_Bound
{
    internal class clsDuLieu
    {
        SqlConnection cn = new SqlConnection();
        int SiSo = -1;
        public bool KetNoi()
        {
            string ChuoiKN = "Data Source =TUANVO_ROG;Initial Catalog = QLySinhVienCD; Integrated Security = True";
            try
            {
                if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
                {
                    cn.ConnectionString = ChuoiKN;
                    cn.Open();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối, vui lòng kiểm tra lại kết nối");
                return false;
            }
        }

        public DataTable LayDLcoDK(string TenBang, string DK = "", string TenFieldSX = "")
        {
            DataTable tbl = new DataTable();
            string ChuoiSQL = "Select * from " + TenBang;
            if (DK != "") ChuoiSQL += " Where " + DK;
            if (TenFieldSX != "") ChuoiSQL += " Order By " + TenFieldSX;
            SqlDataAdapter da = new SqlDataAdapter(ChuoiSQL, cn);
            da.Fill(tbl);
            return tbl;
        }

        public void TinhSiSo (DataTable tbl, Label lbl)
        {
            SiSo = tbl.Rows.Count;
            if((SiSo > 0)&& lbl != null) lbl.Text = "1/" + SiSo;
        }

        public void Dau (Form frm, DataTable tbl, Label lbl)
        {
            if( lbl != null)
            {
                frm.BindingContext[tbl].Position= 0;
                int VT = frm.BindingContext[tbl].Position + 1;
                lbl.Text = VT + "/" + SiSo;
            }
        }

        public void Cuoi(Form frm, DataTable tbl, Label lbl)
        {
            if (lbl != null)
            {
                frm.BindingContext[tbl].Position = SiSo -1;
                int VT = frm.BindingContext[tbl].Position + 1;
                lbl.Text = VT + "/" + SiSo;
            }
        }

        public void Truoc(Form frm, DataTable tbl, Label lbl)
        {
            if (lbl != null)
            {
                frm.BindingContext[tbl].Position--;
                int VT = frm.BindingContext[tbl].Position + 1;
                lbl.Text = VT + "/" + SiSo;
            }
        }

        public void Sau(Form frm, DataTable tbl, Label lbl)
        {
            if (lbl != null)
            {
                frm.BindingContext[tbl].Position++;
                int VT = frm.BindingContext[tbl].Position + 1;
                lbl.Text = VT + "/" + SiSo;
            }
        }
    }
}
