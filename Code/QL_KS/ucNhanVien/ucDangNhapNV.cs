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
using QL_KS.ucHeThong;
using QL_KS.ucNhanVien;


namespace QL_KS.ucNhanVien
{
    public partial class ucDangNhapNV : UserControl
    {
        public ucDangNhapNV()
        {
            InitializeComponent();
        }
        DataConnection conn;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập/Mật khẩu không được trống");
                }
                else
                {
                    conn = new DataConnection();
                    SqlConnection con = conn.getConnect();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand sqlCmd = new SqlCommand("USP_DangNhap_NhanVien", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@tenDangNhap", textBoxUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@matKhau", textBoxPassword.Text);
                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if(dt.Rows.Count!=0)
                    {
                        foreach (ucDangNhapNV ucDN in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangNhapNV>())
                        {
                            FormMain.formMain.metroPanelContainer.Controls.Remove(ucDN);
                        }
                        MessageBox.Show("Chào mừng đến với ivivu!\nMã NV: " + dt.Rows[0]["maNV"].ToString() + "\nHọ tên: " + dt.Rows[0]["hoTen"].ToString());
                        FormMain.formMain.metroLabel.Visible = true;
                        FormMain.formMain.metrolabelAccount.Text = dt.Rows[0]["hoTen"].ToString();
                        FormMain.formMain.metrolabelMaKS.Text = dt.Rows[0]["maKS"].ToString();
                        FormMain.NhanVien.maKS = dt.Rows[0]["maKS"].ToString();
                        FormMain.NhanVien.status = true;

                        templateNhanVien tpNV = new templateNhanVien();
                        tpNV.Dock = DockStyle.Fill;
                        FormMain.formMain.metroPanelContainer.Controls.Add(tpNV);
                        FormMain.formMain.metroPanelContainer.Controls["templateNhanVien"].BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập/Mật khẩu sai");
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (ucDangNhapNV ucDN in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangNhapNV>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(ucDN);
            }
        }
    }
}
