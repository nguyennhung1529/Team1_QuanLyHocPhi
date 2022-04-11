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
    public partial class FrmBienLai_NV : Form
    {
        public FrmBienLai_NV()
        {
            InitializeComponent();
        }

        KetNoi_CSDL ketnoi = new KetNoi_CSDL();

        private void Lay_Dulieu()
        {
            DataTable dataTable = new DataTable();
            ketnoi.KetNoi_DuLieu();
            string query = "SELECT * FROM BIEN_LAI";
            dataTable = ketnoi.Lay_DuLieu(query);
            dataGrid_BienLai.DataSource = dataTable;
            HIENTHI_DULIEU();
        }

        public void LAYBANG_BIENLAI()
        {
            DataTable dta = new DataTable();
            string sql = "SELECT * FROM BIEN_LAI";
            dta = ketnoi.Lay_DuLieu(sql);
            cboTrangThai.DataSource = dta;
            cboTrangThai.DisplayMember = "Status";
            cboTrangThai.ValueMember = "Status";
        }

        public void Lay_TinhTrang() // Hàm lấy dữ liệu tình trạng
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Hủy");
            cboTrangThai.Items.Add("Đã duyệt");
            cboTrangThai.Items.Add("Chưa duyệt");
            //cboTrangThai.SelectedItem = "Chưa duyệt";
        }

        private void HIENTHI_DULIEU()
        {
            txtMaBL.DataBindings.Clear();
            txtMaBL.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MaBL");

            txtTTMaSV.DataBindings.Clear();
            txtTTMaSV.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MSV");

            txtTTNgayNop.DataBindings.Clear();
            txtTTNgayNop.DataBindings.Add("Value", dataGrid_BienLai.DataSource, "NgayNop");

            txtTienNop.DataBindings.Clear();
            txtTienNop.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "TienNop");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "Mota");

            txtTenBL.DataBindings.Clear();
            txtTenBL.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "TenBL");

            txtNgayCapNhat.DataBindings.Clear();
            txtNgayCapNhat.DataBindings.Add("Value", dataGrid_BienLai.DataSource, "NgayCapNhat");

            txtNguoiCapNhat.DataBindings.Clear();
            txtNguoiCapNhat.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MaNguoiCapNhat");

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "Status");
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

        private void FrmBienLai_NV_Load(object sender, EventArgs e)
        {
            Lay_Dulieu();
            LAYBANG_BIENLAI();
            Lay_HocKy();

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaBL.Text = "";
            txtTTMaSV.Text = "";
            txtTTNgayNop.Value = DateTime.Now;
            txtTienNop.Text = "";
            txtMoTa.Text = "";
            txtTenBL.Text = "";
            txtNgayCapNhat.Value = DateTime.Now;
            txtNguoiCapNhat.Text = "";
            cboTrangThai.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO BIEN_LAI VALUES('" + txtMaBL.Text + "'," +
                "'" + txtTTMaSV.Text + "'," +
                "" + txtTTNgayNop.Value.ToString("dd/mm/yyyy") + "," +
                "’" + txtTienNop.Text + "'," +
                "'" + txtMoTa.Text + "'," +
                "'" + txtTenBL.Text + "'," +
                "" + txtNgayCapNhat.Value.ToString("dd/mm/yyyy") + "," +
                "’" + txtNguoiCapNhat.Text + "'," +
                "'" + cboTrangThai.Text + "')";
            ketnoi.ThucThi(sql);
            Lay_Dulieu();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE BIEN_LAI SET MSV = '" + txtTTMaSV.Text + "'," +
                         "NgayNop = " + txtTTNgayNop.Value.ToString("dd/mm/yyyy") + "," +
                         "TienNop = '" + txtTienNop.Text + "', " +
                         "Mota = '" + txtMoTa.Text + "', " +
                         "TenBL = '" + txtTenBL.Text + "', " +
                         "NgayCapNhat = " + txtNgayCapNhat.Value.ToString("dd/mm/yyyy") + ", " +
                         "MaNguoiCapNhat = '" + txtNguoiCapNhat.Text + "' " +
                         "Status = '" + cboTrangThai.Text + "' " +
                         "WHERE MaBL = '" + txtMaBL.Text + "' ";

            ketnoi.ThucThi(sqlUpdate);
            Lay_Dulieu();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM BIEN_LAI WHERE MaBL = '" + txtMaBL.Text + "'";
            ketnoi.ThucThi(sql);
            Lay_Dulieu();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
                this.Close();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string HocKy = "";
            string MSV = "";
            string NgayNop = txtTKNgayNop.Value.ToString("dd/mm/yyyy");


            if (chbNamHoc.Checked == true)
                NamHoc = chbNamHoc.Text;

            if (chbHocKi.Checked == true)
                HocKy = chbHocKi.Text;

            if (chbMaSV.Checked == true)
                MSV = chbMaSV.Text;


            if (chbNgayNop.Checked == true)
                NgayNop = chbNgayNop.Text;

            string sql_tk = string.Format("EXEC SP_TIMKIEM_BIENLAI '{0}', '{1}', '{2}', '{3}'", NamHoc, HocKy, MSV, NgayNop);
            dta = ketnoi.Lay_DuLieu(sql_tk);
            dataGrid_BienLai.DataSource = dta;
            HIENTHI_DULIEU();



        }
    }
}
