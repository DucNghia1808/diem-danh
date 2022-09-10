using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diem_danh
{
    public partial class formMain : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public formMain()
        {
            InitializeComponent();
        }

        #region Method

        #endregion
        #region Event
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
                //Application.Exit();
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


    }
}
