using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KS.ucNhanVien;
using QL_KS.ucNhanVien.Report;

namespace QL_KS.ucNhanVien.Report
{
    public partial class ReportHD : Form
    {
        public ReportHD()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            DataSetReport ds = new DataSetReport();
            string maHD, ngayThanhToan, tongTien, maDP, maKH, hoTen, ngayBatDau, ngayTraPhong, donGia;
            maHD = ucHoaDon.dtHD.dt.Rows[0]["maHD"].ToString();
            ngayThanhToan = ucHoaDon.dtHD.dt.Rows[0]["ngayThanhToan"].ToString();
            tongTien = ucHoaDon.dtHD.dt.Rows[0]["tongTien"].ToString();
            maDP = ucHoaDon.dtHD.dt.Rows[0]["maDP"].ToString();
            maKH = ucHoaDon.dtHD.dt.Rows[0]["maKH"].ToString();
            hoTen = ucHoaDon.dtHD.dt.Rows[0]["hoTen"].ToString();
            ngayBatDau = ucHoaDon.dtHD.dt.Rows[0]["ngayBatDau"].ToString();
            ngayTraPhong = ucHoaDon.dtHD.dt.Rows[0]["ngayTraPhong"].ToString();
            donGia = ucHoaDon.dtHD.dt.Rows[0]["donGia"].ToString();

            ds.TT_HoaDon.AddTT_HoaDonRow(maHD, ngayThanhToan,  int.Parse(tongTien), maDP, maKH, hoTen, ngayBatDau, ngayTraPhong, int.Parse(donGia));
            
            CrystalReportHoaDon rp = new CrystalReportHoaDon();
            rp.SetDataSource(ds);
            rp.SetParameterValue("maKS", FormMain.NhanVien.maKS);
            crystalReportViewerHD.ReportSource = rp;           
        }
    }
}
