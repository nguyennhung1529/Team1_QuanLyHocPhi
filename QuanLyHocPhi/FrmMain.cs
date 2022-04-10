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
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;
        private int status;
        private string username;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(int status)
        {
            InitializeComponent();
            this.status = status;
        }

        public FrmMain(string username, int status)
        {
            InitializeComponent();
            this.username = username;
            this.status = status;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }



        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void quảnLýTiềnTínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuQuanLiTienTin_NV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmQuanLyTienTin_NV();
            frm1.Show();
        }

        private void mnuTimKiemTienTin_NV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmTimKiemTienTin_NV();
            frm1.Show();
        }

        private void mnuBienLai_NV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmBienLai_NV();
            frm1.Show();
        }

        private void mnuThongKeHocPhi_NV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmThongKeHocPhi_NV();
            frm1.Show();
        }

        private void mnuChiTietHocPhi_NV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmChiTietHocPhi_NV();
            frm1.Show();
        }

        private void mnuBaoCaoThongKe_NV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmBaoCaoThongKe_NV();
            frm1.Show();
        }

        private void mnuXemHocPhi_SV_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmXemHocPhi_SV(this.username);
            frm1.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (this.status == 0)
            {
                mnuQuanLiTienTin_NV.Visible = false;
                mnuTimKiemTienTin_NV.Visible = false;
                mnuBienLai_NV.Visible = false;
                mnuThongKeHocPhi_NV.Visible = false;
                mnuChiTietHocPhi_NV.Visible = false;
                mnuBaoCaoThongKe_NV.Visible = false;
            }
            else
            {
                mnuXemHocPhi_SV.Visible = false;
            }
        }
    }
}
