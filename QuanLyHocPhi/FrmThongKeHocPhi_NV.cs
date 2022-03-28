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

        }

        // NHANVIEN(MANV, HOTEN, NGAYSINH, DIACHI, MAPHONG)
        public void LayBang_NhanVien() // Hàm lấy dữ liệu bảng NHANVIEN
        {
            DataTable dta = new DataTable();
            string sql = "select MANV, HOTEN, NGAYSINH, DIACHI, MAPHONG from NHANVIEN";
            dta = ketnoi.Lay_DuLieu(sql);
            dataGVThongKeHocPhi.DataSource = dta;
            HienThi_DuLieu();
        }

        private void HienThi_DuLieu()
        {
            txtBoxMaNV.DataBindings.Clear();
            txtBoxMaNV.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "MANV");

            txtBoxTenNV.DataBindings.Clear();
            txtBoxTenNV.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "HOTEN");

            dtimeNgaySinh.DataBindings.Clear();
            dtimeNgaySinh.DataBindings.Add("Value", dataGVThongKeHocPhi.DataSource, "NGAYSINH");

            txtBoxDiaChi.DataBindings.Clear();
            txtBoxDiaChi.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "DIACHI");

            cboMaPhong.DataBindings.Clear();
            cboMaPhong.DataBindings.Add("Text", dataGVThongKeHocPhi.DataSource, "MAPHONG");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
