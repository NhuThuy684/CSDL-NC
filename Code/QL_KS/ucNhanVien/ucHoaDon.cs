using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Data.SqlClient;
using QL_KS.ucHeThong;
using QL_KS.ucNhanVien.Report;

namespace QL_KS.ucNhanVien
{
    public partial class ucHoaDon : MetroUserControl
    {
        public ucHoaDon()
        {
            InitializeComponent();
        }
        DataConnection conn;

        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["donGia"].DefaultCellStyle.Format = "#,### dong";
            dataGridView1.Columns["tongTien"].DefaultCellStyle.Format = "#,### dong";

            dtHD.dt = new DataTable();
            dtHD.dt.Columns.Add("maHD");
            dtHD.dt.Columns.Add("ngayThanhToan");
            dtHD.dt.Columns.Add("tongTien");
            dtHD.dt.Columns.Add("maDP");
            dtHD.dt.Columns.Add("maKH");
            dtHD.dt.Columns.Add("hoTen");
            dtHD.dt.Columns.Add("ngayBatDau");
            dtHD.dt.Columns.Add("ngayTraPhong");
            dtHD.dt.Columns.Add("donGia");
            dtHD.dt.Rows.Add();
        }

        public class dtHD
        {
            public static DataTable dt;
        }
        
        private void buttonLapHD_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhToan.Visible = true;
                if (textBoxLapHD.Text == "")
                    MessageBox.Show("Mã hóa đơn không được trống!");
                else
                {
                    conn = new DataConnection();
                    SqlConnection con = conn.getConnect();
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand sqlCmd = new SqlCommand("USP_LAPHOADON", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@maDP", textBoxLapHD.Text);
                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.RowCount > 0)
                    {
                        DateTime temp2 = Convert.ToDateTime(dt.Rows[0]["ngayThanhToan"]);
                        DateTime temp1 = DateTime.Now;
                        TimeSpan result = temp1.Subtract(temp2);
                        if (result.Minutes <= 5)
                            ThanhToan.Text = "Hóa đơn chưa được thanh toán!";
                        else
                            ThanhToan.Text = "Hóa đơn đã được thanh toán trước đó!";
                    }
                    else
                    {
                        ThanhToan.Text=("Không tìm thấy mã đặt phòng");
                    }
                    con.Close();          
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhToan.Visible = false;
                if (textBoxMaKH.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã khách hàng!");
                else
                {
                    conn = new DataConnection();
                    SqlConnection con = conn.getConnect();
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand sqlCmd = new SqlCommand("USP_TimKiemThongTinHoaDon", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@maKH", textBoxMaKH.Text);

                    DateTime TEMP3 = Convert.ToDateTime(dateTimePicker1.Value);
                    sqlCmd.Parameters.AddWithValue("@ngayLapHD", TEMP3);

                    sqlCmd.Parameters.AddWithValue("@maKS", FormMain.NhanVien.maKS);

                    if (textBoxTongTien.Text == "")
                    {
                        textBoxTongTien.Text = "0";
                    }
                    sqlCmd.Parameters.AddWithValue("@tongTien", textBoxTongTien.Text);

                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    if(dt.Rows.Count==0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin phù hợp");
                    }

                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportHD rp = new ReportHD();
            rp.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            dtHD.dt.Rows[0]["maHD"] = dataGridView1.Rows[rowIndex].Cells["maHD"].Value.ToString();
            dtHD.dt.Rows[0]["ngayThanhToan"] = dataGridView1.Rows[rowIndex].Cells["ngayThanhToan"].Value.ToString();
            dtHD.dt.Rows[0]["tongTien"] = dataGridView1.Rows[rowIndex].Cells["tongTien"].Value.ToString();
            dtHD.dt.Rows[0]["maDP"] = dataGridView1.Rows[rowIndex].Cells["maDP"].Value.ToString();
            dtHD.dt.Rows[0]["maKH"] = dataGridView1.Rows[rowIndex].Cells["maKH"].Value.ToString();
            dtHD.dt.Rows[0]["hoTen"] = dataGridView1.Rows[rowIndex].Cells["hoTen"].Value.ToString();
            dtHD.dt.Rows[0]["ngayBatDau"] = dataGridView1.Rows[rowIndex].Cells["ngayBatDau"].Value.ToString();
            dtHD.dt.Rows[0]["ngayTraPhong"] = dataGridView1.Rows[rowIndex].Cells["ngayTraPhong"].Value.ToString();
            dtHD.dt.Rows[0]["donGia"] = dataGridView1.Rows[rowIndex].Cells["donGia"].Value.ToString();
        }

    }
}