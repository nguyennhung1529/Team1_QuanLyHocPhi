
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
            this.cbomatt = new System.Windows.Forms.ComboBox();
            this.rdbtentt = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dtgtktientin = new System.Windows.Forms.DataGridView();
            this.rdbmatt = new System.Windows.Forms.RadioButton();
            this.lblTienTin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtentt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtktientin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbomatt
            // 
            this.cbomatt.FormattingEnabled = true;
            this.cbomatt.Location = new System.Drawing.Point(141, 45);
            this.cbomatt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbomatt.Name = "cbomatt";
            this.cbomatt.Size = new System.Drawing.Size(209, 28);
            this.cbomatt.TabIndex = 25;
            // 
            // rdbtentt
            // 
            this.rdbtentt.AutoSize = true;
            this.rdbtentt.Location = new System.Drawing.Point(429, 45);
            this.rdbtentt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtentt.Name = "rdbtentt";
            this.rdbtentt.Size = new System.Drawing.Size(116, 24);
            this.rdbtentt.TabIndex = 24;
            this.rdbtentt.TabStop = true;
            this.rdbtentt.Text = "Tên tiền tín:";
            this.rdbtentt.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(521, 585);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(116, 41);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(334, 585);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(115, 41);
            this.btntimkiem.TabIndex = 22;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dtgtktientin
            // 
            this.dtgtktientin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgtktientin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtktientin.Location = new System.Drawing.Point(105, 279);
            this.dtgtktientin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgtktientin.Name = "dtgtktientin";
            this.dtgtktientin.RowHeadersWidth = 51;
            this.dtgtktientin.RowTemplate.Height = 24;
            this.dtgtktientin.Size = new System.Drawing.Size(760, 264);
            this.dtgtktientin.TabIndex = 21;
            // 
            // rdbmatt
            // 
            this.rdbmatt.AutoSize = true;
            this.rdbmatt.Location = new System.Drawing.Point(10, 45);
            this.rdbmatt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbmatt.Name = "rdbmatt";
            this.rdbmatt.Size = new System.Drawing.Size(111, 24);
            this.rdbmatt.TabIndex = 20;
            this.rdbmatt.TabStop = true;
            this.rdbmatt.Text = "Mã tiền tín:";
            this.rdbmatt.UseVisualStyleBackColor = true;
            // 
            // lblTienTin
            // 
            this.lblTienTin.AutoSize = true;
            this.lblTienTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienTin.Location = new System.Drawing.Point(331, 89);
            this.lblTienTin.Name = "lblTienTin";
            this.lblTienTin.Size = new System.Drawing.Size(321, 38);
            this.lblTienTin.TabIndex = 19;
            this.lblTienTin.Text = "TÌM KIẾM TIỀN TÍN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtentt);
            this.groupBox1.Controls.Add(this.rdbmatt);
            this.groupBox1.Controls.Add(this.rdbtentt);
            this.groupBox1.Controls.Add(this.cbomatt);
            this.groupBox1.Location = new System.Drawing.Point(105, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // cbtentt
            // 
            this.cbtentt.FormattingEnabled = true;
            this.cbtentt.Location = new System.Drawing.Point(551, 44);
            this.cbtentt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtentt.Name = "cbtentt";
            this.cbtentt.Size = new System.Drawing.Size(209, 28);
            this.cbtentt.TabIndex = 26;
            // 
            // FrmTimKiemTienTin_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dtgtktientin);
            this.Controls.Add(this.lblTienTin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemTienTin_NV";
            this.Text = "FrmTimKiemTienTin_NV";
            this.Load += new System.EventHandler(this.FrmTimKiemTienTin_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtktientin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbomatt;
        private System.Windows.Forms.RadioButton rdbtentt;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dtgtktientin;
        private System.Windows.Forms.RadioButton rdbmatt;
        private System.Windows.Forms.Label lblTienTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtentt;
    }
}