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
    public partial class FrmQuanLyTienTin_NV : Form
    {
        KetNoi_CSDL ketNoi = new KetNoi_CSDL();
        public FrmQuanLyTienTin_NV()
        {
            InitializeComponent();
        }

        private void layDuLieu()
        {
            DataTable data = new DataTable();
            ketNoi.KetNoi_DuLieu();
            string query = "SELECT * FROM TIEN_TIN";
            data = ketNoi.Lay_DuLieu(query);
            dtgtientin.DataSource = data;
            hienThiDuLieu();
        }

        private void hienThiDuLieu()
        {
            txtmatientin.DataBindings.Clear();
            txtmatientin.DataBindings.Add("text", dtgtientin.DataSource, "MATT");

            txttentientin.DataBindings.Clear();
            txttentientin.DataBindings.Add("text", dtgtientin.DataSource, "TENTT");

            txttien1tc.DataBindings.Clear();
            txttien1tc.DataBindings.Add("text", dtgtientin.DataSource, "TIENTC");

            txtmota.DataBindings.Clear();
            txtmota.DataBindings.Add("text", dtgtientin.DataSource, "MOTA");

           

        }

        private void FrmQuanLyTienTin_NV_Load(object sender, EventArgs e)
        {
            layDuLieu();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            txtmatientin.Text = "";
            txttentientin.Text = "";
            txttien1tc.Text = "";
            txtmota.Text = "";
            txtmatientin.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO TIEN_TIN VALUES ('" + txtmatientin.Text + "','" + txttentientin.Text + "','" + txttien1tc.Text + "','" + txtmota.Text
                                                                    + "','" + 1 +"')";
            ketNoi.ThucThi(sqlInsert);
            layDuLieu();
        }

        private void txtxoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM TIEN_TIN WHERE MaTT = '" + txtmatientin.Text + "'";
            ketNoi.ThucThi(sqlDelete);
            layDuLieu();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE TIEN_TIN SET TenTT = '" + txttentientin.Text + "', TienTC = '" + txttien1tc.Text + "', MoTa = '" + txtmota.Text + "' WHERE MaTT = '" + txtmatientin.Text + "'";
            ketNoi.ThucThi(sqlUpdate);
            layDuLieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
