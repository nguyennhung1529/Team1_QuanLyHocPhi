
namespace QuanLyHocPhi
{
    partial class FrmBaoCaoThongKe_NV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.chbNamHoc = new System.Windows.Forms.CheckBox();
            this.chbHocKy = new System.Windows.Forms.CheckBox();
            this.chbTinhTrang = new System.Windows.Forms.CheckBox();
            this.chbMaSV = new System.Windows.Forms.CheckBox();
            this.lblBaoCaoThongKeSV = new System.Windows.Forms.Label();
            this.CRVBaoCaoThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.cboTinhTrang);
            this.grbTimKiem.Controls.Add(this.cboHocKy);
            this.grbTimKiem.Controls.Add(this.txtMaSV);
            this.grbTimKiem.Controls.Add(this.txtNamHoc);
            this.grbTimKiem.Controls.Add(this.chbNamHoc);
            this.grbTimKiem.Controls.Add(this.chbHocKy);
            this.grbTimKiem.Controls.Add(this.chbTinhTrang);
            this.grbTimKiem.Controls.Add(this.chbMaSV);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(43, 75);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(817, 119);
            this.grbTimKiem.TabIndex = 7;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(674, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 29);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Còn nợ",
            "Đã đóng",
            "Dư tiền"});
            this.cboTinhTrang.Location = new System.Drawing.Point(481, 73);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(148, 23);
            this.cboTinhTrang.TabIndex = 7;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2",
            "Học kỳ 3"});
            this.cboHocKy.Location = new System.Drawing.Point(481, 39);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(148, 23);
            this.cboHocKy.TabIndex = 6;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(183, 73);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(148, 21);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(183, 39);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(148, 21);
            this.txtNamHoc.TabIndex = 4;
            // 
            // chbNamHoc
            // 
            this.chbNamHoc.AutoSize = true;
            this.chbNamHoc.Location = new System.Drawing.Point(62, 41);
            this.chbNamHoc.Name = "chbNamHoc";
            this.chbNamHoc.Size = new System.Drawing.Size(79, 19);
            this.chbNamHoc.TabIndex = 3;
            this.chbNamHoc.Text = "Năm học:";
            this.chbNamHoc.UseVisualStyleBackColor = true;
            // 
            // chbHocKy
            // 
            this.chbHocKy.AutoSize = true;
            this.chbHocKy.Location = new System.Drawing.Point(376, 41);
            this.chbHocKy.Name = "chbHocKy";
            this.chbHocKy.Size = new System.Drawing.Size(65, 19);
            this.chbHocKy.TabIndex = 2;
            this.chbHocKy.Text = "Học kỳ:";
            this.chbHocKy.UseVisualStyleBackColor = true;
            // 
            // chbTinhTrang
            // 
            this.chbTinhTrang.AutoSize = true;
            this.chbTinhTrang.Location = new System.Drawing.Point(376, 75);
            this.chbTinhTrang.Name = "chbTinhTrang";
            this.chbTinhTrang.Size = new System.Drawing.Size(84, 19);
            this.chbTinhTrang.TabIndex = 1;
            this.chbTinhTrang.Text = "Tình trạng:";
            this.chbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // chbMaSV
            // 
            this.chbMaSV.AutoSize = true;
            this.chbMaSV.Location = new System.Drawing.Point(62, 75);
            this.chbMaSV.Name = "chbMaSV";
            this.chbMaSV.Size = new System.Drawing.Size(98, 19);
            this.chbMaSV.TabIndex = 0;
            this.chbMaSV.Text = "Mã sinh viên:";
            this.chbMaSV.UseVisualStyleBackColor = true;
            // 
            // lblBaoCaoThongKeSV
            // 
            this.lblBaoCaoThongKeSV.AutoSize = true;
            this.lblBaoCaoThongKeSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoThongKeSV.Location = new System.Drawing.Point(207, 37);
            this.lblBaoCaoThongKeSV.Name = "lblBaoCaoThongKeSV";
            this.lblBaoCaoThongKeSV.Size = new System.Drawing.Size(524, 24);
            this.lblBaoCaoThongKeSV.TabIndex = 8;
            this.lblBaoCaoThongKeSV.Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH HỌC PHÍ SINH VIÊN";
            // 
            // CRVBaoCaoThongKe
            // 
            this.CRVBaoCaoThongKe.ActiveViewIndex = -1;
            this.CRVBaoCaoThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBaoCaoThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBaoCaoThongKe.Location = new System.Drawing.Point(9, 200);
            this.CRVBaoCaoThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CRVBaoCaoThongKe.Name = "CRVBaoCaoThongKe";
            this.CRVBaoCaoThongKe.Size = new System.Drawing.Size(884, 382);
            this.CRVBaoCaoThongKe.TabIndex = 9;
            this.CRVBaoCaoThongKe.ToolPanelWidth = 150;
            // 
            // FrmBaoCaoThongKe_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 592);
            this.Controls.Add(this.CRVBaoCaoThongKe);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.lblBaoCaoThongKeSV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBaoCaoThongKe_NV";
            this.Text = "FrmBaoCaoThongKe_NV";
            this.Load += new System.EventHandler(this.FrmBaoCaoThongKe_NV_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.CheckBox chbNamHoc;
        private System.Windows.Forms.CheckBox chbHocKy;
        private System.Windows.Forms.CheckBox chbTinhTrang;
        private System.Windows.Forms.CheckBox chbMaSV;
        private System.Windows.Forms.Label lblBaoCaoThongKeSV;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBaoCaoThongKe;
    }
}