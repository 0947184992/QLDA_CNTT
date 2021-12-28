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
        string QueryAll = "select * from CONGVIEC where MaDA = " + LibByPhongGio.IdDA + ";";
        
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

        }
        public void ShowData(string QueryCheck)
        {
            dgvDataViewCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataViewCV.DataSource = GetDataDuAn(QueryCheck).Tables[0];
            //  dgvDataView.Rows[0] = GetDataKhachHang().Tables[0].Rows[0];
            //  dgvDataView.DataMember = "NhanVien";
        }
        public void ShowDataQT(string QueryCheck)
        {
            dgvQT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQT.DataSource = GetDataDuAn(QueryCheck).Tables[0];
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

        private void dgvDataViewCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow = e.RowIndex;
                txtMaCV.Text = dgvDataViewCV.Rows[numrow].Cells[0].Value.ToString();
                txtTenCV.Text = dgvDataViewCV.Rows[numrow].Cells[1].Value.ToString();

                dateBanGiao.Value = (DateTime)dgvDataViewCV.Rows[numrow].Cells[4].Value;
                dateDuKien.Value = (DateTime)dgvDataViewCV.Rows[numrow].Cells[5].Value;
                dateThucTe.Value = (DateTime)dgvDataViewCV.Rows[numrow].Cells[6].Value;

                txtKinhPhiCV.Text = dgvDataViewCV.Rows[numrow].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("NONE VALUE", "TA ĐA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

    }
}
