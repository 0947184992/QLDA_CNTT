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
        public NhanVien nhanVienForm;
        public DuAn duAnForm;
        public KhachHang khachhangForm;
        public Login loginForm;
        public CongViec congViecForm ;
        public MainForm()
        {
            InitializeComponent();
            ResetTrangThai();
        }
        public void ResetTrangThai()
        {
            if (LibByPhongGio.TrangThaiDangNhap && LibByPhongGio.Permission == 1) // admin
            {
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                menuMainMenu.Enabled = true;

                
                menuCongviecAll.Enabled = true;
                menuNhanVienAll.Enabled = true;
                menuKhachHangAll.Enabled = true;
                menuDuAnAll.Enabled = true;

            }
            else if(LibByPhongGio.TrangThaiDangNhap && LibByPhongGio.Permission == 2)// khach hang
            {
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                menuMainMenu.Enabled = true;

                menuCongviecAll.Enabled = true;
                menuNhanVienAll.Enabled = false;
                menuKhachHangAll.Enabled = false;
                menuDuAnAll.Enabled = true;
            }
            else if (LibByPhongGio.TrangThaiDangNhap && LibByPhongGio.Permission == 0) // nhan vien
            {
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                menuMainMenu.Enabled = true;

                menuCongviecAll.Enabled = true;
                menuNhanVienAll.Enabled = false;
                menuKhachHangAll.Enabled = true;
                menuDuAnAll.Enabled = true;
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
            loginForm = new Login();
            loginForm.Show();
            loginForm.SaveForm(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LibByPhongGio.TrangThaiDangNhap = false;
            LibByPhongGio.Account = "";
            LibByPhongGio.Permission = 0;
            ResetTrangThai();
        }

        private void menuKhachHangAll_Click(object sender, EventArgs e)
        {
            if (khachhangForm == null)
            {
                khachhangForm = new KhachHang();
                khachhangForm.Show();
            }
            else
            {
                khachhangForm.Close();
                khachhangForm = new KhachHang();
                khachhangForm.Show();
            }/*
            khachhangForm = new KhachHang();
            khachhangForm.Show();*/
        }

        private void menuNhanVienView_Click(object sender, EventArgs e)
        {
            if (nhanVienForm == null)
            {
                nhanVienForm = new NhanVien();
                nhanVienForm.Show();
            }
            else
            {
                nhanVienForm.Close();
                nhanVienForm = new NhanVien();
                nhanVienForm.Show();
            }/*
            nhanVienForm = new NhanVien();
            nhanVienForm.Show();*/
        }

        private void menuDuAnView_Click(object sender, EventArgs e)
        {
            if (duAnForm == null)
            {
                duAnForm = new DuAn();
                duAnForm.Show();
            }
            else
            {
                duAnForm.Close();
                duAnForm = new DuAn();
                duAnForm.Show();
            }/*
            duAnForm = new DuAn();
            duAnForm.Show();*/
        }

        private void menuCongViecView_Click(object sender, EventArgs e)
        {
            LibByPhongGio.IdDA = "";
            if (congViecForm == null)
            {
                congViecForm = new CongViec();
                congViecForm.Show();
            }
            else
            {
                congViecForm.Close();
                congViecForm = new CongViec();
                congViecForm.Show();
            }/*
            congViecForm = new CongViec();
            congViecForm.Show();*/
        }
    }
}
