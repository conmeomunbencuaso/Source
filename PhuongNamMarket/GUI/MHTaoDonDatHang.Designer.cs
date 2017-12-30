﻿namespace GUI
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
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grProductInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grProductInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sum";
            this.Column7.Name = "Column7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProductID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ProductName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quality";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Catalog";
            this.Column6.Name = "Column6";
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
            this.groupBox5.Controls.Add(this.dataGridView1);
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
            this.grProductInfo.Controls.Add(this.button2);
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
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(107, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm sản phẩm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(77, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = false;
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
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(514, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 171);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhà cung cấp";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(109, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "Xem toàn bộ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(19, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaoDonDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDonDatHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(597, 575);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(197, 34);
            this.btnTaoDonDatHang.TabIndex = 7;
            this.btnTaoDonDatHang.Text = "Tạo đơn đặt hàng";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = false;
            // 
            // MHTaoDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 621);
            this.Controls.Add(this.btnTaoDonDatHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grProductInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox5);
            this.Name = "MHTaoDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo mới đơn đặt hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.grProductInfo.ResumeLayout(false);
            this.grProductInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox grProductInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoDonDatHang;
    }
}