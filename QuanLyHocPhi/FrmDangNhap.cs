using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocPhi
{
    public partial class FrmDangNhap : Form
    {

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        KetNoi_CSDL ketnoi = new KetNoi_CSDL();
        private void btnDN_Click(object sender, EventArgs e)
        {
            ketnoi.KetNoi_DuLieu();

            string username = txtTenDN.Text;
            string passw = txtMatKhau.Text;
            int status = (radNS.Checked == true) ? 1 : 0;

            string sql_login = "select [Username], [Password] from [USER] where [Username] = '" + username + "' and [Password] = '" + passw + "' and [Status] = " + status;

            SqlCommand cmd = new SqlCommand(sql_login, ketnoi.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.USER_ID = username;
                Globals.STATUS = status;
                Form frmmain = new FrmMain();
                frmmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}
