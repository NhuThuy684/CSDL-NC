namespace QL_KS.ucNhanVien
{
    partial class ucHoaDon
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelBill = new MetroFramework.Controls.MetroLabel();
            this.metroPanelContent = new MetroFramework.Controls.MetroPanel();
            this.ThanhToan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxLapHD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLapHD = new System.Windows.Forms.Button();
            this.textBoxLapHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxLapHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanelContent, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 463);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.metroLabelBill);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(831, 40);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabelBill
            // 
            this.metroLabelBill.AutoSize = true;
            this.metroLabelBill.BackColor = System.Drawing.Color.Teal;
            this.metroLabelBill.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelBill.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelBill.ForeColor = System.Drawing.Color.White;
            this.metroLabelBill.Location = new System.Drawing.Point(3, 0);
            this.metroLabelBill.Name = "metroLabelBill";
            this.metroLabelBill.Size = new System.Drawing.Size(82, 25);
            this.metroLabelBill.TabIndex = 2;
            this.metroLabelBill.Text = "Hóa đơn";
            this.metroLabelBill.UseCustomBackColor = true;
            this.metroLabelBill.UseCustomForeColor = true;
            // 
            // metroPanelContent
            // 
            this.metroPanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanelContent.Controls.Add(this.ThanhToan);
            this.metroPanelContent.Controls.Add(this.button1);
            this.metroPanelContent.Controls.Add(this.dataGridView1);
            this.metroPanelContent.Controls.Add(this.groupBoxTimKiem);
            this.metroPanelContent.Controls.Add(this.groupBoxLapHD);
            this.metroPanelContent.Controls.Add(this.label2);
            this.metroPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelContent.HorizontalScrollbarBarColor = true;
            this.metroPanelContent.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.HorizontalScrollbarSize = 10;
            this.metroPanelContent.Location = new System.Drawing.Point(3, 49);
            this.metroPanelContent.Name = "metroPanelContent";
            this.metroPanelContent.Size = new System.Drawing.Size(831, 411);
            this.metroPanelContent.TabIndex = 1;
            this.metroPanelContent.UseCustomBackColor = true;
            this.metroPanelContent.VerticalScrollbarBarColor = true;
            this.metroPanelContent.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.VerticalScrollbarSize = 10;
            // 
            // ThanhToan
            // 
            this.ThanhToan.AutoSize = true;
            this.ThanhToan.Location = new System.Drawing.Point(269, 266);
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Size = new System.Drawing.Size(0, 13);
            this.ThanhToan.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(735, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.ngayThanhToan,
            this.maKH,
            this.hoTen,
            this.maDP,
            this.ngayBatDau,
            this.ngayTraPhong,
            this.donGia,
            this.tongTien});
            this.dataGridView1.Location = new System.Drawing.Point(18, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(792, 256);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.Name = "maHD";
            this.maHD.ReadOnly = true;
            this.maHD.Width = 83;
            // 
            // ngayThanhToan
            // 
            this.ngayThanhToan.DataPropertyName = "ngayThanhToan";
            this.ngayThanhToan.HeaderText = "Ngày lập";
            this.ngayThanhToan.Name = "ngayThanhToan";
            this.ngayThanhToan.ReadOnly = true;
            this.ngayThanhToan.Width = 69;
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "maKH";
            this.maKH.HeaderText = "Mã khách hàng";
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            this.maKH.Width = 98;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ và tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            this.hoTen.Width = 73;
            // 
            // maDP
            // 
            this.maDP.DataPropertyName = "maDP";
            this.maDP.HeaderText = "Mã đặt phòng";
            this.maDP.Name = "maDP";
            this.maDP.ReadOnly = true;
            this.maDP.Width = 91;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            this.ngayBatDau.HeaderText = "Ngày đến";
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            this.ngayBatDau.Width = 73;
            // 
            // ngayTraPhong
            // 
            this.ngayTraPhong.DataPropertyName = "ngayTraPhong";
            this.ngayTraPhong.HeaderText = "Ngày đi";
            this.ngayTraPhong.Name = "ngayTraPhong";
            this.ngayTraPhong.ReadOnly = true;
            this.ngayTraPhong.Width = 64;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 64;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 71;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxTimKiem.Controls.Add(this.buttonTimKiem);
            this.groupBoxTimKiem.Controls.Add(this.textBoxTongTien);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePicker1);
            this.groupBoxTimKiem.Controls.Add(this.textBoxMaKH);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(428, 7);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 96);
            this.groupBoxTimKiem.TabIndex = 7;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTimKiem.Location = new System.Drawing.Point(211, 36);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(75, 23);
            this.buttonTimKiem.TabIndex = 6;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(75, 64);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(119, 20);
            this.textBoxTongTien.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(74, 12);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(120, 20);
            this.textBoxMaKH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH:";
            // 
            // groupBoxLapHD
            // 
            this.groupBoxLapHD.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLapHD.Controls.Add(this.label1);
            this.groupBoxLapHD.Controls.Add(this.buttonLapHD);
            this.groupBoxLapHD.Controls.Add(this.textBoxLapHD);
            this.groupBoxLapHD.Location = new System.Drawing.Point(77, 7);
            this.groupBoxLapHD.Name = "groupBoxLapHD";
            this.groupBoxLapHD.Size = new System.Drawing.Size(298, 96);
            this.groupBoxLapHD.TabIndex = 6;
            this.groupBoxLapHD.TabStop = false;
            this.groupBoxLapHD.Text = "Lập hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã đặt phòng:";
            // 
            // buttonLapHD
            // 
            this.buttonLapHD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLapHD.Location = new System.Drawing.Point(134, 67);
            this.buttonLapHD.Name = "buttonLapHD";
            this.buttonLapHD.Size = new System.Drawing.Size(80, 23);
            this.buttonLapHD.TabIndex = 5;
            this.buttonLapHD.Text = "Lập hóa đơn";
            this.buttonLapHD.UseVisualStyleBackColor = false;
            this.buttonLapHD.Click += new System.EventHandler(this.buttonLapHD_Click);
            // 
            // textBoxLapHD
            // 
            this.textBoxLapHD.Location = new System.Drawing.Point(89, 38);
            this.textBoxLapHD.Name = "textBoxLapHD";
            this.textBoxLapHD.Size = new System.Drawing.Size(169, 20);
            this.textBoxLapHD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(837, 463);
            this.Load += new System.EventHandler(this.ucHoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanelContent.ResumeLayout(false);
            this.metroPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxLapHD.ResumeLayout(false);
            this.groupBoxLapHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabelBill;
        private MetroFramework.Controls.MetroPanel metroPanelContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLapHD;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.GroupBox groupBoxLapHD;
        private System.Windows.Forms.Button buttonLapHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
    }
}