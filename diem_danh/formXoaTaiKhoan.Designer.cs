namespace diem_danh
{
    partial class formXoaTaiKhoan
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
            this.dataGridViewQuanLyTK = new System.Windows.Forms.DataGridView();
            this.QuanLyHuy = new System.Windows.Forms.Button();
            this.QuanLyXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuanLyTK = new System.Windows.Forms.TextBox();
            this.QuanLyXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyTK
            // 
            this.dataGridViewQuanLyTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyTK.Location = new System.Drawing.Point(281, 39);
            this.dataGridViewQuanLyTK.Name = "dataGridViewQuanLyTK";
            this.dataGridViewQuanLyTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyTK.Size = new System.Drawing.Size(240, 210);
            this.dataGridViewQuanLyTK.TabIndex = 21;
            this.dataGridViewQuanLyTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyTK_CellClick);
            // 
            // QuanLyHuy
            // 
            this.QuanLyHuy.Location = new System.Drawing.Point(126, 162);
            this.QuanLyHuy.Name = "QuanLyHuy";
            this.QuanLyHuy.Size = new System.Drawing.Size(75, 23);
            this.QuanLyHuy.TabIndex = 20;
            this.QuanLyHuy.Text = "Hủy";
            this.QuanLyHuy.UseVisualStyleBackColor = true;
            this.QuanLyHuy.Click += new System.EventHandler(this.QuanLyHuy_Click);
            // 
            // QuanLyXoa
            // 
            this.QuanLyXoa.Location = new System.Drawing.Point(38, 162);
            this.QuanLyXoa.Name = "QuanLyXoa";
            this.QuanLyXoa.Size = new System.Drawing.Size(75, 23);
            this.QuanLyXoa.TabIndex = 19;
            this.QuanLyXoa.Text = "Xóa";
            this.QuanLyXoa.UseVisualStyleBackColor = true;
            this.QuanLyXoa.Click += new System.EventHandler(this.QuanLyXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên tài khoản cần xóa";
            // 
            // QuanLyTK
            // 
            this.QuanLyTK.Location = new System.Drawing.Point(137, 103);
            this.QuanLyTK.Name = "QuanLyTK";
            this.QuanLyTK.Size = new System.Drawing.Size(100, 20);
            this.QuanLyTK.TabIndex = 13;
            // 
            // QuanLyXem
            // 
            this.QuanLyXem.Location = new System.Drawing.Point(126, 202);
            this.QuanLyXem.Name = "QuanLyXem";
            this.QuanLyXem.Size = new System.Drawing.Size(75, 23);
            this.QuanLyXem.TabIndex = 22;
            this.QuanLyXem.Text = "Xem";
            this.QuanLyXem.UseVisualStyleBackColor = true;
            this.QuanLyXem.Click += new System.EventHandler(this.QuanLyXem_Click);
            // 
            // formXoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.QuanLyXem);
            this.Controls.Add(this.dataGridViewQuanLyTK);
            this.Controls.Add(this.QuanLyHuy);
            this.Controls.Add(this.QuanLyXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuanLyTK);
            this.Name = "formXoaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formXoaTaiKhoan";
            this.Load += new System.EventHandler(this.formXoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewQuanLyTK;
        private System.Windows.Forms.Button QuanLyHuy;
        private System.Windows.Forms.Button QuanLyXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuanLyTK;
        private System.Windows.Forms.Button QuanLyXem;
    }
}