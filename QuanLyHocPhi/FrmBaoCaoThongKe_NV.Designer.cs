
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
            this.grbTimKiem.Location = new System.Drawing.Point(57, 92);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Size = new System.Drawing.Size(1089, 147);
            this.grbTimKiem.TabIndex = 7;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(899, 50);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 36);
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
            this.cboTinhTrang.Location = new System.Drawing.Point(641, 90);
            this.cboTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(196, 26);
            this.cboTinhTrang.TabIndex = 7;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2",
            "Học kỳ 3"});
            this.cboHocKy.Location = new System.Drawing.Point(641, 48);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(196, 26);
            this.cboHocKy.TabIndex = 6;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(244, 90);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(196, 24);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(244, 48);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(196, 24);
            this.txtNamHoc.TabIndex = 4;
            // 
            // chbNamHoc
            // 
            this.chbNamHoc.AutoSize = true;
            this.chbNamHoc.Location = new System.Drawing.Point(83, 50);
            this.chbNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.chbNamHoc.Name = "chbNamHoc";
            this.chbNamHoc.Size = new System.Drawing.Size(95, 22);
            this.chbNamHoc.TabIndex = 3;
            this.chbNamHoc.Text = "Năm học:";
            this.chbNamHoc.UseVisualStyleBackColor = true;
            // 
            // chbHocKy
            // 
            this.chbHocKy.AutoSize = true;
            this.chbHocKy.Location = new System.Drawing.Point(502, 50);
            this.chbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.chbHocKy.Name = "chbHocKy";
            this.chbHocKy.Size = new System.Drawing.Size(81, 22);
            this.chbHocKy.TabIndex = 2;
            this.chbHocKy.Text = "Học kỳ:";
            this.chbHocKy.UseVisualStyleBackColor = true;
            // 
            // chbTinhTrang
            // 
            this.chbTinhTrang.AutoSize = true;
            this.chbTinhTrang.Location = new System.Drawing.Point(502, 92);
            this.chbTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.chbTinhTrang.Name = "chbTinhTrang";
            this.chbTinhTrang.Size = new System.Drawing.Size(99, 22);
            this.chbTinhTrang.TabIndex = 1;
            this.chbTinhTrang.Text = "Tình trạng:";
            this.chbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // chbMaSV
            // 
            this.chbMaSV.AutoSize = true;
            this.chbMaSV.Location = new System.Drawing.Point(83, 92);
            this.chbMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.chbMaSV.Name = "chbMaSV";
            this.chbMaSV.Size = new System.Drawing.Size(116, 22);
            this.chbMaSV.TabIndex = 0;
            this.chbMaSV.Text = "Mã sinh viên:";
            this.chbMaSV.UseVisualStyleBackColor = true;
            // 
            // lblBaoCaoThongKeSV
            // 
            this.lblBaoCaoThongKeSV.AutoSize = true;
            this.lblBaoCaoThongKeSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoThongKeSV.Location = new System.Drawing.Point(276, 45);
            this.lblBaoCaoThongKeSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaoCaoThongKeSV.Name = "lblBaoCaoThongKeSV";
            this.lblBaoCaoThongKeSV.Size = new System.Drawing.Size(651, 29);
            this.lblBaoCaoThongKeSV.TabIndex = 8;
            this.lblBaoCaoThongKeSV.Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH HỌC PHÍ SINH VIÊN";
            // 
            // CRVBaoCaoThongKe
            // 
            this.CRVBaoCaoThongKe.ActiveViewIndex = -1;
            this.CRVBaoCaoThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBaoCaoThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBaoCaoThongKe.Location = new System.Drawing.Point(12, 246);
            this.CRVBaoCaoThongKe.Name = "CRVBaoCaoThongKe";
            this.CRVBaoCaoThongKe.Size = new System.Drawing.Size(1178, 470);
            this.CRVBaoCaoThongKe.TabIndex = 9;
            // 
            // FrmBaoCaoThongKe_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 728);
            this.Controls.Add(this.CRVBaoCaoThongKe);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.lblBaoCaoThongKeSV);
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