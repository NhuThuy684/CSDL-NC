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


namespace QL_KS.ucKhachHang
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
        }
        DataConnection conn;
        private void ucDangNhap_Load(object sender, EventArgs e)
        {
            
        }
        
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
                    SqlCommand sqlCmd = new SqlCommand("USP_DangNhap_KhachHang", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@tenDangNhap", textBoxUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@matKhau", textBoxPassword.Text);
                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if(dt.Rows.Count==0)
                    {
                        MessageBox.Show("Tên đăng nhập/Mật khẩu sai");
                    }
                   else
                    {
                        foreach (ucDangNhap ucDN in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangNhap>())
                        {
                            FormMain.formMain.metroPanelContainer.Controls.Remove(ucDN);
                        }


                        if (ucDatPhong._datPhong!=null)
                        {
                            foreach (ucDangNhap ucDN in ucDatPhong.datPhong.metroPanelContainer.Controls.OfType<ucDangNhap>())
                            {
                                ucDatPhong.datPhong.metroPanelContainer.Controls.Remove(ucDN);
                            }
                        }

                        MessageBox.Show("Chào mừng đến với ivivu!\nMã KH: " + dt.Rows[0]["maKH"].ToString() + "\nHọ tên: " + dt.Rows[0]["hoTen"].ToString());
                        FormMain.formMain.metroLabel.Visible = true;
                        FormMain.formMain.metrolabelAccount.Text = dt.Rows[0]["hoTen"].ToString();
                        FormMain.KhachHang.maKH = dt.Rows[0]["maKH"].ToString();
                        FormMain.KhachHang.status = true;
                        Clear();

                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        void Clear()
        {
            textBoxUsername.Text = textBoxPassword.Text = "";
        }

        private void linkLabelRes_Click(object sender, EventArgs e)
        {
            ucDangKy ucDK = new ucDangKy();
            ucDK.Show();
            FormMain.formMain.metroPanelContainer.Controls.Add(ucDK);
            FormMain.formMain.metroPanelContainer.Controls["ucDangKy"].BringToFront();
            foreach (ucDangNhap ucDN in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangNhap>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(ucDN);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (ucDangNhap ucDN in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangNhap>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(ucDN);
            }
            if (ucDatPhong._datPhong != null)
            {
                foreach (ucDangNhap ucDN in ucDatPhong.datPhong.metroPanelContainer.Controls.OfType<ucDangNhap>())
                {
                    ucDatPhong.datPhong.metroPanelContainer.Controls.Remove(ucDN);
                }
            }
            

        }
    }
}
