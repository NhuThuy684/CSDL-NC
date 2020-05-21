namespace QL_KS.ucNhanVien.Report
{
    partial class ReportHD
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
            this.crystalReportViewerHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerHD
            // 
            this.crystalReportViewerHD.ActiveViewIndex = -1;
            this.crystalReportViewerHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerHD.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerHD.Name = "crystalReportViewerHD";
            this.crystalReportViewerHD.Size = new System.Drawing.Size(653, 515);
            this.crystalReportViewerHD.TabIndex = 0;
            this.crystalReportViewerHD.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 515);
            this.Controls.Add(this.crystalReportViewerHD);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHD;
    }
}