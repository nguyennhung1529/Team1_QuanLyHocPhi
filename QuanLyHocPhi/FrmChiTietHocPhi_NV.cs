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

        public FrmChiTietHocPhi_NV(string username)
        {
            this.username = username;
        }

        KetNoi_CSDL ketnoi = new KetNoi_CSDL();
        private string username;

        private void FrmChiTietHocPhi_NV_Load(object sender, EventArgs e)
        {
            Lay_HocKy();
            Lay_TinhTrang();
            Lay_SinhVien();
            Lay_ChiTietSinhVien();

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

        public void Lay_SinhVien() // Hàm lấy dữ liệu sinh viên
        {
            DataTable dta = new DataTable();
            string sql = "SELECT DISTINCT MSV FROM SINH_VIEN";
            dta = ketnoi.Lay_DuLieu(sql);
            cboTKMaSV.DataSource = dta;
            cboTKMaSV.DisplayMember = "MSV";
            cboTKMaSV.ValueMember = "MSV";
        }

        public void Lay_ChiTietSinhVien() // Hàm lấy dữ liệu chi tiết sinh viên
        {
            DataTable dta = new DataTable();

            string sql_tk = string.Format("EXEC SP_TIMKIEM_ChiTietHocPhi '{0}', '{1}', '{2}', N'{3}'", this.NamHoc, this.HocKy, this.MSV, "");
            dta = ketnoi.Lay_DuLieu(sql_tk);
            dataGVChiTietHocPhi_NV.DataSource = dta;
            HienThi_DuLieu();
        }

        private void HienThi_DuLieu()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "MSV");

            txtTenSV.DataBindings.Clear();
            txtTenSV.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "HoTen");

            txtMaL.DataBindings.Clear();
            txtMaL.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "MaL");

            txtMaHP.DataBindings.Clear();
            txtMaHP.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "MaHP");

            txtTenHP.DataBindings.Clear();
            txtTenHP.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "TenHP");

            txtTienHoc.DataBindings.Clear();
            txtTienHoc.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "TienHoc");

            txtMienGiam.DataBindings.Clear();
            txtMienGiam.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "MucGiam");

            txtCanDong.DataBindings.Clear();
            txtCanDong.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "CanDong");

            txtConNo.DataBindings.Clear();
            txtConNo.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "ConNo");

            txtNgayDong.DataBindings.Clear();
            txtNgayDong.DataBindings.Add("Text", dataGVChiTietHocPhi_NV.DataSource, "NgayNop");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string HocKy = "";
            string MaSV = "";
            string TinhTrang = "";

            if (chkTKNamHoc.Checked == true)
                NamHoc = cboTKNamHoc.Text;

            if (chkTKHocKy.Checked == true)
                HocKy = cboTKHocKy.Text;

            if (chkTKMaSV.Checked == true)
                MaSV = cboTKMaSV.Text;

            if (chkTKTinhTrang.Checked == true)
                TinhTrang = cboTKTinhTrang.Text;

            string sql_tk = string.Format("EXEC SP_TIMKIEM_ChiTietHocPhi '{0}', '{1}', '{2}', N'{3}'", NamHoc, HocKy, MaSV, TinhTrang);
            dta = ketnoi.Lay_DuLieu(sql_tk);
            dataGVChiTietHocPhi_NV.DataSource = dta;
            HienThi_DuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
