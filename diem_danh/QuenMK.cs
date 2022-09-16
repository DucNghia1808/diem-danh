using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diem_danh
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            QuenTK.Text = "";
            mkHienTai.Text = "";
        }
        Modify modify = new Modify();
        private void LayMK_Click(object sender, EventArgs e)
        {
            string tentk = QuenTK.Text;
            if(tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản đăng kí");
                return;
            }
            else 
            {
                string query = "Select *from TaiKhoan where TaiKhoan = '"+tentk +"'";
                if(modify.TaiKhoans(query).Count() != 0)
                {
                    mkHienTai.Text = modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa được đăng kí");
                }
            }
        }

        private void HuyLayMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
