namespace diem_danh
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lấyLạiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngSuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.comboPORT = new System.Windows.Forms.ComboBox();
            this.comPortConnect = new System.Windows.Forms.Button();
            this.text_day = new System.Windows.Forms.Label();
            this.text_time = new System.Windows.Forms.Label();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.vàoRaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.lấyLạiMậtKhẩuToolStripMenuItem,
            this.đăngSuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // lấyLạiMậtKhẩuToolStripMenuItem
            // 
            this.lấyLạiMậtKhẩuToolStripMenuItem.Name = "lấyLạiMậtKhẩuToolStripMenuItem";
            this.lấyLạiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lấyLạiMậtKhẩuToolStripMenuItem.Text = "Quên mật khẩu";
            this.lấyLạiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.lấyLạiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngSuấtToolStripMenuItem
            // 
            this.đăngSuấtToolStripMenuItem.Name = "đăngSuấtToolStripMenuItem";
            this.đăngSuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngSuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngSuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngSuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThànhViênToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // thêmThànhViênToolStripMenuItem
            // 
            this.thêmThànhViênToolStripMenuItem.Name = "thêmThànhViênToolStripMenuItem";
            this.thêmThànhViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmThànhViênToolStripMenuItem.Text = "Chỉnh sửa vân tay";
            this.thêmThànhViênToolStripMenuItem.Click += new System.EventHandler(this.thêmThànhViênToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.vàoRaToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Giờ vào";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Giờ ra";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Thông tin liên hệ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Phần mềm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý kết nối hệ thống";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(563, 132);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 26);
            this.button10.TabIndex = 38;
            this.button10.Text = "COM PORT";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // comboPORT
            // 
            this.comboPORT.FormattingEnabled = true;
            this.comboPORT.Location = new System.Drawing.Point(657, 134);
            this.comboPORT.Name = "comboPORT";
            this.comboPORT.Size = new System.Drawing.Size(121, 21);
            this.comboPORT.TabIndex = 35;
            // 
            // comPortConnect
            // 
            this.comPortConnect.Location = new System.Drawing.Point(601, 164);
            this.comPortConnect.Name = "comPortConnect";
            this.comPortConnect.Size = new System.Drawing.Size(154, 31);
            this.comPortConnect.TabIndex = 36;
            this.comPortConnect.Text = "Connect";
            this.comPortConnect.UseVisualStyleBackColor = true;
            this.comPortConnect.Click += new System.EventHandler(this.comPortConnect_Click);
            // 
            // text_day
            // 
            this.text_day.AutoSize = true;
            this.text_day.BackColor = System.Drawing.Color.Transparent;
            this.text_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_day.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_day.Location = new System.Drawing.Point(254, 326);
            this.text_day.Name = "text_day";
            this.text_day.Size = new System.Drawing.Size(33, 16);
            this.text_day.TabIndex = 69;
            this.text_day.Text = "day";
            // 
            // text_time
            // 
            this.text_time.AutoSize = true;
            this.text_time.BackColor = System.Drawing.Color.Transparent;
            this.text_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_time.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_time.Location = new System.Drawing.Point(90, 326);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(36, 16);
            this.text_time.TabIndex = 68;
            this.text_time.Text = "time";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // vàoRaToolStripMenuItem
            // 
            this.vàoRaToolStripMenuItem.Name = "vàoRaToolStripMenuItem";
            this.vàoRaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vàoRaToolStripMenuItem.Text = "Vào ra";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_day);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.comboPORT);
            this.Controls.Add(this.comPortConnect);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "formMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngSuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmThànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem lấyLạiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboPORT;
        private System.Windows.Forms.Button comPortConnect;
        private System.Windows.Forms.Label text_day;
        private System.Windows.Forms.Label text_time;
        private System.Windows.Forms.Timer ThoiGian;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem vàoRaToolStripMenuItem;
    }
}