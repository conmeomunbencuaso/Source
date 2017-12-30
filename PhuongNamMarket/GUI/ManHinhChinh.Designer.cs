﻿namespace GUI
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.menuHeThong = new System.Windows.Forms.MenuStrip();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyDatHang = new System.Windows.Forms.Button();
            this.btnDangCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(399, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Location = new System.Drawing.Point(37, 296);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(98, 29);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.BtnBanHang_Click);
            // 
            // menuHeThong
            // 
            this.menuHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.danhMụcSảnPhẩmToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuHeThong.Location = new System.Drawing.Point(0, 0);
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(589, 24);
            this.menuHeThong.TabIndex = 0;
            this.menuHeThong.Text = "menuStrip1";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // danhMụcSảnPhẩmToolStripMenuItem
            // 
            this.danhMụcSảnPhẩmToolStripMenuItem.Name = "danhMụcSảnPhẩmToolStripMenuItem";
            this.danhMụcSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.danhMụcSảnPhẩmToolStripMenuItem.Text = "Danh mục sản phẩm";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // btnQuanLyDatHang
            // 
            this.btnQuanLyDatHang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDatHang.Location = new System.Drawing.Point(141, 296);
            this.btnQuanLyDatHang.Name = "btnQuanLyDatHang";
            this.btnQuanLyDatHang.Size = new System.Drawing.Size(152, 29);
            this.btnQuanLyDatHang.TabIndex = 2;
            this.btnQuanLyDatHang.Text = "Quản lý đặt hàng";
            this.btnQuanLyDatHang.UseVisualStyleBackColor = true;
            this.btnQuanLyDatHang.Click += new System.EventHandler(this.BtnQuanLy_Click);
            // 
            // btnDangCapNhat
            // 
            this.btnDangCapNhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangCapNhat.Location = new System.Drawing.Point(299, 296);
            this.btnDangCapNhat.Name = "btnDangCapNhat";
            this.btnDangCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btnDangCapNhat.TabIndex = 3;
            this.btnDangCapNhat.Text = "Null";
            this.btnDangCapNhat.UseVisualStyleBackColor = true;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 342);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnDangCapNhat);
            this.Controls.Add(this.btnQuanLyDatHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuHeThong);
            this.MainMenuStrip = this.menuHeThong;
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuHeThong.ResumeLayout(false);
            this.menuHeThong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.MenuStrip menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button btnQuanLyDatHang;
        private System.Windows.Forms.Button btnDangCapNhat;
    }
}

