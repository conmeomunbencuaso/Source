namespace GUI
{
    partial class MHTaoDonDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvSanPhamDat = new System.Windows.Forms.DataGridView();
            this.MaSanPhamDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPhamDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCungCapDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            this.btnQuanLyDonDatHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamDat)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSanPhamDat
            // 
            this.dtgvSanPhamDat.AllowUserToAddRows = false;
            this.dtgvSanPhamDat.AllowUserToDeleteRows = false;
            this.dtgvSanPhamDat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSanPhamDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPhamDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPhamDat,
            this.TenSanPhamDat,
            this.SoLuong,
            this.TongTien,
            this.MaNhaCungCapDat});
            this.dtgvSanPhamDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSanPhamDat.GridColor = System.Drawing.Color.MistyRose;
            this.dtgvSanPhamDat.Location = new System.Drawing.Point(3, 19);
            this.dtgvSanPhamDat.Name = "dtgvSanPhamDat";
            this.dtgvSanPhamDat.ReadOnly = true;
            this.dtgvSanPhamDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSanPhamDat.Size = new System.Drawing.Size(475, 388);
            this.dtgvSanPhamDat.TabIndex = 0;
            // 
            // MaSanPhamDat
            // 
            this.MaSanPhamDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaSanPhamDat.DataPropertyName = "MaSanPhamDat";
            this.MaSanPhamDat.HeaderText = "Mã Sản Phẩm";
            this.MaSanPhamDat.Name = "MaSanPhamDat";
            this.MaSanPhamDat.ReadOnly = true;
            this.MaSanPhamDat.Width = 112;
            // 
            // TenSanPhamDat
            // 
            this.TenSanPhamDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenSanPhamDat.DataPropertyName = "TenSanPhamDat";
            dataGridViewCellStyle1.NullValue = null;
            this.TenSanPhamDat.DefaultCellStyle = dataGridViewCellStyle1;
            this.TenSanPhamDat.HeaderText = "Tên Sản Phẩm";
            this.TenSanPhamDat.Name = "TenSanPhamDat";
            this.TenSanPhamDat.ReadOnly = true;
            this.TenSanPhamDat.Width = 107;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 80;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // MaNhaCungCapDat
            // 
            this.MaNhaCungCapDat.DataPropertyName = "MaNhaCungCapDat";
            this.MaNhaCungCapDat.HeaderText = "Nhà Cung Cấp";
            this.MaNhaCungCapDat.Name = "MaNhaCungCapDat";
            this.MaNhaCungCapDat.ReadOnly = true;
            this.MaNhaCungCapDat.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvSanPhamDat);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(543, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 410);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách sản phẩm cần đặt hàng";
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(187, 7);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(183, 22);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTaoDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(824, 428);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(197, 34);
            this.btnTaoDonDatHang.TabIndex = 7;
            this.btnTaoDonDatHang.Text = "Tạo đơn đặt hàng";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = false;
            this.btnTaoDonDatHang.Click += new System.EventHandler(this.btnTaoDonDatHang_Click);
            // 
            // btnQuanLyDonDatHang
            // 
            this.btnQuanLyDonDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnQuanLyDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDonDatHang.Location = new System.Drawing.Point(621, 428);
            this.btnQuanLyDonDatHang.Name = "btnQuanLyDonDatHang";
            this.btnQuanLyDonDatHang.Size = new System.Drawing.Size(197, 34);
            this.btnQuanLyDonDatHang.TabIndex = 7;
            this.btnQuanLyDonDatHang.Text = "Quản lý đơn đặt hàng";
            this.btnQuanLyDonDatHang.UseVisualStyleBackColor = false;
            this.btnQuanLyDonDatHang.Click += new System.EventHandler(this.BtnQuanLyDonDatHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSanPham);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 410);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm ";
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToAddRows = false;
            this.dtgvSanPham.AllowUserToDeleteRows = false;
            this.dtgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.GiaMua,
            this.TenNhaCungCap,
            this.MaNhaCungCap});
            this.dtgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSanPham.GridColor = System.Drawing.Color.MistyRose;
            this.dtgvSanPham.Location = new System.Drawing.Point(3, 19);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.ReadOnly = true;
            this.dtgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSanPham.Size = new System.Drawing.Size(480, 388);
            this.dtgvSanPham.TabIndex = 0;
            // 
            // MaSanPham
            // 
            this.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã Sán Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            this.MaSanPham.Width = 112;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 117;
            // 
            // GiaMua
            // 
            this.GiaMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GiaMua.DataPropertyName = "GiaMua";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.GiaMua.DefaultCellStyle = dataGridViewCellStyle4;
            this.GiaMua.HeaderText = "Giá Mua";
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.ReadOnly = true;
            this.GiaMua.Width = 79;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.ReadOnly = true;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.MaNhaCungCap.HeaderText = "Mã NCC";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.ReadOnly = true;
            this.MaNhaCungCap.Visible = false;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChon.ForeColor = System.Drawing.Color.Transparent;
            this.btnChon.Location = new System.Drawing.Point(504, 175);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(33, 33);
            this.btnChon.TabIndex = 38;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBoChon.ForeColor = System.Drawing.Color.Transparent;
            this.btnBoChon.Location = new System.Drawing.Point(504, 214);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(33, 33);
            this.btnBoChon.TabIndex = 38;
            this.btnBoChon.Text = "<<";
            this.btnBoChon.UseVisualStyleBackColor = false;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.filter;
            this.pictureBox1.Location = new System.Drawing.Point(164, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MHTaoDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1036, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnQuanLyDonDatHang);
            this.Controls.Add(this.btnTaoDonDatHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MHTaoDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo mới đơn đặt hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MHTaoDonDatHang_FormClosed);
            this.Load += new System.EventHandler(this.MHTaoDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamDat)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnTaoDonDatHang;
        private System.Windows.Forms.Button btnQuanLyDonDatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvSanPhamDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPhamDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPhamDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCapDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
    }
}