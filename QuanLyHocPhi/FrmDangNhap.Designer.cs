
namespace QuanLyHocPhi
{
    partial class FrmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblTitleDangNhap = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radNS = new System.Windows.Forms.RadioButton();
            this.radSV = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenDN.Location = new System.Drawing.Point(183, 216);
            this.lblTenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(151, 25);
            this.lblTenDN.TabIndex = 10;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblTitleDangNhap
            // 
            this.lblTitleDangNhap.AutoSize = true;
            this.lblTitleDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDangNhap.Location = new System.Drawing.Point(190, 104);
            this.lblTitleDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleDangNhap.Name = "lblTitleDangNhap";
            this.lblTitleDangNhap.Size = new System.Drawing.Size(686, 39);
            this.lblTitleDangNhap.TabIndex = 9;
            this.lblTitleDangNhap.Text = "TRƯỜNG ĐẠI HỌC KINH TẾ QUỐC DÂN";
            // 
            // radNS
            // 
            this.radNS.AutoSize = true;
            this.radNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radNS.Location = new System.Drawing.Point(591, 332);
            this.radNS.Margin = new System.Windows.Forms.Padding(4);
            this.radNS.Name = "radNS";
            this.radNS.Size = new System.Drawing.Size(106, 29);
            this.radNS.TabIndex = 17;
            this.radNS.Text = "Nhân sự";
            this.radNS.UseVisualStyleBackColor = true;
            // 
            // radSV
            // 
            this.radSV.AutoSize = true;
            this.radSV.Checked = true;
            this.radSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radSV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radSV.Location = new System.Drawing.Point(396, 332);
            this.radSV.Margin = new System.Windows.Forms.Padding(4);
            this.radSV.Name = "radSV";
            this.radSV.Size = new System.Drawing.Size(114, 29);
            this.radSV.TabIndex = 16;
            this.radSV.TabStop = true;
            this.radSV.Text = "Sinh viên";
            this.radSV.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(591, 400);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 48);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDN.Location = new System.Drawing.Point(396, 400);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(143, 48);
            this.btnDN.TabIndex = 14;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(396, 269);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(487, 34);
            this.txtMatKhau.TabIndex = 13;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(396, 210);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(487, 34);
            this.txtTenDN.TabIndex = 12;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMatKhau.Location = new System.Drawing.Point(183, 275);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(99, 25);
            this.lblMatKhau.TabIndex = 11;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.lblTitleDangNhap);
            this.Controls.Add(this.radNS);
            this.Controls.Add(this.radSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.lblMatKhau);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblTitleDangNhap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radNS;
        private System.Windows.Forms.RadioButton radSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lblMatKhau;
    }
}