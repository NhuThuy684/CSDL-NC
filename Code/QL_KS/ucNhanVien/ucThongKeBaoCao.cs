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
    public partial class ucThongKeBaoCao : MetroUserControl
    {
        DataConnection conn;
        public ucThongKeBaoCao()
        {
            InitializeComponent();
        }

        //Thống kê theo tháng
        private void buttonThongKe1_Click_1(object sender, EventArgs e)
        {
            conn = new DataConnection();
            SqlConnection Con = conn.getConnect();
            try
            {
                Con.Open();
                string Query = ("USP_DoanhThu_Thang");
                SqlCommand Comm = new SqlCommand(Query, Con);
                Comm.CommandType = CommandType.StoredProcedure;

                Comm.Parameters.AddWithValue("@NgayBD", ThongKe_NgayBD.Value);

                Comm.Parameters.AddWithValue("@NgayKT", ThongKe_NgayKT.Value);

                Comm.Parameters.AddWithValue("@MaKS", FormMain.formMain.metrolabelMaKS.Text);
                Comm.ExecuteNonQuery();


                dsTKBC.ds = new DataSetReport();

                SqlDataReader dr = Comm.ExecuteReader();
                dsTKBC.ds.DoanhThuThang.Load(dr);
                dataGridView1.DataSource = dsTKBC.ds.DoanhThuThang;
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show(@"Không tìm thấy doanh thu của khách sạn trong khoảng thời gian này.");
                }
                else
                {
                    dataGridView1.Columns["doanhThuThang"].DefaultCellStyle.Format = "#,### dong";
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Thống kê theo năm
        private void ButtonThongKe2_Click(object sender, EventArgs e)
        {
            conn = new DataConnection();
            SqlConnection Con = conn.getConnect();
            try
            {
                Con.Open();
                string Query = ("USP_DoanhThu_Nam");
                SqlCommand Comm = new SqlCommand(Query, Con);
                Comm.CommandType = CommandType.StoredProcedure;

                Comm.Parameters.AddWithValue("@NgayBD", ThongKe_Nam_NgayBD.Value);

                Comm.Parameters.AddWithValue("@NgayKT", Thong_Ke_LoaiPhong_NgayKT.Value);

                Comm.Parameters.AddWithValue("@MaKS", FormMain.formMain.metrolabelMaKS.Text);

                Comm.ExecuteNonQuery();

                dsTKBC.ds = new DataSetReport();

                SqlDataReader dr = Comm.ExecuteReader();

                dsTKBC.ds.DoanhThuNam.Load(dr);
                dataGridView2.DataSource = dsTKBC.ds.DoanhThuNam;

                if (dataGridView2.RowCount == 0)
                {
                    MessageBox.Show(@"Không tìm thấy doanh thu của khách sạn trong khoảng thời gian này.");
                }
                else
                {

                    dataGridView2.Columns["doanhThuNam"].DefaultCellStyle.Format = "#,### dong";
                }
                Con.Close();
            }
            catch (Exception)
            {
            }
        }

        //Thống kê doanh thu theo loại phòng
        private void ButtonThongKe3_Click(object sender, EventArgs e)
        {
            conn = new DataConnection();
            SqlConnection Con = conn.getConnect();
            try
            {
                Con.Open();
                string Query = ("USP_DoanhThu_LoaiPhong");
                SqlCommand Comm = new SqlCommand(Query, Con);
                Comm.CommandType = CommandType.StoredProcedure;

                Comm.Parameters.AddWithValue("@NgayBD", ThongKe_LoaiPhong_NgayBD.Value);

                Comm.Parameters.AddWithValue("@NgayKT", ThongKe_LoaiPhong_NgayKT.Value);

                Comm.Parameters.AddWithValue("@MaKS", FormMain.formMain.metrolabelMaKS.Text);

                Comm.ExecuteNonQuery();

                dsTKBC.ds = new DataSetReport();

                SqlDataReader dr = Comm.ExecuteReader();

                dsTKBC.ds.DoanhThuLoaiPhong.Load(dr);
                dataGridView3.DataSource = dsTKBC.ds.DoanhThuLoaiPhong;

                if (dataGridView3.RowCount == 0)
                {
                    MessageBox.Show(@"Không tìm thấy doanh thu của khách sạn trong khoảng thời gian này.");
                }
                else
                {

                    dataGridView3.Columns["doanhThu"].DefaultCellStyle.Format = "#,### dong";
                }
                Con.Close();
            }
            catch (Exception)
            {
            }
        }
        public class dsTKBC
        {
            public static DataSetReport ds;
        }

        private void buttonIn_Doanhthu_LoaiPhong_Click(object sender, EventArgs e)
        {
            ReportDTLoaiPhong rp = new ReportDTLoaiPhong();
            rp.ShowDialog();
        }

        private void buttonIn_DoanhThu_Nam_Click(object sender, EventArgs e)
        {
            ReportDTNam rp = new ReportDTNam();
            rp.ShowDialog();
        }

        private void buttonIn_DoanhThu_Thang_Click(object sender, EventArgs e)
        {
            ReportDTThang rp = new ReportDTThang();
            rp.ShowDialog();
        }
    }
}