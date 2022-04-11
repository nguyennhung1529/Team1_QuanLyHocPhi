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
    public partial class FrmXemHocPhi_SV : Form
    {
        public FrmXemHocPhi_SV()
        {
            InitializeComponent();
        }

        KetNoi_CSDL ketnoi = new KetNoi_CSDL();

        public void LayBang_TongQuat() 
        {
            DataTable dta = new DataTable();
            string sql = "select * from Xem_HocPhiSV";
            dta = ketnoi.Lay_DuLieu(sql);
            dataGrid_HocPhiSV.DataSource = dta;
            HienThi_DuLieu();
        }

        private void HienThi_DuLieu()
        {
            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Năm học");

            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Học kỳ");

            txtMaHocPhan.DataBindings.Clear();
            txtMaHocPhan.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Mã học phần");

            txtTenHocPhan.DataBindings.Clear();
            txtTenHocPhan.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Tên học phần");

            txtSoTinChi.DataBindings.Clear();
            txtSoTinChi.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Số tín chỉ");

            txtCanDong.DataBindings.Clear();
            txtCanDong.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Cần đóng");

            txtDaDong.DataBindings.Clear();
            txtDaDong.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Đã đóng");

            txtNgayDong.DataBindings.Clear();
            txtNgayDong.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Ngày đóng");

            txtConNo.DataBindings.Clear();
            txtConNo.DataBindings.Add("Text", dataGrid_HocPhiSV.DataSource, "Còn nợ");

        }

        private void FrmXemHocPhi_SV_Load(object sender, EventArgs e)
        {
            LayBang_TongQuat();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string HocKy = "";
            int sttTinNo = 0;
            

            if (chbNamHoc.Checked == true)
                NamHoc = cboNamHoc.Text;

            if (chbHocKy.Checked == true)
                HocKy = cboHocKy.Text;

            if (chbTinConNo.Checked == true)
                sttTinNo = 1;

            string sql_tk = string.Format("EXEC SP_TIMKIEM_XemHocPhiSV '{0}', '{1}', '{2}'", NamHoc, HocKy, sttTinNo);
            dta = ketnoi.Lay_DuLieu(sql_tk);
            dataGrid_HocPhiSV.DataSource = dta;
            HienThi_DuLieu();

        }

        
    }
}
