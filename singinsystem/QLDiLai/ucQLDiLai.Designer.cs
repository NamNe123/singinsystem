
using singinsystem.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QLDiLai
{
    partial class ucQLDiLai
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
		private TableLayoutPanel tableLayoutPanel8;
		private DataGridView dgDSQLDiLai;
		private DataGridViewButtonColumn dataGridViewButtonColumn1;
		private TableLayoutPanel tableLayoutPanel5;
		private TableLayoutPanel tableLayoutPanel7;
		private Panel panel5;
		private DateTimePicker dtpTu;
		private Panel panel6;
		private TableLayoutPanel tableLayoutPanel6;
		private Label label2;
		private Label label4;
		private Panel panel2;
		private Panel panel4;
		private Label label3;
		private PictureBox pictureBox1;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn MaNV;
		private DataGridViewTextBoxColumn TenNV;
		private DataGridViewTextBoxColumn LyDo;
		private DataGridViewTextBoxColumn TimeOut;
		private DataGridViewTextBoxColumn TimeIn;
		private DataGridViewTextBoxColumn TongTime;
		private DataGridViewTextBoxColumn GhiChu;
		private DataGridViewButtonColumn btnThemGhiChu;
		private Button btnBCTH;
		private DateTimePicker dtpDen;
		private Panel panel7;
		private Panel panel8;
		private ComboBox cbLoaiDangKy;
		private Panel panel9;
		private Panel panel10;
		private ComboBox cbNhanSu;
		private Panel panel11;
		private ComboBox cbHienThi;
		private Label label5;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLDiLai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgDSQLDiLai = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemGhiChu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbNhanSu = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbLoaiDangKy = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBCTH = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbHienThi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cBCaDem = new System.Windows.Forms.CheckBox();
            this.cBCaNgay = new System.Windows.Forms.CheckBox();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLDiLai)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 626);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.51585F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 626);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 620);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgDSQLDiLai, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 461F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(940, 620);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgDSQLDiLai
            // 
            this.dgDSQLDiLai.AllowUserToAddRows = false;
            this.dgDSQLDiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDSQLDiLai.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSQLDiLai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgDSQLDiLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSQLDiLai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MaNV,
            this.TenNV,
            this.LyDo,
            this.TimeOut,
            this.TimeIn,
            this.TongTime,
            this.GhiChu,
            this.btnThemGhiChu});
            this.dgDSQLDiLai.Location = new System.Drawing.Point(3, 161);
            this.dgDSQLDiLai.Name = "dgDSQLDiLai";
            this.dgDSQLDiLai.RowHeadersWidth = 51;
            this.dgDSQLDiLai.Size = new System.Drawing.Size(934, 456);
            this.dgDSQLDiLai.TabIndex = 3;
            this.dgDSQLDiLai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSQLDiLai_CellContentClick);
            this.dgDSQLDiLai.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgDSQLDiLai_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "代码";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.FillWeight = 150F;
            this.TenNV.HeaderText = "姓名";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // LyDo
            // 
            this.LyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "理由";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            // 
            // TimeOut
            // 
            this.TimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeOut.DataPropertyName = "TimeOut";
            dataGridViewCellStyle14.Format = "G";
            dataGridViewCellStyle14.NullValue = null;
            this.TimeOut.DefaultCellStyle = dataGridViewCellStyle14;
            this.TimeOut.HeaderText = "出去时间";
            this.TimeOut.MinimumWidth = 6;
            this.TimeOut.Name = "TimeOut";
            // 
            // TimeIn
            // 
            this.TimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeIn.DataPropertyName = "TimeIn";
            dataGridViewCellStyle15.Format = "G";
            dataGridViewCellStyle15.NullValue = null;
            this.TimeIn.DefaultCellStyle = dataGridViewCellStyle15;
            this.TimeIn.HeaderText = "进入时间";
            this.TimeIn.MinimumWidth = 6;
            this.TimeIn.Name = "TimeIn";
            // 
            // TongTime
            // 
            this.TongTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTime.DataPropertyName = "TongTime";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TongTime.DefaultCellStyle = dataGridViewCellStyle16;
            this.TongTime.HeaderText = "超时";
            this.TongTime.MinimumWidth = 6;
            this.TongTime.Name = "TongTime";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "备注 ";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // btnThemGhiChu
            // 
            this.btnThemGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnThemGhiChu.DataPropertyName = "btnThemGhiChu";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            this.btnThemGhiChu.DefaultCellStyle = dataGridViewCellStyle17;
            this.btnThemGhiChu.HeaderText = "";
            this.btnThemGhiChu.MinimumWidth = 6;
            this.btnThemGhiChu.Name = "btnThemGhiChu";
            this.btnThemGhiChu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnThemGhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnThemGhiChu.Text = "备注";
            this.btnThemGhiChu.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "打卡记录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.26126F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.73874F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(934, 121);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.58823F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.41177F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(928, 68);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.93023F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.06977F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel7.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel9, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel10, 6, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(922, 32);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpTu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(393, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 26);
            this.panel5.TabIndex = 3;
            // 
            // dtpTu
            // 
            this.dtpTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(0, 0);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(166, 30);
            this.dtpTu.TabIndex = 0;
            this.dtpTu.Value = DateTime.Now.Date;
            this.dtpTu.ValueChanged += new System.EventHandler(this.dtpTu_ValueChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpDen);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(565, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 26);
            this.panel6.TabIndex = 9;
            // 
            // dtpDen
            // 
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(3, 0);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(150, 30);
            this.dtpDen.TabIndex = 1;
            this.dtpDen.Value = DateTime.Now.Date.AddHours(23.0).AddMinutes(59.0);
            this.dtpDen.ValueChanged += new System.EventHandler(this.dtpDen_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 26);
            this.panel4.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbNhanSu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(23, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(70, 26);
            this.panel7.TabIndex = 10;
            // 
            // cbNhanSu
            // 
            this.cbNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNhanSu.DropDownHeight = 100;
            this.cbNhanSu.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanSu.FormattingEnabled = true;
            this.cbNhanSu.IntegralHeight = false;
            this.cbNhanSu.Location = new System.Drawing.Point(0, 0);
            this.cbNhanSu.Name = "cbNhanSu";
            this.cbNhanSu.Size = new System.Drawing.Size(70, 38);
            this.cbNhanSu.TabIndex = 14;
            this.cbNhanSu.TextUpdate += new System.EventHandler(this.cbNhanSu_TextUpdate);
            this.cbNhanSu.SelectedValueChanged += new System.EventHandler(this.cbNhanSu_SelectedValueChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbLoaiDangKy);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(99, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(119, 26);
            this.panel8.TabIndex = 11;
            // 
            // cbLoaiDangKy
            // 
            this.cbLoaiDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLoaiDangKy.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiDangKy.FormattingEnabled = true;
            this.cbLoaiDangKy.Location = new System.Drawing.Point(0, 0);
            this.cbLoaiDangKy.Name = "cbLoaiDangKy";
            this.cbLoaiDangKy.Size = new System.Drawing.Size(119, 38);
            this.cbLoaiDangKy.TabIndex = 9;
            this.cbLoaiDangKy.TextUpdate += new System.EventHandler(this.cbLoaiDangKy_TextUpdate);
            this.cbLoaiDangKy.SelectedValueChanged += new System.EventHandler(this.cbLoaiDangKy_SelectedValueChanged);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(224, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(163, 26);
            this.panel9.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(731, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(188, 26);
            this.panel10.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.16505F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.83495F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(922, 24);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "理由";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 18);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "代码 - 姓名";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel8.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnBCTH, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel11, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel12, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(928, 41);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBCTH
            // 
            this.btnBCTH.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCTH.Location = new System.Drawing.Point(815, 3);
            this.btnBCTH.Name = "btnBCTH";
            this.btnBCTH.Size = new System.Drawing.Size(110, 35);
            this.btnBCTH.TabIndex = 12;
            this.btnBCTH.Text = "综合报告";
            this.btnBCTH.UseVisualStyleBackColor = true;
            this.btnBCTH.Click += new System.EventHandler(this.btnBCTH_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cbHienThi);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(272, 35);
            this.panel11.TabIndex = 13;
            // 
            // cbHienThi
            // 
            this.cbHienThi.FormattingEnabled = true;
            this.cbHienThi.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "200",
            "500"});
            this.cbHienThi.Location = new System.Drawing.Point(69, 2);
            this.cbHienThi.Name = "cbHienThi";
            this.cbHienThi.Size = new System.Drawing.Size(91, 33);
            this.cbHienThi.TabIndex = 3;
            this.cbHienThi.TextChanged += new System.EventHandler(this.cbHienThi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "显示:";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.cBCaDem);
            this.panel12.Controls.Add(this.cBCaNgay);
            this.panel12.Location = new System.Drawing.Point(281, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(475, 35);
            this.panel12.TabIndex = 14;
            // 
            // cBCaDem
            // 
            this.cBCaDem.AutoSize = true;
            this.cBCaDem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCaDem.Location = new System.Drawing.Point(104, 3);
            this.cBCaDem.Name = "cBCaDem";
            this.cBCaDem.Size = new System.Drawing.Size(74, 31);
            this.cBCaDem.TabIndex = 1;
            this.cBCaDem.Text = "夜班";
            this.cBCaDem.UseVisualStyleBackColor = true;
            this.cBCaDem.CheckedChanged += new System.EventHandler(this.cBCaDem_CheckedChanged);
            // 
            // cBCaNgay
            // 
            this.cBCaNgay.AutoSize = true;
            this.cBCaNgay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCaNgay.Location = new System.Drawing.Point(3, 3);
            this.cBCaNgay.Name = "cBCaNgay";
            this.cBCaNgay.Size = new System.Drawing.Size(74, 31);
            this.cBCaNgay.TabIndex = 0;
            this.cBCaNgay.Text = "白班";
            this.cBCaNgay.UseVisualStyleBackColor = true;
            this.cBCaNgay.CheckedChanged += new System.EventHandler(this.cBCaNgay_CheckedChanged);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.DataPropertyName = "btnTroLaiLamViec";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewButtonColumn1.HeaderText = "Thao tác";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Text = "Trở lại làm việc";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // ucQLDiLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucQLDiLai";
            this.Size = new System.Drawing.Size(946, 626);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLDiLai)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private Panel panel12;
        private CheckBox cBCaDem;
        private CheckBox cBCaNgay;
    }
}
