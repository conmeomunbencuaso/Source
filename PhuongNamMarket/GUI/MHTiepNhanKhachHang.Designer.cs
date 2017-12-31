namespace GUI
{
    partial class MHTiepNhanKhachHang
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grProductInfo = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemToanBo = new System.Windows.Forms.Button();
            this.btnTimKiemDonDatHang = new System.Windows.Forms.Button();
            this.dtgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(209, 178);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 45;
            this.picLogo.TabStop = false;
            // 
            // grProductInfo
            // 
            this.grProductInfo.Controls.Add(this.textBox2);
            this.grProductInfo.Controls.Add(this.btnXemToanBo);
            this.grProductInfo.Controls.Add(this.textBox1);
            this.grProductInfo.Controls.Add(this.btnTimKiemDonDatHang);
            this.grProductInfo.Controls.Add(this.txtProductID);
            this.grProductInfo.Controls.Add(this.txtProductDescription);
            this.grProductInfo.Controls.Add(this.label2);
            this.grProductInfo.Controls.Add(this.label17);
            this.grProductInfo.Controls.Add(this.label18);
            this.grProductInfo.Controls.Add(this.label19);
            this.grProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grProductInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductInfo.Location = new System.Drawing.Point(227, 12);
            this.grProductInfo.Name = "grProductInfo";
            this.grProductInfo.Size = new System.Drawing.Size(520, 235);
            this.grProductInfo.TabIndex = 42;
            this.grProductInfo.TabStop = false;
            this.grProductInfo.Text = "Thông tin khách hàng";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(132, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(195, 26);
            this.txtProductID.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số điện thoại:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Họ tên:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mã khách hàng:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(132, 124);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(195, 100);
            this.txtProductDescription.TabIndex = 46;
            this.txtProductDescription.Text = "227/12 Nguyễn văn cừ quận 5 thành phố Hồ Chí Minh";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 26);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ:";
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXemToanBo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemToanBo.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemToanBo.Location = new System.Drawing.Point(351, 67);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(144, 32);
            this.btnXemToanBo.TabIndex = 46;
            this.btnXemToanBo.Text = "Xem toàn bộ";
            this.btnXemToanBo.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemDonDatHang
            // 
            this.btnTimKiemDonDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiemDonDatHang.Location = new System.Drawing.Point(351, 29);
            this.btnTimKiemDonDatHang.Name = "btnTimKiemDonDatHang";
            this.btnTimKiemDonDatHang.Size = new System.Drawing.Size(145, 32);
            this.btnTimKiemDonDatHang.TabIndex = 47;
            this.btnTimKiemDonDatHang.Text = "Tìm kiếm";
            this.btnTimKiemDonDatHang.UseVisualStyleBackColor = false;
            // 
            // dtgvDanhSachKhachHang
            // 
            this.dtgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachKhachHang.Location = new System.Drawing.Point(3, 19);
            this.dtgvDanhSachKhachHang.Name = "dtgvDanhSachKhachHang";
            this.dtgvDanhSachKhachHang.Size = new System.Drawing.Size(729, 297);
            this.dtgvDanhSachKhachHang.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 319);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // MHTiepNhanKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(764, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grProductInfo);
            this.Name = "MHTiepNhanKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemToanBo;
        private System.Windows.Forms.Button btnTimKiemDonDatHang;
        private System.Windows.Forms.DataGridView dtgvDanhSachKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}