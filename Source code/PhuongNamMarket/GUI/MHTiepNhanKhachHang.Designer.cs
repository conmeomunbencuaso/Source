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
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(188, 161);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 45;
            this.picLogo.TabStop = false;
            // 
            // grProductInfo
            // 
            this.grProductInfo.Controls.Add(this.txtDiaChi);
            this.grProductInfo.Controls.Add(this.txtSDT);
            this.grProductInfo.Controls.Add(this.btnTiepNhan);
            this.grProductInfo.Controls.Add(this.label1);
            this.grProductInfo.Controls.Add(this.txtTenKhachHang);
            this.grProductInfo.Controls.Add(this.label17);
            this.grProductInfo.Controls.Add(this.label19);
            this.grProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grProductInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductInfo.Location = new System.Drawing.Point(227, 12);
            this.grProductInfo.Name = "grProductInfo";
            this.grProductInfo.Size = new System.Drawing.Size(520, 161);
            this.grProductInfo.TabIndex = 42;
            this.grProductInfo.TabStop = false;
            this.grProductInfo.Text = "Thông tin khách hàng";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTiepNhan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.ForeColor = System.Drawing.Color.Transparent;
            this.btnTiepNhan.Location = new System.Drawing.Point(361, 16);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(153, 133);
            this.btnTiepNhan.TabIndex = 3;
            this.btnTiepNhan.Text = "Tiếp nhận";
            this.btnTiepNhan.UseVisualStyleBackColor = false;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(132, 29);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(195, 26);
            this.txtTenKhachHang.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số điện thoại:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 93);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(195, 56);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(132, 61);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(195, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // MHTiepNhanKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(764, 183);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grProductInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MHTiepNhanKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHTiepNhanKhachHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
    }
}