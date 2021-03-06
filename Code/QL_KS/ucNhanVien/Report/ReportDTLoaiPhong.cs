﻿using System;
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
    public partial class ReportDTLoaiPhong : Form
    {
        public ReportDTLoaiPhong()
        {
            InitializeComponent();
        }
        private void ReportDTLoaiPhong_Load(object sender, EventArgs e)
        {
            CrystalReportDTLoaiPhong rp = new CrystalReportDTLoaiPhong();
            rp.SetDataSource(ucNhanVien.ucThongKeBaoCao.dsTKBC.ds);
            rp.SetParameterValue("maKS", FormMain.NhanVien.maKS);
            crystalReportViewerDTLoaiPhong.ReportSource = rp;
        }
    }
}
