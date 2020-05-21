namespace QL_KS.ucNhanVien
{
    partial class ucTinhTrangPhong
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
            this.metroPanelRoomStatus = new MetroFramework.Controls.MetroPanel();
            this.metroLabelRoomStatus = new MetroFramework.Controls.MetroLabel();
            this.metroPanelContent = new MetroFramework.Controls.MetroPanel();
            this.richTextBoxCT_phong = new System.Windows.Forms.RichTextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTTP = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanelRoomStatus.SuspendLayout();
            this.metroPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTP)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanelRoomStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanelContent, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 662);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // metroPanelRoomStatus
            // 
            this.metroPanelRoomStatus.BackColor = System.Drawing.Color.Teal;
            this.metroPanelRoomStatus.Controls.Add(this.metroLabelRoomStatus);
            this.metroPanelRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelRoomStatus.HorizontalScrollbarBarColor = true;
            this.metroPanelRoomStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelRoomStatus.HorizontalScrollbarSize = 10;
            this.metroPanelRoomStatus.Location = new System.Drawing.Point(3, 3);
            this.metroPanelRoomStatus.Name = "metroPanelRoomStatus";
            this.metroPanelRoomStatus.Size = new System.Drawing.Size(968, 60);
            this.metroPanelRoomStatus.TabIndex = 0;
            this.metroPanelRoomStatus.UseCustomBackColor = true;
            this.metroPanelRoomStatus.UseCustomForeColor = true;
            this.metroPanelRoomStatus.VerticalScrollbarBarColor = true;
            this.metroPanelRoomStatus.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelRoomStatus.VerticalScrollbarSize = 10;
            // 
            // metroLabelRoomStatus
            // 
            this.metroLabelRoomStatus.AutoSize = true;
            this.metroLabelRoomStatus.BackColor = System.Drawing.Color.Teal;
            this.metroLabelRoomStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelRoomStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRoomStatus.ForeColor = System.Drawing.Color.White;
            this.metroLabelRoomStatus.Location = new System.Drawing.Point(3, 0);
            this.metroLabelRoomStatus.Name = "metroLabelRoomStatus";
            this.metroLabelRoomStatus.Size = new System.Drawing.Size(150, 25);
            this.metroLabelRoomStatus.TabIndex = 2;
            this.metroLabelRoomStatus.Text = "Tình trạng phòng";
            this.metroLabelRoomStatus.UseCustomBackColor = true;
            this.metroLabelRoomStatus.UseCustomForeColor = true;
            // 
            // metroPanelContent
            // 
            this.metroPanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanelContent.Controls.Add(this.richTextBoxCT_phong);
            this.metroPanelContent.Controls.Add(this.buttonSearch);
            this.metroPanelContent.Controls.Add(this.dateTimePicker1);
            this.metroPanelContent.Controls.Add(this.comboBoxLoaiPhong);
            this.metroPanelContent.Controls.Add(this.label2);
            this.metroPanelContent.Controls.Add(this.label1);
            this.metroPanelContent.Controls.Add(this.dataGridViewTTP);
            this.metroPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelContent.HorizontalScrollbarBarColor = true;
            this.metroPanelContent.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.HorizontalScrollbarSize = 10;
            this.metroPanelContent.Location = new System.Drawing.Point(3, 69);
            this.metroPanelContent.Name = "metroPanelContent";
            this.metroPanelContent.Size = new System.Drawing.Size(968, 590);
            this.metroPanelContent.TabIndex = 1;
            this.metroPanelContent.UseCustomBackColor = true;
            this.metroPanelContent.VerticalScrollbarBarColor = true;
            this.metroPanelContent.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContent.VerticalScrollbarSize = 10;
            // 
            // richTextBoxCT_phong
            // 
            this.richTextBoxCT_phong.Location = new System.Drawing.Point(358, 75);
            this.richTextBoxCT_phong.Name = "richTextBoxCT_phong";
            this.richTextBoxCT_phong.Size = new System.Drawing.Size(246, 150);
            this.richTextBoxCT_phong.TabIndex = 9;
            this.richTextBoxCT_phong.Text = "";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Location = new System.Drawing.Point(323, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(58, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.FormattingEnabled = true;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(231, 21);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoaiPhong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại phòng";
            // 
            // dataGridViewTTP
            // 
            this.dataGridViewTTP.AllowUserToAddRows = false;
            this.dataGridViewTTP.AllowUserToDeleteRows = false;
            this.dataGridViewTTP.AllowUserToOrderColumns = true;
            this.dataGridViewTTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTTP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTTP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.moTa,
            this.tenLoaiPhong,
            this.donGia,
            this.TinhTrang});
            this.dataGridViewTTP.Location = new System.Drawing.Point(107, 75);
            this.dataGridViewTTP.MultiSelect = false;
            this.dataGridViewTTP.Name = "dataGridViewTTP";
            this.dataGridViewTTP.ReadOnly = true;
            this.dataGridViewTTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTTP.Size = new System.Drawing.Size(245, 277);
            this.dataGridViewTTP.TabIndex = 2;
            this.dataGridViewTTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTTP_CellClick);
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "soPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.ReadOnly = true;
            // 
            // moTa
            // 
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            this.moTa.Visible = false;
            // 
            // tenLoaiPhong
            // 
            this.tenLoaiPhong.DataPropertyName = "tenLoaiPhong";
            this.tenLoaiPhong.HeaderText = "Loại Phòng";
            this.tenLoaiPhong.Name = "tenLoaiPhong";
            this.tenLoaiPhong.ReadOnly = true;
            this.tenLoaiPhong.Visible = false;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Visible = false;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "tinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // ucTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTinhTrangPhong";
            this.Size = new System.Drawing.Size(974, 662);
            this.Load += new System.EventHandler(this.ucTinhTrangPhong_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanelRoomStatus.ResumeLayout(false);
            this.metroPanelRoomStatus.PerformLayout();
            this.metroPanelContent.ResumeLayout(false);
            this.metroPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanelRoomStatus;
        private MetroFramework.Controls.MetroLabel metroLabelRoomStatus;
        private MetroFramework.Controls.MetroPanel metroPanelContent;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTTP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RichTextBox richTextBoxCT_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}
