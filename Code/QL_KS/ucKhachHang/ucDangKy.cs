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
using QL_KS.ucHeThong;

namespace QL_KS.ucKhachHang
{
    public partial class ucDangKy : UserControl
    {
        DataConnection conn;
        public ucDangKy()
        {
            InitializeComponent();
        }
        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPhoneNum.Text == "" || textBoxName.Text == "" || textBoxCMND.Text == "" || textBoxAddr.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    conn = new DataConnection();
                    SqlConnection con = conn.getConnect();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if(textBoxEmail.Text=="")
                    {
                        textBoxEmail.Text = "0";
                    }
                    SqlCommand sqlCmd = new SqlCommand("USP_DangKy_TaiKhoan_KhachHang", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@hoTen", textBoxName.Text);
                    sqlCmd.Parameters.AddWithValue("@tenDangNhap", textBoxUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@matKhau", textBoxPassword.Text);
                    sqlCmd.Parameters.AddWithValue("@moTa", textBoxDescription.Text);
                    sqlCmd.Parameters.AddWithValue("@soCMND", textBoxCMND.Text);
                    sqlCmd.Parameters.AddWithValue("@diaChi", textBoxAddr.Text);
                    sqlCmd.Parameters.AddWithValue("@dienThoai", textBoxPhoneNum.Text);
                    sqlCmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (dt.Rows.Count!=0)
                    {
                        foreach (ucDangKy ucDK in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangKy>())
                        {
                            FormMain.formMain.metroPanelContainer.Controls.Remove(ucDK);
                        }
                        if (ucDatPhong._datPhong != null)
                        {
                            foreach (ucDangKy ucDK in ucDatPhong.datPhong.metroPanelContainer.Controls.OfType<ucDangKy>())
                            {
                                ucDatPhong.datPhong.metroPanelContainer.Controls.Remove(ucDK);
                            }
                        }
                        MessageBox.Show("Đăng ký thành công"+"\n\nMã khách hàng: "+dt.Rows[0]["maKH"]);
                        FormMain.formMain.metrolabelAccount.Text = textBoxName.Text;
                        FormMain.KhachHang.status = true;
                    }
                    Clear();
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

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            ucDangNhap ucDN = new ucDangNhap();
            ucDN.Show();
            FormMain.formMain.metroPanelContainer.Controls.Add(ucDN);
            FormMain.formMain.metroPanelContainer.Controls["ucDangNhap"].BringToFront();
            foreach (ucDangKy ucDK in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangKy>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(ucDK);
            }
            if (ucDatPhong._datPhong != null)
            { 
                foreach (ucDangKy ucDK in ucDatPhong.datPhong.metroPanelContainer.Controls.OfType<ucDangKy>())
                {
                    ucDatPhong.datPhong.metroPanelContainer.Controls.Remove(ucDK);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (ucDangKy ucDK in FormMain.formMain.metroPanelContainer.Controls.OfType<ucDangKy>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(ucDK);
            }
            if (ucDatPhong._datPhong != null)
            {
                foreach (ucDangKy ucDK in ucDatPhong.datPhong.metroPanelContainer.Controls.OfType<ucDangKy>())
                {
                    ucDatPhong.datPhong.metroPanelContainer.Controls.Remove(ucDK);
                }
            }
            
        }

        private void ucDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
