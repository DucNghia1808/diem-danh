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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {   // connect to database taikhoan_table
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-99BV9DS\SQLEXPRESS;Initial Catalog=taikhoan;Integrated Security=True");
            try
            {
                con.Open();
                string username = tkDangNhap.Text;
                string password = mkDangNhap.Text;
                string sql = "select *from taikhoan_table where TaiKhoan = '" + username + "' and MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader data = cmd.ExecuteReader();


                /*if (data.Read()) // dung data
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    formMain f = new formMain();
                    f.Show();
                    this.Hide();
                    f.Logout += F_Logout;
                }
                else
                {
                    MessageBox.Show("Sai tk mk");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }

        }

        private void F_Logout(object sender, EventArgs e) // hàm ủy thác
        {
            (sender as formMain).isExit = false;
            (sender as formMain).Close();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
