namespace diem_danh
{
    partial class formVanTay
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
            this.QuanLyHuy = new System.Windows.Forms.Button();
            this.QuanLyXoa = new System.Windows.Forms.Button();
            this.QuanLySua = new System.Windows.Forms.Button();
            this.QuanLyThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuanLyMK = new System.Windows.Forms.TextBox();
            this.QuanLyTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenThanhVien = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuanLyHuy
            // 
            this.QuanLyHuy.Location = new System.Drawing.Point(126, 235);
            this.QuanLyHuy.Name = "QuanLyHuy";
            this.QuanLyHuy.Size = new System.Drawing.Size(75, 23);
            this.QuanLyHuy.TabIndex = 22;
            this.QuanLyHuy.Text = "Hủy";
            this.QuanLyHuy.UseVisualStyleBackColor = true;
            this.QuanLyHuy.Click += new System.EventHandler(this.QuanLyHuy_Click);
            // 
            // QuanLyXoa
            // 
            this.QuanLyXoa.Location = new System.Drawing.Point(25, 235);
            this.QuanLyXoa.Name = "QuanLyXoa";
            this.QuanLyXoa.Size = new System.Drawing.Size(75, 23);
            this.QuanLyXoa.TabIndex = 21;
            this.QuanLyXoa.Text = "Xóa";
            this.QuanLyXoa.UseVisualStyleBackColor = true;
            // 
            // QuanLySua
            // 
            this.QuanLySua.Location = new System.Drawing.Point(126, 194);
            this.QuanLySua.Name = "QuanLySua";
            this.QuanLySua.Size = new System.Drawing.Size(75, 23);
            this.QuanLySua.TabIndex = 20;
            this.QuanLySua.Text = "Sửa";
            this.QuanLySua.UseVisualStyleBackColor = true;
            // 
            // QuanLyThem
            // 
            this.QuanLyThem.Location = new System.Drawing.Point(25, 194);
            this.QuanLyThem.Name = "QuanLyThem";
            this.QuanLyThem.Size = new System.Drawing.Size(75, 23);
            this.QuanLyThem.TabIndex = 19;
            this.QuanLyThem.Text = "Thêm";
            this.QuanLyThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên tài khoản";
            // 
            // QuanLyMK
            // 
            this.QuanLyMK.Location = new System.Drawing.Point(101, 164);
            this.QuanLyMK.Name = "QuanLyMK";
            this.QuanLyMK.Size = new System.Drawing.Size(100, 20);
            this.QuanLyMK.TabIndex = 14;
            this.QuanLyMK.UseSystemPasswordChar = true;
            // 
            // QuanLyTK
            // 
            this.QuanLyTK.Location = new System.Drawing.Point(101, 123);
            this.QuanLyTK.Name = "QuanLyTK";
            this.QuanLyTK.Size = new System.Drawing.Size(100, 20);
            this.QuanLyTK.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên Thành Viên";
            // 
            // tenThanhVien
            // 
            this.tenThanhVien.Location = new System.Drawing.Point(101, 16);
            this.tenThanhVien.Name = "tenThanhVien";
            this.tenThanhVien.Size = new System.Drawing.Size(100, 20);
            this.tenThanhVien.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(101, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Vân tay";
            // 
            // formVanTay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenThanhVien);
            this.Controls.Add(this.QuanLyHuy);
            this.Controls.Add(this.QuanLyXoa);
            this.Controls.Add(this.QuanLySua);
            this.Controls.Add(this.QuanLyThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuanLyMK);
            this.Controls.Add(this.QuanLyTK);
            this.Name = "formVanTay";
            this.Text = "formVanTay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button QuanLyHuy;
        private System.Windows.Forms.Button QuanLyXoa;
        private System.Windows.Forms.Button QuanLySua;
        private System.Windows.Forms.Button QuanLyThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuanLyMK;
        private System.Windows.Forms.TextBox QuanLyTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenThanhVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}