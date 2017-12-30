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
            this.dtgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grProductInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiemSanPham = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnChonNhaCungCap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            this.btnQuanLyDonDatHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grProductInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDanhSachSanPham
            // 
            this.dtgvDanhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachSanPham.GridColor = System.Drawing.Color.MistyRose;
            this.dtgvDanhSachSanPham.Location = new System.Drawing.Point(3, 19);
            this.dtgvDanhSachSanPham.Name = "dtgvDanhSachSanPham";
            this.dtgvDanhSachSanPham.Size = new System.Drawing.Size(779, 358);
            this.dtgvDanhSachSanPham.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(186, 171);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 36;
            this.picLogo.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvDanhSachSanPham);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(785, 380);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách sản phẩm cần đặt hàng";
            // 
            // grProductInfo
            // 
            this.grProductInfo.Controls.Add(this.button1);
            this.grProductInfo.Controls.Add(this.btnTimKiemSanPham);
            this.grProductInfo.Controls.Add(this.txtProductID);
            this.grProductInfo.Controls.Add(this.label19);
            this.grProductInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductInfo.Location = new System.Drawing.Point(204, 12);
            this.grProductInfo.Name = "grProductInfo";
            this.grProductInfo.Size = new System.Drawing.Size(269, 171);
            this.grProductInfo.TabIndex = 34;
            this.grProductInfo.TabStop = false;
            this.grProductInfo.Text = "Tìm kiếm sản phẩm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(110, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm sản phẩm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.LightCoral;
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSanPham.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(20, 66);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(84, 32);
            this.btnTimKiemSanPham.TabIndex = 2;
            this.btnTimKiemSanPham.Text = "Tìm kiếm";
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            this.btnTimKiemSanPham.Click += new System.EventHandler(this.btnTimKiemSanPham_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(107, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(144, 22);
            this.txtProductID.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mã sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.btnChonNhaCungCap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(508, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 171);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhà cung cấp";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // btnChonNhaCungCap
            // 
            this.btnChonNhaCungCap.BackColor = System.Drawing.Color.LightCoral;
            this.btnChonNhaCungCap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNhaCungCap.ForeColor = System.Drawing.Color.Transparent;
            this.btnChonNhaCungCap.Location = new System.Drawing.Point(95, 66);
            this.btnChonNhaCungCap.Name = "btnChonNhaCungCap";
            this.btnChonNhaCungCap.Size = new System.Drawing.Size(153, 32);
            this.btnChonNhaCungCap.TabIndex = 2;
            this.btnChonNhaCungCap.Text = "Chọn nhà cung cấp";
            this.btnChonNhaCungCap.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.BackColor = System.Drawing.Color.LightCoral;
            this.btnTaoDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(394, 572);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(197, 34);
            this.btnTaoDonDatHang.TabIndex = 7;
            this.btnTaoDonDatHang.Text = "Tạo đơn đặt hàng";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyDonDatHang
            // 
            this.btnQuanLyDonDatHang.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuanLyDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDonDatHang.Location = new System.Drawing.Point(597, 572);
            this.btnQuanLyDonDatHang.Name = "btnQuanLyDonDatHang";
            this.btnQuanLyDonDatHang.Size = new System.Drawing.Size(197, 34);
            this.btnQuanLyDonDatHang.TabIndex = 7;
            this.btnQuanLyDonDatHang.Text = "Quản lý đơn đặt hàng";
            this.btnQuanLyDonDatHang.UseVisualStyleBackColor = false;
            this.btnQuanLyDonDatHang.Click += new System.EventHandler(this.BtnQuanLyDonDatHang_Click);
            // 
            // MHTaoDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(817, 621);
            this.Controls.Add(this.btnQuanLyDonDatHang);
            this.Controls.Add(this.btnTaoDonDatHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grProductInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox5);
            this.Name = "MHTaoDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo mới đơn đặt hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDanhSachSanPham;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimKiemSanPham;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnChonNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoDonDatHang;
        private System.Windows.Forms.Button btnQuanLyDonDatHang;
    }
}