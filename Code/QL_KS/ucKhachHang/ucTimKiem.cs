using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Controls;
using QL_KS.ucHeThong;

namespace QL_KS.ucKhachHang
{
    public partial class ucTimKiem : MetroUserControl
    {
        public class DatPhong
        {
            public static string maKS { get; set; }
            public static string tenKS { get; set; }
            public static DateTime ngayBD { get; set; }
            public static DateTime ngayKT { get; set; }
        }

        private static ucTimKiem _timKiem;

        public static ucTimKiem timKiem
        {
            get
            {
                if (_timKiem == null)
                {
                    _timKiem = new ucTimKiem();
                }
                return _timKiem;
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
        public ucTimKiem()
        {
            InitializeComponent();
        }
        private void ucTimKiem_Load(object sender, EventArgs e)
        {
            cbStar.SelectedItem = "Tất cả";
            dtpBD.MinDate = DateTime.Now.Date;
            dtpT.MinDate = DateTime.Now.Date;
            dgTimKiem.Columns["giaTB"].DefaultCellStyle.Format = "#,### dong";
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            ucManHinhChinh ucMHC = new ucManHinhChinh();
            ucMHC.Dock = DockStyle.Fill;
            FormMain.formMain.metroPanelContainer.Controls.Add(ucMHC);
            FormMain.formMain.metroPanelContainer.Controls["ucManHinhChinh"].BringToFront();
            foreach (ucTimKiem ucTK in FormMain.formMain.metroPanelContainer.Controls.OfType<ucTimKiem>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(ucTK);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new DataConnection();
                SqlConnection con = conn.getConnect();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("TimKiemKhachSan", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ThanhPho", txtCity.Text);
                if (txtHighPrice.Text == "")
                {
                    sqlCmd.Parameters.AddWithValue("@GiaLon", 0);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@GiaLon", int.Parse(txtHighPrice.Text));
                }
                if (txtLowPrice.Text == "")
                {
                    sqlCmd.Parameters.AddWithValue("@GiaBe", 0);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@GiaBe", int.Parse(txtLowPrice.Text));
                }
                if (cbStar.SelectedItem.ToString() == "Tất cả")
                {
                    sqlCmd.Parameters.AddWithValue("@HangSao", 0);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@HangSao", int.Parse(cbStar.SelectedItem.ToString()));
                }
                sqlCmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
                dgTimKiem.DataSource = dt;
                con.Close();
                if (dgTimKiem.Rows.Count == 0)
                {
                    MessageBox.Show("Rất tiếc, không tìm thấy khách sạn nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            if (dgTimKiem.Rows.Count == 0)
            {
                MessageBox.Show("Rất tiếc, không tìm thấy loại phòng phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DatPhong.maKS = dgTimKiem.Rows[dgTimKiem.CurrentRow.Index].Cells["maKS"].Value.ToString();
            DatPhong.tenKS = dgTimKiem.Rows[dgTimKiem.CurrentRow.Index].Cells["tenKS"].Value.ToString();
            DatPhong.ngayBD = dtpBD.Value;
            DatPhong.ngayKT = dtpT.Value;
            ucDatPhong ucDP = new ucDatPhong();
            ucDP.Dock = DockStyle.Fill;
            _timKiem = this;
            ucTimKiem.timKiem.metroPanelContainer.Controls.Add(ucDP);
            ucTimKiem.timKiem.metroPanelContainer.Controls["ucDatPhong"].BringToFront();
        }
        
    }
}
