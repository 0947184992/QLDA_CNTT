using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Du_An_Nhom1
{
    public partial class NhanVien : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCommand;
        string strConnect = LibByPhongGio.ConnectString;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        string QueryAll = "select * from NHANVIEN;";
        public NhanVien()
        {
            InitializeComponent();
            // Show Data
            ShowData(QueryAll);
        }

        public void ShowData(string QueryCheck)
        {
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataView.DataSource = GetDataNhanVien(QueryCheck).Tables[0];
            //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
            //  dgvDataView.DataMember = "NhanVien";
        }

        DataSet GetDataNhanVien(string Query)
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
                txtMaNV.Text = dgvDataView.Rows[numrow].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDataView.Rows[numrow].Cells[1].Value.ToString();


                dateNgaySinh.Value = (DateTime)dgvDataView.Rows[numrow].Cells[2].Value;


                txtDiaChi.Text = dgvDataView.Rows[numrow].Cells[3].Value.ToString();
                txtSDT.Text = dgvDataView.Rows[numrow].Cells[4].Value.ToString();
                txtVitri.Text = dgvDataView.Rows[numrow].Cells[5].Value.ToString();
                txtChucVu.Text = dgvDataView.Rows[numrow].Cells[6].Value.ToString();
                txtLuong.Text = dgvDataView.Rows[numrow].Cells[7].Value.ToString();

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
            string MaNV = txtMaNV.Text.Trim();
            string HoTen = txtHoTen.Text.Trim();
            DateTime NgaySinh = dateNgaySinh.Value;
            string DiaChi = txtDiaChi.Text.Trim();
            string SDT = txtSDT.Text.Trim();
            string ViTri = txtVitri.Text.Trim();
            string ChucVu = txtChucVu.Text.Trim();
            string Luong = txtLuong.Text.Trim();

            string QueryAdd = "insert into NHANVIEN(MaNV, HoTen, NgaySinh, DiaChi, SDT, ViTri, ChucVu, Luong) values " +
                "('" + MaNV + "', N'" + HoTen + "', '" + NgaySinh + "', N'" + DiaChi + "', '" + SDT + "')";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaNV.Text.Trim();
            string QueryDelete = "";
            if (LibByPhongGio.CheckStringDacBiet(MaKH))
            {
                QueryDelete = "delete from KHACHHANG where MaKH = '" + MaKH + "';";
            }
            else
            {
                QueryDelete = "Select * from KHACHHANG;";
            }

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
            string MaKH = txtMaNV.Text.Trim();
            string HoTen = txtHoTen.Text.Trim();
            DateTime NgaySinh = dateNgaySinh.Value;
            string DiaChi = txtDiaChi.Text.Trim();
            string SDT = txtSDT.Text.Trim();

            string QueryEdit = "UPDATE KHACHHANG " +
                "SET HoTen = N'" + HoTen + "', NgaySinh = '" + NgaySinh + "', " +
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

    }
}
