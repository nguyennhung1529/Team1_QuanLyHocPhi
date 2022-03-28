
namespace QuanLyHocPhi
{
    partial class FrmThongKeHocPhi_NV
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
            this.cboTKHocKy = new System.Windows.Forms.ComboBox();
            this.grpBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.cboTKTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTKMaSV = new System.Windows.Forms.TextBox();
            this.chkTKTinhTrang = new System.Windows.Forms.CheckBox();
            this.chkTKMaSV = new System.Windows.Forms.CheckBox();
            this.chkTKHocKy = new System.Windows.Forms.CheckBox();
            this.txtTKNamHoc = new System.Windows.Forms.TextBox();
            this.chkTKNamHoc = new System.Windows.Forms.CheckBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtNguoiCapNhat = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtCanDong = new System.Windows.Forms.TextBox();
            this.txtMienGiam = new System.Windows.Forms.TextBox();
            this.txtMaL = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblnguoicapnhat = new System.Windows.Forms.Label();
            this.lblngaycapnhat = new System.Windows.Forms.Label();
            this.lblconno = new System.Windows.Forms.Label();
            this.lblmiengiam = new System.Windows.Forms.Label();
            this.lblcandong = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.lblmsv = new System.Windows.Forms.Label();
            this.lblhocky = new System.Windows.Forms.Label();
            this.btnXemchitiet = new System.Windows.Forms.Button();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.lblnamhoc = new System.Windows.Forms.Label();
            this.dataGVThongKeHocPhi = new System.Windows.Forms.DataGridView();
            this.lbltkhp = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.grpBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongKeHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTKHocKy
            // 
            this.cboTKHocKy.FormattingEnabled = true;
            this.cboTKHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboTKHocKy.Location = new System.Drawing.Point(166, 87);
            this.cboTKHocKy.Name = "cboTKHocKy";
            this.cboTKHocKy.Size = new System.Drawing.Size(165, 24);
            this.cboTKHocKy.TabIndex = 35;
            // 
            // grpBoxTimKiem
            // 
            this.grpBoxTimKiem.Controls.Add(this.cboTKTinhTrang);
            this.grpBoxTimKiem.Controls.Add(this.cboTKHocKy);
            this.grpBoxTimKiem.Controls.Add(this.txtTKMaSV);
            this.grpBoxTimKiem.Controls.Add(this.chkTKTinhTrang);
            this.grpBoxTimKiem.Controls.Add(this.chkTKMaSV);
            this.grpBoxTimKiem.Controls.Add(this.chkTKHocKy);
            this.grpBoxTimKiem.Controls.Add(this.txtTKNamHoc);
            this.grpBoxTimKiem.Controls.Add(this.chkTKNamHoc);
            this.grpBoxTimKiem.Controls.Add(this.btnTimkiem);
            this.grpBoxTimKiem.Location = new System.Drawing.Point(808, 350);
            this.grpBoxTimKiem.Name = "grpBoxTimKiem";
            this.grpBoxTimKiem.Size = new System.Drawing.Size(350, 287);
            this.grpBoxTimKiem.TabIndex = 57;
            this.grpBoxTimKiem.TabStop = false;
            this.grpBoxTimKiem.Text = "Tìm kiếm";
            // 
            // cboTKTinhTrang
            // 
            this.cboTKTinhTrang.FormattingEnabled = true;
            this.cboTKTinhTrang.Items.AddRange(new object[] {
            "Còn nợ",
            "Đã đóng",
            "Dư tiền"});
            this.cboTKTinhTrang.Location = new System.Drawing.Point(166, 191);
            this.cboTKTinhTrang.Name = "cboTKTinhTrang";
            this.cboTKTinhTrang.Size = new System.Drawing.Size(165, 24);
            this.cboTKTinhTrang.TabIndex = 36;
            // 
            // txtTKMaSV
            // 
            this.txtTKMaSV.Location = new System.Drawing.Point(166, 140);
            this.txtTKMaSV.Name = "txtTKMaSV";
            this.txtTKMaSV.Size = new System.Drawing.Size(165, 22);
            this.txtTKMaSV.TabIndex = 32;
            // 
            // chkTKTinhTrang
            // 
            this.chkTKTinhTrang.AutoSize = true;
            this.chkTKTinhTrang.Location = new System.Drawing.Point(47, 192);
            this.chkTKTinhTrang.Name = "chkTKTinhTrang";
            this.chkTKTinhTrang.Size = new System.Drawing.Size(99, 21);
            this.chkTKTinhTrang.TabIndex = 31;
            this.chkTKTinhTrang.Text = "Tình trạng:";
            this.chkTKTinhTrang.UseVisualStyleBackColor = true;
            // 
            // chkTKMaSV
            // 
            this.chkTKMaSV.AutoSize = true;
            this.chkTKMaSV.Location = new System.Drawing.Point(47, 140);
            this.chkTKMaSV.Name = "chkTKMaSV";
            this.chkTKMaSV.Size = new System.Drawing.Size(113, 21);
            this.chkTKMaSV.TabIndex = 30;
            this.chkTKMaSV.Text = "Mã sinh viên:";
            this.chkTKMaSV.UseVisualStyleBackColor = true;
            // 
            // chkTKHocKy
            // 
            this.chkTKHocKy.AutoSize = true;
            this.chkTKHocKy.Location = new System.Drawing.Point(47, 88);
            this.chkTKHocKy.Name = "chkTKHocKy";
            this.chkTKHocKy.Size = new System.Drawing.Size(77, 21);
            this.chkTKHocKy.TabIndex = 29;
            this.chkTKHocKy.Text = "Học kỳ:";
            this.chkTKHocKy.UseVisualStyleBackColor = true;
            // 
            // txtTKNamHoc
            // 
            this.txtTKNamHoc.Location = new System.Drawing.Point(166, 36);
            this.txtTKNamHoc.Name = "txtTKNamHoc";
            this.txtTKNamHoc.Size = new System.Drawing.Size(165, 22);
            this.txtTKNamHoc.TabIndex = 28;
            // 
            // chkTKNamHoc
            // 
            this.chkTKNamHoc.AutoSize = true;
            this.chkTKNamHoc.Location = new System.Drawing.Point(47, 36);
            this.chkTKNamHoc.Name = "chkTKNamHoc";
            this.chkTKNamHoc.Size = new System.Drawing.Size(90, 21);
            this.chkTKNamHoc.TabIndex = 27;
            this.chkTKNamHoc.Text = "Năm học:";
            this.chkTKNamHoc.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(222, 237);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(98, 36);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtNguoiCapNhat
            // 
            this.txtNguoiCapNhat.Location = new System.Drawing.Point(711, 292);
            this.txtNguoiCapNhat.Name = "txtNguoiCapNhat";
            this.txtNguoiCapNhat.ReadOnly = true;
            this.txtNguoiCapNhat.Size = new System.Drawing.Size(237, 22);
            this.txtNguoiCapNhat.TabIndex = 56;
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(711, 210);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.ReadOnly = true;
            this.txtConNo.Size = new System.Drawing.Size(237, 22);
            this.txtConNo.TabIndex = 54;
            // 
            // txtCanDong
            // 
            this.txtCanDong.Location = new System.Drawing.Point(711, 169);
            this.txtCanDong.Name = "txtCanDong";
            this.txtCanDong.ReadOnly = true;
            this.txtCanDong.Size = new System.Drawing.Size(237, 22);
            this.txtCanDong.TabIndex = 53;
            // 
            // txtMienGiam
            // 
            this.txtMienGiam.Location = new System.Drawing.Point(188, 294);
            this.txtMienGiam.Name = "txtMienGiam";
            this.txtMienGiam.ReadOnly = true;
            this.txtMienGiam.Size = new System.Drawing.Size(332, 22);
            this.txtMienGiam.TabIndex = 52;
            // 
            // txtMaL
            // 
            this.txtMaL.Location = new System.Drawing.Point(188, 252);
            this.txtMaL.Name = "txtMaL";
            this.txtMaL.ReadOnly = true;
            this.txtMaL.Size = new System.Drawing.Size(332, 22);
            this.txtMaL.TabIndex = 51;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(188, 211);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(332, 22);
            this.txtMaSV.TabIndex = 50;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(188, 169);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.ReadOnly = true;
            this.txtNamHoc.Size = new System.Drawing.Size(164, 22);
            this.txtNamHoc.TabIndex = 48;
            // 
            // lblnguoicapnhat
            // 
            this.lblnguoicapnhat.AutoSize = true;
            this.lblnguoicapnhat.Location = new System.Drawing.Point(563, 295);
            this.lblnguoicapnhat.Name = "lblnguoicapnhat";
            this.lblnguoicapnhat.Size = new System.Drawing.Size(108, 17);
            this.lblnguoicapnhat.TabIndex = 47;
            this.lblnguoicapnhat.Text = "Người cập nhật:";
            // 
            // lblngaycapnhat
            // 
            this.lblngaycapnhat.AutoSize = true;
            this.lblngaycapnhat.Location = new System.Drawing.Point(563, 253);
            this.lblngaycapnhat.Name = "lblngaycapnhat";
            this.lblngaycapnhat.Size = new System.Drawing.Size(104, 17);
            this.lblngaycapnhat.TabIndex = 46;
            this.lblngaycapnhat.Text = "Ngày cập nhật:";
            // 
            // lblconno
            // 
            this.lblconno.AutoSize = true;
            this.lblconno.Location = new System.Drawing.Point(563, 211);
            this.lblconno.Name = "lblconno";
            this.lblconno.Size = new System.Drawing.Size(57, 17);
            this.lblconno.TabIndex = 45;
            this.lblconno.Text = "Còn nợ:";
            // 
            // lblmiengiam
            // 
            this.lblmiengiam.AutoSize = true;
            this.lblmiengiam.Location = new System.Drawing.Point(66, 297);
            this.lblmiengiam.Name = "lblmiengiam";
            this.lblmiengiam.Size = new System.Drawing.Size(76, 17);
            this.lblmiengiam.TabIndex = 44;
            this.lblmiengiam.Text = "Miễn giảm:";
            // 
            // lblcandong
            // 
            this.lblcandong.AutoSize = true;
            this.lblcandong.Location = new System.Drawing.Point(563, 169);
            this.lblcandong.Name = "lblcandong";
            this.lblcandong.Size = new System.Drawing.Size(119, 17);
            this.lblcandong.TabIndex = 43;
            this.lblcandong.Text = "Số tiền cần đóng:";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Location = new System.Drawing.Point(64, 255);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(54, 17);
            this.lblmalop.TabIndex = 42;
            this.lblmalop.Text = "Mã lớp:";
            // 
            // lblmsv
            // 
            this.lblmsv.AutoSize = true;
            this.lblmsv.Location = new System.Drawing.Point(64, 213);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(91, 17);
            this.lblmsv.TabIndex = 41;
            this.lblmsv.Text = "Mã sinh viên:";
            // 
            // lblhocky
            // 
            this.lblhocky.AutoSize = true;
            this.lblhocky.Location = new System.Drawing.Point(383, 172);
            this.lblhocky.Name = "lblhocky";
            this.lblhocky.Size = new System.Drawing.Size(55, 17);
            this.lblhocky.TabIndex = 40;
            this.lblhocky.Text = "Học kỳ:";
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.Location = new System.Drawing.Point(1030, 238);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.Size = new System.Drawing.Size(98, 36);
            this.btnXemchitiet.TabIndex = 39;
            this.btnXemchitiet.Text = "Xem chi tiết";
            this.btnXemchitiet.UseVisualStyleBackColor = true;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(460, 169);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(60, 22);
            this.txtHocKy.TabIndex = 49;
            // 
            // lblnamhoc
            // 
            this.lblnamhoc.AutoSize = true;
            this.lblnamhoc.Location = new System.Drawing.Point(64, 169);
            this.lblnamhoc.Name = "lblnamhoc";
            this.lblnamhoc.Size = new System.Drawing.Size(68, 17);
            this.lblnamhoc.TabIndex = 37;
            this.lblnamhoc.Text = "Năm học:";
            // 
            // dataGVThongKeHocPhi
            // 
            this.dataGVThongKeHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVThongKeHocPhi.Location = new System.Drawing.Point(25, 359);
            this.dataGVThongKeHocPhi.Name = "dataGVThongKeHocPhi";
            this.dataGVThongKeHocPhi.RowHeadersWidth = 51;
            this.dataGVThongKeHocPhi.RowTemplate.Height = 24;
            this.dataGVThongKeHocPhi.Size = new System.Drawing.Size(768, 278);
            this.dataGVThongKeHocPhi.TabIndex = 38;
            // 
            // lbltkhp
            // 
            this.lbltkhp.AutoSize = true;
            this.lbltkhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltkhp.Location = new System.Drawing.Point(204, 56);
            this.lbltkhp.Name = "lbltkhp";
            this.lbltkhp.Size = new System.Drawing.Size(758, 32);
            this.lbltkhp.TabIndex = 36;
            this.lbltkhp.Text = "TỔNG QUÁT TÌNH TRẠNG ĐÓNG HỌC PHÍ SINH VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1030, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 36);
            this.btnThoat.TabIndex = 58;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Location = new System.Drawing.Point(711, 251);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.ReadOnly = true;
            this.txtNgayCapNhat.Size = new System.Drawing.Size(237, 22);
            this.txtNgayCapNhat.TabIndex = 55;
            // 
            // FrmThongKeHocPhi_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpBoxTimKiem);
            this.Controls.Add(this.txtNguoiCapNhat);
            this.Controls.Add(this.txtNgayCapNhat);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.txtCanDong);
            this.Controls.Add(this.txtMienGiam);
            this.Controls.Add(this.txtMaL);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.lblnguoicapnhat);
            this.Controls.Add(this.lblngaycapnhat);
            this.Controls.Add(this.lblconno);
            this.Controls.Add(this.lblmiengiam);
            this.Controls.Add(this.lblcandong);
            this.Controls.Add(this.lblmalop);
            this.Controls.Add(this.lblmsv);
            this.Controls.Add(this.lblhocky);
            this.Controls.Add(this.btnXemchitiet);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.lblnamhoc);
            this.Controls.Add(this.dataGVThongKeHocPhi);
            this.Controls.Add(this.lbltkhp);
            this.Name = "FrmThongKeHocPhi_NV";
            this.Text = "FrmThongKeHocPhi_NV";
            this.Load += new System.EventHandler(this.FrmThongKeHocPhi_NV_Load);
            this.grpBoxTimKiem.ResumeLayout(false);
            this.grpBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongKeHocPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTKHocKy;
        private System.Windows.Forms.GroupBox grpBoxTimKiem;
        private System.Windows.Forms.ComboBox cboTKTinhTrang;
        private System.Windows.Forms.TextBox txtTKMaSV;
        private System.Windows.Forms.CheckBox chkTKTinhTrang;
        private System.Windows.Forms.CheckBox chkTKMaSV;
        private System.Windows.Forms.CheckBox chkTKHocKy;
        private System.Windows.Forms.TextBox txtTKNamHoc;
        private System.Windows.Forms.CheckBox chkTKNamHoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtNguoiCapNhat;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtCanDong;
        private System.Windows.Forms.TextBox txtMienGiam;
        private System.Windows.Forms.TextBox txtMaL;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblnguoicapnhat;
        private System.Windows.Forms.Label lblngaycapnhat;
        private System.Windows.Forms.Label lblconno;
        private System.Windows.Forms.Label lblmiengiam;
        private System.Windows.Forms.Label lblcandong;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label lblmsv;
        private System.Windows.Forms.Label lblhocky;
        private System.Windows.Forms.Button btnXemchitiet;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label lblnamhoc;
        private System.Windows.Forms.DataGridView dataGVThongKeHocPhi;
        private System.Windows.Forms.Label lbltkhp;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
    }
}