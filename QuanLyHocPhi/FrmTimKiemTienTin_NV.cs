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
    public partial class FrmTimKiemTienTin_NV : Form
    {
        public FrmTimKiemTienTin_NV()
        {
            InitializeComponent();
        }
        KetNoi_CSDL ketNoi = new KetNoi_CSDL();

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTimKiemTienTin_NV_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = ketNoi.Lay_DuLieu("Select * from TIEN_TIN");
            cbomatt.DataSource = data;
            cbomatt.DisplayMember = "MaTT";
            cbomatt.ValueMember = "MaTT";

            cbtentt.DataSource = data;
            cbtentt.DisplayMember = "TenTT";
            cbtentt.ValueMember = "TenTT";


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string query;
            if (rdbmatt.Checked == true)
            {
                query = "SELECT * FROM TIEN_TIN WHERE MaTT = '" + cbomatt.Text + "'";
                data = ketNoi.Lay_DuLieu(query);
            }
            if (rdbtentt.Checked == true)
            {
                query = "SELECT * FROM TIEN_TIN WHERE TenTT like N'" + cbtentt.Text + "'";
                data = ketNoi.Lay_DuLieu(query);
            }
       
            dtgtktientin.DataSource = data;
        }
    }
}
