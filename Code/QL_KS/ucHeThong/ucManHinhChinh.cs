using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KS.ucKhachHang;
using QL_KS.ucNhanVien;

namespace QL_KS.ucHeThong
{
    public partial class ucManHinhChinh : UserControl
    {
        public ucManHinhChinh()
        {
            InitializeComponent();
        }

        private void metroTileLogin_Click(object sender, EventArgs e)
        {
            if(FormMain.KhachHang.status==true)
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn đăng nhập bằng tài khoản khác?", "Đăng nhập", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    ucDangNhap ucDN = new ucDangNhap();
                    ucDN.Show();
                    FormMain.formMain.metroPanelContainer.Controls.Add(ucDN);
                    FormMain.formMain.metroPanelContainer.Controls["ucDangNhap"].BringToFront();
                }
            }
            else
            {
                ucDangNhap ucDN = new ucDangNhap();
                ucDN.Show();
                FormMain.formMain.metroPanelContainer.Controls.Add(ucDN);
                FormMain.formMain.metroPanelContainer.Controls["ucDangNhap"].BringToFront();
            }
        }

        private void metroTileSignup_Click(object sender, EventArgs e)
        {
            ucDangKy ucDK = new ucDangKy();
            ucDK.Show();
            FormMain.formMain.metroPanelContainer.Controls.Add(ucDK);
            FormMain.formMain.metroPanelContainer.Controls["ucDangKy"].BringToFront();
        }

        private void metroTileStaff_Click(object sender, EventArgs e)
        {
            if(FormMain.NhanVien.status==true)
            {
                templateNhanVien tpNV = new templateNhanVien();
                tpNV.Dock = DockStyle.Fill;
                FormMain.formMain.metroPanelContainer.Controls.Add(tpNV);
                FormMain.formMain.metroPanelContainer.Controls["templateNhanVien"].BringToFront();
            }
            else
            {
                ucDangNhapNV ucDN = new ucDangNhapNV();
                ucDN.Show();
                FormMain.formMain.metroPanelContainer.Controls.Add(ucDN);
                FormMain.formMain.metroPanelContainer.Controls["ucDangNhapNV"].BringToFront();
            }
            
        }

        private void metroTileLogout_Click(object sender, EventArgs e)
        {
            if (FormMain.KhachHang.status==true || FormMain.NhanVien.status==true)
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    FormMain.formMain.metroLabel.Visible = false;
                    FormMain.formMain.metrolabelAccount.Text = "";
                    FormMain.formMain.metrolabelMaKS.Text = "";
                    FormMain.KhachHang.status = false;
                    FormMain.NhanVien.status = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
            }
        }

        private void metroTileLook_Click(object sender, EventArgs e)
        {
            ucTimKiem ucTK = new ucTimKiem();
            ucTK.Dock = DockStyle.Fill;
            FormMain.formMain.metroPanelContainer.Controls.Add(ucTK);
            FormMain.formMain.metroPanelContainer.Controls["ucTimKiem"].BringToFront();
        }
    }
}
