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
        private string maxMaKyHoc;
        public FrmBienLai_NV()
        {
            InitializeComponent();
        }

        KetNoi_CSDL ketnoi = new KetNoi_CSDL();
        private void FrmBienLai_NV_Load(object sender, EventArgs e)
        {
            Lay_HocKy();
            Lay_TrangThai();
            Lay_Dulieu();
        }

        public void Lay_TrangThai() // Hàm lấy dữ liệu tình trạng
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("0");
            cboTrangThai.Items.Add("1");
            cboTrangThai.Items.Add("2");

            cboTKTrangThai.Items.Clear();
            cboTKTrangThai.Items.Add("Ẩn");
            cboTKTrangThai.Items.Add("Đã duyệt");
            cboTKTrangThai.Items.Add("Chưa duyệt");
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

            sql = "SELECT DISTINCT MaKyHoc FROM KY_HOC";
            dta = ketnoi.Lay_DuLieu(sql);
            cboMaKyHoc.DataSource = dta;
            cboMaKyHoc.DisplayMember = "MaKyHoc"; // value
            cboMaKyHoc.ValueMember = "MaKyHoc"; // key

            sql = "SELECT MAX(MaKyHoc) AS MaxMaKyHoc FROM KY_HOC";
            dta = ketnoi.Lay_DuLieu(sql);
            this.maxMaKyHoc = (from DataRow dr in dta.Rows select (string)dr["maxMaKyHoc"]).FirstOrDefault();
        }

        private void Lay_Dulieu()
        {
            DataTable dataTable = new DataTable();
            ketnoi.KetNoi_DuLieu();
            string sql = "SELECT * FROM BIEN_LAI WHERE Status != 0";
            dataTable = ketnoi.Lay_DuLieu(sql);
            dataGrid_BienLai.DataSource = dataTable;
            HienThi_DuLieu();

            this.dtimeNgayCapNhat.Enabled = false;
            this.dtimeTTNgayNop.Enabled = false;
            this.cboMaKyHoc.Enabled = false;
            this.txtMaBL.Enabled = false;
            this.txtTenBL.Enabled = false;
            this.txtTTMaSV.Enabled = false;
            this.txtTienNop.Enabled = false;
            this.cboTrangThai.Enabled = true;
            this.txtMoTa.Enabled = false;
            this.txtNguoiCapNhat.Enabled = false;

        }

        private void HienThi_DuLieu()
        {
            txtMaBL.DataBindings.Clear();
            txtMaBL.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MaBL");

            txtTTMaSV.DataBindings.Clear();
            txtTTMaSV.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MSV");

            dtimeTTNgayNop.DataBindings.Clear();
            dtimeTTNgayNop.DataBindings.Add("Value", dataGrid_BienLai.DataSource, "NgayNop");

            txtTienNop.DataBindings.Clear();
            txtTienNop.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "TienNop");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "Mota");

            txtTenBL.DataBindings.Clear();
            txtTenBL.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "TenBL");

            dtimeNgayCapNhat.DataBindings.Clear();
            dtimeNgayCapNhat.DataBindings.Add("Value", dataGrid_BienLai.DataSource, "NgayCapNhat");

            txtNguoiCapNhat.DataBindings.Clear();
            txtNguoiCapNhat.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MaNguoiCapNhat");

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "Status");

            cboMaKyHoc.DataBindings.Clear();
            cboMaKyHoc.DataBindings.Add("Text", dataGrid_BienLai.DataSource, "MaKyHoc");
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thêm mới bản ghi trống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                txtMaBL.Text = "";
                txtTTMaSV.Text = "";
                dtimeTTNgayNop.Value = DateTime.Today;
                txtTienNop.Text = "";
                txtMoTa.Text = "";
                txtTenBL.Text = "";
                dtimeNgayCapNhat.Value = DateTime.Today;
                txtNguoiCapNhat.Text = Globals.USER_ID;
                cboTrangThai.SelectedItem = "2";

                
                this.cboMaKyHoc.Enabled = true;
                this.txtMaBL.Enabled = true;
                this.txtTenBL.Enabled = true;
                this.txtTTMaSV.Enabled = true;
                this.txtTienNop.Enabled = true;
                this.txtMoTa.Enabled = true;
                this.cboTrangThai.Enabled = false;
                this.dtimeNgayCapNhat.Enabled = false;
                this.dtimeTTNgayNop.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maBL = txtMaBL.Text;
            string maSV = txtTTMaSV.Text;
            string ngayNop = dtimeTTNgayNop.Value.ToString("yyyy-MM-dd");
            decimal tienNop = Convert.ToDecimal(txtTienNop.Text);
            string moTa = txtMoTa.Text;
            string tenBL = txtTenBL.Text;
            string ngayCapNhat = dtimeNgayCapNhat.Value.ToString("yyyy-MM-dd");
            string nguoiCapNhat = txtNguoiCapNhat.Text;
            int trangThai = Convert.ToInt32(cboTrangThai.Text);
            string maKyHoc = cboMaKyHoc.Text;
            

            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn lưu bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (maKyHoc == this.maxMaKyHoc)
                {
                    string sql = "insert into BIEN_LAI (MaBL, TenBL, MSV, TienNop, NgayNop, Mota, NgayCapNhat, MaNguoiCapNhat, MaKyHoc, Status) values ('" + maBL + "', '" + tenBL + "', '" + maSV + "', " + tienNop + ", '" + ngayNop + "', N'" + moTa + "', '" + ngayCapNhat + "', '" + Globals.USER_ID + "', '" + maKyHoc + "', " + trangThai + ")";
                    ketnoi.ThucThi(sql);
                    MessageBox.Show("Thêm mới thành công");
                    Lay_Dulieu();
                }
                else
                {
                    MessageBox.Show("Chỉ có thể thêm/xóa bản ghi của những biên lai xét trong học kỳ hiện tại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maBL = txtMaBL.Text;
            string ngayCapNhat = (DateTime.Today).ToString("yyyy-MM-dd");
            string nguoiCapNhat = Globals.USER_ID;
            int trangThai = Convert.ToInt32(cboTrangThai.Text);

            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn cập nhật bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (trangThai != 2)
                {
                    string sqlUpdate = "UPDATE BIEN_LAI SET Status = " + trangThai + ", NgayCapNhat = '" + ngayCapNhat + "', MaNguoiCapNhat = '" + nguoiCapNhat + "'  WHERE MaBL = '" + maBL + "'";
                    ketnoi.ThucThi(sqlUpdate);
                    MessageBox.Show("Cập nhật thành công");
                    Lay_Dulieu(); 
                }
                else
                {
                    MessageBox.Show("Không thể chỉnh sửa bản ghi trở về trạng thái chưa xét duyệt!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maBL = txtMaBL.Text;
            string maKyHoc = cboMaKyHoc.Text;

            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (maKyHoc == this.maxMaKyHoc)
                {
                    string sql = "DELETE FROM BIEN_LAI WHERE MaBL = '" + maBL + "' AND MaKyHoc = (SELECT MAX(MaKyHoc) FROM KY_HOC)";
                    ketnoi.ThucThi(sql);
                    MessageBox.Show("Xóa bản ghi thành công");
                    Lay_Dulieu();
                }
                else
                {
                    MessageBox.Show("Chỉ có thể thêm/xóa bản ghi của những biên lai xét trong học kỳ hiện tại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }    
                

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Close();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string MaBL = "";
            string NamHoc = "";
            string HocKy = "";
            string MaSV = "";
            string NgayNop = "";
            int Status = -1;

            if (chkTKMaBL.Checked == true)
                MaBL = txtTKMaBienLai.Text;

            if (chkTKNamHoc.Checked == true)
                NamHoc = cboTKNamHoc.Text;

            if (chkTKHocKy.Checked == true)
                HocKy = cboTKHocKy.Text;

            if (chkTKMaSV.Checked == true)
                MaSV = txtTKMaSV.Text;

            if (chkTKNgayNop.Checked == true)
                NgayNop = dtimeTKNgayNop.Value.ToString("yyyy-MM-dd");

            if (chkTKTrangThai.Checked == true)
            {
                if (cboTKTrangThai.Text == "Ẩn")
                    Status = 0;
                if (cboTKTrangThai.Text == "Đã duyệt")
                    Status = 1;
                if (cboTKTrangThai.Text == "Chưa duyệt")
                    Status = 2;
            } 
                
                



            string sql_tk = string.Format("EXEC SP_TIMBIENLAI '{0}', '{1}', '{2}', '{3}', '{4}', {5}", NamHoc, HocKy, MaSV, NgayNop, MaBL, Status);
            dta = ketnoi.Lay_DuLieu(sql_tk);
            dataGrid_BienLai.DataSource = dta;
            HienThi_DuLieu();
        }
    }
}
