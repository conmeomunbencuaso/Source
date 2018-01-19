using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManHinhChinh : Form
    {
        public static ManHinhChinh frmMain;
        public static string user = "";

        public static string NextID(string lastID, string prefixID)
        {
            if (lastID == "")
            {
                return prefixID + "00001";  // fixwidth default
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Trim().Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;
        }

        public ManHinhChinh()
        {
            InitializeComponent();
            frmMain = this;
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            MHBanHang mHBanHang = new MHBanHang();
            mHBanHang.Show();
            this.Hide();
        }

        private void BtnQuanLy_Click(object sender, EventArgs e)
        {
            MHQuanLyDonDatHang quanLyDonDatHang = new MHQuanLyDonDatHang();
            quanLyDonDatHang.Show();
            this.Hide();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void ManHinhChinh_Load_1(object sender, EventArgs e)
        {

        }
    }
}
