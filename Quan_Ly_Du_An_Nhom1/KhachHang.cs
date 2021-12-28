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
    public partial class KhachHang : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCommand;
        string strConnect = LibByPhongGio.ConnectString;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        string QueryAll = "select * from KHACHHANG;";
        public KhachHang()
        {
            InitializeComponent();
            // Show Data
            ShowData(QueryAll);
            ResetButton();
        }
        public void ResetButton()
        {
            switch (LibByPhongGio.Permission)
            {
                case 0: // Nhan Vien
                case 1: // admin
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    break;
                case 2: // user
                default:
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    break;
            }
        }
        public void ShowData(string QueryCheck)
        {
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataView.DataSource = GetDataKhachHang(QueryCheck).Tables[0];
          //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
          //  dgvDataView.DataMember = "NhanVien";
        }

        DataSet GetDataKhachHang(string Query)
        {
            sqlConnect = new SqlConnection(strConnect);
            sqlConnect.Open();

            //
            DataSet data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnect);

            adapter.Fill(data);

            sqlConnect.Close();

            return data;
        }

        private void dgvDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow = e.RowIndex;
                txtMaKH.Text = dgvDataView.Rows[numrow].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDataView.Rows[numrow].Cells[1].Value.ToString();


                dateNgaySinh.Value = (DateTime)dgvDataView.Rows[numrow].Cells[2].Value;


                txtDiaChi.Text = dgvDataView.Rows[numrow].Cells[3].Value.ToString();
                txtSDT.Text = dgvDataView.Rows[numrow].Cells[4].Value.ToString();
                //txtTenDN.Text = dgvDataView.Rows[numrow].Cells[5].Value.ToString();
                //txtMatkhau.Text = dgvDataView.Rows[numrow].Cells[6].Value.ToString();

                //cmbQuyen.SelectedIndex = ((int)dgvDataView.Rows[numrow].Cells[7].Value) ;

            }
            catch (Exception)
            {
                MessageBox.Show("NONE VALUE", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text.Trim();
            string HoTen = txtHoTen.Text.Trim();
            DateTime NgaySinh = dateNgaySinh.Value;
            string DiaChi = txtDiaChi.Text.Trim();
            string SDT = txtSDT.Text.Trim();

            string QueryAdd = "insert into KHACHHANG(MaKH, HoTen, NgaySinh, DiaChi, SDT) " +
                "values ('"+ MaKH  + "', N'"+ HoTen + "', '"+NgaySinh+"', N'"+DiaChi+"', '"+SDT+"')";
            if (MaKH == "" || HoTen == "" || DiaChi == "" || SDT == "" || DiaChi == "" || SDT == "" )
            {
                MessageBox.Show("Không được để trống thông tin", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();

                sqlCommand = new SqlCommand(QueryAdd, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Thêm thành công", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đã tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            string Query = "select * from KHACHHANG;";
            ShowData(Query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string DieuKien = txtSearch.Text.Trim();
            string QuerySearch = "";
            if (rdbCheckAll.Checked)
            {
                QuerySearch = "select * from KHACHHANG where (MaKH like N'%"+ DieuKien +"%' or HoTen like N'%"+ DieuKien +"%'  or SDT like '%"+ DieuKien +"%'); ";
            }
            else if (rdbCheckMaKH.Checked)
            {
                QuerySearch = "select * from KHACHHANG where (MaKH like N'%" + DieuKien + "%'); ";
            }
            else if (rdbCheckTenKH.Checked)
            {
                QuerySearch = "select * from KHACHHANG where ( HoTen like N'%" + DieuKien + "%'); ";
            }
            else if (rdbCheckSDT.Checked)
            {
                QuerySearch = "select * from KHACHHANG where (SDT like '%" + DieuKien + "%'); ";
            }
            ShowData(QuerySearch);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text.Trim();
            string QueryDelete = "";
            
            QueryDelete = "delete from KHACHHANG where MaKH = '" + MaKH + "';";
            
            try
            {

                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryDelete, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Xóa thành công khách hàng có mã: " + MaKH, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string Query = "select * from KHACHHANG;";
            ShowData(Query);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text.Trim();
            string HoTen = txtHoTen.Text.Trim();
            DateTime NgaySinh = dateNgaySinh.Value;
            string DiaChi = txtDiaChi.Text.Trim();
            string SDT = txtSDT.Text.Trim();

            string QueryEdit = "UPDATE KHACHHANG " +
                "SET HoTen = N'"+ HoTen + "', NgaySinh = '" + NgaySinh + "', " +
                "DiaChi = N'" + DiaChi + "', SDT = '" + SDT + "' " +
                "where MaKH = '" + MaKH + "'; ";

            try
            {
                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryEdit, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Sửa thành công khách hàng có mã: " + MaKH, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "select * from KHACHHANG;";
            ShowData(Query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string DieuKien = txtSearch.Text.Trim();
            string QuerySearch = "";
            if (rdbCheckAll.Checked)
            {
                QuerySearch = "select * from KHACHHANG where (MaKH like N'%" + DieuKien + "%' or HoTen like N'%" + DieuKien + "%'  or SDT like '%" + DieuKien + "%'); ";
            }
            else if (rdbCheckMaKH.Checked)
            {
                QuerySearch = "select * from KHACHHANG where (MaKH like N'%" + DieuKien + "%'); ";
            }
            else if (rdbCheckTenKH.Checked)
            {
                QuerySearch = "select * from KHACHHANG where ( HoTen like N'%" + DieuKien + "%'); ";
            }
            else if (rdbCheckSDT.Checked)
            {
                QuerySearch = "select * from KHACHHANG where (SDT like '%" + DieuKien + "%'); ";
            }
            ShowData(QuerySearch);
        }
    }
}
