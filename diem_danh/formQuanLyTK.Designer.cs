namespace diem_danh
{
    partial class formQuanLyTK
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
            this.QuanLyTK = new System.Windows.Forms.TextBox();
            this.QuanLyMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuanLyLoaiTK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuanLyThem = new System.Windows.Forms.Button();
            this.QuanLySua = new System.Windows.Forms.Button();
            this.QuanLyXoa = new System.Windows.Forms.Button();
            this.QuanLyHuy = new System.Windows.Forms.Button();
            this.dataGridViewQuanLyTK = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.QuanLyXnMK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTK)).BeginInit();
            this.SuspendLayout();
            // 
            // QuanLyTK
            // 
            this.QuanLyTK.Location = new System.Drawing.Point(91, 12);
            this.QuanLyTK.Name = "QuanLyTK";
            this.QuanLyTK.Size = new System.Drawing.Size(100, 20);
            this.QuanLyTK.TabIndex = 0;
            // 
            // QuanLyMK
            // 
            this.QuanLyMK.Location = new System.Drawing.Point(91, 53);
            this.QuanLyMK.Name = "QuanLyMK";
            this.QuanLyMK.Size = new System.Drawing.Size(100, 20);
            this.QuanLyMK.TabIndex = 1;
            this.QuanLyMK.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // QuanLyLoaiTK
            // 
            this.QuanLyLoaiTK.FormattingEnabled = true;
            this.QuanLyLoaiTK.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.QuanLyLoaiTK.Location = new System.Drawing.Point(91, 111);
            this.QuanLyLoaiTK.Name = "QuanLyLoaiTK";
            this.QuanLyLoaiTK.Size = new System.Drawing.Size(100, 21);
            this.QuanLyLoaiTK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại tài khoản";
            // 
            // QuanLyThem
            // 
            this.QuanLyThem.Location = new System.Drawing.Point(15, 149);
            this.QuanLyThem.Name = "QuanLyThem";
            this.QuanLyThem.Size = new System.Drawing.Size(75, 23);
            this.QuanLyThem.TabIndex = 6;
            this.QuanLyThem.Text = "Thêm";
            this.QuanLyThem.UseVisualStyleBackColor = true;
            this.QuanLyThem.Click += new System.EventHandler(this.QuanLyThem_Click);
            // 
            // QuanLySua
            // 
            this.QuanLySua.Location = new System.Drawing.Point(116, 149);
            this.QuanLySua.Name = "QuanLySua";
            this.QuanLySua.Size = new System.Drawing.Size(75, 23);
            this.QuanLySua.TabIndex = 7;
            this.QuanLySua.Text = "Sửa";
            this.QuanLySua.UseVisualStyleBackColor = true;
            // 
            // QuanLyXoa
            // 
            this.QuanLyXoa.Location = new System.Drawing.Point(15, 190);
            this.QuanLyXoa.Name = "QuanLyXoa";
            this.QuanLyXoa.Size = new System.Drawing.Size(75, 23);
            this.QuanLyXoa.TabIndex = 8;
            this.QuanLyXoa.Text = "Xóa";
            this.QuanLyXoa.UseVisualStyleBackColor = true;
            // 
            // QuanLyHuy
            // 
            this.QuanLyHuy.Location = new System.Drawing.Point(116, 190);
            this.QuanLyHuy.Name = "QuanLyHuy";
            this.QuanLyHuy.Size = new System.Drawing.Size(75, 23);
            this.QuanLyHuy.TabIndex = 9;
            this.QuanLyHuy.Text = "Hủy";
            this.QuanLyHuy.UseVisualStyleBackColor = true;
            this.QuanLyHuy.Click += new System.EventHandler(this.QuanLyHuy_Click);
            // 
            // dataGridViewQuanLyTK
            // 
            this.dataGridViewQuanLyTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyTK.Location = new System.Drawing.Point(209, 12);
            this.dataGridViewQuanLyTK.Name = "dataGridViewQuanLyTK";
            this.dataGridViewQuanLyTK.Size = new System.Drawing.Size(240, 210);
            this.dataGridViewQuanLyTK.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Xác nhận MK";
            // 
            // QuanLyXnMK
            // 
            this.QuanLyXnMK.Location = new System.Drawing.Point(91, 85);
            this.QuanLyXnMK.Name = "QuanLyXnMK";
            this.QuanLyXnMK.Size = new System.Drawing.Size(100, 20);
            this.QuanLyXnMK.TabIndex = 11;
            this.QuanLyXnMK.UseSystemPasswordChar = true;
            // 
            // formQuanLyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 234);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuanLyXnMK);
            this.Controls.Add(this.dataGridViewQuanLyTK);
            this.Controls.Add(this.QuanLyHuy);
            this.Controls.Add(this.QuanLyXoa);
            this.Controls.Add(this.QuanLySua);
            this.Controls.Add(this.QuanLyThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuanLyLoaiTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuanLyMK);
            this.Controls.Add(this.QuanLyTK);
            this.Name = "formQuanLyTK";
            this.Text = "formQuanLyTK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuanLyTK;
        private System.Windows.Forms.TextBox QuanLyMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QuanLyLoaiTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button QuanLyThem;
        private System.Windows.Forms.Button QuanLySua;
        private System.Windows.Forms.Button QuanLyXoa;
        private System.Windows.Forms.Button QuanLyHuy;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuanLyXnMK;
    }
}