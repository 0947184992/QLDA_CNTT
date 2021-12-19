
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
            this.xemTấtCảToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVienAll = new System.Windows.Forms.ToolStripMenuItem();
            this.xemTấtCảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHangAll = new System.Windows.Forms.ToolStripMenuItem();
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
            this.kháchHàngToolStripMenuItem});
            this.menuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(872, 24);
            this.menuMainMenu.TabIndex = 1;
            this.menuMainMenu.Text = "menuStrip1";
            // 
            // menuDuAnAll
            // 
            this.menuDuAnAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemTấtCảToolStripMenuItem2});
            this.menuDuAnAll.Name = "menuDuAnAll";
            this.menuDuAnAll.Size = new System.Drawing.Size(50, 20);
            this.menuDuAnAll.Text = "Dự án";
            // 
            // xemTấtCảToolStripMenuItem2
            // 
            this.xemTấtCảToolStripMenuItem2.Name = "xemTấtCảToolStripMenuItem2";
            this.xemTấtCảToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.xemTấtCảToolStripMenuItem2.Text = "Xem tất cả";
            // 
            // menuNhanVienAll
            // 
            this.menuNhanVienAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemTấtCảToolStripMenuItem1});
            this.menuNhanVienAll.Name = "menuNhanVienAll";
            this.menuNhanVienAll.Size = new System.Drawing.Size(73, 20);
            this.menuNhanVienAll.Text = "Nhân viên";
            // 
            // xemTấtCảToolStripMenuItem1
            // 
            this.xemTấtCảToolStripMenuItem1.Name = "xemTấtCảToolStripMenuItem1";
            this.xemTấtCảToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xemTấtCảToolStripMenuItem1.Text = "Xem tất cả";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhachHangAll});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // menuKhachHangAll
            // 
            this.menuKhachHangAll.Name = "menuKhachHangAll";
            this.menuKhachHangAll.Size = new System.Drawing.Size(180, 22);
            this.menuKhachHangAll.Text = "Xem tất cả";
            this.menuKhachHangAll.Click += new System.EventHandler(this.menuKhachHangAll_Click);
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
        private System.Windows.Forms.ToolStripMenuItem xemTấtCảToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVienAll;
        private System.Windows.Forms.ToolStripMenuItem xemTấtCảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHangAll;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangXuat;
    }
}