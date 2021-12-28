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
    public partial class CongViec : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCommand;
        string strConnect = LibByPhongGio.ConnectString;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        string QueryAll = "select * from CONGVIEC where MaDA = '" + LibByPhongGio.IdDA + "';";
        string QueryMaCV = "select MACV from CONGVIEC order by MACV";
        public CongViec()
        {
            InitializeComponent();
            if(LibByPhongGio.IdDA.Trim() == "")
            {
                QueryAll = "select * from CONGVIEC";
            }
            else
            {
                QueryAll = "select * from CONGVIEC where MaDA = '" + LibByPhongGio.IdDA + "';";
            }
            // ShowDataQT(QueryQT);
            try{
                ShowData(QueryAll);
            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ như dự án chưa có công việc nào. hãy thêm công việc", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ResetButton();
        }
        public void ResetButton()
        {
            switch (LibByPhongGio.Permission)
            {
                case 0: // Nhan Vien
                case 1: // admin
                    btnAdd.Enabled = true;
                    btnDeleteCV.Enabled = true;
                    btnEdit.Enabled = true;
                    btnAddQT.Enabled = true;
                    btnEditQT.Enabled = true;
                    btnXoaQT.Enabled = true;

                    break;
                case 2: // user
                default:
                    btnAdd.Enabled = false;
                    btnDeleteCV.Enabled = false;
                    btnEdit.Enabled = false;
                    btnAddQT.Enabled = false;
                    btnEditQT.Enabled = false;
                    btnXoaQT.Enabled = false;

                    break;
            }
        }


        void ShowDataMaCV()
        {

            dgvMaCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaCV.DataSource = GetData(QueryMaCV).Tables[0];
        }


        public void ShowData(string QueryCheck)
        {
            ShowDataMaCV();
            txtMaDA.Text = LibByPhongGio.IdDA;
            dgvDataViewCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataViewCV.DataSource = GetData(QueryCheck).Tables[0];
            //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
            //  dgvDataView.DataMember = "NhanVien";
        }
        public void ShowDataQT(string QueryCheck)
        {
            dgvQT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQT.DataSource = GetData(QueryCheck).Tables[0];
            //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
            //  dgvDataView.DataMember = "NhanVien";
        }
        DataSet GetData(string Query)
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

        private void dgvDataViewCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow = e.RowIndex;
                txtMaCV.Text = dgvDataViewCV.Rows[numrow].Cells[0].Value.ToString();
                txtMaCVQT.Text = dgvDataViewCV.Rows[numrow].Cells[0].Value.ToString();

                txtTenCV.Text = dgvDataViewCV.Rows[numrow].Cells[1].Value.ToString();
                txtMaDA.Text = dgvDataViewCV.Rows[numrow].Cells[2].Value.ToString();
                txtMaNV.Text = dgvDataViewCV.Rows[numrow].Cells[3].Value.ToString();
                dateBanGiao.Value = (DateTime)dgvDataViewCV.Rows[numrow].Cells[4].Value;
                dateDuKien.Value = (DateTime)dgvDataViewCV.Rows[numrow].Cells[5].Value;
                dateThucTe.Value = (DateTime)dgvDataViewCV.Rows[numrow].Cells[6].Value;

                txtKinhPhiCV.Text = dgvDataViewCV.Rows[numrow].Cells[7].Value.ToString();

                UpdateQuaTrinh(txtMaCV.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("NONE VALUE", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDA.Text = LibByPhongGio.IdDA;

            }
        }

        void UpdateQuaTrinh(string DieuKien)
        {
            string queryQT = "select * from QUATRINH where MaCV = '"+ DieuKien + "';";
            ShowDataQT(queryQT);
        }

        private void dgvQT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                int numrow = e.RowIndex;
                txtMaQT.Text = dgvQT.Rows[numrow].Cells[0].Value.ToString();
                txtMaCVQT.Text = dgvQT.Rows[numrow].Cells[1].Value.ToString();

                txtMoTa.Text = dgvQT.Rows[numrow].Cells[2].Value.ToString();
                txtTienDo.Text = dgvQT.Rows[numrow].Cells[3].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("NONE VALUE", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        void Search()
        {
            string DieuKien = txtSearch.Text;
            string QuerySearch = "select * from CONGVIEC " +
                "where ( MaCV like N'%" + DieuKien + "%' or TenCV like N'%" + DieuKien + "%' " +
                " or MaDA like N'%" + DieuKien + "%' ) and( MaDA like N'%" + LibByPhongGio.IdDA + "%');";
            ShowData(QuerySearch);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaCV = txtMaCV.Text.Trim();
            string TenCV = txtTenCV.Text.Trim();
            string MaDA = txtMaDA.Text.Trim();
            string MaNV = txtMaNV.Text.Trim();

            DateTime TGBanGiao = dateBanGiao.Value;
            DateTime TGDuKien = dateDuKien.Value;
            DateTime TGThucTe = dateThucTe.Value;
            float KinhPhi;
            string KinhPhiString = txtKinhPhiCV.Text.Trim();
            if(float.TryParse(KinhPhiString, out KinhPhi))
            {
                KinhPhi = float.Parse(KinhPhiString);
            }
            else
            {
                KinhPhi = 0;

            }

            string QueryAddCV = "insert into CONGVIEC(MaCV, TenCV, MaDA, MaNV, TGBanGiao, TGDuKien, TGThucTe, KinhPhi)" +
                "values ('" + MaCV + "', N'" + TenCV + "', N'" + MaDA + "', '" + MaNV + "' " +
                ", '" + TGBanGiao + "', '" + TGDuKien + "', '" + TGThucTe + "', " + KinhPhi + ")";


            if (MaCV == "" || TenCV == "" || MaDA == "" || MaNV == "" )
            {
                MessageBox.Show("Không được để trống thông tin", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();

                sqlCommand = new SqlCommand(QueryAddCV, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Thêm thành công", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đã tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            string Query = "";
            if (LibByPhongGio.IdDA.Trim() != "")
            {
                Query = "select * from CONGVIEC where MaDA = '" + LibByPhongGio.IdDA + "';";
            }
            else
            {
                Query = "select * from CONGVIEC";
            }
            ShowData(Query);
        }

        private void btnAddQT_Click(object sender, EventArgs e)
        {
            string MaCV = txtMaCVQT.Text.Trim();
            string MaQT = txtMaQT.Text.Trim();
            string MoTa = txtMoTa.Text.Trim();
            float TienDo; 
            string TienDoString = txtTienDo.Text.Trim();
            if(float.TryParse(TienDoString, out TienDo))
            {
                TienDo = float.Parse(TienDoString);
            }
            else
            {
                TienDo = 0;
            }


            string QueryAddQT = "insert into QUATRINH( MaQT, MaCV, MoTa, TienDo)" +
                "values ('" + MaQT + "', '" + MaCV + "', N'" + MoTa + "', " + TienDo + ")";

            if (MaCV == "" || MaQT == "" || MoTa == "" )
            {
                MessageBox.Show("Không được để trống thông tin", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();

                sqlCommand = new SqlCommand(QueryAddQT, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Thêm thành công", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đã tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "Select * from QUATRINH where MaCV = '" + MaCV + "'; ";
            ShowDataQT(Query);
        }

        private void btnEditQT_Click(object sender, EventArgs e)
        {
            string MaCV = txtMaCVQT.Text.Trim();
            string MaQT = txtMaQT.Text.Trim();
            string MoTa = txtMoTa.Text.Trim();
            string TienDoString = txtTienDo.Text;

            float TienDo ;
            if (float.TryParse(TienDoString, out TienDo)) { 
                TienDo = float.Parse(TienDoString);
            }
            else
            {
                TienDo = 0;
            }
            string QueryEdit = "UPDATE QUATRINH " +
                "SET MoTa = N'"+ MoTa  + "', TienDo = "+ TienDo +
                " where MaQT = N'"+ MaQT + "' and MaCV = '"+ MaCV + "'; ";


            if (MaQT.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã quá trình!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryEdit, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Sửa thành Quá trình có mã: " + MaQT, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "Select * from QUATRINH where MaCV = '" + MaCV + "'; ";
            ShowDataQT(Query);
        }

        private void btnXoaQT_Click(object sender, EventArgs e)
        {
            string MaQT = txtMaQT.Text.Trim();
            string MaCV = txtMaCVQT.Text.Trim();

            string QueryDelete = "DELETE from QUATRINH where MaQT = N'" + MaQT + "';";
            if(MaQT.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã quá trình!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                sqlConnect = new SqlConnection(strConnect); 
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryDelete, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Xóa thành Quá trình có mã: " + MaQT, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "Select * from QUATRINH where MaCV = '" + MaCV + "'; ";
            ShowDataQT(Query);
        }

        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
           
            string MaCV = txtMaCVQT.Text.Trim();

            string QueryDelete = "DELETE from QUATRINH where MaCV = N'" + MaCV + "';";
            if (MaCV.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã Công việc!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryDelete, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Xóa thành Quá trình có mã cv = " + MaCV, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "Select * from QUATRINH where MaCV = '" + MaCV + "'; ";
            ShowDataQT(Query);



            string QueryDeleteCV = "DELETE from CONGVIEC where MaCV = N'" + MaCV + "';";
            if (MaCV.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã Công việc!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryDeleteCV, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Xóa thành Công việc có mã cv = " + MaCV, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query2 = "";
            if (LibByPhongGio.IdDA.Trim() != "")
            {
                Query2 = "select * from CONGVIEC where MaDA = '" + LibByPhongGio.IdDA + "';";
            }
            else
            {
                Query2 = "select * from CONGVIEC";
            }
            ShowData(Query2);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MaCV = txtMaCV.Text.Trim();
            string TenCV = txtTenCV.Text.Trim();
            string MaDA = txtMaDA.Text.Trim();
            string MaNV = txtMaNV.Text.Trim();

            DateTime TGBanGiao = dateBanGiao.Value;
            DateTime TGDuKien = dateDuKien.Value;
            DateTime TGThucTe = dateThucTe.Value;

            float KinhPhi ;
            string KinhPhiString = txtKinhPhiCV.Text.Trim();

            if (float.TryParse(KinhPhiString, out KinhPhi))
            {
                KinhPhi = float.Parse(KinhPhiString);
            }
            else
            {
                KinhPhi = 0;
            }
            string QueryEdit = "UPDATE CONGVIEC " +
                "SET TenCV = N'"+ TenCV + "', MaNV = N'" + MaNV + "', " +
                "TGBanGiao = '" + TGBanGiao + "', TGDuKien = '"+ TGDuKien + "', TGThucTe = '"+ TGThucTe  + "'," +
                "KinhPhi = "+ KinhPhi +"" +
                "where MaCV = N'"+ MaCV + "'; ; ";


            if (MaCV.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã công việc!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryEdit, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Sửa thành Quá trình có mã: " + MaCV, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "";
            if (LibByPhongGio.IdDA.Trim() != "")
            {
                Query = "select * from CONGVIEC where MaDA = '" + LibByPhongGio.IdDA + "';";
            }
            else
            {
                Query = "select * from CONGVIEC";
            }
            ShowData(Query);
        }
    }
}
