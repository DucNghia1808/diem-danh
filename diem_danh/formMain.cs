using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace diem_danh
{
    public partial class formMain : Form
    {

        public bool isExit = true;
        public event EventHandler Logout;
        public formMain()
        {
            InitializeComponent();
            ThoiGian.Start();
        }

        #region Method

        #endregion
        #region Event
        Modify modify = new Modify();
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

     
        // bt ddang suat
        private void đăngSuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        #endregion

        private void formMain_Load(object sender, EventArgs e)
        {
            string[] myport = SerialPort.GetPortNames();
            comboPORT.Items.AddRange(myport);// get port
          

        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formQuanLyTK f = new formQuanLyTK();
            f.Show();
        }

        private void lấyLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuenMK f = new QuenMK();
            f.Show();
        }

        private void thêmThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVanTay f = new formVanTay();
            f.Show();
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            text_time.Text = DateTime.Now.ToLongTimeString();
            text_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void comPortConnect_Click(object sender, EventArgs e)
        {
            if (comboPORT.Text == "")
            {
                MessageBox.Show("Vui lòng kết nối cổng serial!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    comboPORT.Enabled = true;
                    comPortConnect.Text = "Connect";
                    MessageBox.Show("Cổng serial đã đóng!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    serialPort1.PortName = comboPORT.Text;
                    serialPort1.BaudRate = 115200; // Int.Parse(comboBaudrate.Text) // baudrate
                    comboPORT.Enabled = false;
                    serialPort1.Open();
                    comPortConnect.Text = "Disconnect";
                    MessageBox.Show("Đã kết nối!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối cổng serial!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formXoaTaiKhoan f = new formXoaTaiKhoan();
            f.Show();
        }

        private void sửaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaMK f = new SuaMK();
            f.Show();
        }

        private void timkiem_TextChanged(object sender, EventArgs e)
        {
            string tim = timkiem.Text.Trim();
            if (tim == "")
            {
                formMain_Load(sender, e); // load form lại lên thôi
            }
            else // trả kết quả tìm kiếm ra grid
            {
                //string query = "select * from TaiKhoan where TaiKhoan like '%" + tim + "%'";
                //dataGridViewTimKiem.DataSource = modify.Table(query);
            }
        }
    }
}
