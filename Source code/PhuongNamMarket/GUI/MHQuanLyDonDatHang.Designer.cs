namespace GUI
{
    partial class MHQuanLyDonDatHang
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
            this.txtTimKiemTheoMaDonDatHang = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grProductInfo = new System.Windows.Forms.GroupBox();
            this.cbbTimKiemTheoTrangThai = new System.Windows.Forms.ComboBox();
            this.btnXemToanBo = new System.Windows.Forms.Button();
            this.btnTimKiemDonDatHang = new System.Windows.Forms.Button();
            this.dtgvDanhSachDonDatHang = new System.Windows.Forms.DataGridView();
            this.MaDonDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMaDonDatHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaDDH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDonDatHang)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiemTheoMaDonDatHang
            // 
            this.txtTimKiemTheoMaDonDatHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTheoMaDonDatHang.Location = new System.Drawing.Point(109, 33);
            this.txtTimKiemTheoMaDonDatHang.Name = "txtTimKiemTheoMaDonDatHang";
            this.txtTimKiemTheoMaDonDatHang.Size = new System.Drawing.Size(144, 22);
            this.txtTimKiemTheoMaDonDatHang.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Trạng thái:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mã đơn hàng:";
            // 
            // grProductInfo
            // 
            this.grProductInfo.Controls.Add(this.cbbTimKiemTheoTrangThai);
            this.grProductInfo.Controls.Add(this.btnXemToanBo);
            this.grProductInfo.Controls.Add(this.btnTimKiemDonDatHang);
            this.grProductInfo.Controls.Add(this.txtTimKiemTheoMaDonDatHang);
            this.grProductInfo.Controls.Add(this.label18);
            this.grProductInfo.Controls.Add(this.label19);
            this.grProductInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductInfo.Location = new System.Drawing.Point(229, 12);
            this.grProductInfo.Name = "grProductInfo";
            this.grProductInfo.Size = new System.Drawing.Size(283, 142);
            this.grProductInfo.TabIndex = 33;
            this.grProductInfo.TabStop = false;
            this.grProductInfo.Text = "Tìm kiếm đơn đặt hàng";
            // 
            // cbbTimKiemTheoTrangThai
            // 
            this.cbbTimKiemTheoTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemTheoTrangThai.FormattingEnabled = true;
            this.cbbTimKiemTheoTrangThai.Location = new System.Drawing.Point(109, 61);
            this.cbbTimKiemTheoTrangThai.Name = "cbbTimKiemTheoTrangThai";
            this.cbbTimKiemTheoTrangThai.Size = new System.Drawing.Size(144, 24);
            this.cbbTimKiemTheoTrangThai.TabIndex = 3;
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXemToanBo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemToanBo.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemToanBo.Location = new System.Drawing.Point(109, 98);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(144, 32);
            this.btnXemToanBo.TabIndex = 2;
            this.btnXemToanBo.Text = "Xem toàn bộ";
            this.btnXemToanBo.UseVisualStyleBackColor = false;
            this.btnXemToanBo.Click += new System.EventHandler(this.btnXemToanBo_Click);
            // 
            // btnTimKiemDonDatHang
            // 
            this.btnTimKiemDonDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiemDonDatHang.Location = new System.Drawing.Point(19, 98);
            this.btnTimKiemDonDatHang.Name = "btnTimKiemDonDatHang";
            this.btnTimKiemDonDatHang.Size = new System.Drawing.Size(84, 32);
            this.btnTimKiemDonDatHang.TabIndex = 2;
            this.btnTimKiemDonDatHang.Text = "Tìm kiếm";
            this.btnTimKiemDonDatHang.UseVisualStyleBackColor = false;
            this.btnTimKiemDonDatHang.Click += new System.EventHandler(this.BtnTimKiemDonDatHang_Click);
            // 
            // dtgvDanhSachDonDatHang
            // 
            this.dtgvDanhSachDonDatHang.AllowUserToAddRows = false;
            this.dtgvDanhSachDonDatHang.AllowUserToDeleteRows = false;
            this.dtgvDanhSachDonDatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDanhSachDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonDatHang,
            this.NgayLap,
            this.TrangThai});
            this.dtgvDanhSachDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachDonDatHang.GridColor = System.Drawing.Color.MistyRose;
            this.dtgvDanhSachDonDatHang.Location = new System.Drawing.Point(3, 19);
            this.dtgvDanhSachDonDatHang.MultiSelect = false;
            this.dtgvDanhSachDonDatHang.Name = "dtgvDanhSachDonDatHang";
            this.dtgvDanhSachDonDatHang.ReadOnly = true;
            this.dtgvDanhSachDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachDonDatHang.Size = new System.Drawing.Size(672, 277);
            this.dtgvDanhSachDonDatHang.TabIndex = 0;
            this.dtgvDanhSachDonDatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvDanhSachDonDatHang_CellClick);
            this.dtgvDanhSachDonDatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvDanhSachDonDatHang_CellFormatting);
            // 
            // MaDonDatHang
            // 
            this.MaDonDatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDonDatHang.DataPropertyName = "MaDonDatHang";
            this.MaDonDatHang.HeaderText = "Mã Đơn Đặt Hàng";
            this.MaDonDatHang.Name = "MaDonDatHang";
            this.MaDonDatHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TenTrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvDanhSachDonDatHang);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 299);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách đơn đặt hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkNgayLap);
            this.groupBox1.Controls.Add(this.cbbTrangThai);
            this.groupBox1.Controls.Add(this.txtMaDonDatHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSuaDDH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 90);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin/trạng thái đơn đặt hàng";
            // 
            // dtpkNgayLap
            // 
            this.dtpkNgayLap.Enabled = false;
            this.dtpkNgayLap.Location = new System.Drawing.Point(155, 45);
            this.dtpkNgayLap.Name = "dtpkNgayLap";
            this.dtpkNgayLap.Size = new System.Drawing.Size(200, 23);
            this.dtpkNgayLap.TabIndex = 5;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(359, 45);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(144, 24);
            this.cbbTrangThai.TabIndex = 3;
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.Location = new System.Drawing.Point(20, 45);
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.ReadOnly = true;
            this.txtMaDonDatHang.Size = new System.Drawing.Size(129, 23);
            this.txtMaDonDatHang.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã đơn đặt hàng";
            // 
            // btnSuaDDH
            // 
            this.btnSuaDDH.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSuaDDH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDDH.ForeColor = System.Drawing.Color.Transparent;
            this.btnSuaDDH.Location = new System.Drawing.Point(509, 40);
            this.btnSuaDDH.Name = "btnSuaDDH";
            this.btnSuaDDH.Size = new System.Drawing.Size(146, 33);
            this.btnSuaDDH.TabIndex = 2;
            this.btnSuaDDH.Text = "Lưu đơn đặt hàng";
            this.btnSuaDDH.UseVisualStyleBackColor = false;
            this.btnSuaDDH.Click += new System.EventHandler(this.btnSuaDDH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái";
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTaoDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaoDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(3, 19);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(166, 120);
            this.btnTaoDonDatHang.TabIndex = 4;
            this.btnTaoDonDatHang.Text = "Đặt hàng";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = false;
            this.btnTaoDonDatHang.Click += new System.EventHandler(this.BtnTaoDonDatHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTaoDonDatHang);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 142);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo đơn đặt hàng";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(211, 142);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 36;
            this.picLogo.TabStop = false;
            // 
            // MHQuanLyDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(703, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grProductInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "MHQuanLyDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn đặt hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MHQuanLyDonDatHang_FormClosed);
            this.Load += new System.EventHandler(this.MHQuanLyDonDatHang_Load);
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDonDatHang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemTheoMaDonDatHang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.Button btnXemToanBo;
        private System.Windows.Forms.Button btnTimKiemDonDatHang;
        private System.Windows.Forms.DataGridView dtgvDanhSachDonDatHang;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoDonDatHang;
        private System.Windows.Forms.ComboBox cbbTimKiemTheoTrangThai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaDDH;
        private System.Windows.Forms.TextBox txtMaDonDatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkNgayLap;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}