using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KS.ucNhanVien.Report
{
    public partial class ReportDTNam : Form
    {
        public ReportDTNam()
        {
            InitializeComponent();
        }

        private void ReportDTNam_Load(object sender, EventArgs e)
        {
            CrystalReportDTNam rp = new CrystalReportDTNam();
            rp.SetDataSource(ucNhanVien.ucThongKeBaoCao.dsTKBC.ds);
            rp.SetParameterValue("maKS", FormMain.NhanVien.maKS);
            crystalReportViewerDTNam.ReportSource = rp;
        }
    }
}
