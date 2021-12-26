
namespace Quan_Ly_Du_An_Nhom1
{
    partial class MainForm
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
            this.menuMainMenu = new System.Windows.Forms.MenuStrip();
            this.menuDuAnAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuAnView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVienAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVienView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHangAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHangView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCongviecAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCongViecView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.menuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainMenu
            // 
            this.menuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDuAnAll,
            this.menuNhanVienAll,
            this.menuKhachHangAll,
            this.menuCongviecAll});
            this.menuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(872, 24);
            this.menuMainMenu.TabIndex = 1;
            this.menuMainMenu.Text = "menuStrip1";
            // 
            // menuDuAnAll
            // 
            this.menuDuAnAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDuAnView});
            this.menuDuAnAll.Name = "menuDuAnAll";
            this.menuDuAnAll.Size = new System.Drawing.Size(50, 20);
            this.menuDuAnAll.Text = "Dự án";
            // 
            // menuDuAnView
            // 
            this.menuDuAnView.Name = "menuDuAnView";
            this.menuDuAnView.Size = new System.Drawing.Size(130, 22);
            this.menuDuAnView.Text = "Xem tất cả";
            // 
            // menuNhanVienAll
            // 
            this.menuNhanVienAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVienView});
            this.menuNhanVienAll.Name = "menuNhanVienAll";
            this.menuNhanVienAll.Size = new System.Drawing.Size(73, 20);
            this.menuNhanVienAll.Text = "Nhân viên";
            // 
            // menuNhanVienView
            // 
            this.menuNhanVienView.Name = "menuNhanVienView";
            this.menuNhanVienView.Size = new System.Drawing.Size(180, 22);
            this.menuNhanVienView.Text = "Xem tất cả";
            this.menuNhanVienView.Click += new System.EventHandler(this.menuNhanVienView_Click);
            // 
            // menuKhachHangAll
            // 
            this.menuKhachHangAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhachHangView});
            this.menuKhachHangAll.Name = "menuKhachHangAll";
            this.menuKhachHangAll.Size = new System.Drawing.Size(82, 20);
            this.menuKhachHangAll.Text = "Khách hàng";
            // 
            // menuKhachHangView
            // 
            this.menuKhachHangView.Name = "menuKhachHangView";
            this.menuKhachHangView.Size = new System.Drawing.Size(130, 22);
            this.menuKhachHangView.Text = "Xem tất cả";
            this.menuKhachHangView.Click += new System.EventHandler(this.menuKhachHangAll_Click);
            // 
            // menuCongviecAll
            // 
            this.menuCongviecAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCongViecView});
            this.menuCongviecAll.Name = "menuCongviecAll";
            this.menuCongviecAll.Size = new System.Drawing.Size(72, 20);
            this.menuCongviecAll.Text = "Công việc";
            // 
            // menuCongViecView
            // 
            this.menuCongViecView.Name = "menuCongViecView";
            this.menuCongViecView.Size = new System.Drawing.Size(180, 22);
            this.menuCongViecView.Text = "Xem tất cả";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(405, 1);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(486, 1);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 417);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.menuMainMenu);
            this.MainMenuStrip = this.menuMainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuMainMenu.ResumeLayout(false);
            this.menuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDuAnAll;
        private System.Windows.Forms.ToolStripMenuItem menuDuAnView;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVienAll;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVienView;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHangAll;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHangView;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuCongviecAll;
        private System.Windows.Forms.ToolStripMenuItem menuCongViecView;
    }
}