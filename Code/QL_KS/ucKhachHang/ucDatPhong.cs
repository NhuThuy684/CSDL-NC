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

namespace QL_KS.ucKhachHang
{
    public partial class ucDatPhong : MetroUserControl
    {
        public static ucDatPhong _datPhong;
        int temp=1;
        public static ucDatPhong datPhong
        {
            get
            {
                
                if (_datPhong == null)
                {
                    _datPhong = new ucDatPhong();
                }
                return _datPhong;
            }
            
        }

        public MetroPanel metroPanelContainer
        {
            get
            {
                return this.metroPanelContent;
            }
            set
            {
                this.metroPanelContent = value;
            }
        }
        DataConnection conn;
        public ucDatPhong()
        {
            InitializeComponent();
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            foreach (ucDatPhong ucDP in ucTimKiem.timKiem.metroPanelContainer.Controls.OfType<ucDatPhong>())
            {
                ucTimKiem.timKiem.metroPanelContainer.Controls.Remove(ucDP);
            }
        }
        private void ucDatPhong_Load(object sender, EventArgs e)
        {
            dtpBD.MinDate = DateTime.Now.Date;
            dtpBD.Value= 
            dtpT.MinDate = DateTime.Now.Date;
            dgDatPhong.Columns["donGia"].DefaultCellStyle.Format = "#,### dong";
            try
            {
                dtpBD.Value = ucTimKiem.DatPhong.ngayBD;
                dtpT.Value = ucTimKiem.DatPhong.ngayKT;
                lbTenKS.Text += ucTimKiem.DatPhong.tenKS;
                conn = new DataConnection();
                SqlConnection con = conn.getConnect();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("USP_LoaiPhongCoTheDat", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                
                sqlCmd.Parameters.AddWithValue("@ngayBatDau", ucTimKiem.DatPhong.ngayBD);
                sqlCmd.Parameters.AddWithValue("@ngayTraPhong", ucTimKiem.DatPhong.ngayKT);
                sqlCmd.Parameters.AddWithValue("@maKS", ucTimKiem.DatPhong.maKS);
                sqlCmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
                dgDatPhong.DataSource = dt;
                con.Close();
                if (dgDatPhong.Rows.Count == 0)
                {
                    MessageBox.Show("Rất tiếc, đã hết phòng\nBạn có thể đặt phòng vào ngày khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btDatPhong_Click(object sender, EventArgs e)
        {

            try
            {
                if (FormMain.KhachHang.status!=true)
                {
                    DialogResult dlr = MessageBox.Show("Hãy đăng nhập để đặt phòng nhé!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                   
                    if (dlr == DialogResult.Yes)
                    {
                        ucDangNhap ucDN = new ucDangNhap();
                        ucDN.Show();
                        
                        _datPhong = this;
                        _datPhong.metroPanelContainer.Controls.Add(ucDN);
                        _datPhong.metroPanelContainer.Controls["ucDangNhap"].BringToFront();
                        
                            
                    }
                   
                }
                else
                {
                    SqlConnection con = conn.getConnect();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand sqlCmd = new SqlCommand("USP_DatPhong", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@malphong", dgDatPhong.Rows[dgDatPhong.CurrentRow.Index].Cells["maLoaiPhong"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@makh", FormMain.KhachHang.maKH);
                    sqlCmd.Parameters.AddWithValue("ngayBD", dtpBD.Value);
                    sqlCmd.Parameters.AddWithValue("ngayT", dtpT.Value);
                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đặt phòng thành công");
                    }

                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btPhongTrong_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new DataConnection();
                SqlConnection con = conn.getConnect();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("USP_LoaiPhongCoTheDat", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ngayBatDau", dtpBD.Value);
                sqlCmd.Parameters.AddWithValue("@ngayTraPhong", dtpT.Value);
                sqlCmd.Parameters.AddWithValue("@maKS", ucTimKiem.DatPhong.maKS);
                sqlCmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
                dgDatPhong.DataSource = dt;
                con.Close();
                if (dgDatPhong.Rows.Count == 0)
                {
                    MessageBox.Show("Rất tiếc, đã hết phòng\nBạn có thể đặt phòng vào ngày khác!", "Thông báo");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
