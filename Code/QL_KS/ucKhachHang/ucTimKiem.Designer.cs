namespace QL_KS.ucKhachHang
{
    partial class ucTimKiem
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelContent = new MetroFramework.Controls.MetroPanel();
            this.dgTimKiem = new System.Windows.Forms.DataGridView();
            this.maKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpT = new System.Windows.Forms.DateTimePicker();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHighPrice = new System.Windows.Forms.TextBox();
            this.txtLowPrice = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.cbStar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.metroPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimKiem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.pictureBoxBack);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(829, 53);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.Image = global::QL_KS.Properties.Resources.imgTroVe;
            this.pictureBoxBack.Location = new System.Drawing.Point(777, 3);
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
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tìm kiếm";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroPanelContent
            // 
            this.metroPanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanelContent.Controls.Add(this.dgTimKiem);
            this.metroPanelContent.Controls.Add(this.dtpT);
            this.metroPanelContent.Controls.Add(this.dtpBD);
            this.metroPanelContent.Controls.Add(this.label5);
            this.metroPanelContent.Controls.Add(this.label6);
            this.metroPanelContent.Controls.Add(this.btChiTiet);
            this.metroPanelContent.Controls.Add(this.label4);
            this.metroPanelContent.Controls.Add(this.txtHighPrice);
            this.metroPanelContent.Controls.Add(this.txtLowPrice);
            this.metroPanelContent.Controls.Add(this.txtCity);
            this.metroPanelContent.Controls.Add(this.buttonTimKiem);
            this.metroPanelContent.Controls.Add(this.cbStar);
            this.metroPanelContent.Controls.Add(this.label2);
            this.metroPanelContent.Controls.Add(this.label3);
            this.metroPanelContent.Controls.Add(this.label1);
            this.metroPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelContent.HorizontalScrollbarBarColor = true;
            this.metroPanelContent.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.HorizontalScrollbarSize = 10;
            this.metroPanelContent.Location = new System.Drawing.Point(3, 62);
            this.metroPanelContent.Name = "metroPanelContent";
            this.metroPanelContent.Size = new System.Drawing.Size(829, 528);
            this.metroPanelContent.TabIndex = 4;
            this.metroPanelContent.UseCustomBackColor = true;
            this.metroPanelContent.VerticalScrollbarBarColor = true;
            this.metroPanelContent.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.VerticalScrollbarSize = 10;
            // 
            // dgTimKiem
            // 
            this.dgTimKiem.AllowUserToAddRows = false;
            this.dgTimKiem.AllowUserToDeleteRows = false;
            this.dgTimKiem.AllowUserToOrderColumns = true;
            this.dgTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTimKiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTimKiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKS,
            this.tenKS,
            this.diaChi,
            this.soSao,
            this.giaTB,
            this.moTa});
            this.dgTimKiem.Location = new System.Drawing.Point(16, 151);
            this.dgTimKiem.MultiSelect = false;
            this.dgTimKiem.Name = "dgTimKiem";
            this.dgTimKiem.ReadOnly = true;
            this.dgTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTimKiem.Size = new System.Drawing.Size(790, 356);
            this.dgTimKiem.TabIndex = 21;
            // 
            // maKS
            // 
            this.maKS.DataPropertyName = "maKS";
            this.maKS.HeaderText = "Mã khách sạn";
            this.maKS.Name = "maKS";
            this.maKS.ReadOnly = true;
            this.maKS.Width = 92;
            // 
            // tenKS
            // 
            this.tenKS.DataPropertyName = "tenKS";
            this.tenKS.HeaderText = "Tên khách sạn";
            this.tenKS.Name = "tenKS";
            this.tenKS.ReadOnly = true;
            this.tenKS.Width = 96;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 48;
            // 
            // soSao
            // 
            this.soSao.DataPropertyName = "soSao";
            this.soSao.HeaderText = "Số sao";
            this.soSao.Name = "soSao";
            this.soSao.ReadOnly = true;
            this.soSao.Width = 60;
            // 
            // giaTB
            // 
            this.giaTB.DataPropertyName = "giaTB";
            this.giaTB.HeaderText = "Giá trung bình";
            this.giaTB.Name = "giaTB";
            this.giaTB.ReadOnly = true;
            this.giaTB.Width = 90;
            // 
            // moTa
            // 
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            this.moTa.Width = 47;
            // 
            // dtpT
            // 
            this.dtpT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpT.Location = new System.Drawing.Point(390, 100);
            this.dtpT.Name = "dtpT";
            this.dtpT.Size = new System.Drawing.Size(115, 20);
            this.dtpT.TabIndex = 20;
            // 
            // dtpBD
            // 
            this.dtpBD.CustomFormat = "";
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(156, 101);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(115, 20);
            this.dtpBD.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày trả phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // btChiTiet
            // 
            this.btChiTiet.BackColor = System.Drawing.SystemColors.Control;
            this.btChiTiet.Location = new System.Drawing.Point(543, 98);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btChiTiet.TabIndex = 14;
            this.btChiTiet.Text = "Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = false;
            this.btChiTiet.Click += new System.EventHandler(this.btChiTiet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "đến";
            // 
            // txtHighPrice
            // 
            this.txtHighPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighPrice.Location = new System.Drawing.Point(543, 14);
            this.txtHighPrice.Name = "txtHighPrice";
            this.txtHighPrice.Size = new System.Drawing.Size(129, 21);
            this.txtHighPrice.TabIndex = 12;
            // 
            // txtLowPrice
            // 
            this.txtLowPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowPrice.Location = new System.Drawing.Point(371, 15);
            this.txtLowPrice.Name = "txtLowPrice";
            this.txtLowPrice.Size = new System.Drawing.Size(134, 21);
            this.txtLowPrice.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(81, 15);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(204, 21);
            this.txtCity.TabIndex = 10;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTimKiem.Location = new System.Drawing.Point(343, 58);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(75, 23);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // cbStar
            // 
            this.cbStar.FormattingEnabled = true;
            this.cbStar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "Tất cả"});
            this.cbStar.Location = new System.Drawing.Point(740, 14);
            this.cbStar.Name = "cbStar";
            this.cbStar.Size = new System.Drawing.Size(66, 21);
            this.cbStar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá phòng từ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hạng sao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thành phố:";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTimKiem";
            this.Size = new System.Drawing.Size(835, 593);
            this.Load += new System.EventHandler(this.ucTimKiem_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.metroPanelContent.ResumeLayout(false);
            this.metroPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimKiem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanelContent;
        private System.Windows.Forms.DateTimePicker dtpT;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHighPrice;
        private System.Windows.Forms.TextBox txtLowPrice;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.ComboBox cbStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSao;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}
