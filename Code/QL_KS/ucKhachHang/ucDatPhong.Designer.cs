namespace QL_KS.ucKhachHang
{
    partial class ucDatPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpT = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanelContent = new MetroFramework.Controls.MetroPanel();
            this.lbTenKS = new MetroFramework.Controls.MetroLabel();
            this.btPhongTrong = new System.Windows.Forms.Button();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.btDatPhong = new System.Windows.Forms.Button();
            this.dgDatPhong = new System.Windows.Forms.DataGridView();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpT
            // 
            this.dtpT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpT.Location = new System.Drawing.Point(317, 17);
            this.dtpT.Name = "dtpT";
            this.dtpT.Size = new System.Drawing.Size(115, 20);
            this.dtpT.TabIndex = 16;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.Image = global::QL_KS.Properties.Resources.imgTroVe;
            this.pictureBoxBack.Location = new System.Drawing.Point(765, 3);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(52, 46);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 3;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(3, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Đặt phòng";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.pictureBoxBack);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(817, 46);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanelContent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 523);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // metroPanelContent
            // 
            this.metroPanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanelContent.Controls.Add(this.lbTenKS);
            this.metroPanelContent.Controls.Add(this.btPhongTrong);
            this.metroPanelContent.Controls.Add(this.dtpT);
            this.metroPanelContent.Controls.Add(this.dtpBD);
            this.metroPanelContent.Controls.Add(this.btDatPhong);
            this.metroPanelContent.Controls.Add(this.dgDatPhong);
            this.metroPanelContent.Controls.Add(this.label2);
            this.metroPanelContent.Controls.Add(this.label1);
            this.metroPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelContent.HorizontalScrollbarBarColor = true;
            this.metroPanelContent.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.HorizontalScrollbarSize = 10;
            this.metroPanelContent.Location = new System.Drawing.Point(3, 55);
            this.metroPanelContent.Name = "metroPanelContent";
            this.metroPanelContent.Size = new System.Drawing.Size(817, 465);
            this.metroPanelContent.TabIndex = 4;
            this.metroPanelContent.UseCustomBackColor = true;
            this.metroPanelContent.VerticalScrollbarBarColor = true;
            this.metroPanelContent.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.VerticalScrollbarSize = 10;
            // 
            // lbTenKS
            // 
            this.lbTenKS.AutoSize = true;
            this.lbTenKS.Location = new System.Drawing.Point(297, 50);
            this.lbTenKS.Name = "lbTenKS";
            this.lbTenKS.Size = new System.Drawing.Size(73, 19);
            this.lbTenKS.TabIndex = 18;
            this.lbTenKS.Text = "Khách sạn: ";
            // 
            // btPhongTrong
            // 
            this.btPhongTrong.BackColor = System.Drawing.SystemColors.Control;
            this.btPhongTrong.Location = new System.Drawing.Point(496, 14);
            this.btPhongTrong.Name = "btPhongTrong";
            this.btPhongTrong.Size = new System.Drawing.Size(75, 23);
            this.btPhongTrong.TabIndex = 17;
            this.btPhongTrong.Text = "Phòng trống";
            this.btPhongTrong.UseVisualStyleBackColor = false;
            this.btPhongTrong.Click += new System.EventHandler(this.btPhongTrong_Click);
            // 
            // dtpBD
            // 
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(91, 16);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(115, 20);
            this.dtpBD.TabIndex = 15;
            // 
            // btDatPhong
            // 
            this.btDatPhong.BackColor = System.Drawing.SystemColors.Control;
            this.btDatPhong.Location = new System.Drawing.Point(577, 83);
            this.btDatPhong.Name = "btDatPhong";
            this.btDatPhong.Size = new System.Drawing.Size(75, 23);
            this.btDatPhong.TabIndex = 14;
            this.btDatPhong.Text = "Đặt phòng";
            this.btDatPhong.UseVisualStyleBackColor = false;
            this.btDatPhong.Click += new System.EventHandler(this.btDatPhong_Click);
            // 
            // dgDatPhong
            // 
            this.dgDatPhong.AllowUserToAddRows = false;
            this.dgDatPhong.AllowUserToDeleteRows = false;
            this.dgDatPhong.AllowUserToOrderColumns = true;
            this.dgDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDatPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loaiPhong,
            this.maLoaiPhong,
            this.donGia,
            this.moTa});
            this.dgDatPhong.Location = new System.Drawing.Point(16, 83);
            this.dgDatPhong.MultiSelect = false;
            this.dgDatPhong.Name = "dgDatPhong";
            this.dgDatPhong.ReadOnly = true;
            this.dgDatPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatPhong.Size = new System.Drawing.Size(555, 345);
            this.dgDatPhong.TabIndex = 9;
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "tenLoaiPhong";
            this.loaiPhong.HeaderText = "Loại phòng";
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.ReadOnly = true;
            // 
            // maLoaiPhong
            // 
            this.maLoaiPhong.DataPropertyName = "maLoaiPhong";
            this.maLoaiPhong.HeaderText = "Mã loại phòng";
            this.maLoaiPhong.Name = "maLoaiPhong";
            this.maLoaiPhong.ReadOnly = true;
            this.maLoaiPhong.Visible = false;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Giá phòng";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // moTa
            // 
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày trả phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // ucDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDatPhong";
            this.Size = new System.Drawing.Size(823, 523);
            this.Load += new System.EventHandler(this.ucDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanelContent.ResumeLayout(false);
            this.metroPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpT;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanelContent;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.Button btDatPhong;
        private System.Windows.Forms.DataGridView dgDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private MetroFramework.Controls.MetroLabel lbTenKS;
    }
}
