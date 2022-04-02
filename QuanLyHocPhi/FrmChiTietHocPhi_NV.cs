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
    public partial class FrmChiTietHocPhi_NV : Form
    {
        private string NamHoc;
        private string HocKy;
        private string MSV;

        public FrmChiTietHocPhi_NV()
        {
            InitializeComponent();
        }

        public FrmChiTietHocPhi_NV(string NamHoc, string HocKy, string MSV) : this()
        {
            this.NamHoc = NamHoc;
            this.HocKy = HocKy;
            this.MSV = MSV;
        }
        KetNoi_CSDL ketnoi = new KetNoi_CSDL();
        private void FrmChiTietHocPhi_NV_Load(object sender, EventArgs e)
        {
            Lay_HocKy();
            Lay_TinhTrang();
            Lay_SinhVien();

            if (this.NamHoc != null)
                cboTKNamHoc.SelectedValue = this.NamHoc;

            if (this.HocKy != null)
                cboTKHocKy.SelectedValue = this.HocKy;

            if (this.MSV != null)
                cboTKMaSV.SelectedValue = this.MSV;
        }

        public void Lay_HocKy() // Hàm lấy dữ liệu HOC_KY
        {
            DataTable dta = new DataTable();
            string sql = "SELECT DISTINCT NamHoc FROM KY_HOC";
            dta = ketnoi.Lay_DuLieu(sql);
            cboTKNamHoc.DataSource = dta;
            cboTKNamHoc.DisplayMember = "NamHoc";
            cboTKNamHoc.ValueMember = "NamHoc";
            

            sql = "SELECT DISTINCT HocKy FROM KY_HOC";
            dta = ketnoi.Lay_DuLieu(sql);
            cboTKHocKy.DataSource = dta;
            cboTKHocKy.DisplayMember = "HocKy"; // value
            cboTKHocKy.ValueMember = "HocKy"; // key
            
        }

        public void Lay_TinhTrang() // Hàm lấy dữ liệu tình trạng
        {
            cboTKTinhTrang.Items.Clear();
            cboTKTinhTrang.Items.Add("Còn nợ");
            cboTKTinhTrang.Items.Add("Đã đóng");
            cboTKTinhTrang.Items.Add("Dư tiền");
            cboTKTinhTrang.SelectedItem = "Còn nợ";
        }

        public void Lay_SinhVien() // Hàm lấy dữ liệu tình trạng
        {
            DataTable dta = new DataTable();
            string sql = "SELECT DISTINCT MSV FROM SINH_VIEN";
            dta = ketnoi.Lay_DuLieu(sql);
            cboTKMaSV.DataSource = dta;
            cboTKMaSV.DisplayMember = "MSV";
            cboTKMaSV.ValueMember = "MSV";
        }
    }
}
