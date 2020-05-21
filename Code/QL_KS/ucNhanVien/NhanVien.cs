using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KS.ucHeThong;
using MetroFramework.Controls;

namespace QL_KS.ucNhanVien
{
    public partial class templateNhanVien : UserControl
    {
        public templateNhanVien()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            ucManHinhChinh ucMHC = new ucManHinhChinh();
            ucMHC.Dock = DockStyle.Fill;
            FormMain.formMain.metroPanelContainer.Controls.Add(ucMHC);
            FormMain.formMain.metroPanelContainer.Controls["ucManHinhChinh"].BringToFront();
            foreach (templateNhanVien tpNV in FormMain.formMain.metroPanelContainer.Controls.OfType<templateNhanVien>())
            {
                FormMain.formMain.metroPanelContainer.Controls.Remove(tpNV);
            }
        }
        public void metroLabel_Click(object sender, EventArgs e)
        {
            MetroLabel ml = (MetroLabel)sender;
            MetroPanel mp = (MetroPanel)ml.Parent;
            MetroPanel mpParent = (MetroPanel)mp.Parent;

            foreach (MetroPanel pChild in mpParent.Controls.OfType<MetroPanel>())
            {
                pChild.Tag = 0;
                //pChild.BackColor = Color.FromArgb(0, 64, 80);
                pChild.BackColor = Color.Teal;
            }

            mpParent.UseCustomBackColor = true;
            mp.Tag = 0;
            mp.BackColor = Color.FromArgb(120, 158, 166);

            NoiDungUserControl(mp.AccessibleName);
        }
        public void NoiDungUserControl(string ucName)
        {
            foreach (UserControl uc in metroPanelContent.Controls.OfType<UserControl>())
            {
                metroPanelContent.Controls.Remove(uc);
            }
            switch (ucName)
            {
                case "ucTinhTrangPhong":
                    {
                        ucTinhTrangPhong uc = new ucTinhTrangPhong();
                        uc.Dock = DockStyle.Fill;
                        metroPanelContent.Controls.Add(uc);
                        metroPanelContent.Controls["ucTinhTrangPhong"].BringToFront();
                    }; break;
                case "ucHoaDon":
                    {
                        ucHoaDon uc = new ucHoaDon();
                        uc.Dock = DockStyle.Fill;
                        metroPanelContent.Controls.Add(uc);
                        metroPanelContent.Controls["ucHoaDon"].BringToFront();
                    }; break;
                case "ucThongKeBaoCao":
                    {
                        ucThongKeBaoCao uc = new ucThongKeBaoCao();
                        uc.Dock = DockStyle.Fill;
                        metroPanelContent.Controls.Add(uc);
                        metroPanelContent.Controls["ucThongKeBaoCao"].BringToFront();
                    }; break;
            }
        }
    }  
}
