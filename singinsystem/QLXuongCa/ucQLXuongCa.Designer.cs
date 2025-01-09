
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QLXuongCa
{
    partial class ucQLXuongCa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private Panel panel3;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel4;
		private TableLayoutPanel tableLayoutPanel5;
		private TableLayoutPanel tableLayoutPanel7;
		private ComboBox cbNhanSu;
		private TableLayoutPanel tableLayoutPanel8;
		private DataGridViewButtonColumn dataGridViewButtonColumn1;
		private Panel panel5;
		private DateTimePicker dtpTu;
		private Panel panel6;
		private DateTimePicker dtpDen;
		private TableLayoutPanel tableLayoutPanel6;
		private Panel panel2;
		private Label label3;
		private Panel panel4;
		private Label label2;
		private Panel panel7;
		private PictureBox pictureBox1;
		private Panel panel8;
		private ComboBox cbHienThi;
		private Label label4;
		private Panel panel9;
		private DataGridView dgDSQLXuongCa;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn MaNv;
		private DataGridViewTextBoxColumn Ten;
		private DataGridViewTextBoxColumn GioLamViec;
		private DataGridViewTextBoxColumn GioXuongCa;
		private DataGridViewTextBoxColumn TongGioLam;
		private DataGridViewTextBoxColumn TrangThai;
		private DataGridViewButtonColumn btnTroLaiLamViec;
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			this.panel3 = new Panel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.panel1 = new Panel();
			this.tableLayoutPanel2 = new TableLayoutPanel();
			this.label1 = new Label();
			this.tableLayoutPanel4 = new TableLayoutPanel();
			this.tableLayoutPanel5 = new TableLayoutPanel();
			this.tableLayoutPanel7 = new TableLayoutPanel();
			this.cbNhanSu = new ComboBox();
			this.panel5 = new Panel();
			this.dtpTu = new DateTimePicker();
			this.panel6 = new Panel();
			this.dtpDen = new DateTimePicker();
			this.panel7 = new Panel();
			this.tableLayoutPanel6 = new TableLayoutPanel();
			this.panel2 = new Panel();
			this.label3 = new Label();
			this.panel4 = new Panel();
			this.label2 = new Label();
			this.tableLayoutPanel8 = new TableLayoutPanel();
			this.pictureBox1 = new PictureBox();
			this.panel8 = new Panel();
			this.cbHienThi = new ComboBox();
			this.label4 = new Label();
			this.panel9 = new Panel();
			this.dgDSQLXuongCa = new DataGridView();
			this.Id = new DataGridViewTextBoxColumn();
			this.MaNv = new DataGridViewTextBoxColumn();
			this.Ten = new DataGridViewTextBoxColumn();
			this.GioLamViec = new DataGridViewTextBoxColumn();
			this.GioXuongCa = new DataGridViewTextBoxColumn();
			this.TongGioLam = new DataGridViewTextBoxColumn();
			this.TrangThai = new DataGridViewTextBoxColumn();
			this.btnTroLaiLamViec = new DataGridViewButtonColumn();
			this.dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
			this.panel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.dgDSQLXuongCa).BeginInit();
			base.SuspendLayout();
			this.panel3.BackColor = Color.White;
			this.panel3.Controls.Add(this.tableLayoutPanel1);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(946, 626);
			this.panel3.TabIndex = 3;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.51585f));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new Size(946, 626);
			this.tableLayoutPanel1.TabIndex = 0;
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(940, 620);
			this.panel1.TabIndex = 2;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 2);
			this.tableLayoutPanel2.Dock = DockStyle.Fill;
			this.tableLayoutPanel2.Location = new Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80f));
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 447f));
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel2.Size = new Size(940, 620);
			this.tableLayoutPanel2.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Font = new Font("Microsoft YaHei", 16.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(934, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "上下班记录";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 1);
			this.tableLayoutPanel4.Dock = DockStyle.Fill;
			this.tableLayoutPanel4.Location = new Point(3, 37);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 65.57377f));
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 34.42623f));
			this.tableLayoutPanel4.Size = new Size(934, 132);
			this.tableLayoutPanel4.TabIndex = 2;
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
			this.tableLayoutPanel5.Dock = DockStyle.Fill;
			this.tableLayoutPanel5.Location = new Point(3, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 45.58823f));
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 54.41177f));
			this.tableLayoutPanel5.Size = new Size(928, 80);
			this.tableLayoutPanel5.TabIndex = 0;
			this.tableLayoutPanel7.ColumnCount = 6;
			this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.80451f));
			this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.19549f));
			this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275f));
			this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165f));
			this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 216f));
			this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102f));
			this.tableLayoutPanel7.Controls.Add(this.cbNhanSu, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.panel5, 3, 0);
			this.tableLayoutPanel7.Controls.Add(this.panel6, 4, 0);
			this.tableLayoutPanel7.Controls.Add(this.panel7, 2, 0);
			this.tableLayoutPanel7.Dock = DockStyle.Fill;
			this.tableLayoutPanel7.Location = new Point(3, 39);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel7.Size = new Size(922, 38);
			this.tableLayoutPanel7.TabIndex = 1;
			this.cbNhanSu.Dock = DockStyle.Fill;
			this.cbNhanSu.DropDownHeight = 100;
			this.cbNhanSu.Font = new Font("Microsoft YaHei", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbNhanSu.FormattingEnabled = true;
			this.cbNhanSu.IntegralHeight = false;
			this.cbNhanSu.Location = new Point(38, 3);
			this.cbNhanSu.Name = "cbNhanSu";
			this.cbNhanSu.Size = new Size(122, 38);
			this.cbNhanSu.TabIndex = 2;
			this.cbNhanSu.TextUpdate += this.cbNhanSu_TextUpdate;
			this.cbNhanSu.SelectedValueChanged += this.cbNhanSu_SelectedValueChanged;
			this.panel5.Controls.Add(this.dtpTu);
			this.panel5.Dock = DockStyle.Fill;
			this.panel5.Location = new Point(441, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(159, 32);
			this.panel5.TabIndex = 3;
			this.dtpTu.Dock = DockStyle.Fill;
			this.dtpTu.Format = DateTimePickerFormat.Short;
			this.dtpTu.Location = new Point(0, 0);
			this.dtpTu.Name = "dtpTu";
			this.dtpTu.Size = new Size(159, 30);
			this.dtpTu.TabIndex = 0;
			this.dtpTu.Value = DateTime.Now.Date;
			this.dtpTu.ValueChanged += this.dtpTu_ValueChanged;
			this.panel6.Controls.Add(this.dtpDen);
			this.panel6.Dock = DockStyle.Fill;
			this.panel6.Location = new Point(606, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size(210, 32);
			this.panel6.TabIndex = 4;
			this.dtpDen.Format = DateTimePickerFormat.Short;
			this.dtpDen.Location = new Point(0, 0);
			this.dtpDen.Name = "dtpDen";
			this.dtpDen.Size = new Size(151, 30);
			this.dtpDen.TabIndex = 0;
			this.dtpDen.Value = DateTime.Now.Date.AddHours(23.0).AddMinutes(59.0);
			this.dtpDen.ValueChanged += this.dtpDen_ValueChanged;
			this.panel7.Dock = DockStyle.Fill;
			this.panel7.Location = new Point(166, 3);
			this.panel7.Name = "panel7";
			this.panel7.Size = new Size(269, 32);
			this.panel7.TabIndex = 5;
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.16505f));
			this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.83495f));
			this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 377f));
			this.tableLayoutPanel6.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel6.Dock = DockStyle.Fill;
			this.tableLayoutPanel6.Location = new Point(3, 3);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel6.Size = new Size(922, 30);
			this.tableLayoutPanel6.TabIndex = 2;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = DockStyle.Fill;
			this.panel2.Location = new Point(63, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(478, 24);
			this.panel2.TabIndex = 0;
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Font = new Font("Microsoft YaHei", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new Size(134, 31);
			this.label3.TabIndex = 1;
			this.label3.Text = "代码 - 姓名";
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = DockStyle.Fill;
			this.panel4.Location = new Point(547, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(372, 24);
			this.panel4.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Font = new Font("Microsoft YaHei", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(62, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "时间";
			this.tableLayoutPanel8.ColumnCount = 3;
			this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 349f));
			this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.82759f));
			this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49f));
			this.tableLayoutPanel8.Controls.Add(this.pictureBox1, 2, 0);
			this.tableLayoutPanel8.Controls.Add(this.panel8, 0, 0);
			this.tableLayoutPanel8.Dock = DockStyle.Fill;
			this.tableLayoutPanel8.Location = new Point(3, 89);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 1;
			this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel8.Size = new Size(928, 40);
			this.tableLayoutPanel8.TabIndex = 1;
			//this.pictureBox1.Image = Resources.excel;
			this.pictureBox1.Location = new Point(882, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(43, 30);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += this.pictureBox1_Click;
			this.panel8.Controls.Add(this.cbHienThi);
			this.panel8.Controls.Add(this.label4);
			this.panel8.Dock = DockStyle.Fill;
			this.panel8.Location = new Point(3, 3);
			this.panel8.Name = "panel8";
			this.panel8.Size = new Size(343, 34);
			this.panel8.TabIndex = 11;
			this.cbHienThi.FormattingEnabled = true;
			this.cbHienThi.Items.AddRange(new object[]
			{
				"10",
				"50",
				"100",
				"200",
				"500"
			});
			this.cbHienThi.Location = new Point(70, 0);
			this.cbHienThi.Name = "cbHienThi";
			this.cbHienThi.Size = new Size(91, 33);
			this.cbHienThi.TabIndex = 1;
			this.cbHienThi.TextChanged += this.cbHienThi_TextChanged;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft YaHei", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(6, 1);
			this.label4.Name = "label4";
			this.label4.Size = new Size(58, 27);
			this.label4.TabIndex = 0;
			this.label4.Text = "显示:";
			this.label4.TextChanged += this.cbHienThi_TextChanged;
			this.panel9.Controls.Add(this.dgDSQLXuongCa);
			this.panel9.Dock = DockStyle.Fill;
			this.panel9.Location = new Point(3, 175);
			this.panel9.Name = "panel9";
			this.panel9.Size = new Size(934, 442);
			this.panel9.TabIndex = 3;
			this.dgDSQLXuongCa.AllowUserToAddRows = false;
			this.dgDSQLXuongCa.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dgDSQLXuongCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgDSQLXuongCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDSQLXuongCa.Columns.AddRange(new DataGridViewColumn[]
			{
				this.Id,
				this.MaNv,
				this.Ten,
				this.GioLamViec,
				this.GioXuongCa,
				this.TongGioLam,
				this.TrangThai,
				this.btnTroLaiLamViec
			});
			this.dgDSQLXuongCa.Dock = DockStyle.Fill;
			this.dgDSQLXuongCa.Location = new Point(0, 0);
			this.dgDSQLXuongCa.Name = "dgDSQLXuongCa";
			this.dgDSQLXuongCa.RowHeadersWidth = 51;
			this.dgDSQLXuongCa.Size = new Size(934, 442);
			this.dgDSQLXuongCa.TabIndex = 4;
			this.dgDSQLXuongCa.CellContentClick += this.dgDSQLXuongCa_CellContentClick;
			this.dgDSQLXuongCa.DataBindingComplete += this.dgDSQLXuongCa_DataBindingComplete;
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.Width = 125;
			this.MaNv.DataPropertyName = "MaNv";
			this.MaNv.HeaderText = "代码";
			this.MaNv.MinimumWidth = 6;
			this.MaNv.Name = "MaNv";
			this.MaNv.Width = 125;
			this.Ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Ten.DataPropertyName = "Ten";
			this.Ten.FillWeight = 150f;
			this.Ten.HeaderText = "姓名";
			this.Ten.MinimumWidth = 6;
			this.Ten.Name = "Ten";
			this.GioLamViec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.GioLamViec.DataPropertyName = "GioLamViec";
			dataGridViewCellStyle2.Format = "G";
			dataGridViewCellStyle2.NullValue = null;
			this.GioLamViec.DefaultCellStyle = dataGridViewCellStyle2;
			this.GioLamViec.HeaderText = "上班时间";
			this.GioLamViec.MinimumWidth = 6;
			this.GioLamViec.Name = "GioLamViec";
			this.GioXuongCa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.GioXuongCa.DataPropertyName = "GioXuongCa";
			dataGridViewCellStyle3.Format = "G";
			dataGridViewCellStyle3.NullValue = null;
			this.GioXuongCa.DefaultCellStyle = dataGridViewCellStyle3;
			this.GioXuongCa.HeaderText = "下班时间";
			this.GioXuongCa.MinimumWidth = 6;
			this.GioXuongCa.Name = "GioXuongCa";
			this.TongGioLam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.TongGioLam.DataPropertyName = "TongGioLam";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.TongGioLam.DefaultCellStyle = dataGridViewCellStyle4;
			this.TongGioLam.HeaderText = "总时间";
			this.TongGioLam.MinimumWidth = 6;
			this.TongGioLam.Name = "TongGioLam";
			this.TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 129;
			this.btnTroLaiLamViec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.btnTroLaiLamViec.DataPropertyName = "btnTroLaiLamViec";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = Color.Lime;
			dataGridViewCellStyle5.ForeColor = Color.White;
			this.btnTroLaiLamViec.DefaultCellStyle = dataGridViewCellStyle5;
			this.btnTroLaiLamViec.HeaderText = "操作";
			this.btnTroLaiLamViec.MinimumWidth = 6;
			this.btnTroLaiLamViec.Name = "btnTroLaiLamViec";
			this.btnTroLaiLamViec.Resizable = DataGridViewTriState.True;
			this.btnTroLaiLamViec.SortMode = DataGridViewColumnSortMode.Automatic;
			this.btnTroLaiLamViec.Text = "回来上班";
			this.btnTroLaiLamViec.UseColumnTextForButtonValue = true;
			this.dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewButtonColumn1.DataPropertyName = "btnTroLaiLamViec";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = Color.Lime;
			dataGridViewCellStyle6.ForeColor = Color.White;
			this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewButtonColumn1.HeaderText = "Thao tác";
			this.dataGridViewButtonColumn1.MinimumWidth = 6;
			this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
			this.dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
			this.dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewButtonColumn1.Text = "Trở lại làm việc";
			this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
			base.AutoScaleDimensions = new SizeF(12f, 25f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.panel3);
			this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "ucQLXuongCa";
			base.Size = new Size(946, 626);
			this.panel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.tableLayoutPanel8.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			((ISupportInitialize)this.dgDSQLXuongCa).EndInit();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
