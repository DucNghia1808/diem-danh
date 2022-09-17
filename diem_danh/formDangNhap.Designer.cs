namespace diem_danh
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tkDangNhap = new System.Windows.Forms.TextBox();
            this.mkDangNhap = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.text_day = new System.Windows.Forms.Label();
            this.text_time = new System.Windows.Forms.Label();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.quenMK = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // tkDangNhap
            // 
            this.tkDangNhap.Location = new System.Drawing.Point(104, 35);
            this.tkDangNhap.Name = "tkDangNhap";
            this.tkDangNhap.Size = new System.Drawing.Size(100, 20);
            this.tkDangNhap.TabIndex = 2;
            // 
            // mkDangNhap
            // 
            this.mkDangNhap.Location = new System.Drawing.Point(104, 77);
            this.mkDangNhap.Name = "mkDangNhap";
            this.mkDangNhap.Size = new System.Drawing.Size(100, 20);
            this.mkDangNhap.TabIndex = 3;
            this.mkDangNhap.UseSystemPasswordChar = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(35, 130);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(116, 130);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // text_day
            // 
            this.text_day.AutoSize = true;
            this.text_day.BackColor = System.Drawing.Color.Transparent;
            this.text_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_day.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_day.Location = new System.Drawing.Point(144, 156);
            this.text_day.Name = "text_day";
            this.text_day.Size = new System.Drawing.Size(33, 16);
            this.text_day.TabIndex = 71;
            this.text_day.Text = "day";
            // 
            // text_time
            // 
            this.text_time.AutoSize = true;
            this.text_time.BackColor = System.Drawing.Color.Transparent;
            this.text_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_time.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_time.Location = new System.Drawing.Point(25, 156);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(36, 16);
            this.text_time.TabIndex = 70;
            this.text_time.Text = "time";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // quenMK
            // 
            this.quenMK.AutoSize = true;
            this.quenMK.Location = new System.Drawing.Point(124, 105);
            this.quenMK.Name = "quenMK";
            this.quenMK.Size = new System.Drawing.Size(80, 13);
            this.quenMK.TabIndex = 73;
            this.quenMK.TabStop = true;
            this.quenMK.Text = "Quên mật khẩu";
            this.quenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quenMK_LinkClicked);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 185);
            this.Controls.Add(this.quenMK);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.text_day);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.mkDangNhap);
            this.Controls.Add(this.tkDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tkDangNhap;
        private System.Windows.Forms.TextBox mkDangNhap;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label text_day;
        private System.Windows.Forms.Label text_time;
        private System.Windows.Forms.Timer ThoiGian;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel quenMK;
    }
}

