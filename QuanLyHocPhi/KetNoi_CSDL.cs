using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// Data Source=MSI\;Initial Catalog=QLHocPhi;Integrated Security=True
namespace QuanLyHocPhi
{
    class KetNoi_CSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada; // lấy dữ liệu

        public void KetNoi_DuLieu()
        {
            string strKetNoi = @"Data Source=MSI\;Initial Catalog=QuanLyHocPhi;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DuLieu(string Sql)
        {
            KetNoi_DuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            HuyKetNoi();
            return dta;
        }

        public void ThucThi(string Sql)
        {
            KetNoi_DuLieu();
            cmd = new SqlCommand(Sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
