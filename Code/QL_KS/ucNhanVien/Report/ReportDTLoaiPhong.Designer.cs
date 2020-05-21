namespace QL_KS.ucNhanVien.Report
{
    partial class ReportDTLoaiPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewerDTLoaiPhong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerDTLoaiPhong
            // 
            this.crystalReportViewerDTLoaiPhong.ActiveViewIndex = -1;
            this.crystalReportViewerDTLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerDTLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerDTLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerDTLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerDTLoaiPhong.Name = "crystalReportViewerDTLoaiPhong";
            this.crystalReportViewerDTLoaiPhong.Size = new System.Drawing.Size(820, 342);
            this.crystalReportViewerDTLoaiPhong.TabIndex = 0;
            this.crystalReportViewerDTLoaiPhong.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportDTLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 342);
            this.Controls.Add(this.crystalReportViewerDTLoaiPhong);
            this.Name = "ReportDTLoaiPhong";
            this.Text = "ReportDTLoaiPhong";
            this.Load += new System.EventHandler(this.ReportDTLoaiPhong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerDTLoaiPhong;
    }
}