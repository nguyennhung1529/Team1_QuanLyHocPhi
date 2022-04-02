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
    public partial class FrmThongKeHocPhi_NV : Form
    {
        public FrmThongKeHocPhi_NV()
        {
            InitializeComponent();
        }

        KetNoi_CSDL ketnoi = new KetNoi_CSDL();
        private void FrmThongKeHocPhi_NV_Load(object sender, EventArgs e)
        {
            LayBang_TongQuat();
            Lay_HocKy();
            Lay_TinhTrang();
        }

        // NHANVIEN(MANV, HOTEN, NGAYSINH, DIACHI, MAPHONG)
        public void LayBang_TongQuat() // Hàm lấy dữ liệu bảng NHANVIEN
        {
            DataTable dta = new DataTable();
            string sql = "select * from VW_TongQuatHocPhi";
            dta = ketnoi.Lay_DuLieu(sql);
            dataGVThongKeHocPhi.DataSource = dta;
            HienThi_DuLieu();
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



        private void HienThi_DuLieu()
        {
            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "Năm học");

            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "Học kỳ");

            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "MSV");

            txtMaL.DataBindings.Clear();
            txtMaL.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "Mã lớp");

            txtMienGiam.DataBindings.Clear();
            txtMienGiam.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "Mức giảm");

            txtCanDong.DataBindings.Clear();
            txtCanDong.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "Cần đóng");

            txtConNo.DataBindings.Clear();
            txtConNo.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "Còn nợ");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            FrmChiTietHocPhi_NV frmXemChiTiet = new FrmChiTietHocPhi_NV(txtNamHoc.Text, txtHocKy.Text, txtMaSV.Text);
            frmXemChiTiet.Show();
            this.Hide();
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
                MaSV = txtTKMaSV.Text;

            if (chkTKTinhTrang.Checked == true)
                TinhTrang = cboTKTinhTrang.Text;

            string sql_tk = string.Format("EXEC SP_TIMKIEM_TongQuatHocPhi '{0}', '{1}', '{2}', N'{3}'", NamHoc, HocKy, MaSV, TinhTrang);
            dta = ketnoi.Lay_DuLieu(sql_tk);
            dataGVThongKeHocPhi.DataSource = dta;
            HienThi_DuLieu();
        }
    }
}
