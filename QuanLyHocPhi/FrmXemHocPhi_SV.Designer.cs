
namespace QuanLyHocPhi
{
    partial class FrmXemHocPhi_SV
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGrid_HocPhiSV = new System.Windows.Forms.DataGridView();
            this.chbNamHoc = new System.Windows.Forms.CheckBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.chbHocKy = new System.Windows.Forms.CheckBox();
            this.chbTinConNo = new System.Windows.Forms.CheckBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtNgayDong = new System.Windows.Forms.TextBox();
            this.txtDaDong = new System.Windows.Forms.TextBox();
            this.txtCanDong = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTenHocPhan = new System.Windows.Forms.TextBox();
            this.txtMaHocPhan = new System.Windows.Forms.TextBox();
            this.lblMaHocPhan = new System.Windows.Forms.Label();
            this.lblNgayDong = new System.Windows.Forms.Label();
            this.lblNgayNo = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblCanDong = new System.Windows.Forms.Label();
            this.lblDaDong = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblTienNo = new System.Windows.Forms.Label();
            this.lblTinNo = new System.Windows.Forms.Label();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.txtTinNo = new System.Windows.Forms.TextBox();
            this.lblTenHocPhan = new System.Windows.Forms.Label();
            this.grbTongKet = new System.Windows.Forms.GroupBox();
            this.lblHocPhiSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HocPhiSV)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.grbTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(200, 133);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 23);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGrid_HocPhiSV
            // 
            this.dataGrid_HocPhiSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_HocPhiSV.Location = new System.Drawing.Point(46, 264);
            this.dataGrid_HocPhiSV.Name = "dataGrid_HocPhiSV";
            this.dataGrid_HocPhiSV.RowHeadersWidth = 51;
            this.dataGrid_HocPhiSV.Size = new System.Drawing.Size(656, 268);
            this.dataGrid_HocPhiSV.TabIndex = 45;
            // 
            // chbNamHoc
            // 
            this.chbNamHoc.AutoSize = true;
            this.chbNamHoc.Location = new System.Drawing.Point(25, 39);
            this.chbNamHoc.Name = "chbNamHoc";
            this.chbNamHoc.Size = new System.Drawing.Size(79, 19);
            this.chbNamHoc.TabIndex = 19;
            this.chbNamHoc.Text = "Năm học:";
            this.chbNamHoc.UseVisualStyleBackColor = true;
            // 
            // cboHocKy
            // 
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2",
            "Học kỳ 3"});
            this.cboHocKy.Location = new System.Drawing.Point(142, 64);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(135, 23);
            this.cboHocKy.TabIndex = 18;
            // 
            // chbHocKy
            // 
            this.chbHocKy.AutoSize = true;
            this.chbHocKy.Location = new System.Drawing.Point(25, 66);
            this.chbHocKy.Name = "chbHocKy";
            this.chbHocKy.Size = new System.Drawing.Size(65, 19);
            this.chbHocKy.TabIndex = 20;
            this.chbHocKy.Text = "Học kỳ:";
            this.chbHocKy.UseVisualStyleBackColor = true;
            // 
            // chbTinConNo
            // 
            this.chbTinConNo.AutoSize = true;
            this.chbTinConNo.Location = new System.Drawing.Point(25, 93);
            this.chbTinConNo.Name = "chbTinConNo";
            this.chbTinConNo.Size = new System.Drawing.Size(83, 19);
            this.chbTinConNo.TabIndex = 21;
            this.chbTinConNo.Text = "Tín còn nợ";
            this.chbTinConNo.UseVisualStyleBackColor = true;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.cboNamHoc);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.chbNamHoc);
            this.grbTimKiem.Controls.Add(this.cboHocKy);
            this.grbTimKiem.Controls.Add(this.chbHocKy);
            this.grbTimKiem.Controls.Add(this.chbTinConNo);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(718, 264);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(303, 180);
            this.grbTimKiem.TabIndex = 46;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(141, 35);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(135, 23);
            this.cboNamHoc.TabIndex = 26;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(356, 121);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(38, 20);
            this.txtHocKy.TabIndex = 43;
            // 
            // txtConNo
            // 
            this.txtConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNo.Location = new System.Drawing.Point(524, 195);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.ReadOnly = true;
            this.txtConNo.Size = new System.Drawing.Size(177, 21);
            this.txtConNo.TabIndex = 42;
            // 
            // txtNgayDong
            // 
            this.txtNgayDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDong.Location = new System.Drawing.Point(524, 169);
            this.txtNgayDong.Name = "txtNgayDong";
            this.txtNgayDong.ReadOnly = true;
            this.txtNgayDong.Size = new System.Drawing.Size(177, 21);
            this.txtNgayDong.TabIndex = 41;
            // 
            // txtDaDong
            // 
            this.txtDaDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaDong.Location = new System.Drawing.Point(524, 143);
            this.txtDaDong.Name = "txtDaDong";
            this.txtDaDong.ReadOnly = true;
            this.txtDaDong.Size = new System.Drawing.Size(177, 21);
            this.txtDaDong.TabIndex = 40;
            // 
            // txtCanDong
            // 
            this.txtCanDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanDong.Location = new System.Drawing.Point(524, 117);
            this.txtCanDong.Name = "txtCanDong";
            this.txtCanDong.ReadOnly = true;
            this.txtCanDong.Size = new System.Drawing.Size(177, 21);
            this.txtCanDong.TabIndex = 39;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(170, 199);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(224, 20);
            this.txtSoTinChi.TabIndex = 38;
            // 
            // txtTenHocPhan
            // 
            this.txtTenHocPhan.Location = new System.Drawing.Point(170, 173);
            this.txtTenHocPhan.Name = "txtTenHocPhan";
            this.txtTenHocPhan.ReadOnly = true;
            this.txtTenHocPhan.Size = new System.Drawing.Size(224, 20);
            this.txtTenHocPhan.TabIndex = 37;
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Location = new System.Drawing.Point(170, 147);
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.ReadOnly = true;
            this.txtMaHocPhan.Size = new System.Drawing.Size(224, 20);
            this.txtMaHocPhan.TabIndex = 44;
            // 
            // lblMaHocPhan
            // 
            this.lblMaHocPhan.AutoSize = true;
            this.lblMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocPhan.Location = new System.Drawing.Point(64, 148);
            this.lblMaHocPhan.Name = "lblMaHocPhan";
            this.lblMaHocPhan.Size = new System.Drawing.Size(82, 15);
            this.lblMaHocPhan.TabIndex = 36;
            this.lblMaHocPhan.Text = "Mã học phần:";
            // 
            // lblNgayDong
            // 
            this.lblNgayDong.AutoSize = true;
            this.lblNgayDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDong.Location = new System.Drawing.Point(425, 172);
            this.lblNgayDong.Name = "lblNgayDong";
            this.lblNgayDong.Size = new System.Drawing.Size(69, 15);
            this.lblNgayDong.TabIndex = 34;
            this.lblNgayDong.Text = "Ngày đóng:";
            // 
            // lblNgayNo
            // 
            this.lblNgayNo.AutoSize = true;
            this.lblNgayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNo.Location = new System.Drawing.Point(425, 198);
            this.lblNgayNo.Name = "lblNgayNo";
            this.lblNgayNo.Size = new System.Drawing.Size(49, 15);
            this.lblNgayNo.TabIndex = 33;
            this.lblNgayNo.Text = "Còn nợ:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(298, 122);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(46, 15);
            this.lblHocKy.TabIndex = 32;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTinChi.Location = new System.Drawing.Point(64, 199);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(60, 15);
            this.lblSoTinChi.TabIndex = 31;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // lblCanDong
            // 
            this.lblCanDong.AutoSize = true;
            this.lblCanDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanDong.Location = new System.Drawing.Point(425, 120);
            this.lblCanDong.Name = "lblCanDong";
            this.lblCanDong.Size = new System.Drawing.Size(63, 15);
            this.lblCanDong.TabIndex = 30;
            this.lblCanDong.Text = "Cần đóng:";
            // 
            // lblDaDong
            // 
            this.lblDaDong.AutoSize = true;
            this.lblDaDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaDong.Location = new System.Drawing.Point(425, 146);
            this.lblDaDong.Name = "lblDaDong";
            this.lblDaDong.Size = new System.Drawing.Size(57, 15);
            this.lblDaDong.TabIndex = 29;
            this.lblDaDong.Text = "Đã đóng:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(64, 122);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(60, 15);
            this.lblNamHoc.TabIndex = 28;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(170, 120);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.ReadOnly = true;
            this.txtNamHoc.Size = new System.Drawing.Size(108, 20);
            this.txtNamHoc.TabIndex = 27;
            // 
            // lblTienNo
            // 
            this.lblTienNo.AutoSize = true;
            this.lblTienNo.Location = new System.Drawing.Point(22, 61);
            this.lblTienNo.Name = "lblTienNo";
            this.lblTienNo.Size = new System.Drawing.Size(94, 15);
            this.lblTienNo.TabIndex = 3;
            this.lblTienNo.Text = "Tổng số tiền nợ:";
            // 
            // lblTinNo
            // 
            this.lblTinNo.AutoSize = true;
            this.lblTinNo.Location = new System.Drawing.Point(22, 28);
            this.lblTinNo.Name = "lblTinNo";
            this.lblTinNo.Size = new System.Drawing.Size(81, 15);
            this.lblTinNo.TabIndex = 2;
            this.lblTinNo.Text = "Số tín còn nợ:";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(142, 58);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.ReadOnly = true;
            this.txtTienNo.Size = new System.Drawing.Size(135, 21);
            this.txtTienNo.TabIndex = 1;
            // 
            // txtTinNo
            // 
            this.txtTinNo.Location = new System.Drawing.Point(142, 28);
            this.txtTinNo.Name = "txtTinNo";
            this.txtTinNo.ReadOnly = true;
            this.txtTinNo.Size = new System.Drawing.Size(135, 21);
            this.txtTinNo.TabIndex = 0;
            // 
            // lblTenHocPhan
            // 
            this.lblTenHocPhan.AutoSize = true;
            this.lblTenHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHocPhan.Location = new System.Drawing.Point(64, 173);
            this.lblTenHocPhan.Name = "lblTenHocPhan";
            this.lblTenHocPhan.Size = new System.Drawing.Size(85, 15);
            this.lblTenHocPhan.TabIndex = 35;
            this.lblTenHocPhan.Text = "Tên học phần:";
            // 
            // grbTongKet
            // 
            this.grbTongKet.Controls.Add(this.lblTienNo);
            this.grbTongKet.Controls.Add(this.lblTinNo);
            this.grbTongKet.Controls.Add(this.txtTienNo);
            this.grbTongKet.Controls.Add(this.txtTinNo);
            this.grbTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTongKet.Location = new System.Drawing.Point(718, 117);
            this.grbTongKet.Name = "grbTongKet";
            this.grbTongKet.Size = new System.Drawing.Size(303, 100);
            this.grbTongKet.TabIndex = 26;
            this.grbTongKet.TabStop = false;
            this.grbTongKet.Text = "Tổng kết";
            // 
            // lblHocPhiSV
            // 
            this.lblHocPhiSV.AutoSize = true;
            this.lblHocPhiSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocPhiSV.Location = new System.Drawing.Point(430, 38);
            this.lblHocPhiSV.Name = "lblHocPhiSV";
            this.lblHocPhiSV.Size = new System.Drawing.Size(238, 26);
            this.lblHocPhiSV.TabIndex = 25;
            this.lblHocPhiSV.Text = "HỌC PHÍ SINH VIÊN";
            // 
            // FrmXemHocPhi_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 571);
            this.Controls.Add(this.dataGrid_HocPhiSV);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.txtNgayDong);
            this.Controls.Add(this.txtDaDong);
            this.Controls.Add(this.txtCanDong);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.txtTenHocPhan);
            this.Controls.Add(this.txtMaHocPhan);
            this.Controls.Add(this.lblMaHocPhan);
            this.Controls.Add(this.lblNgayDong);
            this.Controls.Add(this.lblNgayNo);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.lblSoTinChi);
            this.Controls.Add(this.lblCanDong);
            this.Controls.Add(this.lblDaDong);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.lblTenHocPhan);
            this.Controls.Add(this.grbTongKet);
            this.Controls.Add(this.lblHocPhiSV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmXemHocPhi_SV";
            this.Text = "FrmXemHocPhi_SV";
            this.Load += new System.EventHandler(this.FrmXemHocPhi_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HocPhiSV)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbTongKet.ResumeLayout(false);
            this.grbTongKet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGrid_HocPhiSV;
        private System.Windows.Forms.CheckBox chbNamHoc;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.CheckBox chbHocKy;
        private System.Windows.Forms.CheckBox chbTinConNo;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtNgayDong;
        private System.Windows.Forms.TextBox txtDaDong;
        private System.Windows.Forms.TextBox txtCanDong;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtTenHocPhan;
        private System.Windows.Forms.TextBox txtMaHocPhan;
        private System.Windows.Forms.Label lblMaHocPhan;
        private System.Windows.Forms.Label lblNgayDong;
        private System.Windows.Forms.Label lblNgayNo;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.Label lblCanDong;
        private System.Windows.Forms.Label lblDaDong;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblTienNo;
        private System.Windows.Forms.Label lblTinNo;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.TextBox txtTinNo;
        private System.Windows.Forms.Label lblTenHocPhan;
        private System.Windows.Forms.GroupBox grbTongKet;
        private System.Windows.Forms.Label lblHocPhiSV;
        private System.Windows.Forms.ComboBox cboNamHoc;
    }
}