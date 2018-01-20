namespace GUI
{
    partial class ManHinhChinh
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnQuanLyDatHang = new System.Windows.Forms.Button();
            this.btnDangCapNhat = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBanHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanHang.Location = new System.Drawing.Point(12, 296);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(110, 34);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.BtnBanHang_Click);
            // 
            // btnQuanLyDatHang
            // 
            this.btnQuanLyDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnQuanLyDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDatHang.Location = new System.Drawing.Point(299, 296);
            this.btnQuanLyDatHang.Name = "btnQuanLyDatHang";
            this.btnQuanLyDatHang.Size = new System.Drawing.Size(152, 34);
            this.btnQuanLyDatHang.TabIndex = 2;
            this.btnQuanLyDatHang.Text = "Quản lý đặt hàng";
            this.btnQuanLyDatHang.UseVisualStyleBackColor = false;
            this.btnQuanLyDatHang.Click += new System.EventHandler(this.BtnQuanLy_Click);
            // 
            // btnDangCapNhat
            // 
            this.btnDangCapNhat.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDangCapNhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangCapNhat.ForeColor = System.Drawing.Color.Transparent;
            this.btnDangCapNhat.Location = new System.Drawing.Point(128, 296);
            this.btnDangCapNhat.Name = "btnDangCapNhat";
            this.btnDangCapNhat.Size = new System.Drawing.Size(165, 34);
            this.btnDangCapNhat.TabIndex = 3;
            this.btnDangCapNhat.Text = "Tiếp nhận khách hàng";
            this.btnDangCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Transparent;
            this.btnSanPham.Location = new System.Drawing.Point(457, 296);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(153, 34);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "Quản lý sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(620, 348);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnDangCapNhat);
            this.Controls.Add(this.btnQuanLyDatHang);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnQuanLyDatHang;
        private System.Windows.Forms.Button btnDangCapNhat;
        private System.Windows.Forms.Button btnSanPham;
    }
}

