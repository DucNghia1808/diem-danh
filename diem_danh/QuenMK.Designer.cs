namespace diem_danh
{
    partial class QuenMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuenTK = new System.Windows.Forms.TextBox();
            this.LayMK = new System.Windows.Forms.Button();
            this.mkHienTai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HuyLayMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào tên tài khoản";
            // 
            // QuenTK
            // 
            this.QuenTK.Location = new System.Drawing.Point(167, 63);
            this.QuenTK.Name = "QuenTK";
            this.QuenTK.Size = new System.Drawing.Size(100, 20);
            this.QuenTK.TabIndex = 1;
            // 
            // LayMK
            // 
            this.LayMK.Location = new System.Drawing.Point(71, 173);
            this.LayMK.Name = "LayMK";
            this.LayMK.Size = new System.Drawing.Size(75, 23);
            this.LayMK.TabIndex = 2;
            this.LayMK.Text = "Lấy lại MK";
            this.LayMK.UseVisualStyleBackColor = true;
            this.LayMK.Click += new System.EventHandler(this.LayMK_Click);
            // 
            // mkHienTai
            // 
            this.mkHienTai.Location = new System.Drawing.Point(167, 117);
            this.mkHienTai.Name = "mkHienTai";
            this.mkHienTai.ReadOnly = true;
            this.mkHienTai.Size = new System.Drawing.Size(100, 20);
            this.mkHienTai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu của bạn";
            // 
            // HuyLayMK
            // 
            this.HuyLayMK.Location = new System.Drawing.Point(152, 173);
            this.HuyLayMK.Name = "HuyLayMK";
            this.HuyLayMK.Size = new System.Drawing.Size(75, 23);
            this.HuyLayMK.TabIndex = 5;
            this.HuyLayMK.Text = "Hủy";
            this.HuyLayMK.UseVisualStyleBackColor = true;
            this.HuyLayMK.Click += new System.EventHandler(this.HuyLayMK_Click);
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 287);
            this.Controls.Add(this.HuyLayMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mkHienTai);
            this.Controls.Add(this.LayMK);
            this.Controls.Add(this.QuenTK);
            this.Controls.Add(this.label1);
            this.Name = "QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuenTK;
        private System.Windows.Forms.Button LayMK;
        private System.Windows.Forms.TextBox mkHienTai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HuyLayMK;
    }
}