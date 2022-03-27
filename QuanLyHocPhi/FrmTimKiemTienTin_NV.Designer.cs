
namespace QuanLyHocPhi
{
    partial class FrmTimKiemTienTin_NV
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
            this.txttentt = new System.Windows.Forms.TextBox();
            this.cbomatt = new System.Windows.Forms.ComboBox();
            this.rdbtentt = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dtgtktientin = new System.Windows.Forms.DataGridView();
            this.rdbmatt = new System.Windows.Forms.RadioButton();
            this.lblTienTin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtktientin)).BeginInit();
            this.SuspendLayout();
            // 
            // txttentt
            // 
            this.txttentt.Location = new System.Drawing.Point(583, 156);
            this.txttentt.Name = "txttentt";
            this.txttentt.Size = new System.Drawing.Size(186, 22);
            this.txttentt.TabIndex = 26;
            // 
            // cbomatt
            // 
            this.cbomatt.FormattingEnabled = true;
            this.cbomatt.Location = new System.Drawing.Point(210, 156);
            this.cbomatt.Name = "cbomatt";
            this.cbomatt.Size = new System.Drawing.Size(186, 24);
            this.cbomatt.TabIndex = 25;
            // 
            // rdbtentt
            // 
            this.rdbtentt.AutoSize = true;
            this.rdbtentt.Location = new System.Drawing.Point(466, 156);
            this.rdbtentt.Name = "rdbtentt";
            this.rdbtentt.Size = new System.Drawing.Size(104, 21);
            this.rdbtentt.TabIndex = 24;
            this.rdbtentt.TabStop = true;
            this.rdbtentt.Text = "Tên tiền tín:";
            this.rdbtentt.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(463, 468);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(103, 33);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(297, 468);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(102, 33);
            this.btntimkiem.TabIndex = 22;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // dtgtktientin
            // 
            this.dtgtktientin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtktientin.Location = new System.Drawing.Point(93, 223);
            this.dtgtktientin.Name = "dtgtktientin";
            this.dtgtktientin.RowHeadersWidth = 51;
            this.dtgtktientin.RowTemplate.Height = 24;
            this.dtgtktientin.Size = new System.Drawing.Size(676, 211);
            this.dtgtktientin.TabIndex = 21;
            // 
            // rdbmatt
            // 
            this.rdbmatt.AutoSize = true;
            this.rdbmatt.Location = new System.Drawing.Point(93, 156);
            this.rdbmatt.Name = "rdbmatt";
            this.rdbmatt.Size = new System.Drawing.Size(98, 21);
            this.rdbmatt.TabIndex = 20;
            this.rdbmatt.TabStop = true;
            this.rdbmatt.Text = "Mã tiền tín:";
            this.rdbmatt.UseVisualStyleBackColor = true;
            // 
            // lblTienTin
            // 
            this.lblTienTin.AutoSize = true;
            this.lblTienTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienTin.Location = new System.Drawing.Point(294, 71);
            this.lblTienTin.Name = "lblTienTin";
            this.lblTienTin.Size = new System.Drawing.Size(275, 32);
            this.lblTienTin.TabIndex = 19;
            this.lblTienTin.Text = "TÌM KIẾM TIỀN TÍN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 18;
            // 
            // FrmTimKiemTienTin_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 528);
            this.Controls.Add(this.txttentt);
            this.Controls.Add(this.cbomatt);
            this.Controls.Add(this.rdbtentt);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dtgtktientin);
            this.Controls.Add(this.rdbmatt);
            this.Controls.Add(this.lblTienTin);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiemTienTin_NV";
            this.Text = "FrmTimKiemTienTin_NV";
            ((System.ComponentModel.ISupportInitialize)(this.dtgtktientin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttentt;
        private System.Windows.Forms.ComboBox cbomatt;
        private System.Windows.Forms.RadioButton rdbtentt;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dtgtktientin;
        private System.Windows.Forms.RadioButton rdbmatt;
        private System.Windows.Forms.Label lblTienTin;
        private System.Windows.Forms.Label label1;
    }
}