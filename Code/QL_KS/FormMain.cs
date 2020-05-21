using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using QL_KS.ucHeThong;
using QL_KS.ucKhachHang;


namespace QL_KS
{
     
    public partial class FormMain : MetroForm
    {
        private static FormMain _formMain;

        public static FormMain formMain
        {
            get
            {
                if(_formMain == null)
                {
                    _formMain = new FormMain();
                }
                return _formMain;
            }
        }
        
        public MetroPanel metroPanelContainer
        {
            get
            {
                return this.metroPanelChinh;
            }
            set
            {
                this.metroPanelChinh = value;
            }
        }

        public MetroLabel metrolabelMaKS
        {
            get
            {
                return this.metroLabelMaKS;
            }
            set
            {
                this.metroLabelMaKS = value;
            }
        }

        public MetroLabel metrolabelAccount
        {
            get
            {
                return this.metroLabelAccount;
            }
            set
            {
                this.metroLabelAccount = value;
            }
        }
        public MetroLabel metroLabel
        {
            get
            {
                return this.metroLabel1;
            }
            set
            {

            }
        }
        public class KhachHang
        {
            public static bool status { get; set; }
            public static string maKH { get; set; }
        }
        
        public class NhanVien
        {
            
            public static bool status { get; set; }
            public static string maKS { get; set; }
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _formMain = this;
            ucManHinhChinh ucMHC = new ucManHinhChinh();
            ucMHC.Dock = DockStyle.Fill;
            _formMain.metroPanelContainer.Controls.Add(ucMHC);
            _formMain.metroPanelContainer.Controls["ucManHinhChinh"].BringToFront();
            _formMain.metroLabel1.Visible = false;
        }
    }
}
