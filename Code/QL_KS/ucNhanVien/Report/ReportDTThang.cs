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
    public partial class ReportDTThang : Form
    {
        public ReportDTThang()
        {
            InitializeComponent();
        }

        private void ReportDTThang_Load(object sender, EventArgs e)
        {
            CrystalReportDTThang rp = new CrystalReportDTThang();
            rp.SetDataSource(ucNhanVien.ucThongKeBaoCao.dsTKBC.ds);
            rp.SetParameterValue("maKS", FormMain.NhanVien.maKS);
            crystalReportViewerDTThang.ReportSource = rp;
        }
    }
}
