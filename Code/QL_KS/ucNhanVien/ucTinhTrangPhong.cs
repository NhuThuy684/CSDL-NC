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

namespace QL_KS.ucNhanVien
{
    public partial class ucTinhTrangPhong : MetroUserControl
    {
        DataConnection conn;
        public ucTinhTrangPhong()
        {
            InitializeComponent();
        }
        private void ucTinhTrangPhong_Load (object sender, EventArgs e)
        {
            conn = new DataConnection();
            SqlConnection con = conn.getConnect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand sqlCmd = new SqlCommand("USP_LP_KS", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@maKS", int.Parse(FormMain.formMain.metrolabelMaKS.Text));
            SqlDataReader dr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBoxLoaiPhong.DataSource = dt;
            comboBoxLoaiPhong.DisplayMember = "tenLoaiPhong";
            comboBoxLoaiPhong.ValueMember = "tenLoaiPhong";
            con.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            conn = new DataConnection();
            SqlConnection con = conn.getConnect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand sqlCmd = new SqlCommand("USP_KiemTra_TinhTrangPhong", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tenLoaiPhong", comboBoxLoaiPhong.Text);
            sqlCmd.Parameters.AddWithValue("@maKS", int.Parse(FormMain.formMain.metrolabelMaKS.Text));
            sqlCmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value.ToString());
            sqlCmd.ExecuteNonQuery();
            DataTable dtTinhTrangPhong = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dtTinhTrangPhong);
            dataGridViewTTP.DataSource = dtTinhTrangPhong;
            con.Close();
        }

        private void dataGridViewTTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            richTextBoxCT_phong.Text = "Số phòng: " + dataGridViewTTP.Rows[numrow].Cells["soPhong"].Value.ToString() + "\nLoại phòng: " + dataGridViewTTP.Rows[numrow].Cells["tenLoaiPhong"].Value.ToString() + "\nĐơn giá: " + dataGridViewTTP.Rows[numrow].Cells["donGia"].Value.ToString() + "\nMô tả: " + dataGridViewTTP.Rows[numrow].Cells["moTa"].Value.ToString();
        }
    }
}
