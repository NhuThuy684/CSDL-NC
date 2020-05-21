namespace QL_KS.ucNhanVien.Report
{
    partial class ReportDTNam
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
            this.crystalReportViewerDTNam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerDTNam
            // 
            this.crystalReportViewerDTNam.ActiveViewIndex = -1;
            this.crystalReportViewerDTNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerDTNam.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerDTNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerDTNam.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerDTNam.Name = "crystalReportViewerDTNam";
            this.crystalReportViewerDTNam.Size = new System.Drawing.Size(704, 351);
            this.crystalReportViewerDTNam.TabIndex = 0;
            this.crystalReportViewerDTNam.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportDTNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 351);
            this.Controls.Add(this.crystalReportViewerDTNam);
            this.Name = "ReportDTNam";
            this.Text = "ReportDTNam";
            this.Load += new System.EventHandler(this.ReportDTNam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerDTNam;
    }
}