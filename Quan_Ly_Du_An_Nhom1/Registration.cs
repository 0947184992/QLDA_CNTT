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
                MessageBox.Show("KIỂM TRA DỮ LIỆU NHẬP VÀO!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Mk != reMk)
                {
                    MessageBox.Show("Mat khau khong trung khop", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            sqlConnect.Open();
            string Query1 = "insert into TAIKHOAN values ('" + Tk + "' , '" + Mk + "', 0); ";
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
    }
}
