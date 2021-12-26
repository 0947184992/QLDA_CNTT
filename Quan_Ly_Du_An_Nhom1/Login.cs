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
                string Query1 = "select * from TAIKHOAN where TenDN = '" + account +"' and MatKhau = '" + password +"';";
                sqlCommand = new SqlCommand(Query1, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                if (DataReader.Read()) {
                    MessageBox.Show("Đăng nhập thành công!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LibByPhongGio.TrangThaiDangNhap = true;
                    LibByPhongGio.Account = account;
                    current.ResetTrangThai();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại! lỗi ex", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            MakeID();
        }
        public void MakeID()
        {
            sqlConnect = new SqlConnection(strConnect);
            try
            {
                sqlConnect.Open();
                string Query1 = "select Quyen from TAIKHOAN where TenDN = '" +LibByPhongGio.Account+ "'; ";
                sqlCommand = new SqlCommand(Query1, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                if (DataReader.Read())
                {
                    
                    LibByPhongGio.Permission = DataReader.GetInt32(0); 
                    MessageBox.Show("Bạn đang đăng nhập tài khoản: " + LibByPhongGio.Account 
                        + " Với quyền: " + LibByPhongGio.Permission
                        , "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnect.Close();
            }
            catch (Exception)
            {
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
