namespace GUI
{
    partial class MHBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDanhSachSP = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grProductInfo = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbTenKH = new System.Windows.Forms.ComboBox();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSDT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSP)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDanhSachSP
            // 
            this.dtgvDanhSachSP.AllowUserToAddRows = false;
            this.dtgvDanhSachSP.AllowUserToDeleteRows = false;
            this.dtgvDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.DonGia,
            this.SoLuong,
            this.TongGia});
            this.dtgvDanhSachSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachSP.Location = new System.Drawing.Point(3, 19);
            this.dtgvDanhSachSP.Name = "dtgvDanhSachSP";
            this.dtgvDanhSachSP.ReadOnly = true;
            this.dtgvDanhSachSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachSP.Size = new System.Drawing.Size(688, 222);
            this.dtgvDanhSachSP.TabIndex = 0;
            this.dtgvDanhSachSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachSP_CellDoubleClick);
            this.dtgvDanhSachSP.SelectionChanged += new System.EventHandler(this.dtgvDanhSachSP_SelectionChanged);
            // 
            // MaSanPham
            // 
            this.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle10.Format = "C0";
            dataGridViewCellStyle10.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle10;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle11;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // TongGia
            // 
            this.TongGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongGia.DataPropertyName = "TongGia";
            dataGridViewCellStyle12.Format = "C0";
            dataGridViewCellStyle12.NullValue = null;
            this.TongGia.DefaultCellStyle = dataGridViewCellStyle12;
            this.TongGia.HeaderText = "Tổng giá";
            this.TongGia.Name = "TongGia";
            this.TongGia.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvDanhSachSP);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(694, 244);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách sản phẩm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(216, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm khách hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // grProductInfo
            // 
            this.grProductInfo.Controls.Add(this.cbbMaKH);
            this.grProductInfo.Controls.Add(this.cbbSDT);
            this.grProductInfo.Controls.Add(this.label1);
            this.grProductInfo.Controls.Add(this.cbbTenKH);
            this.grProductInfo.Controls.Add(this.button1);
            this.grProductInfo.Controls.Add(this.label18);
            this.grProductInfo.Controls.Add(this.label19);
            this.grProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grProductInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductInfo.Location = new System.Drawing.Point(206, 12);
            this.grProductInfo.Name = "grProductInfo";
            this.grProductInfo.Size = new System.Drawing.Size(357, 147);
            this.grProductInfo.TabIndex = 28;
            this.grProductInfo.TabStop = false;
            this.grProductInfo.Text = "Thông tin Khách hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên khách hàng:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mã khách hàng:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Location = new System.Drawing.Point(569, 408);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(134, 32);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoaSP.Enabled = false;
            this.btnXoaSP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaSP.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoaSP.Location = new System.Drawing.Point(12, 408);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(134, 32);
            this.btnXoaSP.TabIndex = 4;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(177, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 31;
            this.picLogo.TabStop = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Location = new System.Drawing.Point(569, 22);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(134, 32);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSalmon;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.Transparent;
            this.btnHuy.Location = new System.Drawing.Point(569, 60);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(134, 32);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbTenKH
            // 
            this.cbbTenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenKH.FormattingEnabled = true;
            this.cbbTenKH.Location = new System.Drawing.Point(127, 59);
            this.cbbTenKH.Name = "cbbTenKH";
            this.cbbTenKH.Size = new System.Drawing.Size(224, 24);
            this.cbbTenKH.TabIndex = 3;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(127, 30);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(224, 24);
            this.cbbMaKH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sđt khách hàng:";
            // 
            // cbbSDT
            // 
            this.cbbSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSDT.FormattingEnabled = true;
            this.cbbSDT.Location = new System.Drawing.Point(127, 89);
            this.cbbSDT.Name = "cbbSDT";
            this.cbbSDT.Size = new System.Drawing.Size(224, 24);
            this.cbbSDT.TabIndex = 3;
            // 
            // MHBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(717, 453);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grProductInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MHBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHBanHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSP)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dtgvDanhSachSP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGia;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbTenKH;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.ComboBox cbbSDT;
        private System.Windows.Forms.Label label1;
    }
}