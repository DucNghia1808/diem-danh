namespace diem_danh
{
    partial class SuaMK
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
            this.HuySuaMK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mkHienTai = new System.Windows.Forms.TextBox();
            this.suaMKbt = new System.Windows.Forms.Button();
            this.suaTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suaMK1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suaXNMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HuySuaMK
            // 
            this.HuySuaMK.Location = new System.Drawing.Point(156, 197);
            this.HuySuaMK.Name = "HuySuaMK";
            this.HuySuaMK.Size = new System.Drawing.Size(75, 23);
            this.HuySuaMK.TabIndex = 11;
            this.HuySuaMK.Text = "Hủy";
            this.HuySuaMK.UseVisualStyleBackColor = true;
            this.HuySuaMK.Click += new System.EventHandler(this.HuySuaMK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // mkHienTai
            // 
            this.mkHienTai.Location = new System.Drawing.Point(177, 84);
            this.mkHienTai.Name = "mkHienTai";
            this.mkHienTai.Size = new System.Drawing.Size(100, 20);
            this.mkHienTai.TabIndex = 9;
            this.mkHienTai.UseSystemPasswordChar = true;
            // 
            // suaMKbt
            // 
            this.suaMKbt.Location = new System.Drawing.Point(75, 197);
            this.suaMKbt.Name = "suaMKbt";
            this.suaMKbt.Size = new System.Drawing.Size(75, 23);
            this.suaMKbt.TabIndex = 8;
            this.suaMKbt.Text = "Đổi MK";
            this.suaMKbt.UseVisualStyleBackColor = true;
            this.suaMKbt.Click += new System.EventHandler(this.suaMKbt_Click);
            // 
            // suaTK
            // 
            this.suaTK.Location = new System.Drawing.Point(177, 48);
            this.suaTK.Name = "suaTK";
            this.suaTK.Size = new System.Drawing.Size(100, 20);
            this.suaTK.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập vào tên tài khoản";
            // 
            // suaMK1
            // 
            this.suaMK1.Location = new System.Drawing.Point(177, 119);
            this.suaMK1.Name = "suaMK1";
            this.suaMK1.Size = new System.Drawing.Size(100, 20);
            this.suaMK1.TabIndex = 12;
            this.suaMK1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Xác nhận mật khẩu ";
            // 
            // suaXNMK
            // 
            this.suaXNMK.Location = new System.Drawing.Point(177, 156);
            this.suaXNMK.Name = "suaXNMK";
            this.suaXNMK.Size = new System.Drawing.Size(100, 20);
            this.suaXNMK.TabIndex = 14;
            this.suaXNMK.UseSystemPasswordChar = true;
            // 
            // SuaMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 268);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.suaXNMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suaMK1);
            this.Controls.Add(this.HuySuaMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mkHienTai);
            this.Controls.Add(this.suaMKbt);
            this.Controls.Add(this.suaTK);
            this.Controls.Add(this.label1);
            this.Name = "SuaMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuySuaMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mkHienTai;
        private System.Windows.Forms.Button suaMKbt;
        private System.Windows.Forms.TextBox suaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suaMK1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox suaXNMK;
    }
}