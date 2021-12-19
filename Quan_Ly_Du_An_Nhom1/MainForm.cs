using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Du_An_Nhom1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ResetTrangThai();
        }
        public void ResetTrangThai()
        {
            if (LibByPhongGio.TrangThaiDangNhap)
            {
                menuMainMenu.Enabled = true;
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
            }
            else
            {
                menuMainMenu.Enabled = false;
                btnDangNhap.Enabled = true;
                btnDangXuat.Enabled = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            loginForm.SaveForm(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LibByPhongGio.TrangThaiDangNhap = false;
            ResetTrangThai();
        }

        private void menuKhachHangAll_Click(object sender, EventArgs e)
        {
            KhachHang khachhangForm = new KhachHang();
            khachhangForm.Show();
        }
    }
}
