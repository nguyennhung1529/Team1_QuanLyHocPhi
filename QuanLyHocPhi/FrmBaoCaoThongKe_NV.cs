using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocPhi
{
    public partial class FrmBaoCaoThongKe_NV : Form
    {
        public FrmBaoCaoThongKe_NV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string namHoc = "";
            string hocKy = "";
            string maSv = "";
            string tinhTrang = "";
            if(chbNamHoc.Checked == true)
            {
                namHoc = txtNamHoc.Text;
            }
            if (chbMaSV.Checked == true)
            {
                maSv = txtMaSV.Text;
            }
            if (chbHocKy.Checked == true)
            {
                hocKy = cboHocKy.Text;

            }
            if (chbTinhTrang.Checked == true)
            {
                tinhTrang = cboTinhTrang.Text;

            }

        }
    }
}
