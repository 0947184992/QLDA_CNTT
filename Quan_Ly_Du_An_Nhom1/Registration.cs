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
    public partial class Registration : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCommand;
        string strConnect = LibByPhongGio.ConnectString;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();

        public Registration()
        {
            InitializeComponent();
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string Tk = txtAccount.Text;
            string Mk = txtPassword.Text;
            string reMk = txtRetype.Text;
            
            if (!LibByPhongGio.CheckStringDacBiet(Tk) || !LibByPhongGio.CheckStringDacBiet(Mk) || !LibByPhongGio.CheckStringDacBiet(reMk))
            {
                MessageBox.Show("EROR!KIỂM TRA DỮ LIỆU NHẬP VÀO!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(Mk.Length < 5)
                {
                    MessageBox.Show("Mật khẩu không được nhỏ hơn 5 kí tự", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Mk != reMk)
                {
                    MessageBox.Show("Mật khẩu không khớp", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SignUpCheck(Tk, Mk);
                }
            }
        }

        void SignUpCheck(string Tk, string Mk)
        {
            sqlConnect = new SqlConnection(strConnect);
            int Quyen = 0;
            if (rdbNhanVien.Checked)
            {
                Quyen = 0;
            }
            else
            {
                Quyen = 2;
            }

            sqlConnect.Open();
            string Query1 = "insert into TAIKHOAN values ('" + Tk + "' , '" + Mk + "', "+ Quyen + "); ";
            sqlCommand = new SqlCommand(Query1, sqlConnect);
            try
            {
                
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                
                MessageBox.Show("Đăng kí thành công", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                DataReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại tài khoản này Hoặc lỗi kết nối!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string CheckML = txtPassword.Text.Trim();

            if(CheckML.Length < 5)
            {
                lblMK.Text = "Mật khẩu phải > 5 kí tự";
            }
            else
            {
                lblMK.Text = "OK";
            }
        }
    }
}
