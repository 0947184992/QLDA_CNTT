using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_Ly_Du_An_Nhom1
{
    public partial class Login : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCommand;
        string strConnect = LibByPhongGio.ConnectString;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        Registration SignUp;
        MainForm current; 
        private void LoginCheck(string account, string password)
        {
            sqlConnect = new SqlConnection(strConnect);
            try
            {
                sqlConnect.Open();
                string Query1 = "select * from TAIKHOAN where TaiKhoan = '"+ account +"' and MatKhau = '" + password +"';";
                sqlCommand = new SqlCommand(Query1, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                if (DataReader.Read()) {
                    MessageBox.Show("Đăng nhập thành công!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LibByPhongGio.TrangThaiDangNhap = true;
                    current.ResetTrangThai();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Đăng nhập thất bại!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string Tk = txtAccount.Text;
            string  Mk = txtPassword.Text;
            if(!LibByPhongGio.CheckStringDacBiet(Tk) || !LibByPhongGio.CheckStringDacBiet(Mk))
            {
                MessageBox.Show("KIỂM TRA DỮ LIỆU NHẬP VÀO!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoginCheck(Tk, Mk);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(SignUp == null)
            {
                SignUp = new Registration();
                SignUp.Show();
            }
            else
            {
                SignUp.Close();
                SignUp = new Registration();
                SignUp.Show();
            }
        }

        public void SaveForm(MainForm main)
        {
            current = main;
        }
    }
}
