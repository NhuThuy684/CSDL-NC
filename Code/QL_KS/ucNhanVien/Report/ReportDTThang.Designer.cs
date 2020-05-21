namespace QL_KS.ucNhanVien.Report
{
    partial class ReportDTThang
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
            this.crystalReportViewerDTThang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerDTThang
            // 
            this.crystalReportViewerDTThang.ActiveViewIndex = -1;
            this.crystalReportViewerDTThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerDTThang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerDTThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerDTThang.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerDTThang.Name = "crystalReportViewerDTThang";
            this.crystalReportViewerDTThang.Size = new System.Drawing.Size(813, 356);
            this.crystalReportViewerDTThang.TabIndex = 0;
            this.crystalReportViewerDTThang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportDTThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 356);
            this.Controls.Add(this.crystalReportViewerDTThang);
            this.Name = "ReportDTThang";
            this.Text = "ReportDTThang";
            this.Load += new System.EventHandler(this.ReportDTThang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerDTThang;
    }
}