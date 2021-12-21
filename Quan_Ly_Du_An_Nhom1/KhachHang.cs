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
                txtTenDN.Text = dgvDataView.Rows[numrow].Cells[5].Value.ToString();
                txtMatkhau.Text = dgvDataView.Rows[numrow].Cells[6].Value.ToString();

                cmbQuyen.SelectedIndex = ((int)dgvDataView.Rows[numrow].Cells[7].Value) ;

            }
            catch (Exception)
            {
                MessageBox.Show("NONE VALUE", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string DieuKien = txtSearch.Text;

            string QuerySearch = "select * from KHACHHANG where ;";

            ShowData(QuerySearch);

        }
    }
}
