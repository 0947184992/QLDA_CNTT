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
    public partial class DuAn : Form
    {

        SqlConnection sqlConnect;
        SqlCommand sqlCommand;
        string strConnect = LibByPhongGio.ConnectString;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        string QueryAll = "select * from DUAN;";
        string QueryKH = "select MaKH, HoTen from KHACHHANG;";

        public DuAn()
        {
            InitializeComponent();
            ShowDataKH(QueryKH);
            ShowData(QueryAll);
            ResetButton();
        }
        public void ResetButton()
        {
            switch (LibByPhongGio.Permission)
            {
                case 1: // admin
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    break;
                case 0: // Nhan Vien
                case 2: // user
                default:
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    break;
            }
        }
        public void ShowDataKH(string QueryCheck)
        {
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.DataSource = GetDataDuAn(QueryCheck).Tables[0];
            //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
            //  dgvDataView.DataMember = "NhanVien";
        }
        public void ShowData(string QueryCheck)
        {
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataView.DataSource = GetDataDuAn(QueryCheck).Tables[0];
            //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
            //  dgvDataView.DataMember = "NhanVien";
        }
        DataSet GetDataDuAn(string Query)
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
                txtMaDA.Text = dgvDataView.Rows[numrow].Cells[0].Value.ToString();
                txtTenDA.Text = dgvDataView.Rows[numrow].Cells[1].Value.ToString();
                cbbLoaiDuAn.Text = dgvDataView.Rows[numrow].Cells[2].Value.ToString();
                txtMaKH.Text = dgvDataView.Rows[numrow].Cells[3].Value.ToString();


                dateBanGiao.Value = (DateTime)dgvDataView.Rows[numrow].Cells[4].Value;
                dateDuKien.Value = (DateTime)dgvDataView.Rows[numrow].Cells[5].Value;
                dateThucTe.Value = (DateTime)dgvDataView.Rows[numrow].Cells[6].Value;

                txtDuKien.Text = dgvDataView.Rows[numrow].Cells[7].Value.ToString();
                txtBanGiao.Text = dgvDataView.Rows[numrow].Cells[8].Value.ToString();
                txtThucTe.Text = dgvDataView.Rows[numrow].Cells[9].Value.ToString();

                if(dgvDataView.Rows[numrow].Cells[10].Value.ToString() == "Hoàn thành")
                {
                    cbbTrangThai.SelectedIndex = 0;
                }
                else
                {
                    cbbTrangThai.SelectedIndex = 1;
                }

                txtTongTienDo.Text = dgvDataView.Rows[numrow].Cells[11].Value.ToString();



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
            string MaDA = txtMaDA.Text.Trim();
            string TenDA = txtTenDA.Text.Trim();
            string LoaiDuAn = cbbLoaiDuAn.Text.Trim();
            string MaKH = txtMaKH.Text.Trim();

            DateTime TGBanGiao = dateBanGiao.Value;
            DateTime TGDuKien = dateDuKien.Value;
            DateTime TGThucTe = dateThucTe.Value;

            float KPDuKien ;
            float KPBanGiao ;
            float KPThucTe;
            string KinhPhi1 = txtDuKien.Text.Trim();
            string KinhPhi2 = txtBanGiao.Text.Trim();
            string KinhPhi3 = txtThucTe.Text.Trim();

            if (float.TryParse(KinhPhi1, out KPDuKien))
            {
                KPDuKien = float.Parse(KinhPhi1);
            }
            else
            {
                KPDuKien = 0;
            }
            if (float.TryParse(KinhPhi2, out KPBanGiao))
            {
                KPBanGiao = float.Parse(KinhPhi2);
            }
            else
            {
                KPBanGiao = 0;
            }
            if (float.TryParse(KinhPhi3, out KPThucTe))
            {
                KPThucTe = float.Parse(KinhPhi3);
            }
            else
            {
                KPThucTe = 0;
            }


            string TrangThaiThanhToan = cbbTrangThai.Text.Trim();
            string TongTienDo = txtTongTienDo.Text.Trim();

            string QueryAdd = "insert into " +
                "DUAN(MaDA, TenDA, LoaiDuAn, MaKH, TGBanGiao, TGDuKien, TGThucTe, KPDuKien, KPBanGiao, KPCuoi, TTThanhToan, TongTienDo) " +
                "values " +
                "('"+ MaDA + "', N'" + TenDA + "', N'" + LoaiDuAn + "', " +
                "'" + MaKH + "', '" + TGBanGiao + "', '" + TGDuKien + "', '" + TGThucTe + "', " +
                "" + KPDuKien + ", " + KPBanGiao + ", " + KPThucTe + ", N'" + TrangThaiThanhToan + "', '" + TongTienDo + "');";

            if (MaDA == "" || TenDA == "" || LoaiDuAn == "" || MaKH == "")
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

            string Query = "select * from DUAN;";
            ShowData(Query);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MaDA = txtMaDA.Text.Trim();
            string TenDA = txtTenDA.Text.Trim();
            string LoaiDuAn = cbbLoaiDuAn.Text.Trim();
            string MaKH = txtMaKH.Text.Trim();

            DateTime TGBanGiao = dateBanGiao.Value;
            DateTime TGDuKien = dateDuKien.Value;
            DateTime TGThucTe = dateThucTe.Value;

            string k1 = txtDuKien.Text.Trim();
            string k2 = txtBanGiao.Text.Trim();
            string k3 = txtThucTe.Text.Trim();
            float KPDuKien ;
            float KPBanGiao;
            float KPThucTe ;
            if (float.TryParse(k1, out KPDuKien))
            {
                KPDuKien = float.Parse(k1);
            }
            else
            {
                KPDuKien = 0;
            }

            if (float.TryParse(k2, out KPBanGiao))
            {
                KPBanGiao = float.Parse(k2);
            }
            else
            {
                KPBanGiao = 0;
            }

            if (float.TryParse(k3, out KPThucTe))
            {
                KPThucTe = float.Parse(k3);
            }
            else
            {
                KPThucTe = 0;
            }

            string TrangThaiThanhToan = cbbTrangThai.Text.Trim();

            string TienDoString = txtTongTienDo.Text.Trim();

            float TongTienDo;


            if (float.TryParse(TienDoString, out TongTienDo))
            {
                TongTienDo = float.Parse(TienDoString);
            }
            else
            {
                TongTienDo = 0;
            }





            string QueryEdit = "UPDATE DUAN " +
                "SET TenDA = N'" + TenDA + "', LoaiDuAn = N'" + LoaiDuAn + "', " +
                "MaKH = N'" + MaKH + "', " +
                "TGBanGiao = '" + TGBanGiao + "', TGDuKien = N'" + TGDuKien + "', TGThucTe = '" + TGThucTe + "', " +
                "KPDuKien = " + KPDuKien + ", KPBanGiao = " + KPBanGiao + ", KPCuoi = " + KPThucTe + ", " +
                "TTThanhToan = N'" + TrangThaiThanhToan + "', TongTienDo = " + TongTienDo + " " +
                "where MaDA = '" + MaDA + "'; ";

            try
            {
                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryEdit, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Sửa thành công Dự án có mã: " + MaDA, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string Query = "select * from DUAN;";
            ShowData(Query);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaDA = txtMaDA.Text.Trim();
            string QueryDelete = "";

            QueryDelete = "delete from DUAN where MaDA = '" + MaDA + "';";

            try
            {

                sqlConnect = new SqlConnection(strConnect);
                sqlConnect.Open();
                sqlCommand = new SqlCommand(QueryDelete, sqlConnect);
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Xóa thành công dự có mã: " + MaDA, "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không tồn tại hoặc sai dữ liệu!", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string Query = "select * from DUAN;";
            ShowData(Query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string DieuKien = txtSearch.Text.Trim();
            string QuerySearch = "select * from DUAN where (MaDA like N'%" + DieuKien + "%' or TenDA like N'%" + DieuKien + "%'  or LoaiDuAn like '%" + DieuKien + "%'  or MaKH like '%" + DieuKien + "%' ); ";
            
            ShowData(QuerySearch);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string DieuKien = txtSearch.Text.Trim();
            string QuerySearch = "select * from DUAN where (MaDA like N'%" + DieuKien + "%' or TenDA like N'%" + DieuKien + "%'  or LoaiDuAn like  N'%" + DieuKien + "%'  or MaKH like '%" + DieuKien + "%' ); ";

            ShowData(QuerySearch);
        }

        private void btnUpdateCV_Click(object sender, EventArgs e)
        {
            string MaDA = txtMaDA.Text.Trim();
            LibByPhongGio.IdDA = MaDA;

            CongViec congViec = new CongViec();
            congViec.Show();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow = e.RowIndex;
                txtMaKH.Text = dgvKH.Rows[numrow].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("NONE VALUE", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
