namespace GUI
{
    partial class MHThemKhachHang
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
            this.grProductInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnXemToanBo = new System.Windows.Forms.Button();
            this.btnTimKiemDonDatHang = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grProductInfo
            // 
            this.grProductInfo.Controls.Add(this.textBox2);
            this.grProductInfo.Controls.Add(this.btnXemToanBo);
            this.grProductInfo.Controls.Add(this.btnTimKiemDonDatHang);
            this.grProductInfo.Controls.Add(this.txtProductID);
            this.grProductInfo.Controls.Add(this.label17);
            this.grProductInfo.Controls.Add(this.label19);
            this.grProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grProductInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductInfo.Location = new System.Drawing.Point(12, 12);
            this.grProductInfo.Name = "grProductInfo";
            this.grProductInfo.Size = new System.Drawing.Size(638, 253);
            this.grProductInfo.TabIndex = 43;
            this.grProductInfo.TabStop = false;
            this.grProductInfo.Text = "Tra cứu khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 26);
            this.textBox2.TabIndex = 0;
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXemToanBo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemToanBo.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemToanBo.Location = new System.Drawing.Point(494, 64);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(138, 32);
            this.btnXemToanBo.TabIndex = 46;
            this.btnXemToanBo.Text = "Xem toàn bộ";
            this.btnXemToanBo.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemDonDatHang
            // 
            this.btnTimKiemDonDatHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDonDatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiemDonDatHang.Location = new System.Drawing.Point(348, 64);
            this.btnTimKiemDonDatHang.Name = "btnTimKiemDonDatHang";
            this.btnTimKiemDonDatHang.Size = new System.Drawing.Size(140, 32);
            this.btnTimKiemDonDatHang.TabIndex = 47;
            this.btnTimKiemDonDatHang.Text = "Tìm kiếm";
            this.btnTimKiemDonDatHang.UseVisualStyleBackColor = false;
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
            this.label17.Location = new System.Drawing.Point(29, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số điện thoại:";
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
            // MHThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 278);
            this.Controls.Add(this.grProductInfo);
            this.Name = "MHThemKhachHang";
            this.Text = "MHThemKhachHang";
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnXemToanBo;
        private System.Windows.Forms.Button btnTimKiemDonDatHang;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
    }
}