
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
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HocPhiSV)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.grbTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(259, 179);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 37);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGrid_HocPhiSV
            // 
            this.dataGrid_HocPhiSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_HocPhiSV.Location = new System.Drawing.Point(12, 353);
            this.dataGrid_HocPhiSV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_HocPhiSV.Name = "dataGrid_HocPhiSV";
            this.dataGrid_HocPhiSV.RowHeadersWidth = 51;
            this.dataGrid_HocPhiSV.Size = new System.Drawing.Size(875, 242);
            this.dataGrid_HocPhiSV.TabIndex = 45;
            // 
            // chbNamHoc
            // 
            this.chbNamHoc.AutoSize = true;
            this.chbNamHoc.Location = new System.Drawing.Point(33, 47);
            this.chbNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.chbNamHoc.Name = "chbNamHoc";
            this.chbNamHoc.Size = new System.Drawing.Size(95, 22);
            this.chbNamHoc.TabIndex = 19;
            this.chbNamHoc.Text = "Năm học:";
            this.chbNamHoc.UseVisualStyleBackColor = true;
            // 
            // cboHocKy
            // 
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboHocKy.Location = new System.Drawing.Point(189, 87);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(179, 26);
            this.cboHocKy.TabIndex = 18;
            // 
            // chbHocKy
            // 
            this.chbHocKy.AutoSize = true;
            this.chbHocKy.Location = new System.Drawing.Point(33, 91);
            this.chbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.chbHocKy.Name = "chbHocKy";
            this.chbHocKy.Size = new System.Drawing.Size(81, 22);
            this.chbHocKy.TabIndex = 20;
            this.chbHocKy.Text = "Học kỳ:";
            this.chbHocKy.UseVisualStyleBackColor = true;
            // 
            // chbTinConNo
            // 
            this.chbTinConNo.AutoSize = true;
            this.chbTinConNo.Location = new System.Drawing.Point(33, 136);
            this.chbTinConNo.Margin = new System.Windows.Forms.Padding(4);
            this.chbTinConNo.Name = "chbTinConNo";
            this.chbTinConNo.Size = new System.Drawing.Size(100, 22);
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
            this.grbTimKiem.Location = new System.Drawing.Point(908, 353);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Size = new System.Drawing.Size(404, 242);
            this.grbTimKiem.TabIndex = 46;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022"});
            this.cboNamHoc.Location = new System.Drawing.Point(188, 43);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(179, 26);
            this.cboNamHoc.TabIndex = 26;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(426, 177);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(49, 22);
            this.txtHocKy.TabIndex = 43;
            // 
            // txtConNo
            // 
            this.txtConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNo.Location = new System.Drawing.Point(650, 292);
            this.txtConNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.ReadOnly = true;
            this.txtConNo.Size = new System.Drawing.Size(235, 24);
            this.txtConNo.TabIndex = 42;
            // 
            // txtNgayDong
            // 
            this.txtNgayDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDong.Location = new System.Drawing.Point(650, 252);
            this.txtNgayDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayDong.Name = "txtNgayDong";
            this.txtNgayDong.ReadOnly = true;
            this.txtNgayDong.Size = new System.Drawing.Size(235, 24);
            this.txtNgayDong.TabIndex = 41;
            // 
            // txtDaDong
            // 
            this.txtDaDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaDong.Location = new System.Drawing.Point(650, 212);
            this.txtDaDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtDaDong.Name = "txtDaDong";
            this.txtDaDong.ReadOnly = true;
            this.txtDaDong.Size = new System.Drawing.Size(235, 24);
            this.txtDaDong.TabIndex = 40;
            // 
            // txtCanDong
            // 
            this.txtCanDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanDong.Location = new System.Drawing.Point(650, 172);
            this.txtCanDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanDong.Name = "txtCanDong";
            this.txtCanDong.ReadOnly = true;
            this.txtCanDong.Size = new System.Drawing.Size(235, 24);
            this.txtCanDong.TabIndex = 39;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(178, 294);
            this.txtSoTinChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(297, 22);
            this.txtSoTinChi.TabIndex = 38;
            // 
            // txtTenHocPhan
            // 
            this.txtTenHocPhan.Location = new System.Drawing.Point(178, 254);
            this.txtTenHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHocPhan.Name = "txtTenHocPhan";
            this.txtTenHocPhan.ReadOnly = true;
            this.txtTenHocPhan.Size = new System.Drawing.Size(297, 22);
            this.txtTenHocPhan.TabIndex = 37;
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Location = new System.Drawing.Point(178, 214);
            this.txtMaHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.ReadOnly = true;
            this.txtMaHocPhan.Size = new System.Drawing.Size(297, 22);
            this.txtMaHocPhan.TabIndex = 44;
            // 
            // lblMaHocPhan
            // 
            this.lblMaHocPhan.AutoSize = true;
            this.lblMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocPhan.Location = new System.Drawing.Point(36, 218);
            this.lblMaHocPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHocPhan.Name = "lblMaHocPhan";
            this.lblMaHocPhan.Size = new System.Drawing.Size(98, 18);
            this.lblMaHocPhan.TabIndex = 36;
            this.lblMaHocPhan.Text = "Mã học phần:";
            // 
            // lblNgayDong
            // 
            this.lblNgayDong.AutoSize = true;
            this.lblNgayDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDong.Location = new System.Drawing.Point(518, 258);
            this.lblNgayDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDong.Name = "lblNgayDong";
            this.lblNgayDong.Size = new System.Drawing.Size(83, 18);
            this.lblNgayDong.TabIndex = 34;
            this.lblNgayDong.Text = "Ngày đóng:";
            // 
            // lblNgayNo
            // 
            this.lblNgayNo.AutoSize = true;
            this.lblNgayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNo.Location = new System.Drawing.Point(518, 298);
            this.lblNgayNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNo.Name = "lblNgayNo";
            this.lblNgayNo.Size = new System.Drawing.Size(61, 18);
            this.lblNgayNo.TabIndex = 33;
            this.lblNgayNo.Text = "Còn nợ:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(348, 178);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(59, 18);
            this.lblHocKy.TabIndex = 32;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTinChi.Location = new System.Drawing.Point(36, 298);
            this.lblSoTinChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(73, 18);
            this.lblSoTinChi.TabIndex = 31;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // lblCanDong
            // 
            this.lblCanDong.AutoSize = true;
            this.lblCanDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanDong.Location = new System.Drawing.Point(518, 176);
            this.lblCanDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanDong.Name = "lblCanDong";
            this.lblCanDong.Size = new System.Drawing.Size(76, 18);
            this.lblCanDong.TabIndex = 30;
            this.lblCanDong.Text = "Cần đóng:";
            // 
            // lblDaDong
            // 
            this.lblDaDong.AutoSize = true;
            this.lblDaDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaDong.Location = new System.Drawing.Point(518, 218);
            this.lblDaDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaDong.Name = "lblDaDong";
            this.lblDaDong.Size = new System.Drawing.Size(68, 18);
            this.lblDaDong.TabIndex = 29;
            this.lblDaDong.Text = "Đã đóng:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(36, 178);
            this.lblNamHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(73, 18);
            this.lblNamHoc.TabIndex = 28;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(178, 176);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.ReadOnly = true;
            this.txtNamHoc.Size = new System.Drawing.Size(143, 22);
            this.txtNamHoc.TabIndex = 27;
            // 
            // lblTienNo
            // 
            this.lblTienNo.AutoSize = true;
            this.lblTienNo.Location = new System.Drawing.Point(29, 70);
            this.lblTienNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienNo.Name = "lblTienNo";
            this.lblTienNo.Size = new System.Drawing.Size(115, 18);
            this.lblTienNo.TabIndex = 3;
            this.lblTienNo.Text = "Tổng số tiền nợ:";
            // 
            // lblTinNo
            // 
            this.lblTinNo.AutoSize = true;
            this.lblTinNo.Location = new System.Drawing.Point(30, 38);
            this.lblTinNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinNo.Name = "lblTinNo";
            this.lblTinNo.Size = new System.Drawing.Size(100, 18);
            this.lblTinNo.TabIndex = 2;
            this.lblTinNo.Text = "Số tín còn nợ:";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(189, 67);
            this.txtTienNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.ReadOnly = true;
            this.txtTienNo.Size = new System.Drawing.Size(179, 24);
            this.txtTienNo.TabIndex = 1;
            // 
            // txtTinNo
            // 
            this.txtTinNo.Location = new System.Drawing.Point(189, 34);
            this.txtTinNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTinNo.Name = "txtTinNo";
            this.txtTinNo.ReadOnly = true;
            this.txtTinNo.Size = new System.Drawing.Size(179, 24);
            this.txtTinNo.TabIndex = 0;
            // 
            // lblTenHocPhan
            // 
            this.lblTenHocPhan.AutoSize = true;
            this.lblTenHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHocPhan.Location = new System.Drawing.Point(36, 258);
            this.lblTenHocPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHocPhan.Name = "lblTenHocPhan";
            this.lblTenHocPhan.Size = new System.Drawing.Size(102, 18);
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
            this.grbTongKet.Location = new System.Drawing.Point(908, 163);
            this.grbTongKet.Margin = new System.Windows.Forms.Padding(4);
            this.grbTongKet.Name = "grbTongKet";
            this.grbTongKet.Padding = new System.Windows.Forms.Padding(4);
            this.grbTongKet.Size = new System.Drawing.Size(404, 153);
            this.grbTongKet.TabIndex = 26;
            this.grbTongKet.TabStop = false;
            this.grbTongKet.Text = "Tổng kết";
            // 
            // lblHocPhiSV
            // 
            this.lblHocPhiSV.AutoSize = true;
            this.lblHocPhiSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocPhiSV.Location = new System.Drawing.Point(539, 79);
            this.lblHocPhiSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocPhiSV.Name = "lblHocPhiSV";
            this.lblHocPhiSV.Size = new System.Drawing.Size(292, 32);
            this.lblHocPhiSV.TabIndex = 25;
            this.lblHocPhiSV.Text = "HỌC PHÍ SINH VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThoat.Location = new System.Drawing.Point(1166, 267);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 33);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmXemHocPhi_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 636);
            this.Controls.Add(this.btnThoat);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnThoat;
    }
}