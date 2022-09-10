namespace diem_danh
{
    partial class formThemVanTay
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
            this.themTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.themVanTay = new System.Windows.Forms.TextBox();
            this.themChucVu = new System.Windows.Forms.TextBox();
            this.themSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vdsf = new System.Windows.Forms.Label();
            this.themLuu = new System.Windows.Forms.Button();
            this.themHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themTen
            // 
            this.themTen.Location = new System.Drawing.Point(99, 28);
            this.themTen.Name = "themTen";
            this.themTen.Size = new System.Drawing.Size(100, 20);
            this.themTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vân Tay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ";
            // 
            // themVanTay
            // 
            this.themVanTay.Location = new System.Drawing.Point(99, 138);
            this.themVanTay.Name = "themVanTay";
            this.themVanTay.Size = new System.Drawing.Size(100, 20);
            this.themVanTay.TabIndex = 5;
            // 
            // themChucVu
            // 
            this.themChucVu.Location = new System.Drawing.Point(99, 67);
            this.themChucVu.Name = "themChucVu";
            this.themChucVu.Size = new System.Drawing.Size(100, 20);
            this.themChucVu.TabIndex = 7;
            // 
            // themSDT
            // 
            this.themSDT.Location = new System.Drawing.Point(99, 103);
            this.themSDT.Name = "themSDT";
            this.themSDT.Size = new System.Drawing.Size(100, 20);
            this.themSDT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chức vụ";
            // 
            // vdsf
            // 
            this.vdsf.AutoSize = true;
            this.vdsf.Location = new System.Drawing.Point(36, 106);
            this.vdsf.Name = "vdsf";
            this.vdsf.Size = new System.Drawing.Size(29, 13);
            this.vdsf.TabIndex = 10;
            this.vdsf.Text = "SDT";
            // 
            // themLuu
            // 
            this.themLuu.Location = new System.Drawing.Point(39, 182);
            this.themLuu.Name = "themLuu";
            this.themLuu.Size = new System.Drawing.Size(75, 23);
            this.themLuu.TabIndex = 11;
            this.themLuu.Text = "Lưu";
            this.themLuu.UseVisualStyleBackColor = true;
            // 
            // themHuy
            // 
            this.themHuy.Location = new System.Drawing.Point(124, 182);
            this.themHuy.Name = "themHuy";
            this.themHuy.Size = new System.Drawing.Size(75, 23);
            this.themHuy.TabIndex = 12;
            this.themHuy.Text = "Hủy";
            this.themHuy.UseVisualStyleBackColor = true;
            // 
            // formThemVanTay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 234);
            this.Controls.Add(this.themHuy);
            this.Controls.Add(this.themLuu);
            this.Controls.Add(this.vdsf);
            this.Controls.Add(this.themSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.themChucVu);
            this.Controls.Add(this.themVanTay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.themTen);
            this.Name = "formThemVanTay";
            this.Text = "formThemVanTay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox themTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox themVanTay;
        private System.Windows.Forms.TextBox themChucVu;

        private System.Windows.Forms.TextBox themSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vdsf;
        private System.Windows.Forms.Button themLuu;
        private System.Windows.Forms.Button themHuy;
    }
}