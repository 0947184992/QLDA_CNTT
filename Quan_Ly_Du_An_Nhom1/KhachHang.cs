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
       
        public KhachHang()
        {
            InitializeComponent();
            // Show Data
            ShowData();
        }
        
        public void ShowData()
        {
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataView.DataSource = GetDataKhachHang().Tables[0];
          //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
          //  dgvDataView.DataMember = "NhanVien";
        }

        DataSet GetDataKhachHang()
        {
            sqlConnect = new SqlConnection(strConnect);
            sqlConnect.Open();

            string Query1 = "select * from KHACHHANG;";
            DataSet data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Query1, sqlConnect);

            adapter.Fill(data);

            sqlConnect.Close();

            return data;
        }

        private void dgvDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            txtMaKH.Text = dgvDataView.Rows[numrow].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDataView.Rows[numrow].Cells[1].Value.ToString();


            dateNgaySinh.Value = (DateTime) dgvDataView.Rows[numrow].Cells[2].Value;


            txtDiaChi.Text = dgvDataView.Rows[numrow].Cells[3].Value.ToString();
            txtSDT.Text = dgvDataView.Rows[numrow].Cells[4].Value.ToString();
        }

    }
}
